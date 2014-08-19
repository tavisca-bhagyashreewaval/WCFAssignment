﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWCFService.EmployeeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementUsingWCF")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] RemarksField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Remarks {
            get {
                return this.RemarksField;
            }
            set {
                if ((object.ReferenceEquals(this.RemarksField, value) != true)) {
                    this.RemarksField = value;
                    this.RaisePropertyChanged("Remarks");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomeException", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementUsingWCF")]
    [System.SerializableAttribute()]
    public partial class CustomeException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IAddEmployeeData")]
    public interface IAddEmployeeData {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmployeeData/ClearpreviousRecords", ReplyAction="http://tempuri.org/IAddEmployeeData/ClearpreviousRecordsResponse")]
        void ClearpreviousRecords();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmployeeData/ClearpreviousRecords", ReplyAction="http://tempuri.org/IAddEmployeeData/ClearpreviousRecordsResponse")]
        System.Threading.Tasks.Task ClearpreviousRecordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmployeeData/CreateEmployee", ReplyAction="http://tempuri.org/IAddEmployeeData/CreateEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TestWCFService.EmployeeService.CustomeException), Action="http://tempuri.org/IAddEmployeeData/CreateEmployeeCustomeExceptionFault", Name="CustomeException", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementUsingWCF")]
        string CreateEmployee(TestWCFService.EmployeeService.Employee e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmployeeData/CreateEmployee", ReplyAction="http://tempuri.org/IAddEmployeeData/CreateEmployeeResponse")]
        System.Threading.Tasks.Task<string> CreateEmployeeAsync(TestWCFService.EmployeeService.Employee e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmployeeData/AddRemarkOnId", ReplyAction="http://tempuri.org/IAddEmployeeData/AddRemarkOnIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TestWCFService.EmployeeService.CustomeException), Action="http://tempuri.org/IAddEmployeeData/AddRemarkOnIdCustomeExceptionFault", Name="CustomeException", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementUsingWCF")]
        string AddRemarkOnId(int id, string remarkText, string remarkGrade, string remarkAuthor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmployeeData/AddRemarkOnId", ReplyAction="http://tempuri.org/IAddEmployeeData/AddRemarkOnIdResponse")]
        System.Threading.Tasks.Task<string> AddRemarkOnIdAsync(int id, string remarkText, string remarkGrade, string remarkAuthor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmployeeData/AddRemarkOnName", ReplyAction="http://tempuri.org/IAddEmployeeData/AddRemarkOnNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TestWCFService.EmployeeService.CustomeException), Action="http://tempuri.org/IAddEmployeeData/AddRemarkOnNameCustomeExceptionFault", Name="CustomeException", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementUsingWCF")]
        string AddRemarkOnName(string name, string remarkText, string remarkGrade, string remarkAuthor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmployeeData/AddRemarkOnName", ReplyAction="http://tempuri.org/IAddEmployeeData/AddRemarkOnNameResponse")]
        System.Threading.Tasks.Task<string> AddRemarkOnNameAsync(string name, string remarkText, string remarkGrade, string remarkAuthor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAddEmployeeDataChannel : TestWCFService.EmployeeService.IAddEmployeeData, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddEmployeeDataClient : System.ServiceModel.ClientBase<TestWCFService.EmployeeService.IAddEmployeeData>, TestWCFService.EmployeeService.IAddEmployeeData {
        
        public AddEmployeeDataClient() {
        }
        
        public AddEmployeeDataClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AddEmployeeDataClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddEmployeeDataClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddEmployeeDataClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void ClearpreviousRecords() {
            base.Channel.ClearpreviousRecords();
        }
        
        public System.Threading.Tasks.Task ClearpreviousRecordsAsync() {
            return base.Channel.ClearpreviousRecordsAsync();
        }
        
        public string CreateEmployee(TestWCFService.EmployeeService.Employee e) {
            return base.Channel.CreateEmployee(e);
        }
        
        public System.Threading.Tasks.Task<string> CreateEmployeeAsync(TestWCFService.EmployeeService.Employee e) {
            return base.Channel.CreateEmployeeAsync(e);
        }
        
        public string AddRemarkOnId(int id, string remarkText, string remarkGrade, string remarkAuthor) {
            return base.Channel.AddRemarkOnId(id, remarkText, remarkGrade, remarkAuthor);
        }
        
        public System.Threading.Tasks.Task<string> AddRemarkOnIdAsync(int id, string remarkText, string remarkGrade, string remarkAuthor) {
            return base.Channel.AddRemarkOnIdAsync(id, remarkText, remarkGrade, remarkAuthor);
        }
        
        public string AddRemarkOnName(string name, string remarkText, string remarkGrade, string remarkAuthor) {
            return base.Channel.AddRemarkOnName(name, remarkText, remarkGrade, remarkAuthor);
        }
        
        public System.Threading.Tasks.Task<string> AddRemarkOnNameAsync(string name, string remarkText, string remarkGrade, string remarkAuthor) {
            return base.Channel.AddRemarkOnNameAsync(name, remarkText, remarkGrade, remarkAuthor);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IGetEmployeeData")]
    public interface IGetEmployeeData {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetEmployeeData/GetEmployeeById", ReplyAction="http://tempuri.org/IGetEmployeeData/GetEmployeeByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TestWCFService.EmployeeService.CustomeException), Action="http://tempuri.org/IGetEmployeeData/GetEmployeeByIdCustomeExceptionFault", Name="CustomeException", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementUsingWCF")]
        TestWCFService.EmployeeService.Employee GetEmployeeById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetEmployeeData/GetEmployeeById", ReplyAction="http://tempuri.org/IGetEmployeeData/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<TestWCFService.EmployeeService.Employee> GetEmployeeByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetEmployeeData/GetEmployeeByName", ReplyAction="http://tempuri.org/IGetEmployeeData/GetEmployeeByNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TestWCFService.EmployeeService.CustomeException), Action="http://tempuri.org/IGetEmployeeData/GetEmployeeByNameCustomeExceptionFault", Name="CustomeException", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementUsingWCF")]
        TestWCFService.EmployeeService.Employee GetEmployeeByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetEmployeeData/GetEmployeeByName", ReplyAction="http://tempuri.org/IGetEmployeeData/GetEmployeeByNameResponse")]
        System.Threading.Tasks.Task<TestWCFService.EmployeeService.Employee> GetEmployeeByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetEmployeeData/GetAllEmployees", ReplyAction="http://tempuri.org/IGetEmployeeData/GetAllEmployeesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TestWCFService.EmployeeService.CustomeException), Action="http://tempuri.org/IGetEmployeeData/GetAllEmployeesCustomeExceptionFault", Name="CustomeException", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementUsingWCF")]
        TestWCFService.EmployeeService.Employee[] GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetEmployeeData/GetAllEmployees", ReplyAction="http://tempuri.org/IGetEmployeeData/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<TestWCFService.EmployeeService.Employee[]> GetAllEmployeesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGetEmployeeDataChannel : TestWCFService.EmployeeService.IGetEmployeeData, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetEmployeeDataClient : System.ServiceModel.ClientBase<TestWCFService.EmployeeService.IGetEmployeeData>, TestWCFService.EmployeeService.IGetEmployeeData {
        
        public GetEmployeeDataClient() {
        }
        
        public GetEmployeeDataClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetEmployeeDataClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetEmployeeDataClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetEmployeeDataClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestWCFService.EmployeeService.Employee GetEmployeeById(int id) {
            return base.Channel.GetEmployeeById(id);
        }
        
        public System.Threading.Tasks.Task<TestWCFService.EmployeeService.Employee> GetEmployeeByIdAsync(int id) {
            return base.Channel.GetEmployeeByIdAsync(id);
        }
        
        public TestWCFService.EmployeeService.Employee GetEmployeeByName(string name) {
            return base.Channel.GetEmployeeByName(name);
        }
        
        public System.Threading.Tasks.Task<TestWCFService.EmployeeService.Employee> GetEmployeeByNameAsync(string name) {
            return base.Channel.GetEmployeeByNameAsync(name);
        }
        
        public TestWCFService.EmployeeService.Employee[] GetAllEmployees() {
            return base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task<TestWCFService.EmployeeService.Employee[]> GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
    }
}