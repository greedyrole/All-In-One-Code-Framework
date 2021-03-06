//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("SchoolModel", "FK_CourseGrade_Course", "Course", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CSLinqToEntities.Course), "CourseGrade", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CSLinqToEntities.CourseGrade))]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("SchoolModel", "FK_CourseGrade_Student", "Person", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CSLinqToEntities.Person), "CourseGrade", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CSLinqToEntities.CourseGrade))]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("SchoolModel", "CourseInstructor", "Course", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CSLinqToEntities.Course), "Person", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CSLinqToEntities.Person))]

// Original file name:
// Generation date: 09/04/08 1:53:01 PM
namespace CSLinqToEntities
{
    
    /// <summary>
    /// There are no comments for SchoolEntities in the schema.
    /// </summary>
    public partial class SchoolEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new SchoolEntities object using the connection string found in the 'SchoolEntities' section of the application configuration file.
        /// </summary>
        public SchoolEntities() : 
                base("name=SchoolEntities", "SchoolEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new SchoolEntities object.
        /// </summary>
        public SchoolEntities(string connectionString) : 
                base(connectionString, "SchoolEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new SchoolEntities object.
        /// </summary>
        public SchoolEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "SchoolEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Course in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Course> Course
        {
            get
            {
                if ((this._Course == null))
                {
                    this._Course = base.CreateQuery<Course>("[Course]");
                }
                return this._Course;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Course> _Course;
        /// <summary>
        /// There are no comments for CourseGrade in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<CourseGrade> CourseGrade
        {
            get
            {
                if ((this._CourseGrade == null))
                {
                    this._CourseGrade = base.CreateQuery<CourseGrade>("[CourseGrade]");
                }
                return this._CourseGrade;
            }
        }
        private global::System.Data.Objects.ObjectQuery<CourseGrade> _CourseGrade;
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Person> Person
        {
            get
            {
                if ((this._Person == null))
                {
                    this._Person = base.CreateQuery<Person>("[Person]");
                }
                return this._Person;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Person> _Person;
        /// <summary>
        /// There are no comments for Course in the schema.
        /// </summary>
        public void AddToCourse(Course course)
        {
            base.AddObject("Course", course);
        }
        /// <summary>
        /// There are no comments for CourseGrade in the schema.
        /// </summary>
        public void AddToCourseGrade(CourseGrade courseGrade)
        {
            base.AddObject("CourseGrade", courseGrade);
        }
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        public void AddToPerson(Person person)
        {
            base.AddObject("Person", person);
        }
    }
    /// <summary>
    /// There are no comments for SchoolModel.Course in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CourseID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SchoolModel", Name="Course")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Course : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Course object.
        /// </summary>
        /// <param name="courseID">Initial value of CourseID.</param>
        /// <param name="title">Initial value of Title.</param>
        /// <param name="credits">Initial value of Credits.</param>
        /// <param name="departmentID">Initial value of DepartmentID.</param>
        public static Course CreateCourse(int courseID, string title, int credits, int departmentID)
        {
            Course course = new Course();
            course.CourseID = courseID;
            course.Title = title;
            course.Credits = credits;
            course.DepartmentID = departmentID;
            return course;
        }
        /// <summary>
        /// There are no comments for Property CourseID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int CourseID
        {
            get
            {
                return this._CourseID;
            }
            set
            {
                this.OnCourseIDChanging(value);
                this.ReportPropertyChanging("CourseID");
                this._CourseID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("CourseID");
                this.OnCourseIDChanged();
            }
        }
        private int _CourseID;
        partial void OnCourseIDChanging(int value);
        partial void OnCourseIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this.ReportPropertyChanging("Title");
                this._Title = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Title");
                this.OnTitleChanged();
            }
        }
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Credits in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Credits
        {
            get
            {
                return this._Credits;
            }
            set
            {
                this.OnCreditsChanging(value);
                this.ReportPropertyChanging("Credits");
                this._Credits = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Credits");
                this.OnCreditsChanged();
            }
        }
        private int _Credits;
        partial void OnCreditsChanging(int value);
        partial void OnCreditsChanged();
        /// <summary>
        /// There are no comments for Property DepartmentID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int DepartmentID
        {
            get
            {
                return this._DepartmentID;
            }
            set
            {
                this.OnDepartmentIDChanging(value);
                this.ReportPropertyChanging("DepartmentID");
                this._DepartmentID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DepartmentID");
                this.OnDepartmentIDChanged();
            }
        }
        private int _DepartmentID;
        partial void OnDepartmentIDChanging(int value);
        partial void OnDepartmentIDChanged();
        /// <summary>
        /// There are no comments for CourseGrade in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SchoolModel", "FK_CourseGrade_Course", "CourseGrade")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<CourseGrade> CourseGrade
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<CourseGrade>("SchoolModel.FK_CourseGrade_Course", "CourseGrade");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<CourseGrade>("SchoolModel.FK_CourseGrade_Course", "CourseGrade", value);
                }
            }
        }
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SchoolModel", "CourseInstructor", "Person")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<Person> Person
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Person>("SchoolModel.CourseInstructor", "Person");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Person>("SchoolModel.CourseInstructor", "Person", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for SchoolModel.CourseGrade in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EnrollmentID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SchoolModel", Name="CourseGrade")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class CourseGrade : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new CourseGrade object.
        /// </summary>
        /// <param name="enrollmentID">Initial value of EnrollmentID.</param>
        public static CourseGrade CreateCourseGrade(int enrollmentID)
        {
            CourseGrade courseGrade = new CourseGrade();
            courseGrade.EnrollmentID = enrollmentID;
            return courseGrade;
        }
        /// <summary>
        /// There are no comments for Property EnrollmentID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int EnrollmentID
        {
            get
            {
                return this._EnrollmentID;
            }
            set
            {
                this.OnEnrollmentIDChanging(value);
                this.ReportPropertyChanging("EnrollmentID");
                this._EnrollmentID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("EnrollmentID");
                this.OnEnrollmentIDChanged();
            }
        }
        private int _EnrollmentID;
        partial void OnEnrollmentIDChanging(int value);
        partial void OnEnrollmentIDChanged();
        /// <summary>
        /// There are no comments for Property Grade in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<decimal> Grade
        {
            get
            {
                return this._Grade;
            }
            set
            {
                this.OnGradeChanging(value);
                this.ReportPropertyChanging("Grade");
                this._Grade = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Grade");
                this.OnGradeChanged();
            }
        }
        private global::System.Nullable<decimal> _Grade;
        partial void OnGradeChanging(global::System.Nullable<decimal> value);
        partial void OnGradeChanged();
        /// <summary>
        /// There are no comments for Course in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SchoolModel", "FK_CourseGrade_Course", "Course")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Course Course
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Course>("SchoolModel.FK_CourseGrade_Course", "Course").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Course>("SchoolModel.FK_CourseGrade_Course", "Course").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for Course in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Course> CourseReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Course>("SchoolModel.FK_CourseGrade_Course", "Course");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Course>("SchoolModel.FK_CourseGrade_Course", "Course", value);
                }
            }
        }
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SchoolModel", "FK_CourseGrade_Student", "Person")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Person Person
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Person>("SchoolModel.FK_CourseGrade_Student", "Person").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Person>("SchoolModel.FK_CourseGrade_Student", "Person").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Person> PersonReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Person>("SchoolModel.FK_CourseGrade_Student", "Person");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Person>("SchoolModel.FK_CourseGrade_Student", "Person", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for SchoolModel.Person in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SchoolModel", Name="Person")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    [global::System.Runtime.Serialization.KnownTypeAttribute(typeof(global::CSLinqToEntities.Student))]
    [global::System.Runtime.Serialization.KnownTypeAttribute(typeof(global::CSLinqToEntities.Instructor))]
    public partial class Person : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="personID">Initial value of PersonID.</param>
        /// <param name="lastName">Initial value of LastName.</param>
        /// <param name="firstName">Initial value of FirstName.</param>
        public static Person CreatePerson(int personID, string lastName, string firstName)
        {
            Person person = new Person();
            person.PersonID = personID;
            person.LastName = lastName;
            person.FirstName = firstName;
            return person;
        }
        /// <summary>
        /// There are no comments for Property PersonID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonID
        {
            get
            {
                return this._PersonID;
            }
            set
            {
                this.OnPersonIDChanging(value);
                this.ReportPropertyChanging("PersonID");
                this._PersonID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("PersonID");
                this.OnPersonIDChanged();
            }
        }
        private int _PersonID;
        partial void OnPersonIDChanging(int value);
        partial void OnPersonIDChanged();
        /// <summary>
        /// There are no comments for Property LastName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this.OnLastNameChanging(value);
                this.ReportPropertyChanging("LastName");
                this._LastName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("LastName");
                this.OnLastNameChanged();
            }
        }
        private string _LastName;
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        /// <summary>
        /// There are no comments for Property FirstName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this.OnFirstNameChanging(value);
                this.ReportPropertyChanging("FirstName");
                this._FirstName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("FirstName");
                this.OnFirstNameChanged();
            }
        }
        private string _FirstName;
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        /// <summary>
        /// There are no comments for Property Picture in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Picture
        {
            get
            {
                return global::System.Data.Objects.DataClasses.StructuralObject.GetValidValue(this._Picture);
            }
            set
            {
                this.OnPictureChanging(value);
                this.ReportPropertyChanging("Picture");
                this._Picture = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Picture");
                this.OnPictureChanged();
            }
        }
        private byte[] _Picture;
        partial void OnPictureChanging(byte[] value);
        partial void OnPictureChanged();
        /// <summary>
        /// There are no comments for CourseGrade in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SchoolModel", "FK_CourseGrade_Student", "CourseGrade")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<CourseGrade> CourseGrade
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<CourseGrade>("SchoolModel.FK_CourseGrade_Student", "CourseGrade");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<CourseGrade>("SchoolModel.FK_CourseGrade_Student", "CourseGrade", value);
                }
            }
        }
        /// <summary>
        /// There are no comments for Course in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("SchoolModel", "CourseInstructor", "Course")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<Course> Course
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Course>("SchoolModel.CourseInstructor", "Course");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Course>("SchoolModel.CourseInstructor", "Course", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for SchoolModel.Student in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SchoolModel", Name="Student")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Student : Person
    {
        /// <summary>
        /// Create a new Student object.
        /// </summary>
        /// <param name="personID">Initial value of PersonID.</param>
        /// <param name="lastName">Initial value of LastName.</param>
        /// <param name="firstName">Initial value of FirstName.</param>
        public static Student CreateStudent(int personID, string lastName, string firstName)
        {
            Student student = new Student();
            student.PersonID = personID;
            student.LastName = lastName;
            student.FirstName = firstName;
            return student;
        }
        /// <summary>
        /// There are no comments for Property EnrollmentDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> EnrollmentDate
        {
            get
            {
                return this._EnrollmentDate;
            }
            set
            {
                this.OnEnrollmentDateChanging(value);
                this.ReportPropertyChanging("EnrollmentDate");
                this._EnrollmentDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("EnrollmentDate");
                this.OnEnrollmentDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _EnrollmentDate;
        partial void OnEnrollmentDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnEnrollmentDateChanged();
    }
    /// <summary>
    /// There are no comments for SchoolModel.Instructor in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SchoolModel", Name="Instructor")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Instructor : Person
    {
        /// <summary>
        /// Create a new Instructor object.
        /// </summary>
        /// <param name="personID">Initial value of PersonID.</param>
        /// <param name="lastName">Initial value of LastName.</param>
        /// <param name="firstName">Initial value of FirstName.</param>
        public static Instructor CreateInstructor(int personID, string lastName, string firstName)
        {
            Instructor instructor = new Instructor();
            instructor.PersonID = personID;
            instructor.LastName = lastName;
            instructor.FirstName = firstName;
            return instructor;
        }
        /// <summary>
        /// There are no comments for Property HireDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> HireDate
        {
            get
            {
                return this._HireDate;
            }
            set
            {
                this.OnHireDateChanging(value);
                this.ReportPropertyChanging("HireDate");
                this._HireDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("HireDate");
                this.OnHireDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _HireDate;
        partial void OnHireDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnHireDateChanged();
    }
}
