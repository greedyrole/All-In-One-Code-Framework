'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4927
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute("5998540f-cc11-49fb-879b-6377531fad6b")> 

'Original file name:
'Generation date: 3/4/2010 11:15:03 AM
'''<summary>
'''There are no comments for NorthwindEntities in the schema.
'''</summary>
Partial Public Class NorthwindEntities
    Inherits Global.System.Data.Objects.ObjectContext
    '''<summary>
    '''Initializes a new NorthwindEntities object using the connection string found in the 'NorthwindEntities' section of the application configuration file.
    '''</summary>
    Public Sub New()
        MyBase.New("name=NorthwindEntities", "NorthwindEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new NorthwindEntities object.
    '''</summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "NorthwindEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new NorthwindEntities object.
    '''</summary>
    Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
        MyBase.New(connection, "NorthwindEntities")
        Me.OnContextCreated
    End Sub
    Partial Private Sub OnContextCreated()
        End Sub
    '''<summary>
    '''There are no comments for Customers in the schema.
    '''</summary>
    Public ReadOnly Property Customers() As Global.System.Data.Objects.ObjectQuery(Of Customers)
        Get
            If (Me._Customers Is Nothing) Then
                Me._Customers = MyBase.CreateQuery(Of Customers)("[Customers]")
            End If
            Return Me._Customers
        End Get
    End Property
    Private _Customers As Global.System.Data.Objects.ObjectQuery(Of Customers)
    '''<summary>
    '''There are no comments for Customers in the schema.
    '''</summary>
    Public Sub AddToCustomers(ByVal customers As Customers)
        MyBase.AddObject("Customers", customers)
    End Sub
End Class
'''<summary>
'''There are no comments for NorthwindModel.Customers in the schema.
'''</summary>
'''<KeyProperties>
'''CustomerID
'''</KeyProperties>
<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="NorthwindModel", Name:="Customers"),  _
 Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=true),  _
 Global.System.Serializable()>  _
Partial Public Class Customers
    Inherits Global.System.Data.Objects.DataClasses.EntityObject
    '''<summary>
    '''Create a new Customers object.
    '''</summary>
    '''<param name="companyName">Initial value of CompanyName.</param>
    '''<param name="customerID">Initial value of CustomerID.</param>
    Public Shared Function CreateCustomers(ByVal companyName As String, ByVal customerID As String) As Customers
        Dim customers As Customers = New Customers
        customers.CompanyName = companyName
        customers.CustomerID = customerID
        Return customers
    End Function
    '''<summary>
    '''There are no comments for Property Address in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Address() As String
        Get
            Return Me._Address
        End Get
        Set
            Me.OnAddressChanging(value)
            Me.ReportPropertyChanging("Address")
            Me._Address = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Address")
            Me.OnAddressChanged
        End Set
    End Property
    Private _Address As String
    Partial Private Sub OnAddressChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnAddressChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property City in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property City() As String
        Get
            Return Me._City
        End Get
        Set
            Me.OnCityChanging(value)
            Me.ReportPropertyChanging("City")
            Me._City = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("City")
            Me.OnCityChanged
        End Set
    End Property
    Private _City As String
    Partial Private Sub OnCityChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnCityChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property CompanyName in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property CompanyName() As String
        Get
            Return Me._CompanyName
        End Get
        Set
            Me.OnCompanyNameChanging(value)
            Me.ReportPropertyChanging("CompanyName")
            Me._CompanyName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("CompanyName")
            Me.OnCompanyNameChanged
        End Set
    End Property
    Private _CompanyName As String
    Partial Private Sub OnCompanyNameChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnCompanyNameChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property ContactName in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property ContactName() As String
        Get
            Return Me._ContactName
        End Get
        Set
            Me.OnContactNameChanging(value)
            Me.ReportPropertyChanging("ContactName")
            Me._ContactName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("ContactName")
            Me.OnContactNameChanged
        End Set
    End Property
    Private _ContactName As String
    Partial Private Sub OnContactNameChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnContactNameChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property ContactTitle in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property ContactTitle() As String
        Get
            Return Me._ContactTitle
        End Get
        Set
            Me.OnContactTitleChanging(value)
            Me.ReportPropertyChanging("ContactTitle")
            Me._ContactTitle = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("ContactTitle")
            Me.OnContactTitleChanged
        End Set
    End Property
    Private _ContactTitle As String
    Partial Private Sub OnContactTitleChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnContactTitleChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Country in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Country() As String
        Get
            Return Me._Country
        End Get
        Set
            Me.OnCountryChanging(value)
            Me.ReportPropertyChanging("Country")
            Me._Country = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Country")
            Me.OnCountryChanged
        End Set
    End Property
    Private _Country As String
    Partial Private Sub OnCountryChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnCountryChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property CustomerID in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property CustomerID() As String
        Get
            Return Me._CustomerID
        End Get
        Set
            Me.OnCustomerIDChanging(value)
            Me.ReportPropertyChanging("CustomerID")
            Me._CustomerID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("CustomerID")
            Me.OnCustomerIDChanged
        End Set
    End Property
    Private _CustomerID As String
    Partial Private Sub OnCustomerIDChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnCustomerIDChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Fax in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Fax() As String
        Get
            Return Me._Fax
        End Get
        Set
            Me.OnFaxChanging(value)
            Me.ReportPropertyChanging("Fax")
            Me._Fax = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Fax")
            Me.OnFaxChanged
        End Set
    End Property
    Private _Fax As String
    Partial Private Sub OnFaxChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnFaxChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Phone in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Phone() As String
        Get
            Return Me._Phone
        End Get
        Set
            Me.OnPhoneChanging(value)
            Me.ReportPropertyChanging("Phone")
            Me._Phone = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Phone")
            Me.OnPhoneChanged
        End Set
    End Property
    Private _Phone As String
    Partial Private Sub OnPhoneChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnPhoneChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property PostalCode in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property PostalCode() As String
        Get
            Return Me._PostalCode
        End Get
        Set
            Me.OnPostalCodeChanging(value)
            Me.ReportPropertyChanging("PostalCode")
            Me._PostalCode = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("PostalCode")
            Me.OnPostalCodeChanged
        End Set
    End Property
    Private _PostalCode As String
    Partial Private Sub OnPostalCodeChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnPostalCodeChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Region in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Region() As String
        Get
            Return Me._Region
        End Get
        Set
            Me.OnRegionChanging(value)
            Me.ReportPropertyChanging("Region")
            Me._Region = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Region")
            Me.OnRegionChanged
        End Set
    End Property
    Private _Region As String
    Partial Private Sub OnRegionChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnRegionChanged()
        End Sub
End Class
