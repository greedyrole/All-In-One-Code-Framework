'*************************** Module Header ******************************'
' Module Name:  ICustomDoc.vb
' Project:      VBCustomIEContextMenu
' Copyright (c) Microsoft Corporation.
' 
' The interface ICustomDoc enables a host to set the MSHTML IDocHostUIHandler
' interface.
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

Imports System.Runtime.InteropServices

Namespace NativeMethods
    <ComImport()> _
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)> _
    <GuidAttribute("3050f3f0-98b5-11cf-bb82-00aa00bdce0b")> _
    Public Interface ICustomDoc
        <PreserveSig()> _
        Sub SetUIHandler(ByVal pUIHandler As IDocHostUIHandler)
    End Interface
End Namespace


