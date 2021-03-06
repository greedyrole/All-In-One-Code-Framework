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

<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute("c560c3bb-1945-435e-9fd3-1fcbb0db40bf"), _
 Assembly: Global.System.Data.Objects.DataClasses.EdmRelationshipAttribute("SQLServer2005DBModel", "FK_CourseGrade_Course", "Course", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.One, GetType(LinqToEntities.Course), "CourseGrade", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(LinqToEntities.CourseGrade)), _
 Assembly: Global.System.Data.Objects.DataClasses.EdmRelationshipAttribute("SQLServer2005DBModel", "FK_CourseGrade_Student", "Person", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.One, GetType(LinqToEntities.Person), "CourseGrade", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(LinqToEntities.CourseGrade)), _
 Assembly: Global.System.Data.Objects.DataClasses.EdmRelationshipAttribute("SQLServer2005DBModel", "CourseInstructor", "Course", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(LinqToEntities.Course), "Person", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(LinqToEntities.Person))> 

Namespace LinqToEntities
    'Original file name:
    'Generation date: 8/8/2009 10:17:34 PM
    '''<summary>
    '''There are no comments for SQLServer2005DBEntities in the schema.
    '''</summary>
    Partial Public Class SQLServer2005DBEntities
        Inherits Global.System.Data.Objects.ObjectContext
        '''<summary>
        '''Initializes a new SQLServer2005DBEntities object using the connection string found in the 'SQLServer2005DBEntities' section of the application configuration file.
        '''</summary>
        Public Sub New()
            MyBase.New("name=SQLServer2005DBEntities", "SQLServer2005DBEntities")
            Me.OnContextCreated()
        End Sub
        '''<summary>
        '''Initialize a new SQLServer2005DBEntities object.
        '''</summary>
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString, "SQLServer2005DBEntities")
            Me.OnContextCreated()
        End Sub
        '''<summary>
        '''Initialize a new SQLServer2005DBEntities object.
        '''</summary>
        Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
            MyBase.New(connection, "SQLServer2005DBEntities")
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
        '''There are no comments for CourseGrade in the schema.
        '''</summary>
        Public ReadOnly Property CourseGrade() As Global.System.Data.Objects.ObjectQuery(Of CourseGrade)
            Get
                If (Me._CourseGrade Is Nothing) Then
                    Me._CourseGrade = MyBase.CreateQuery(Of CourseGrade)("[CourseGrade]")
                End If
                Return Me._CourseGrade
            End Get
        End Property
        Private _CourseGrade As Global.System.Data.Objects.ObjectQuery(Of CourseGrade)
        '''<summary>
        '''There are no comments for Person in the schema.
        '''</summary>
        Public ReadOnly Property Person() As Global.System.Data.Objects.ObjectQuery(Of Person)
            Get
                If (Me._Person Is Nothing) Then
                    Me._Person = MyBase.CreateQuery(Of Person)("[Person]")
                End If
                Return Me._Person
            End Get
        End Property
        Private _Person As Global.System.Data.Objects.ObjectQuery(Of Person)
        '''<summary>
        '''There are no comments for Course in the schema.
        '''</summary>
        Public Sub AddToCourse(ByVal course As Course)
            MyBase.AddObject("Course", course)
        End Sub
        '''<summary>
        '''There are no comments for CourseGrade in the schema.
        '''</summary>
        Public Sub AddToCourseGrade(ByVal courseGrade As CourseGrade)
            MyBase.AddObject("CourseGrade", courseGrade)
        End Sub
        '''<summary>
        '''There are no comments for Person in the schema.
        '''</summary>
        Public Sub AddToPerson(ByVal person As Person)
            MyBase.AddObject("Person", person)
        End Sub
    End Class
    '''<summary>
    '''There are no comments for SQLServer2005DBModel.Course in the schema.
    '''</summary>
    '''<KeyProperties>
    '''CourseID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="SQLServer2005DBModel", Name:="Course"), _
     Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), _
     Global.System.Serializable()> _
    Partial Public Class Course
        Inherits Global.System.Data.Objects.DataClasses.EntityObject
        '''<summary>
        '''Create a new Course object.
        '''</summary>
        '''<param name="courseID">Initial value of CourseID.</param>
        '''<param name="title">Initial value of Title.</param>
        '''<param name="credits">Initial value of Credits.</param>
        '''<param name="departmentID">Initial value of DepartmentID.</param>
        Public Shared Function CreateCourse(ByVal courseID As Integer, ByVal title As String, ByVal credits As Integer, ByVal departmentID As Integer) As Course
            Dim course As Course = New Course
            course.CourseID = courseID
            course.Title = title
            course.Credits = credits
            course.DepartmentID = departmentID
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
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Title() As String
            Get
                Return Me._Title
            End Get
            Set(ByVal value As String)
                Me.OnTitleChanging(value)
                Me.ReportPropertyChanging("Title")
                Me._Title = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, False)
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
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Credits() As Integer
            Get
                Return Me._Credits
            End Get
            Set(ByVal value As Integer)
                Me.OnCreditsChanging(value)
                Me.ReportPropertyChanging("Credits")
                Me._Credits = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("Credits")
                Me.OnCreditsChanged()
            End Set
        End Property
        Private _Credits As Integer
        Partial Private Sub OnCreditsChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnCreditsChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property DepartmentID in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=False), _
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
        '''There are no comments for CourseGrade in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SQLServer2005DBModel", "FK_CourseGrade_Course", "CourseGrade"), _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(), _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property CourseGrade() As Global.System.Data.Objects.DataClasses.EntityCollection(Of CourseGrade)
            Get
                Return CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of CourseGrade)("SQLServer2005DBModel.FK_CourseGrade_Course", "CourseGrade")
            End Get
            Set(ByVal value As Global.System.Data.Objects.DataClasses.EntityCollection(Of CourseGrade))
                If (Not (value) Is Nothing) Then
                    CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of CourseGrade)("SQLServer2005DBModel.FK_CourseGrade_Course", "CourseGrade", value)
                End If
            End Set
        End Property
        '''<summary>
        '''There are no comments for Person in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SQLServer2005DBModel", "CourseInstructor", "Person"), _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(), _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Person() As Global.System.Data.Objects.DataClasses.EntityCollection(Of Person)
            Get
                Return CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of Person)("SQLServer2005DBModel.CourseInstructor", "Person")
            End Get
            Set(ByVal value As Global.System.Data.Objects.DataClasses.EntityCollection(Of Person))
                If (Not (value) Is Nothing) Then
                    CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of Person)("SQLServer2005DBModel.CourseInstructor", "Person", value)
                End If
            End Set
        End Property
    End Class
    '''<summary>
    '''There are no comments for SQLServer2005DBModel.CourseGrade in the schema.
    '''</summary>
    '''<KeyProperties>
    '''EnrollmentID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="SQLServer2005DBModel", Name:="CourseGrade"), _
     Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), _
     Global.System.Serializable()> _
    Partial Public Class CourseGrade
        Inherits Global.System.Data.Objects.DataClasses.EntityObject
        '''<summary>
        '''Create a new CourseGrade object.
        '''</summary>
        '''<param name="enrollmentID">Initial value of EnrollmentID.</param>
        Public Shared Function CreateCourseGrade(ByVal enrollmentID As Integer) As CourseGrade
            Dim courseGrade As CourseGrade = New CourseGrade
            courseGrade.EnrollmentID = enrollmentID
            Return courseGrade
        End Function
        '''<summary>
        '''There are no comments for Property EnrollmentID in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property EnrollmentID() As Integer
            Get
                Return Me._EnrollmentID
            End Get
            Set(ByVal value As Integer)
                Me.OnEnrollmentIDChanging(value)
                Me.ReportPropertyChanging("EnrollmentID")
                Me._EnrollmentID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("EnrollmentID")
                Me.OnEnrollmentIDChanged()
            End Set
        End Property
        Private _EnrollmentID As Integer
        Partial Private Sub OnEnrollmentIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnEnrollmentIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Grade in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Grade() As Global.System.Nullable(Of Decimal)
            Get
                Return Me._Grade
            End Get
            Set(ByVal value As Global.System.Nullable(Of Decimal))
                Me.OnGradeChanging(value)
                Me.ReportPropertyChanging("Grade")
                Me._Grade = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("Grade")
                Me.OnGradeChanged()
            End Set
        End Property
        Private _Grade As Global.System.Nullable(Of Decimal)
        Partial Private Sub OnGradeChanging(ByVal value As Global.System.Nullable(Of Decimal))
        End Sub
        Partial Private Sub OnGradeChanged()
        End Sub
        '''<summary>
        '''There are no comments for Course in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SQLServer2005DBModel", "FK_CourseGrade_Course", "Course"), _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(), _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Course() As Course
            Get
                Return CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Course)("SQLServer2005DBModel.FK_CourseGrade_Course", "Course").Value
            End Get
            Set(ByVal value As Course)
                CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Course)("SQLServer2005DBModel.FK_CourseGrade_Course", "Course").Value = value
            End Set
        End Property
        '''<summary>
        '''There are no comments for Course in the schema.
        '''</summary>
        <Global.System.ComponentModel.BrowsableAttribute(False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property CourseReference() As Global.System.Data.Objects.DataClasses.EntityReference(Of Course)
            Get
                Return CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Course)("SQLServer2005DBModel.FK_CourseGrade_Course", "Course")
            End Get
            Set(ByVal value As Global.System.Data.Objects.DataClasses.EntityReference(Of Course))
                If (Not (value) Is Nothing) Then
                    CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Course)("SQLServer2005DBModel.FK_CourseGrade_Course", "Course", value)
                End If
            End Set
        End Property
        '''<summary>
        '''There are no comments for Person in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SQLServer2005DBModel", "FK_CourseGrade_Student", "Person"), _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(), _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Person() As Person
            Get
                Return CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Person)("SQLServer2005DBModel.FK_CourseGrade_Student", "Person").Value
            End Get
            Set(ByVal value As Person)
                CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Person)("SQLServer2005DBModel.FK_CourseGrade_Student", "Person").Value = value
            End Set
        End Property
        '''<summary>
        '''There are no comments for Person in the schema.
        '''</summary>
        <Global.System.ComponentModel.BrowsableAttribute(False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property PersonReference() As Global.System.Data.Objects.DataClasses.EntityReference(Of Person)
            Get
                Return CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Person)("SQLServer2005DBModel.FK_CourseGrade_Student", "Person")
            End Get
            Set(ByVal value As Global.System.Data.Objects.DataClasses.EntityReference(Of Person))
                If (Not (value) Is Nothing) Then
                    CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Person)("SQLServer2005DBModel.FK_CourseGrade_Student", "Person", value)
                End If
            End Set
        End Property
    End Class
    '''<summary>
    '''There are no comments for SQLServer2005DBModel.Person in the schema.
    '''</summary>
    '''<KeyProperties>
    '''PersonID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="SQLServer2005DBModel", Name:="Person"), _
     Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=True), _
     Global.System.Serializable()> _
    Partial Public Class Person
        Inherits Global.System.Data.Objects.DataClasses.EntityObject
        '''<summary>
        '''Create a new Person object.
        '''</summary>
        '''<param name="personID">Initial value of PersonID.</param>
        '''<param name="lastName">Initial value of LastName.</param>
        '''<param name="firstName">Initial value of FirstName.</param>
        '''<param name="personCategory">Initial value of PersonCategory.</param>
        Public Shared Function CreatePerson(ByVal personID As Integer, ByVal lastName As String, ByVal firstName As String, ByVal personCategory As Short) As Person
            Dim person As Person = New Person
            person.PersonID = personID
            person.LastName = lastName
            person.FirstName = firstName
            person.PersonCategory = personCategory
            Return person
        End Function
        '''<summary>
        '''There are no comments for Property PersonID in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property PersonID() As Integer
            Get
                Return Me._PersonID
            End Get
            Set(ByVal value As Integer)
                Me.OnPersonIDChanging(value)
                Me.ReportPropertyChanging("PersonID")
                Me._PersonID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("PersonID")
                Me.OnPersonIDChanged()
            End Set
        End Property
        Private _PersonID As Integer
        Partial Private Sub OnPersonIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnPersonIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property LastName in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property LastName() As String
            Get
                Return Me._LastName
            End Get
            Set(ByVal value As String)
                Me.OnLastNameChanging(value)
                Me.ReportPropertyChanging("LastName")
                Me._LastName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, False)
                Me.ReportPropertyChanged("LastName")
                Me.OnLastNameChanged()
            End Set
        End Property
        Private _LastName As String
        Partial Private Sub OnLastNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnLastNameChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property FirstName in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property FirstName() As String
            Get
                Return Me._FirstName
            End Get
            Set(ByVal value As String)
                Me.OnFirstNameChanging(value)
                Me.ReportPropertyChanging("FirstName")
                Me._FirstName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, False)
                Me.ReportPropertyChanged("FirstName")
                Me.OnFirstNameChanged()
            End Set
        End Property
        Private _FirstName As String
        Partial Private Sub OnFirstNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnFirstNameChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property PersonCategory in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=False), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property PersonCategory() As Short
            Get
                Return Me._PersonCategory
            End Get
            Set(ByVal value As Short)
                Me.OnPersonCategoryChanging(value)
                Me.ReportPropertyChanging("PersonCategory")
                Me._PersonCategory = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("PersonCategory")
                Me.OnPersonCategoryChanged()
            End Set
        End Property
        Private _PersonCategory As Short
        Partial Private Sub OnPersonCategoryChanging(ByVal value As Short)
        End Sub
        Partial Private Sub OnPersonCategoryChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property HireDate in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property HireDate() As Global.System.Nullable(Of Date)
            Get
                Return Me._HireDate
            End Get
            Set(ByVal value As Global.System.Nullable(Of Date))
                Me.OnHireDateChanging(value)
                Me.ReportPropertyChanging("HireDate")
                Me._HireDate = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("HireDate")
                Me.OnHireDateChanged()
            End Set
        End Property
        Private _HireDate As Global.System.Nullable(Of Date)
        Partial Private Sub OnHireDateChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
        Partial Private Sub OnHireDateChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property EnrollmentDate in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property EnrollmentDate() As Global.System.Nullable(Of Date)
            Get
                Return Me._EnrollmentDate
            End Get
            Set(ByVal value As Global.System.Nullable(Of Date))
                Me.OnEnrollmentDateChanging(value)
                Me.ReportPropertyChanging("EnrollmentDate")
                Me._EnrollmentDate = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("EnrollmentDate")
                Me.OnEnrollmentDateChanged()
            End Set
        End Property
        Private _EnrollmentDate As Global.System.Nullable(Of Date)
        Partial Private Sub OnEnrollmentDateChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
        Partial Private Sub OnEnrollmentDateChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Picture in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Picture() As Byte()
            Get
                Return Global.System.Data.Objects.DataClasses.StructuralObject.GetValidValue(Me._Picture)
            End Get
            Set(ByVal value As Byte())
                Me.OnPictureChanging(value)
                Me.ReportPropertyChanging("Picture")
                Me._Picture = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, True)
                Me.ReportPropertyChanged("Picture")
                Me.OnPictureChanged()
            End Set
        End Property
        Private _Picture() As Byte
        Partial Private Sub OnPictureChanging(ByVal value() As Byte)
        End Sub
        Partial Private Sub OnPictureChanged()
        End Sub
        '''<summary>
        '''There are no comments for CourseGrade in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SQLServer2005DBModel", "FK_CourseGrade_Student", "CourseGrade"), _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(), _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property CourseGrade() As Global.System.Data.Objects.DataClasses.EntityCollection(Of CourseGrade)
            Get
                Return CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of CourseGrade)("SQLServer2005DBModel.FK_CourseGrade_Student", "CourseGrade")
            End Get
            Set(ByVal value As Global.System.Data.Objects.DataClasses.EntityCollection(Of CourseGrade))
                If (Not (value) Is Nothing) Then
                    CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of CourseGrade)("SQLServer2005DBModel.FK_CourseGrade_Student", "CourseGrade", value)
                End If
            End Set
        End Property
        '''<summary>
        '''There are no comments for Course in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SQLServer2005DBModel", "CourseInstructor", "Course"), _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(), _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(), _
         Global.System.Runtime.Serialization.DataMemberAttribute()> _
        Public Property Course() As Global.System.Data.Objects.DataClasses.EntityCollection(Of Course)
            Get
                Return CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of Course)("SQLServer2005DBModel.CourseInstructor", "Course")
            End Get
            Set(ByVal value As Global.System.Data.Objects.DataClasses.EntityCollection(Of Course))
                If (Not (value) Is Nothing) Then
                    CType(Me, Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of Course)("SQLServer2005DBModel.CourseInstructor", "Course", value)
                End If
            End Set
        End Property
    End Class
End Namespace