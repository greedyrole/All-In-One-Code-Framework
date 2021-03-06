//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("LazyLoadingModel", "FK_Course_Department", "Department", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(CSEFLazyLoading.Department), "Course", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CSEFLazyLoading.Course), true)]

#endregion

namespace CSEFLazyLoading
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LazyLoadingEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LazyLoadingEntities object using the connection string found in the 'LazyLoadingEntities' section of the application configuration file.
        /// </summary>
        public LazyLoadingEntities() : base("name=LazyLoadingEntities", "LazyLoadingEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LazyLoadingEntities object.
        /// </summary>
        public LazyLoadingEntities(string connectionString) : base(connectionString, "LazyLoadingEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LazyLoadingEntities object.
        /// </summary>
        public LazyLoadingEntities(EntityConnection connection) : base(connection, "LazyLoadingEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Course> Courses
        {
            get
            {
                if ((_Courses == null))
                {
                    _Courses = base.CreateObjectSet<Course>("Courses");
                }
                return _Courses;
            }
        }
        private ObjectSet<Course> _Courses;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Department> Departments
        {
            get
            {
                if ((_Departments == null))
                {
                    _Departments = base.CreateObjectSet<Department>("Departments");
                }
                return _Departments;
            }
        }
        private ObjectSet<Department> _Departments;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Courses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCourses(Course course)
        {
            base.AddObject("Courses", course);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Departments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDepartments(Department department)
        {
            base.AddObject("Departments", department);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LazyLoadingModel", Name="Course")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Course : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Course object.
        /// </summary>
        /// <param name="courseID">Initial value of the CourseID property.</param>
        public static Course CreateCourse(global::System.Int32 courseID)
        {
            Course course = new Course();
            course.CourseID = courseID;
            return course;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CourseID
        {
            get
            {
                return _CourseID;
            }
            set
            {
                if (_CourseID != value)
                {
                    OnCourseIDChanging(value);
                    ReportPropertyChanging("CourseID");
                    _CourseID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CourseID");
                    OnCourseIDChanged();
                }
            }
        }
        private global::System.Int32 _CourseID;
        partial void OnCourseIDChanging(global::System.Int32 value);
        partial void OnCourseIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Credits
        {
            get
            {
                return _Credits;
            }
            set
            {
                OnCreditsChanging(value);
                ReportPropertyChanging("Credits");
                _Credits = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Credits");
                OnCreditsChanged();
            }
        }
        private Nullable<global::System.Int32> _Credits;
        partial void OnCreditsChanging(Nullable<global::System.Int32> value);
        partial void OnCreditsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> DepartmentID
        {
            get
            {
                return _DepartmentID;
            }
            set
            {
                OnDepartmentIDChanging(value);
                ReportPropertyChanging("DepartmentID");
                _DepartmentID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DepartmentID");
                OnDepartmentIDChanged();
            }
        }
        private Nullable<global::System.Int32> _DepartmentID;
        partial void OnDepartmentIDChanging(Nullable<global::System.Int32> value);
        partial void OnDepartmentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> StatusID
        {
            get
            {
                return _StatusID;
            }
            set
            {
                OnStatusIDChanging(value);
                ReportPropertyChanging("StatusID");
                _StatusID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StatusID");
                OnStatusIDChanged();
            }
        }
        private Nullable<global::System.Boolean> _StatusID;
        partial void OnStatusIDChanging(Nullable<global::System.Boolean> value);
        partial void OnStatusIDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LazyLoadingModel", "FK_Course_Department", "Department")]
        public Department Department
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("LazyLoadingModel.FK_Course_Department", "Department").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("LazyLoadingModel.FK_Course_Department", "Department").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Department> DepartmentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("LazyLoadingModel.FK_Course_Department", "Department");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Department>("LazyLoadingModel.FK_Course_Department", "Department", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LazyLoadingModel", Name="Department")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Department : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Department object.
        /// </summary>
        /// <param name="departmentID">Initial value of the DepartmentID property.</param>
        public static Department CreateDepartment(global::System.Int32 departmentID)
        {
            Department department = new Department();
            department.DepartmentID = departmentID;
            return department;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DepartmentID
        {
            get
            {
                return _DepartmentID;
            }
            set
            {
                if (_DepartmentID != value)
                {
                    OnDepartmentIDChanging(value);
                    ReportPropertyChanging("DepartmentID");
                    _DepartmentID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DepartmentID");
                    OnDepartmentIDChanged();
                }
            }
        }
        private global::System.Int32 _DepartmentID;
        partial void OnDepartmentIDChanging(global::System.Int32 value);
        partial void OnDepartmentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Budget
        {
            get
            {
                return _Budget;
            }
            set
            {
                OnBudgetChanging(value);
                ReportPropertyChanging("Budget");
                _Budget = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Budget");
                OnBudgetChanged();
            }
        }
        private Nullable<global::System.Decimal> _Budget;
        partial void OnBudgetChanging(Nullable<global::System.Decimal> value);
        partial void OnBudgetChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> StartDate
        {
            get
            {
                return _StartDate;
            }
            set
            {
                OnStartDateChanging(value);
                ReportPropertyChanging("StartDate");
                _StartDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StartDate");
                OnStartDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _StartDate;
        partial void OnStartDateChanging(Nullable<global::System.DateTime> value);
        partial void OnStartDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Administrator
        {
            get
            {
                return _Administrator;
            }
            set
            {
                OnAdministratorChanging(value);
                ReportPropertyChanging("Administrator");
                _Administrator = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Administrator");
                OnAdministratorChanged();
            }
        }
        private Nullable<global::System.Int32> _Administrator;
        partial void OnAdministratorChanging(Nullable<global::System.Int32> value);
        partial void OnAdministratorChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LazyLoadingModel", "FK_Course_Department", "Course")]
        public EntityCollection<Course> Courses
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Course>("LazyLoadingModel.FK_Course_Department", "Course");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Course>("LazyLoadingModel.FK_Course_Department", "Course", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
