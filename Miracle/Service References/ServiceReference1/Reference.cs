﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Miracle.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SaveData", ReplyAction="http://tempuri.org/IService/SaveDataResponse")]
        void SaveData(Miracle.Models.Helpers.Message m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SaveData", ReplyAction="http://tempuri.org/IService/SaveDataResponse")]
        System.Threading.Tasks.Task SaveDataAsync(Miracle.Models.Helpers.Message m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LoadData", ReplyAction="http://tempuri.org/IService/LoadDataResponse")]
        Miracle.Models.Helpers.Message LoadData(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LoadData", ReplyAction="http://tempuri.org/IService/LoadDataResponse")]
        System.Threading.Tasks.Task<Miracle.Models.Helpers.Message> LoadDataAsync(string s);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Miracle.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Miracle.ServiceReference1.IService>, Miracle.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SaveData(Miracle.Models.Helpers.Message m) {
            base.Channel.SaveData(m);
        }
        
        public System.Threading.Tasks.Task SaveDataAsync(Miracle.Models.Helpers.Message m) {
            return base.Channel.SaveDataAsync(m);
        }
        
        public Miracle.Models.Helpers.Message LoadData(string s) {
            return base.Channel.LoadData(s);
        }
        
        public System.Threading.Tasks.Task<Miracle.Models.Helpers.Message> LoadDataAsync(string s) {
            return base.Channel.LoadDataAsync(s);
        }
    }
}
