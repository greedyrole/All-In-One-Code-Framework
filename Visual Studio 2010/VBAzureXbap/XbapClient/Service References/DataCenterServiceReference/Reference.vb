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
Imports System.Runtime.Serialization

Namespace DataCenterServiceReference
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="DataCenter", [Namespace]:="http://schemas.datacontract.org/2004/07/WCFServiceWebRole"),  _
     System.SerializableAttribute()>  _
    Partial Public Class DataCenter
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private BoundField As DataCenterServiceReference.Rect
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private NameField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Bound() As DataCenterServiceReference.Rect
            Get
                Return Me.BoundField
            End Get
            Set
                If (Object.ReferenceEquals(Me.BoundField, value) <> true) Then
                    Me.BoundField = value
                    Me.RaisePropertyChanged("Bound")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me.NameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.NameField, value) <> true) Then
                    Me.NameField = value
                    Me.RaisePropertyChanged("Name")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Rect", [Namespace]:="http://schemas.datacontract.org/2004/07/WCFServiceWebRole"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Rect
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private HeightField As Double
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private WidthField As Double
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private XField As Double
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private YField As Double
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Height() As Double
            Get
                Return Me.HeightField
            End Get
            Set
                If (Me.HeightField.Equals(value) <> true) Then
                    Me.HeightField = value
                    Me.RaisePropertyChanged("Height")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Width() As Double
            Get
                Return Me.WidthField
            End Get
            Set
                If (Me.WidthField.Equals(value) <> true) Then
                    Me.WidthField = value
                    Me.RaisePropertyChanged("Width")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property X() As Double
            Get
                Return Me.XField
            End Get
            Set
                If (Me.XField.Equals(value) <> true) Then
                    Me.XField = value
                    Me.RaisePropertyChanged("X")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Y() As Double
            Get
                Return Me.YField
            End Get
            Set
                If (Me.YField.Equals(value) <> true) Then
                    Me.YField = value
                    Me.RaisePropertyChanged("Y")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="DataCenterServiceReference.IDataCenterService")>  _
    Public Interface IDataCenterService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataCenterService/GetDataCenters", ReplyAction:="http://tempuri.org/IDataCenterService/GetDataCentersResponse")>  _
        Function GetDataCenters() As DataCenterServiceReference.DataCenter()
        
        <System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/IDataCenterService/GetDataCenters", ReplyAction:="http://tempuri.org/IDataCenterService/GetDataCentersResponse")>  _
        Function BeginGetDataCenters(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Function EndGetDataCenters(ByVal result As System.IAsyncResult) As DataCenterServiceReference.DataCenter()
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IDataCenterServiceChannel
        Inherits DataCenterServiceReference.IDataCenterService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class GetDataCentersCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Public Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        Public ReadOnly Property Result() As DataCenterServiceReference.DataCenter()
            Get
                MyBase.RaiseExceptionIfNecessary
                Return CType(Me.results(0),DataCenterServiceReference.DataCenter())
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class DataCenterServiceClient
        Inherits System.ServiceModel.ClientBase(Of DataCenterServiceReference.IDataCenterService)
        Implements DataCenterServiceReference.IDataCenterService
        
        Private onBeginGetDataCentersDelegate As BeginOperationDelegate
        
        Private onEndGetDataCentersDelegate As EndOperationDelegate
        
        Private onGetDataCentersCompletedDelegate As System.Threading.SendOrPostCallback
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Event GetDataCentersCompleted As System.EventHandler(Of GetDataCentersCompletedEventArgs)
        
        Public Function GetDataCenters() As DataCenterServiceReference.DataCenter() Implements DataCenterServiceReference.IDataCenterService.GetDataCenters
            Return MyBase.Channel.GetDataCenters
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Function BeginGetDataCenters(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements DataCenterServiceReference.IDataCenterService.BeginGetDataCenters
            Return MyBase.Channel.BeginGetDataCenters(callback, asyncState)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Function EndGetDataCenters(ByVal result As System.IAsyncResult) As DataCenterServiceReference.DataCenter() Implements DataCenterServiceReference.IDataCenterService.EndGetDataCenters
            Return MyBase.Channel.EndGetDataCenters(result)
        End Function
        
        Private Function OnBeginGetDataCenters(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginGetDataCenters(callback, asyncState)
        End Function
        
        Private Function OnEndGetDataCenters(ByVal result As System.IAsyncResult) As Object()
            Dim retVal() As DataCenterServiceReference.DataCenter = Me.EndGetDataCenters(result)
            Return New Object() {retVal}
        End Function
        
        Private Sub OnGetDataCentersCompleted(ByVal state As Object)
            If (Not (Me.GetDataCentersCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent GetDataCentersCompleted(Me, New GetDataCentersCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub GetDataCentersAsync()
            Me.GetDataCentersAsync(Nothing)
        End Sub
        
        Public Overloads Sub GetDataCentersAsync(ByVal userState As Object)
            If (Me.onBeginGetDataCentersDelegate Is Nothing) Then
                Me.onBeginGetDataCentersDelegate = AddressOf Me.OnBeginGetDataCenters
            End If
            If (Me.onEndGetDataCentersDelegate Is Nothing) Then
                Me.onEndGetDataCentersDelegate = AddressOf Me.OnEndGetDataCenters
            End If
            If (Me.onGetDataCentersCompletedDelegate Is Nothing) Then
                Me.onGetDataCentersCompletedDelegate = AddressOf Me.OnGetDataCentersCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginGetDataCentersDelegate, Nothing, Me.onEndGetDataCentersDelegate, Me.onGetDataCentersCompletedDelegate, userState)
        End Sub
    End Class
End Namespace
