'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3074
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="SQLServer2005DB")>  _
Partial Public Class SchoolDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertPerson(instance As Person)
    End Sub
  Partial Private Sub UpdatePerson(instance As Person)
    End Sub
  Partial Private Sub DeletePerson(instance As Person)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.VBLinqToXml.My.MySettings.Default.SQLServer2005DBConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Persons() As System.Data.Linq.Table(Of Person)
		Get
			Return Me.GetTable(Of Person)
		End Get
	End Property
End Class

<Table(Name:="dbo.Person")>  _
Partial Public Class Person
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _PersonID As Integer
	
	Private _LastName As String
	
	Private _FirstName As String
	
	Private _HireDate As System.Nullable(Of Date)
	
	Private _EnrollmentDate As System.Nullable(Of Date)
	
	Private _Picture As System.Data.Linq.Binary
	
	Private _PersonCategory As Short
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnPersonIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnPersonIDChanged()
    End Sub
    Partial Private Sub OnLastNameChanging(value As String)
    End Sub
    Partial Private Sub OnLastNameChanged()
    End Sub
    Partial Private Sub OnFirstNameChanging(value As String)
    End Sub
    Partial Private Sub OnFirstNameChanged()
    End Sub
    Partial Private Sub OnHireDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnHireDateChanged()
    End Sub
    Partial Private Sub OnEnrollmentDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnEnrollmentDateChanged()
    End Sub
    Partial Private Sub OnPictureChanging(value As System.Data.Linq.Binary)
    End Sub
    Partial Private Sub OnPictureChanged()
    End Sub
    Partial Private Sub OnPersonCategoryChanging(value As Short)
    End Sub
    Partial Private Sub OnPersonCategoryChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Column(Storage:="_PersonID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property PersonID() As Integer
		Get
			Return Me._PersonID
		End Get
		Set
			If ((Me._PersonID = value)  _
						= false) Then
				Me.OnPersonIDChanging(value)
				Me.SendPropertyChanging
				Me._PersonID = value
				Me.SendPropertyChanged("PersonID")
				Me.OnPersonIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_LastName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property LastName() As String
		Get
			Return Me._LastName
		End Get
		Set
			If (String.Equals(Me._LastName, value) = false) Then
				Me.OnLastNameChanging(value)
				Me.SendPropertyChanging
				Me._LastName = value
				Me.SendPropertyChanged("LastName")
				Me.OnLastNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_FirstName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property FirstName() As String
		Get
			Return Me._FirstName
		End Get
		Set
			If (String.Equals(Me._FirstName, value) = false) Then
				Me.OnFirstNameChanging(value)
				Me.SendPropertyChanging
				Me._FirstName = value
				Me.SendPropertyChanged("FirstName")
				Me.OnFirstNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_HireDate", DbType:="DateTime")>  _
	Public Property HireDate() As System.Nullable(Of Date)
		Get
			Return Me._HireDate
		End Get
		Set
			If (Me._HireDate.Equals(value) = false) Then
				Me.OnHireDateChanging(value)
				Me.SendPropertyChanging
				Me._HireDate = value
				Me.SendPropertyChanged("HireDate")
				Me.OnHireDateChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_EnrollmentDate", DbType:="DateTime")>  _
	Public Property EnrollmentDate() As System.Nullable(Of Date)
		Get
			Return Me._EnrollmentDate
		End Get
		Set
			If (Me._EnrollmentDate.Equals(value) = false) Then
				Me.OnEnrollmentDateChanging(value)
				Me.SendPropertyChanging
				Me._EnrollmentDate = value
				Me.SendPropertyChanged("EnrollmentDate")
				Me.OnEnrollmentDateChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Picture", DbType:="Image", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property Picture() As System.Data.Linq.Binary
		Get
			Return Me._Picture
		End Get
		Set
			If (Object.Equals(Me._Picture, value) = false) Then
				Me.OnPictureChanging(value)
				Me.SendPropertyChanging
				Me._Picture = value
				Me.SendPropertyChanged("Picture")
				Me.OnPictureChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_PersonCategory", DbType:="SmallInt NOT NULL")>  _
	Public Property PersonCategory() As Short
		Get
			Return Me._PersonCategory
		End Get
		Set
			If ((Me._PersonCategory = value)  _
						= false) Then
				Me.OnPersonCategoryChanging(value)
				Me.SendPropertyChanging
				Me._PersonCategory = value
				Me.SendPropertyChanged("PersonCategory")
				Me.OnPersonCategoryChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
