﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceMyPhotos
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ModelProiect2020", IsReference=true)]
    public partial class User : object
    {
        
        private string EmailField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private string PasswordField;
        
        private string PhoneField;
        
        private int UserIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID
        {
            get
            {
                return this.UserIDField;
            }
            set
            {
                this.UserIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Data", Namespace="http://schemas.datacontract.org/2004/07/ModelProiect2020", IsReference=true)]
    public partial class Data : object
    {
        
        private System.DateTime CreationDateField;
        
        private int DataIDField;
        
        private string DateTypeField;
        
        private string EventNameField;
        
        private bool FavoriteDataField;
        
        private string LocationField;
        
        private bool MovedDataField;
        
        private string PathField;
        
        private string PeopleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationDate
        {
            get
            {
                return this.CreationDateField;
            }
            set
            {
                this.CreationDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DataID
        {
            get
            {
                return this.DataIDField;
            }
            set
            {
                this.DataIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DateType
        {
            get
            {
                return this.DateTypeField;
            }
            set
            {
                this.DateTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EventName
        {
            get
            {
                return this.EventNameField;
            }
            set
            {
                this.EventNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool FavoriteData
        {
            get
            {
                return this.FavoriteDataField;
            }
            set
            {
                this.FavoriteDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool MovedData
        {
            get
            {
                return this.MovedDataField;
            }
            set
            {
                this.MovedDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string People
        {
            get
            {
                return this.PeopleField;
            }
            set
            {
                this.PeopleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SpecialProperty", Namespace="http://schemas.datacontract.org/2004/07/ModelProiect2020", IsReference=true)]
    public partial class SpecialProperty : object
    {
        
        private int DataIDField;
        
        private string PropertyDescriptionField;
        
        private int PropertyIDField;
        
        private string PropertyNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DataID
        {
            get
            {
                return this.DataIDField;
            }
            set
            {
                this.DataIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyDescription
        {
            get
            {
                return this.PropertyDescriptionField;
            }
            set
            {
                this.PropertyDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PropertyID
        {
            get
            {
                return this.PropertyIDField;
            }
            set
            {
                this.PropertyIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyName
        {
            get
            {
                return this.PropertyNameField;
            }
            set
            {
                this.PropertyNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceMyPhotos.IProject")]
    public interface IProject
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceUser/CreateUser", ReplyAction="http://tempuri.org/InterfaceUser/CreateUserResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.User> CreateUserAsync(string firstName, string lastName, string password, string email, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceUser/UpdateUser", ReplyAction="http://tempuri.org/InterfaceUser/UpdateUserResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.User> UpdateUserAsync(int userId, string firstName, string lastName, string password, string email, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceUser/DeleteUser", ReplyAction="http://tempuri.org/InterfaceUser/DeleteUserResponse")]
        System.Threading.Tasks.Task<bool> DeleteUserAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceUser/GetUserById", ReplyAction="http://tempuri.org/InterfaceUser/GetUserByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.User> GetUserByIdAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceUser/GetAllUsers", ReplyAction="http://tempuri.org/InterfaceUser/GetAllUsersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.User>> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceUser/Login", ReplyAction="http://tempuri.org/InterfaceUser/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceData/CreateData", ReplyAction="http://tempuri.org/InterfaceData/CreateDataResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Data> CreateDataAsync(string dateType, System.DateTime creationDate, string eventName, string people, string location, string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceData/UpdateData", ReplyAction="http://tempuri.org/InterfaceData/UpdateDataResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Data> UpdateDataAsync(int dataID, string dateType, System.DateTime creationDate, string eventName, string people, string location, string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceData/GetDataById", ReplyAction="http://tempuri.org/InterfaceData/GetDataByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Data> GetDataByIdAsync(int dataID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceData/GetAllData", ReplyAction="http://tempuri.org/InterfaceData/GetAllDataResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Data>> GetAllDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceData/MoveData", ReplyAction="http://tempuri.org/InterfaceData/MoveDataResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Data> MoveDataAsync(int dataID, string path, bool movedData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceData/FavoritesData", ReplyAction="http://tempuri.org/InterfaceData/FavoritesDataResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Data> FavoritesDataAsync(int dataID, bool favoriteData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSpecialProperties/CreateSpecialProperty", ReplyAction="http://tempuri.org/InterfaceSpecialProperties/CreateSpecialPropertyResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.SpecialProperty> CreateSpecialPropertyAsync(string propertyName, string propertyDescription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSpecialProperties/DeleteSpecialProperty", ReplyAction="http://tempuri.org/InterfaceSpecialProperties/DeleteSpecialPropertyResponse")]
        System.Threading.Tasks.Task<bool> DeleteSpecialPropertyAsync(int propertyID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceSpecialProperties/UpdateSpecialProperty", ReplyAction="http://tempuri.org/InterfaceSpecialProperties/UpdateSpecialPropertyResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.SpecialProperty> UpdateSpecialPropertyAsync(int propertyID, string propertyName, string propertyDescription);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IProjectChannel : ServiceReferenceMyPhotos.IProject, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ProjectClient : System.ServiceModel.ClientBase<ServiceReferenceMyPhotos.IProject>, ServiceReferenceMyPhotos.IProject
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ProjectClient() : 
                base(ProjectClient.GetDefaultBinding(), ProjectClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IProject.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProjectClient(EndpointConfiguration endpointConfiguration) : 
                base(ProjectClient.GetBindingForEndpoint(endpointConfiguration), ProjectClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProjectClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ProjectClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProjectClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ProjectClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProjectClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.User> CreateUserAsync(string firstName, string lastName, string password, string email, string phone)
        {
            return base.Channel.CreateUserAsync(firstName, lastName, password, email, phone);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.User> UpdateUserAsync(int userId, string firstName, string lastName, string password, string email, string phone)
        {
            return base.Channel.UpdateUserAsync(userId, firstName, lastName, password, email, phone);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteUserAsync(int userId)
        {
            return base.Channel.DeleteUserAsync(userId);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.User> GetUserByIdAsync(int userId)
        {
            return base.Channel.GetUserByIdAsync(userId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.User>> GetAllUsersAsync()
        {
            return base.Channel.GetAllUsersAsync();
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string email, string password)
        {
            return base.Channel.LoginAsync(email, password);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Data> CreateDataAsync(string dateType, System.DateTime creationDate, string eventName, string people, string location, string path)
        {
            return base.Channel.CreateDataAsync(dateType, creationDate, eventName, people, location, path);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Data> UpdateDataAsync(int dataID, string dateType, System.DateTime creationDate, string eventName, string people, string location, string path)
        {
            return base.Channel.UpdateDataAsync(dataID, dateType, creationDate, eventName, people, location, path);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Data> GetDataByIdAsync(int dataID)
        {
            return base.Channel.GetDataByIdAsync(dataID);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Data>> GetAllDataAsync()
        {
            return base.Channel.GetAllDataAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Data> MoveDataAsync(int dataID, string path, bool movedData)
        {
            return base.Channel.MoveDataAsync(dataID, path, movedData);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Data> FavoritesDataAsync(int dataID, bool favoriteData)
        {
            return base.Channel.FavoritesDataAsync(dataID, favoriteData);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.SpecialProperty> CreateSpecialPropertyAsync(string propertyName, string propertyDescription)
        {
            return base.Channel.CreateSpecialPropertyAsync(propertyName, propertyDescription);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteSpecialPropertyAsync(int propertyID)
        {
            return base.Channel.DeleteSpecialPropertyAsync(propertyID);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.SpecialProperty> UpdateSpecialPropertyAsync(int propertyID, string propertyName, string propertyDescription)
        {
            return base.Channel.UpdateSpecialPropertyAsync(propertyID, propertyName, propertyDescription);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IProject))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IProject))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ProjectClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IProject);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ProjectClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IProject);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IProject,
        }
    }
}
