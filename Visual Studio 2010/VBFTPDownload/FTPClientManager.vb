'*************************** Module Header ******************************'
' Module Name:  FTPClientManager.vb
' Project:	    VBFTPDownload
' Copyright (c) Microsoft Corporation.
' 
' The class FTPClientManager supplies following features:
' 1. Verify whether a file or a directory exists on the FTP server.
' 2. List subdirectories and files of a folder on the FTP server.
' 3. Delete files or directories on the FTP server.
' 4. Create a directory on the FTP server.
' 5. Manage the FTPDownloadClient to download files from the FTP server. 
' 
' 
' This source is subject to the Microsoft Public License.
' See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
' All other rights reserved.
' 
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'*************************************************************************'

Imports System.IO
Imports System.Net

Partial Public Class FTPClientManager

    ''' <summary>
    ''' The Credentials to connect to the FTP server.
    ''' </summary>
    Public Property Credentials() As ICredentials

    ''' <summary>
    ''' The current URL of this FTPClient.
    ''' </summary>
    Private _url As Uri
    Public Property Url() As Uri
        Get
            Return _url
        End Get
        Private Set(ByVal value As Uri)
            _url = value
        End Set
    End Property

    Private _status As FTPClientManagerStatus

    ''' <summary>
    ''' Get or Set the status of this FTPClient.
    ''' </summary>
    Public Property Status() As FTPClientManagerStatus
        Get
            Return _status
        End Get

        Private Set(ByVal value As FTPClientManagerStatus)
            If _status <> value Then
                _status = value

                ' Raise a OnStatusChanged event.
                Me.OnStatusChanged(EventArgs.Empty)

            End If
        End Set
    End Property

    Public Event UrlChanged As EventHandler

    Public Event ErrorOccurred As EventHandler(Of ErrorEventArgs)

    Public Event StatusChanged As EventHandler

    Public Event FileDownloadCompleted As EventHandler(Of FileDownloadCompletedEventArgs)

    Public Event NewMessageArrived As EventHandler(Of NewMessageEventArg)

    ''' <summary>
    '''  Initialize a FTPClient instance.
    ''' </summary>
    Public Sub New(ByVal url As Uri, ByVal credentials As ICredentials)
        Me.Credentials = credentials

        ' Check whether the Url exists and the credentials is correct.
        ' If there is an error, an exception will be thrown.
        CheckFTPUrlExist(url)

        Me.Url = url

        ' Set the Status.
        Me.Status = FTPClientManagerStatus.Idle

    End Sub

    ''' <summary>
    ''' Navigate to the parent folder.
    ''' </summary>
    Public Sub NavigateParent()
        If Url.AbsolutePath <> "/" Then

            ' Get the parent url.
            Dim newUrl As New Uri(Me.Url, "..")

            ' Check whether the Url exists.
            CheckFTPUrlExist(newUrl)

            Me.Url = newUrl
            Me.OnUrlChanged(EventArgs.Empty)
        End If
    End Sub

    ''' <summary>
    ''' Navigate a url.
    ''' </summary>
    Public Sub Naviagte(ByVal newUrl As Uri)
        ' Check whether the Url exists.
        Dim urlExist As Boolean = VerifyFTPUrlExist(newUrl)

        Me.Url = newUrl
        Me.OnUrlChanged(EventArgs.Empty)
    End Sub

    ''' <summary>
    ''' If the Url does not exist, an exception will be thrown.
    ''' </summary>
    Private Sub CheckFTPUrlExist(ByVal url As Uri)
        Dim urlExist As Boolean = VerifyFTPUrlExist(url)

        If Not urlExist Then
            Throw New ApplicationException("The url does not exist")
        End If
    End Sub

    ''' <summary>
    ''' Verify whether the url exists.
    ''' </summary>
    Private Function VerifyFTPUrlExist(ByVal url As Uri) As Boolean
        Dim urlExist As Boolean = False

        If url.IsFile Then
            urlExist = VerifyFileExist(url)
        Else
            urlExist = VerifyDirectoryExist(url)
        End If

        Return urlExist
    End Function

    ''' <summary>
    ''' Verify whether the directory exists.
    ''' </summary>
    Private Function VerifyDirectoryExist(ByVal url As Uri) As Boolean
        Dim request As FtpWebRequest = TryCast(WebRequest.Create(url), FtpWebRequest)
        request.Credentials = Me.Credentials
        request.Method = WebRequestMethods.Ftp.ListDirectory

        Dim response As FtpWebResponse = Nothing

        Try
            response = TryCast(request.GetResponse(), FtpWebResponse)

            Return response.StatusCode = FtpStatusCode.DataAlreadyOpen
        Catch webEx As System.Net.WebException
            Dim ftpResponse As FtpWebResponse = TryCast(webEx.Response, FtpWebResponse)

            If ftpResponse.StatusCode = FtpStatusCode.ActionNotTakenFileUnavailable Then
                Return False
            End If

            Throw
        Finally
            If response IsNot Nothing Then
                response.Close()
            End If
        End Try
    End Function

    ''' <summary>
    ''' Verify whether the file exists.
    ''' </summary>
    Private Function VerifyFileExist(ByVal url As Uri) As Boolean
        Dim request As FtpWebRequest = TryCast(WebRequest.Create(url), FtpWebRequest)
        request.Credentials = Me.Credentials
        request.Method = WebRequestMethods.Ftp.GetFileSize

        Dim response As FtpWebResponse = Nothing

        Try
            response = TryCast(request.GetResponse(), FtpWebResponse)

            Return response.StatusCode = FtpStatusCode.FileStatus
        Catch webEx As System.Net.WebException
            Dim ftpResponse As FtpWebResponse = TryCast(webEx.Response, FtpWebResponse)

            If ftpResponse.StatusCode = FtpStatusCode.ActionNotTakenFileUnavailable Then
                Return False
            End If

            Throw
        Finally
            If response IsNot Nothing Then
                response.Close()
            End If
        End Try
    End Function

    ''' <summary>
    ''' Get the sub directories and files of the current Url by dafault.
    ''' </summary>
    Public Function GetSubDirectoriesAndFiles() As IEnumerable(Of FTPFileSystem)
        Return GetSubDirectoriesAndFiles(Me.Url)
    End Function

    ''' <summary>
    ''' Get the sub directories and files of the Url. It will be used in enumerate 
    ''' all the folders.
    ''' When run the FTP LIST protocol method to get a detailed listing of the files  
    ''' on an FTP server, the server will response many records of information. Each 
    ''' record represents a file. 
    ''' </summary>
    Public Function GetSubDirectoriesAndFiles(ByVal url As Uri) _
        As IEnumerable(Of FTPFileSystem)
        Dim request As FtpWebRequest = TryCast(WebRequest.Create(url), FtpWebRequest)

        request.Credentials = Me.Credentials

        request.Method = WebRequestMethods.Ftp.ListDirectoryDetails


        Dim response As FtpWebResponse = Nothing
        Dim responseStream As Stream = Nothing
        Dim reader As StreamReader = Nothing
        Try
            response = TryCast(request.GetResponse(), FtpWebResponse)

            Me.OnNewMessageArrived(New NewMessageEventArg _
                                   With {.NewMessage = response.StatusDescription})

            responseStream = response.GetResponseStream()
            reader = New StreamReader(responseStream)

            Dim subDirs As New List(Of FTPFileSystem)()

            Dim subDir As String = reader.ReadLine()

            ' Find out the FTP Directory Listing Style from the recordString.
            Dim style As FTPDirectoryListingStyle = FTPDirectoryListingStyle.MSDOS
            If Not String.IsNullOrEmpty(subDir) Then
                style = FTPFileSystem.GetDirectoryListingStyle(subDir)
            End If
            Do While Not String.IsNullOrEmpty(subDir)
                subDirs.Add(FTPFileSystem.ParseRecordString(url, subDir, style))

                subDir = reader.ReadLine()
            Loop
            Return subDirs
        Finally
            If response IsNot Nothing Then
                response.Close()
            End If

            ' Close the StreamReader object and the underlying stream, and release
            ' any system resources associated with the reader.
            If reader IsNot Nothing Then
                reader.Close()
            End If
        End Try
    End Function

    ''' <summary>
    ''' Download files, directories and their subdirectories.
    ''' </summary>
    Public Sub DownloadDirectoriesAndFiles(ByVal files As IEnumerable(Of FTPFileSystem),
                                           ByVal localPath As String)
        If Me.Status <> FTPClientManagerStatus.Idle Then
            Throw New ApplicationException("This client is busy now.")
        End If

        Me.Status = FTPClientManagerStatus.Downloading

        Dim downloadClient As New FTPDownloadClient(Me)
        AddHandler downloadClient.FileDownloadCompleted,
            AddressOf downloadClient_FileDownloadCompleted

        AddHandler downloadClient.AllFilesDownloadCompleted,
            AddressOf downloadClient_AllFilesDownloadCompleted

        downloadClient.DownloadDirectoriesAndFiles(files, localPath)

    End Sub

    Private Sub downloadClient_AllFilesDownloadCompleted(ByVal sender As Object,
                                                         ByVal e As EventArgs)
        Me.Status = FTPClientManagerStatus.Idle
    End Sub

    Private Sub downloadClient_FileDownloadCompleted(ByVal sender As Object,
                                                     ByVal e As FileDownloadCompletedEventArgs)
        Me.OnFileDownloadCompleted(e)
    End Sub

    Protected Overridable Sub OnUrlChanged(ByVal e As EventArgs)
        RaiseEvent UrlChanged(Me, e)
    End Sub

    Protected Overridable Sub OnStatusChanged(ByVal e As EventArgs)
        RaiseEvent StatusChanged(Me, e)
    End Sub

    Protected Overridable Sub OnFileDownloadCompleted(ByVal e As FileDownloadCompletedEventArgs)
        RaiseEvent FileDownloadCompleted(Me, e)
    End Sub

    Protected Overridable Sub OnErrorOccurred(ByVal e As ErrorEventArgs)
        Me.Status = FTPClientManagerStatus.Idle

        RaiseEvent ErrorOccurred(Me, e)
    End Sub

    Protected Overridable Sub OnNewMessageArrived(ByVal e As NewMessageEventArg)
        RaiseEvent NewMessageArrived(Me, e)
    End Sub
End Class
