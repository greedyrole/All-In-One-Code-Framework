'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3603
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports VBEFEntityDataModel.VBEFEntityDataModel.One2Many

<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute("a6f7d9c4-b386-4e01-a510-c78d9f7e480f"), _
 Assembly: Global.System.Data.Objects.DataClasses.EdmRelationshipAttribute("EFO2MModel", "FK_Course_Department", "Department", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, GetType(Department), "Course", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(Course))> 
Namespace VBEFEntityDataModel.One2Many
    'Original file name:
    'Generation date: 2009/10/22 18:03:16
    '''<summary>
    '''There are no comments for EFO2MEntities in the schema.
    '''</summary>
    Partial Public Class EFO2MEntities
        Inherits Global.System.Data.Objects.ObjectContext
        '''<summary>
        '''Initializes a new EFO2MEntities object using the connection string found in the 'EFO2MEntities' section of the application configuration file.
        '''</summary>
        Public Sub New()
            MyBase.New("name=EFO2MEntities", "EFO2MEntities")
            Me.OnContextCreated()
        End Sub
        '''<summary>
        '''Initialize a new EFO2MEntities object.
        '''</summary>
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString, "EFO2MEntities")
            Me.OnContextCreated()
        End Sub
        '''<summary>
        '''Initialize a new EFO2MEntities object.
        '''</summary>
        Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
            MyBase.New(connection, "EFO2MEntities")
            Me.OnContextCreated()
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        '''<summary>
        '''There are no comments for Course in the schema.
        '''</summary>
        Public ReadOnly Property Course() As Global.System.Data.Objects.ObjectQuery(Of Course)
            Get
                If (Me._Course Is Nothing) Then
                    Me._Course = MyBase.CreateQuery(Of Course)("[Course]")
                End If
                Return Me._Course
            End Get
        End Property
        Private _Course As Global.System.Data.Objects.ObjectQuery(Of Course)
        '''<summary>
        '''There are no comments for Department in the schema.
        '''</summary>
        Public ReadOnly Property Department() As Global.System.Data.Objects.ObjectQuery(Of Department)
            Get
                If (Me._Department Is Nothing) Then
                    Me._Department = MyBase.CreateQuery(Of Department)("[Department]")
                End If
                Return Me._Department
            End Get
        End Property
        Private _Department As Global.System.Data.Objects.ObjectQuery(Of Department)
        '''<summary>
        '''There are no comments for Course in the schema.
        '''</summary>
        Public Sub AddToCourse(ByVal course As Course)
            MyBase.AddObject("Course", course)
        End Sub
        '''<summary>
        '''There are no comments for Department in the schema.
        '''</summary>
        Public Sub AddToDepartment(ByVal department As Department)
            MyBase.AddObject("Department", department)
        End Sub
    End Class
    '''<summary>
    '''There are no comments for EFO2MModel.Course in the schema.
    '''</summary>
    '''<KeyProperties>
    '''CourseID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="EFO2MModel", Name:="Course"), _
     Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), _
     Global.System.Serializable()> _
    Partial Public Class Course
        Inherits Global.System.Data.Objects.DataClasses.EntityObject
        '''<summary>
        '''Create a new Course object.
        '''</summary>
        '''<param name="courseID">Initial value of CourseID.</param>
        Public Shared Function CreateCourse(ByVal courseID As Integer) As Course
            Dim course As Course = New Course
            course.CourseID = courseID
            Return course
        End Function
        '''<summary>
        '''There are no comments for Property CourseID in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property CourseID() As Integer
            Get
                Return Me._CourseID
            End Get
            Set(ByVal value As Integer)
                Me.OnCourseIDChanging(value)
                Me.ReportPropertyChanging("CourseID")
                Me._CourseID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("CourseID")
                Me.OnCourseIDChanged()
            End Set
        End Property
        Private _CourseID As Integer
        Partial Private Sub OnCourseIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnCourseIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Title in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Title() As String
            Get
                Return Me._Title
            End Get
            Set(ByVal value As String)
                Me.OnTitleChanging(value)
                Me.ReportPropertyChanging("Title")
                Me._Title = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, True)
                Me.ReportPropertyChanged("Title")
                Me.OnTitleChanged()
            End Set
        End Property
        Private _Title As String
        Partial Private Sub OnTitleChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnTitleChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Credits in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Credits() As Global.System.Nullable(Of Integer)
            Get
                Return Me._Credits
            End Get
            Set(ByVal value As Global.System.Nullable(Of Integer))
                Me.OnCreditsChanging(value)
                Me.ReportPropertyChanging("Credits")
                Me._Credits = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("Credits")
                Me.OnCreditsChanged()
            End Set
        End Property
        Private _Credits As Global.System.Nullable(Of Integer)
        Partial Private Sub OnCreditsChanging(ByVal value As Global.System.Nullable(Of Integer))
        End Sub
        Partial Private Sub OnCreditsChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property StatusID in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property StatusID() As Global.System.Nullable(Of Boolean)
            Get
                Return Me._StatusID
            End Get
            Set(ByVal value As Global.System.Nullable(Of Boolean))
                Me.OnStatusIDChanging(value)
                Me.ReportPropertyChanging("StatusID")
                Me._StatusID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("StatusID")
                Me.OnStatusIDChanged()
            End Set
        End Property
        Private _StatusID As Global.System.Nullable(Of Boolean)
        Partial Private Sub OnStatusIDChanging(ByVal value As Global.System.Nullable(Of Boolean))
        End Sub
        Partial Private Sub OnStatusIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Department in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("EFO2MModel", "FK_Course_Department", "Department"), _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(), _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Department() As Department
            Get
                Return CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Department)("EFO2MModel.FK_Course_Department", "Department").Value
            End Get
            Set(ByVal value As Department)
                CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Department)("EFO2MModel.FK_Course_Department", "Department").Value = value
            End Set
        End Property
        '''<summary>
        '''There are no comments for Department in the schema.
        '''</summary>
        <Global.System.ComponentModel.BrowsableAttribute(False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property DepartmentReference() As Global.System.Data.Objects.DataClasses.EntityReference(Of Department)
            Get
                Return CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Department)("EFO2MModel.FK_Course_Department", "Department")
            End Get
            Set(ByVal value As Global.System.Data.Objects.DataClasses.EntityReference(Of Department))
                If (Not (value) Is Nothing) Then
                    CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Department)("EFO2MModel.FK_Course_Department", "Department", value)
                End If
            End Set
        End Property
    End Class
    '''<summary>
    '''There are no comments for EFO2MModel.Department in the schema.
    '''</summary>
    '''<KeyProperties>
    '''DepartmentID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="EFO2MModel", Name:="Department"), _
     Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), _
     Global.System.Serializable()> _
    Partial Public Class Department
        Inherits Global.System.Data.Objects.DataClasses.EntityObject
        '''<summary>
        '''Create a new Department object.
        '''</summary>
        '''<param name="departmentID">Initial value of DepartmentID.</param>
        Public Shared Function CreateDepartment(ByVal departmentID As Integer) As Department
            Dim department As Department = New Department
            department.DepartmentID = departmentID
            Return department
        End Function
        '''<summary>
        '''There are no comments for Property DepartmentID in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property DepartmentID() As Integer
            Get
                Return Me._DepartmentID
            End Get
            Set(ByVal value As Integer)
                Me.OnDepartmentIDChanging(value)
                Me.ReportPropertyChanging("DepartmentID")
                Me._DepartmentID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("DepartmentID")
                Me.OnDepartmentIDChanged()
            End Set
        End Property
        Private _DepartmentID As Integer
        Partial Private Sub OnDepartmentIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnDepartmentIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Name in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(ByVal value As String)
                Me.OnNameChanging(value)
                Me.ReportPropertyChanging("Name")
                Me._Name = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, True)
                Me.ReportPropertyChanged("Name")
                Me.OnNameChanged()
            End Set
        End Property
        Private _Name As String
        Partial Private Sub OnNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnNameChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Budget in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Budget() As Global.System.Nullable(Of Decimal)
            Get
                Return Me._Budget
            End Get
            Set(ByVal value As Global.System.Nullable(Of Decimal))
                Me.OnBudgetChanging(value)
                Me.ReportPropertyChanging("Budget")
                Me._Budget = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("Budget")
                Me.OnBudgetChanged()
            End Set
        End Property
        Private _Budget As Global.System.Nullable(Of Decimal)
        Partial Private Sub OnBudgetChanging(ByVal value As Global.System.Nullable(Of Decimal))
        End Sub
        Partial Private Sub OnBudgetChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property StartDate in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property StartDate() As Global.System.Nullable(Of Date)
            Get
                Return Me._StartDate
            End Get
            Set(ByVal value As Global.System.Nullable(Of Date))
                Me.OnStartDateChanging(value)
                Me.ReportPropertyChanging("StartDate")
                Me._StartDate = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("StartDate")
                Me.OnStartDateChanged()
            End Set
        End Property
        Private _StartDate As Global.System.Nullable(Of Date)
        Partial Private Sub OnStartDateChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
        Partial Private Sub OnStartDateChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Administrator in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Administrator() As Global.System.Nullable(Of Integer)
            Get
                Return Me._Administrator
            End Get
            Set(ByVal value As Global.System.Nullable(Of Integer))
                Me.OnAdministratorChanging(value)
                Me.ReportPropertyChanging("Administrator")
                Me._Administrator = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("Administrator")
                Me.OnAdministratorChanged()
            End Set
        End Property
        Private _Administrator As Global.System.Nullable(Of Integer)
        Partial Private Sub OnAdministratorChanging(ByVal value As Global.System.Nullable(Of Integer))
        End Sub
        Partial Private Sub OnAdministratorChanged()
        End Sub
        '''<summary>
        '''There are no comments for Course in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("EFO2MModel", "FK_Course_Department", "Course"), _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(), _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Course() As Global.System.Data.Objects.DataClasses.EntityCollection(Of Course)
            Get
                Return CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of Course)("EFO2MModel.FK_Course_Department", "Course")
            End Get
            Set(ByVal value As Global.System.Data.Objects.DataClasses.EntityCollection(Of Course))
                If (Not (value) Is Nothing) Then
                    CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of Course)("EFO2MModel.FK_Course_Department", "Course", value)
                End If
            End Set
        End Property
    End Class
End Namespace