﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MetalBandBakery.Console.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckStock", ReplyAction="http://tempuri.org/IService/CheckStockResponse")]
        void CheckStock(string[] itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckStock", ReplyAction="http://tempuri.org/IService/CheckStockResponse")]
        System.Threading.Tasks.Task CheckStockAsync(string[] itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ShowStock", ReplyAction="http://tempuri.org/IService/ShowStockResponse")]
        void ShowStock(string[] itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ShowStock", ReplyAction="http://tempuri.org/IService/ShowStockResponse")]
        System.Threading.Tasks.Task ShowStockAsync(string[] itemId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : MetalBandBakery.Console.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<MetalBandBakery.Console.ServiceReference1.IService>, MetalBandBakery.Console.ServiceReference1.IService {
        
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
        
        public void CheckStock(string[] itemId) {
            base.Channel.CheckStock(itemId);
        }
        
        public System.Threading.Tasks.Task CheckStockAsync(string[] itemId) {
            return base.Channel.CheckStockAsync(itemId);
        }
        
        public void ShowStock(string[] itemId) {
            base.Channel.ShowStock(itemId);
        }
        
        public System.Threading.Tasks.Task ShowStockAsync(string[] itemId) {
            return base.Channel.ShowStockAsync(itemId);
        }
    }
}