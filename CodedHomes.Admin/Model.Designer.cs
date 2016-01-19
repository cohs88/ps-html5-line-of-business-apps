﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("CodedHomesDEVModel", "webpages_UsersInRoles", "Users", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CodedHomes.Admin.User), "webpages_Roles", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CodedHomes.Admin.webpages_Roles))]

#endregion

namespace CodedHomes.Admin
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CodedHomesDEVEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CodedHomesDEVEntities object using the connection string found in the 'CodedHomesDEVEntities' section of the application configuration file.
        /// </summary>
        public CodedHomesDEVEntities() : base("name=CodedHomesDEVEntities", "CodedHomesDEVEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CodedHomesDEVEntities object.
        /// </summary>
        public CodedHomesDEVEntities(string connectionString) : base(connectionString, "CodedHomesDEVEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CodedHomesDEVEntities object.
        /// </summary>
        public CodedHomesDEVEntities(EntityConnection connection) : base(connection, "CodedHomesDEVEntities")
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
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<webpages_Roles> webpages_Roles
        {
            get
            {
                if ((_webpages_Roles == null))
                {
                    _webpages_Roles = base.CreateObjectSet<webpages_Roles>("webpages_Roles");
                }
                return _webpages_Roles;
            }
        }
        private ObjectSet<webpages_Roles> _webpages_Roles;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the webpages_Roles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTowebpages_Roles(webpages_Roles webpages_Roles)
        {
            base.AddObject("webpages_Roles", webpages_Roles);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CodedHomesDEVModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="username">Initial value of the Username property.</param>
        public static User CreateUser(global::System.Int32 id, global::System.String username)
        {
            User user = new User();
            user.Id = id;
            user.Username = username;
            return user;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Username
        {
            get
            {
                return _Username;
            }
            set
            {
                OnUsernameChanging(value);
                ReportPropertyChanging("Username");
                _Username = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Username");
                OnUsernameChanged();
            }
        }
        private global::System.String _Username;
        partial void OnUsernameChanging(global::System.String value);
        partial void OnUsernameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CodedHomesDEVModel", "webpages_UsersInRoles", "webpages_Roles")]
        public EntityCollection<webpages_Roles> webpages_Roles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<webpages_Roles>("CodedHomesDEVModel.webpages_UsersInRoles", "webpages_Roles");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<webpages_Roles>("CodedHomesDEVModel.webpages_UsersInRoles", "webpages_Roles", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CodedHomesDEVModel", Name="webpages_Roles")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class webpages_Roles : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new webpages_Roles object.
        /// </summary>
        /// <param name="roleId">Initial value of the RoleId property.</param>
        /// <param name="roleName">Initial value of the RoleName property.</param>
        public static webpages_Roles Createwebpages_Roles(global::System.Int32 roleId, global::System.String roleName)
        {
            webpages_Roles webpages_Roles = new webpages_Roles();
            webpages_Roles.RoleId = roleId;
            webpages_Roles.RoleName = roleName;
            return webpages_Roles;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 RoleId
        {
            get
            {
                return _RoleId;
            }
            set
            {
                if (_RoleId != value)
                {
                    OnRoleIdChanging(value);
                    ReportPropertyChanging("RoleId");
                    _RoleId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("RoleId");
                    OnRoleIdChanged();
                }
            }
        }
        private global::System.Int32 _RoleId;
        partial void OnRoleIdChanging(global::System.Int32 value);
        partial void OnRoleIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RoleName
        {
            get
            {
                return _RoleName;
            }
            set
            {
                OnRoleNameChanging(value);
                ReportPropertyChanging("RoleName");
                _RoleName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("RoleName");
                OnRoleNameChanged();
            }
        }
        private global::System.String _RoleName;
        partial void OnRoleNameChanging(global::System.String value);
        partial void OnRoleNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CodedHomesDEVModel", "webpages_UsersInRoles", "Users")]
        public EntityCollection<User> Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<User>("CodedHomesDEVModel.webpages_UsersInRoles", "Users");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<User>("CodedHomesDEVModel.webpages_UsersInRoles", "Users", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}