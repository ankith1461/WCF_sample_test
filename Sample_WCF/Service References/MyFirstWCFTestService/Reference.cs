﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample_WCF.MyFirstWCFTestService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Name", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class Name : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastnameField;
        
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
        public string firstname {
            get {
                return this.firstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstnameField, value) != true)) {
                    this.firstnameField = value;
                    this.RaisePropertyChanged("firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastname {
            get {
                return this.lastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastnameField, value) != true)) {
                    this.lastnameField = value;
                    this.RaisePropertyChanged("lastname");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyFirstWCFTestService.IName")]
    public interface IName {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IName/UrNameIs", ReplyAction="http://tempuri.org/IName/UrNameIsResponse")]
        string UrNameIs(Sample_WCF.MyFirstWCFTestService.Name sample);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IName/UrNameIs", ReplyAction="http://tempuri.org/IName/UrNameIsResponse")]
        System.Threading.Tasks.Task<string> UrNameIsAsync(Sample_WCF.MyFirstWCFTestService.Name sample);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INameChannel : Sample_WCF.MyFirstWCFTestService.IName, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NameClient : System.ServiceModel.ClientBase<Sample_WCF.MyFirstWCFTestService.IName>, Sample_WCF.MyFirstWCFTestService.IName {
        
        public NameClient() {
        }
        
        public NameClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NameClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NameClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NameClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string UrNameIs(Sample_WCF.MyFirstWCFTestService.Name sample) {
            return base.Channel.UrNameIs(sample);
        }
        
        public System.Threading.Tasks.Task<string> UrNameIsAsync(Sample_WCF.MyFirstWCFTestService.Name sample) {
            return base.Channel.UrNameIsAsync(sample);
        }
    }
}
