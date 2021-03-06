'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
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


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="SessionDB")>  _
Partial Public Class SessionDBDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InserttblChatRoom(instance As tblChatRoom)
    End Sub
  Partial Private Sub UpdatetblChatRoom(instance As tblChatRoom)
    End Sub
  Partial Private Sub DeletetblChatRoom(instance As tblChatRoom)
    End Sub
  Partial Private Sub InserttblTalker(instance As tblTalker)
    End Sub
  Partial Private Sub UpdatetblTalker(instance As tblTalker)
    End Sub
  Partial Private Sub DeletetblTalker(instance As tblTalker)
    End Sub
  Partial Private Sub InserttblMessagePool(instance As tblMessagePool)
    End Sub
  Partial Private Sub UpdatetblMessagePool(instance As tblMessagePool)
    End Sub
  Partial Private Sub DeletetblMessagePool(instance As tblMessagePool)
    End Sub
  Partial Private Sub InserttblSession(instance As tblSession)
    End Sub
  Partial Private Sub UpdatetblSession(instance As tblSession)
    End Sub
  Partial Private Sub DeletetblSession(instance As tblSession)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("SessionDBConnectionString").ConnectionString, mappingSource)
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
	
	Public ReadOnly Property tblChatRooms() As System.Data.Linq.Table(Of tblChatRoom)
		Get
			Return Me.GetTable(Of tblChatRoom)
		End Get
	End Property
	
	Public ReadOnly Property tblTalkers() As System.Data.Linq.Table(Of tblTalker)
		Get
			Return Me.GetTable(Of tblTalker)
		End Get
	End Property
	
	Public ReadOnly Property tblMessagePools() As System.Data.Linq.Table(Of tblMessagePool)
		Get
			Return Me.GetTable(Of tblMessagePool)
		End Get
	End Property
	
	Public ReadOnly Property tblSessions() As System.Data.Linq.Table(Of tblSession)
		Get
			Return Me.GetTable(Of tblSession)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblChatRoom")>  _
Partial Public Class tblChatRoom
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ChatRoomID As System.Guid
	
	Private _ChatRoomPassword As String
	
	Private _ChatRoomName As String
	
	Private _NeedPassword As Boolean
	
	Private _MaxUserNumber As Integer
	
	Private _IsLock As Boolean
	
	Private _tblTalkers As EntitySet(Of tblTalker)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnChatRoomIDChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnChatRoomIDChanged()
    End Sub
    Partial Private Sub OnChatRoomPasswordChanging(value As String)
    End Sub
    Partial Private Sub OnChatRoomPasswordChanged()
    End Sub
    Partial Private Sub OnChatRoomNameChanging(value As String)
    End Sub
    Partial Private Sub OnChatRoomNameChanged()
    End Sub
    Partial Private Sub OnNeedPasswordChanging(value As Boolean)
    End Sub
    Partial Private Sub OnNeedPasswordChanged()
    End Sub
    Partial Private Sub OnMaxUserNumberChanging(value As Integer)
    End Sub
    Partial Private Sub OnMaxUserNumberChanged()
    End Sub
    Partial Private Sub OnIsLockChanging(value As Boolean)
    End Sub
    Partial Private Sub OnIsLockChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._tblTalkers = New EntitySet(Of tblTalker)(AddressOf Me.attach_tblTalkers, AddressOf Me.detach_tblTalkers)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ChatRoomID", DbType:="UniqueIdentifier NOT NULL", IsPrimaryKey:=true)>  _
	Public Property ChatRoomID() As System.Guid
		Get
			Return Me._ChatRoomID
		End Get
		Set
			If ((Me._ChatRoomID = value)  _
						= false) Then
				Me.OnChatRoomIDChanging(value)
				Me.SendPropertyChanging
				Me._ChatRoomID = value
				Me.SendPropertyChanged("ChatRoomID")
				Me.OnChatRoomIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ChatRoomPassword", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property ChatRoomPassword() As String
		Get
			Return Me._ChatRoomPassword
		End Get
		Set
			If (String.Equals(Me._ChatRoomPassword, value) = false) Then
				Me.OnChatRoomPasswordChanging(value)
				Me.SendPropertyChanging
				Me._ChatRoomPassword = value
				Me.SendPropertyChanged("ChatRoomPassword")
				Me.OnChatRoomPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ChatRoomName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property ChatRoomName() As String
		Get
			Return Me._ChatRoomName
		End Get
		Set
			If (String.Equals(Me._ChatRoomName, value) = false) Then
				Me.OnChatRoomNameChanging(value)
				Me.SendPropertyChanging
				Me._ChatRoomName = value
				Me.SendPropertyChanged("ChatRoomName")
				Me.OnChatRoomNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NeedPassword", DbType:="Bit NOT NULL")>  _
	Public Property NeedPassword() As Boolean
		Get
			Return Me._NeedPassword
		End Get
		Set
			If ((Me._NeedPassword = value)  _
						= false) Then
				Me.OnNeedPasswordChanging(value)
				Me.SendPropertyChanging
				Me._NeedPassword = value
				Me.SendPropertyChanged("NeedPassword")
				Me.OnNeedPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MaxUserNumber", DbType:="Int NOT NULL")>  _
	Public Property MaxUserNumber() As Integer
		Get
			Return Me._MaxUserNumber
		End Get
		Set
			If ((Me._MaxUserNumber = value)  _
						= false) Then
				Me.OnMaxUserNumberChanging(value)
				Me.SendPropertyChanging
				Me._MaxUserNumber = value
				Me.SendPropertyChanged("MaxUserNumber")
				Me.OnMaxUserNumberChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsLock", DbType:="Bit NOT NULL")>  _
	Public Property IsLock() As Boolean
		Get
			Return Me._IsLock
		End Get
		Set
			If ((Me._IsLock = value)  _
						= false) Then
				Me.OnIsLockChanging(value)
				Me.SendPropertyChanging
				Me._IsLock = value
				Me.SendPropertyChanged("IsLock")
				Me.OnIsLockChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tblChatRoom_tblTalker", Storage:="_tblTalkers", ThisKey:="ChatRoomID", OtherKey:="ChatRoomID")>  _
	Public Property tblTalkers() As EntitySet(Of tblTalker)
		Get
			Return Me._tblTalkers
		End Get
		Set
			Me._tblTalkers.Assign(value)
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
	
	Private Sub attach_tblTalkers(ByVal entity As tblTalker)
		Me.SendPropertyChanging
		entity.tblChatRoom = Me
	End Sub
	
	Private Sub detach_tblTalkers(ByVal entity As tblTalker)
		Me.SendPropertyChanging
		entity.tblChatRoom = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblTalker")>  _
Partial Public Class tblTalker
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _TalkerID As Integer
	
	Private _SessionID As Integer
	
	Private _ChatRoomID As System.Guid
	
	Private _CheckInTime As Date
	
	Private _CheckOutTime As System.Nullable(Of Date)
	
	Private _tblMessagePools As EntitySet(Of tblMessagePool)
	
	Private _tblChatRoom As EntityRef(Of tblChatRoom)
	
	Private _tblSession As EntityRef(Of tblSession)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnTalkerIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnTalkerIDChanged()
    End Sub
    Partial Private Sub OnSessionIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnSessionIDChanged()
    End Sub
    Partial Private Sub OnChatRoomIDChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnChatRoomIDChanged()
    End Sub
    Partial Private Sub OnCheckInTimeChanging(value As Date)
    End Sub
    Partial Private Sub OnCheckInTimeChanged()
    End Sub
    Partial Private Sub OnCheckOutTimeChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnCheckOutTimeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._tblMessagePools = New EntitySet(Of tblMessagePool)(AddressOf Me.attach_tblMessagePools, AddressOf Me.detach_tblMessagePools)
		Me._tblChatRoom = CType(Nothing, EntityRef(Of tblChatRoom))
		Me._tblSession = CType(Nothing, EntityRef(Of tblSession))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TalkerID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property TalkerID() As Integer
		Get
			Return Me._TalkerID
		End Get
		Set
			If ((Me._TalkerID = value)  _
						= false) Then
				Me.OnTalkerIDChanging(value)
				Me.SendPropertyChanging
				Me._TalkerID = value
				Me.SendPropertyChanged("TalkerID")
				Me.OnTalkerIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SessionID", DbType:="Int NOT NULL")>  _
	Public Property SessionID() As Integer
		Get
			Return Me._SessionID
		End Get
		Set
			If ((Me._SessionID = value)  _
						= false) Then
				If Me._tblSession.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnSessionIDChanging(value)
				Me.SendPropertyChanging
				Me._SessionID = value
				Me.SendPropertyChanged("SessionID")
				Me.OnSessionIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ChatRoomID", DbType:="UniqueIdentifier NOT NULL")>  _
	Public Property ChatRoomID() As System.Guid
		Get
			Return Me._ChatRoomID
		End Get
		Set
			If ((Me._ChatRoomID = value)  _
						= false) Then
				If Me._tblChatRoom.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnChatRoomIDChanging(value)
				Me.SendPropertyChanging
				Me._ChatRoomID = value
				Me.SendPropertyChanged("ChatRoomID")
				Me.OnChatRoomIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CheckInTime", DbType:="DateTime NOT NULL")>  _
	Public Property CheckInTime() As Date
		Get
			Return Me._CheckInTime
		End Get
		Set
			If ((Me._CheckInTime = value)  _
						= false) Then
				Me.OnCheckInTimeChanging(value)
				Me.SendPropertyChanging
				Me._CheckInTime = value
				Me.SendPropertyChanged("CheckInTime")
				Me.OnCheckInTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CheckOutTime", DbType:="DateTime")>  _
	Public Property CheckOutTime() As System.Nullable(Of Date)
		Get
			Return Me._CheckOutTime
		End Get
		Set
			If (Me._CheckOutTime.Equals(value) = false) Then
				Me.OnCheckOutTimeChanging(value)
				Me.SendPropertyChanging
				Me._CheckOutTime = value
				Me.SendPropertyChanged("CheckOutTime")
				Me.OnCheckOutTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tblTalker_tblMessagePool", Storage:="_tblMessagePools", ThisKey:="TalkerID", OtherKey:="talkerID")>  _
	Public Property tblMessagePools() As EntitySet(Of tblMessagePool)
		Get
			Return Me._tblMessagePools
		End Get
		Set
			Me._tblMessagePools.Assign(value)
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tblChatRoom_tblTalker", Storage:="_tblChatRoom", ThisKey:="ChatRoomID", OtherKey:="ChatRoomID", IsForeignKey:=true)>  _
	Public Property tblChatRoom() As tblChatRoom
		Get
			Return Me._tblChatRoom.Entity
		End Get
		Set
			Dim previousValue As tblChatRoom = Me._tblChatRoom.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._tblChatRoom.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._tblChatRoom.Entity = Nothing
					previousValue.tblTalkers.Remove(Me)
				End If
				Me._tblChatRoom.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.tblTalkers.Add(Me)
					Me._ChatRoomID = value.ChatRoomID
				Else
					Me._ChatRoomID = CType(Nothing, System.Guid)
				End If
				Me.SendPropertyChanged("tblChatRoom")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tblSession_tblTalker", Storage:="_tblSession", ThisKey:="SessionID", OtherKey:="UID", IsForeignKey:=true)>  _
	Public Property tblSession() As tblSession
		Get
			Return Me._tblSession.Entity
		End Get
		Set
			Dim previousValue As tblSession = Me._tblSession.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._tblSession.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._tblSession.Entity = Nothing
					previousValue.tblTalkers.Remove(Me)
				End If
				Me._tblSession.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.tblTalkers.Add(Me)
					Me._SessionID = value.UID
				Else
					Me._SessionID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("tblSession")
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
	
	Private Sub attach_tblMessagePools(ByVal entity As tblMessagePool)
		Me.SendPropertyChanging
		entity.tblTalker = Me
	End Sub
	
	Private Sub detach_tblMessagePools(ByVal entity As tblMessagePool)
		Me.SendPropertyChanging
		entity.tblTalker = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblMessagePool")>  _
Partial Public Class tblMessagePool
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _messageID As Integer
	
	Private _message As String
	
	Private _SendTime As Date
	
	Private _talkerID As Integer
	
	Private _tblTalker As EntityRef(Of tblTalker)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnmessageIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnmessageIDChanged()
    End Sub
    Partial Private Sub OnmessageChanging(value As String)
    End Sub
    Partial Private Sub OnmessageChanged()
    End Sub
    Partial Private Sub OnSendTimeChanging(value As Date)
    End Sub
    Partial Private Sub OnSendTimeChanged()
    End Sub
    Partial Private Sub OntalkerIDChanging(value As Integer)
    End Sub
    Partial Private Sub OntalkerIDChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._tblTalker = CType(Nothing, EntityRef(Of tblTalker))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_messageID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property messageID() As Integer
		Get
			Return Me._messageID
		End Get
		Set
			If ((Me._messageID = value)  _
						= false) Then
				Me.OnmessageIDChanging(value)
				Me.SendPropertyChanging
				Me._messageID = value
				Me.SendPropertyChanged("messageID")
				Me.OnmessageIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_message", DbType:="NVarChar(1000) NOT NULL", CanBeNull:=false)>  _
	Public Property message() As String
		Get
			Return Me._message
		End Get
		Set
			If (String.Equals(Me._message, value) = false) Then
				Me.OnmessageChanging(value)
				Me.SendPropertyChanging
				Me._message = value
				Me.SendPropertyChanged("message")
				Me.OnmessageChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SendTime", DbType:="DateTime NOT NULL")>  _
	Public Property SendTime() As Date
		Get
			Return Me._SendTime
		End Get
		Set
			If ((Me._SendTime = value)  _
						= false) Then
				Me.OnSendTimeChanging(value)
				Me.SendPropertyChanging
				Me._SendTime = value
				Me.SendPropertyChanged("SendTime")
				Me.OnSendTimeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_talkerID", DbType:="Int NOT NULL")>  _
	Public Property talkerID() As Integer
		Get
			Return Me._talkerID
		End Get
		Set
			If ((Me._talkerID = value)  _
						= false) Then
				If Me._tblTalker.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OntalkerIDChanging(value)
				Me.SendPropertyChanging
				Me._talkerID = value
				Me.SendPropertyChanged("talkerID")
				Me.OntalkerIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tblTalker_tblMessagePool", Storage:="_tblTalker", ThisKey:="talkerID", OtherKey:="TalkerID", IsForeignKey:=true)>  _
	Public Property tblTalker() As tblTalker
		Get
			Return Me._tblTalker.Entity
		End Get
		Set
			Dim previousValue As tblTalker = Me._tblTalker.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._tblTalker.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._tblTalker.Entity = Nothing
					previousValue.tblMessagePools.Remove(Me)
				End If
				Me._tblTalker.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.tblMessagePools.Add(Me)
					Me._talkerID = value.TalkerID
				Else
					Me._talkerID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("tblTalker")
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

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblSession")>  _
Partial Public Class tblSession
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _UID As Integer
	
	Private _SessionID As String
	
	Private _IP As String
	
	Private _UserAlias As String
	
	Private _tblTalkers As EntitySet(Of tblTalker)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnUIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnUIDChanged()
    End Sub
    Partial Private Sub OnSessionIDChanging(value As String)
    End Sub
    Partial Private Sub OnSessionIDChanged()
    End Sub
    Partial Private Sub OnIPChanging(value As String)
    End Sub
    Partial Private Sub OnIPChanged()
    End Sub
    Partial Private Sub OnUserAliasChanging(value As String)
    End Sub
    Partial Private Sub OnUserAliasChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._tblTalkers = New EntitySet(Of tblTalker)(AddressOf Me.attach_tblTalkers, AddressOf Me.detach_tblTalkers)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property UID() As Integer
		Get
			Return Me._UID
		End Get
		Set
			If ((Me._UID = value)  _
						= false) Then
				Me.OnUIDChanging(value)
				Me.SendPropertyChanging
				Me._UID = value
				Me.SendPropertyChanged("UID")
				Me.OnUIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SessionID", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property SessionID() As String
		Get
			Return Me._SessionID
		End Get
		Set
			If (String.Equals(Me._SessionID, value) = false) Then
				Me.OnSessionIDChanging(value)
				Me.SendPropertyChanging
				Me._SessionID = value
				Me.SendPropertyChanged("SessionID")
				Me.OnSessionIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IP", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property IP() As String
		Get
			Return Me._IP
		End Get
		Set
			If (String.Equals(Me._IP, value) = false) Then
				Me.OnIPChanging(value)
				Me.SendPropertyChanging
				Me._IP = value
				Me.SendPropertyChanged("IP")
				Me.OnIPChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserAlias", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property UserAlias() As String
		Get
			Return Me._UserAlias
		End Get
		Set
			If (String.Equals(Me._UserAlias, value) = false) Then
				Me.OnUserAliasChanging(value)
				Me.SendPropertyChanging
				Me._UserAlias = value
				Me.SendPropertyChanged("UserAlias")
				Me.OnUserAliasChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="tblSession_tblTalker", Storage:="_tblTalkers", ThisKey:="UID", OtherKey:="SessionID")>  _
	Public Property tblTalkers() As EntitySet(Of tblTalker)
		Get
			Return Me._tblTalkers
		End Get
		Set
			Me._tblTalkers.Assign(value)
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
	
	Private Sub attach_tblTalkers(ByVal entity As tblTalker)
		Me.SendPropertyChanging
		entity.tblSession = Me
	End Sub
	
	Private Sub detach_tblTalkers(ByVal entity As tblTalker)
		Me.SendPropertyChanging
		entity.tblSession = Nothing
	End Sub
End Class
