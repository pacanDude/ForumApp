﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ForumApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OneUserX", Namespace="http://schemas.datacontract.org/2004/07/ForumService")]
    [System.SerializableAttribute()]
    public partial class OneUserX : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string aboutField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] fotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ratingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ratingAnswersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ratingQweryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string about {
            get {
                return this.aboutField;
            }
            set {
                if ((object.ReferenceEquals(this.aboutField, value) != true)) {
                    this.aboutField = value;
                    this.RaisePropertyChanged("about");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int age {
            get {
                return this.ageField;
            }
            set {
                if ((this.ageField.Equals(value) != true)) {
                    this.ageField = value;
                    this.RaisePropertyChanged("age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] foto {
            get {
                return this.fotoField;
            }
            set {
                if ((object.ReferenceEquals(this.fotoField, value) != true)) {
                    this.fotoField = value;
                    this.RaisePropertyChanged("foto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int rating {
            get {
                return this.ratingField;
            }
            set {
                if ((this.ratingField.Equals(value) != true)) {
                    this.ratingField = value;
                    this.RaisePropertyChanged("rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ratingAnswers {
            get {
                return this.ratingAnswersField;
            }
            set {
                if ((this.ratingAnswersField.Equals(value) != true)) {
                    this.ratingAnswersField = value;
                    this.RaisePropertyChanged("ratingAnswers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ratingQwery {
            get {
                return this.ratingQweryField;
            }
            set {
                if ((this.ratingQweryField.Equals(value) != true)) {
                    this.ratingQweryField = value;
                    this.RaisePropertyChanged("ratingQwery");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QweryX", Namespace="http://schemas.datacontract.org/2004/07/ForumService")]
    [System.SerializableAttribute()]
    public partial class QweryX : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string categoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string headerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ratingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string textField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string category {
            get {
                return this.categoryField;
            }
            set {
                if ((object.ReferenceEquals(this.categoryField, value) != true)) {
                    this.categoryField = value;
                    this.RaisePropertyChanged("category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                if ((object.ReferenceEquals(this.codeField, value) != true)) {
                    this.codeField = value;
                    this.RaisePropertyChanged("code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string header {
            get {
                return this.headerField;
            }
            set {
                if ((object.ReferenceEquals(this.headerField, value) != true)) {
                    this.headerField = value;
                    this.RaisePropertyChanged("header");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int rating {
            get {
                return this.ratingField;
            }
            set {
                if ((this.ratingField.Equals(value) != true)) {
                    this.ratingField = value;
                    this.RaisePropertyChanged("rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string text {
            get {
                return this.textField;
            }
            set {
                if ((object.ReferenceEquals(this.textField, value) != true)) {
                    this.textField = value;
                    this.RaisePropertyChanged("text");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AllMessageAndQwery", Namespace="http://schemas.datacontract.org/2004/07/ForumService")]
    [System.SerializableAttribute()]
    public partial class AllMessageAndQwery : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ForumApp.ServiceReference1.AnsverX[] answersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ForumApp.ServiceReference1.QweryX qweryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ForumApp.ServiceReference1.AnsverX[] answers {
            get {
                return this.answersField;
            }
            set {
                if ((object.ReferenceEquals(this.answersField, value) != true)) {
                    this.answersField = value;
                    this.RaisePropertyChanged("answers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ForumApp.ServiceReference1.QweryX qwery {
            get {
                return this.qweryField;
            }
            set {
                if ((object.ReferenceEquals(this.qweryField, value) != true)) {
                    this.qweryField = value;
                    this.RaisePropertyChanged("qwery");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AnsverX", Namespace="http://schemas.datacontract.org/2004/07/ForumService")]
    [System.SerializableAttribute()]
    public partial class AnsverX : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QweryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ratingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string textField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QweryId {
            get {
                return this.QweryIdField;
            }
            set {
                if ((this.QweryIdField.Equals(value) != true)) {
                    this.QweryIdField = value;
                    this.RaisePropertyChanged("QweryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                if ((object.ReferenceEquals(this.codeField, value) != true)) {
                    this.codeField = value;
                    this.RaisePropertyChanged("code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int rating {
            get {
                return this.ratingField;
            }
            set {
                if ((this.ratingField.Equals(value) != true)) {
                    this.ratingField = value;
                    this.RaisePropertyChanged("rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string text {
            get {
                return this.textField;
            }
            set {
                if ((object.ReferenceEquals(this.textField, value) != true)) {
                    this.textField = value;
                    this.RaisePropertyChanged("text");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IForumService")]
    public interface IForumService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/RegisterUser", ReplyAction="http://tempuri.org/IForumService/RegisterUserResponse")]
        bool RegisterUser(ForumApp.ServiceReference1.OneUserX user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/RegisterUser", ReplyAction="http://tempuri.org/IForumService/RegisterUserResponse")]
        System.Threading.Tasks.Task<bool> RegisterUserAsync(ForumApp.ServiceReference1.OneUserX user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/LogIn", ReplyAction="http://tempuri.org/IForumService/LogInResponse")]
        bool LogIn([System.ServiceModel.MessageParameterAttribute(Name="login")] string login1, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/LogIn", ReplyAction="http://tempuri.org/IForumService/LogInResponse")]
        System.Threading.Tasks.Task<bool> LogInAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/GetOneUser", ReplyAction="http://tempuri.org/IForumService/GetOneUserResponse")]
        ForumApp.ServiceReference1.OneUserX GetOneUser(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/GetOneUser", ReplyAction="http://tempuri.org/IForumService/GetOneUserResponse")]
        System.Threading.Tasks.Task<ForumApp.ServiceReference1.OneUserX> GetOneUserAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/EditOneUser", ReplyAction="http://tempuri.org/IForumService/EditOneUserResponse")]
        bool EditOneUser(ForumApp.ServiceReference1.OneUserX user, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/EditOneUser", ReplyAction="http://tempuri.org/IForumService/EditOneUserResponse")]
        System.Threading.Tasks.Task<bool> EditOneUserAsync(ForumApp.ServiceReference1.OneUserX user, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/GetQweryList", ReplyAction="http://tempuri.org/IForumService/GetQweryListResponse")]
        ForumApp.ServiceReference1.QweryX[] GetQweryList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/GetQweryList", ReplyAction="http://tempuri.org/IForumService/GetQweryListResponse")]
        System.Threading.Tasks.Task<ForumApp.ServiceReference1.QweryX[]> GetQweryListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/GetQweryWithAnsvers", ReplyAction="http://tempuri.org/IForumService/GetQweryWithAnsversResponse")]
        ForumApp.ServiceReference1.AllMessageAndQwery GetQweryWithAnsvers(int QweryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/GetQweryWithAnsvers", ReplyAction="http://tempuri.org/IForumService/GetQweryWithAnsversResponse")]
        System.Threading.Tasks.Task<ForumApp.ServiceReference1.AllMessageAndQwery> GetQweryWithAnsversAsync(int QweryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/SendMessage", ReplyAction="http://tempuri.org/IForumService/SendMessageResponse")]
        bool SendMessage(string login, int QweryId, string message, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/SendMessage", ReplyAction="http://tempuri.org/IForumService/SendMessageResponse")]
        System.Threading.Tasks.Task<bool> SendMessageAsync(string login, int QweryId, string message, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/GetCategoryList", ReplyAction="http://tempuri.org/IForumService/GetCategoryListResponse")]
        string[] GetCategoryList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForumService/GetCategoryList", ReplyAction="http://tempuri.org/IForumService/GetCategoryListResponse")]
        System.Threading.Tasks.Task<string[]> GetCategoryListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IForumServiceChannel : ForumApp.ServiceReference1.IForumService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ForumServiceClient : System.ServiceModel.ClientBase<ForumApp.ServiceReference1.IForumService>, ForumApp.ServiceReference1.IForumService {
        
        public ForumServiceClient() {
        }
        
        public ForumServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ForumServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ForumServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ForumServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool RegisterUser(ForumApp.ServiceReference1.OneUserX user) {
            return base.Channel.RegisterUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterUserAsync(ForumApp.ServiceReference1.OneUserX user) {
            return base.Channel.RegisterUserAsync(user);
        }
        
        public bool LogIn(string login1, string password) {
            return base.Channel.LogIn(login1, password);
        }
        
        public System.Threading.Tasks.Task<bool> LogInAsync(string login, string password) {
            return base.Channel.LogInAsync(login, password);
        }
        
        public ForumApp.ServiceReference1.OneUserX GetOneUser(string name) {
            return base.Channel.GetOneUser(name);
        }
        
        public System.Threading.Tasks.Task<ForumApp.ServiceReference1.OneUserX> GetOneUserAsync(string name) {
            return base.Channel.GetOneUserAsync(name);
        }
        
        public bool EditOneUser(ForumApp.ServiceReference1.OneUserX user, string name) {
            return base.Channel.EditOneUser(user, name);
        }
        
        public System.Threading.Tasks.Task<bool> EditOneUserAsync(ForumApp.ServiceReference1.OneUserX user, string name) {
            return base.Channel.EditOneUserAsync(user, name);
        }
        
        public ForumApp.ServiceReference1.QweryX[] GetQweryList() {
            return base.Channel.GetQweryList();
        }
        
        public System.Threading.Tasks.Task<ForumApp.ServiceReference1.QweryX[]> GetQweryListAsync() {
            return base.Channel.GetQweryListAsync();
        }
        
        public ForumApp.ServiceReference1.AllMessageAndQwery GetQweryWithAnsvers(int QweryId) {
            return base.Channel.GetQweryWithAnsvers(QweryId);
        }
        
        public System.Threading.Tasks.Task<ForumApp.ServiceReference1.AllMessageAndQwery> GetQweryWithAnsversAsync(int QweryId) {
            return base.Channel.GetQweryWithAnsversAsync(QweryId);
        }
        
        public bool SendMessage(string login, int QweryId, string message, string code) {
            return base.Channel.SendMessage(login, QweryId, message, code);
        }
        
        public System.Threading.Tasks.Task<bool> SendMessageAsync(string login, int QweryId, string message, string code) {
            return base.Channel.SendMessageAsync(login, QweryId, message, code);
        }
        
        public string[] GetCategoryList() {
            return base.Channel.GetCategoryList();
        }
        
        public System.Threading.Tasks.Task<string[]> GetCategoryListAsync() {
            return base.Channel.GetCategoryListAsync();
        }
    }
}
