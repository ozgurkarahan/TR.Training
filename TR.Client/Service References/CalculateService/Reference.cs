﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TR.Client.CalculateService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculateService.ICalculateService", CallbackContract=typeof(TR.Client.CalculateService.ICalculateServiceCallback))]
    public interface ICalculateService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculateService/Calculate", ReplyAction="http://tempuri.org/ICalculateService/CalculateResponse")]
        void Calculate(int input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculateService/Calculate", ReplyAction="http://tempuri.org/ICalculateService/CalculateResponse")]
        System.Threading.Tasks.Task CalculateAsync(int input);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculateServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculateService/OnCalculateCallback")]
        void OnCalculateCallback(string functionName, int result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculateServiceChannel : TR.Client.CalculateService.ICalculateService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculateServiceClient : System.ServiceModel.DuplexClientBase<TR.Client.CalculateService.ICalculateService>, TR.Client.CalculateService.ICalculateService {
        
        public CalculateServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CalculateServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CalculateServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalculateServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalculateServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Calculate(int input) {
            base.Channel.Calculate(input);
        }
        
        public System.Threading.Tasks.Task CalculateAsync(int input) {
            return base.Channel.CalculateAsync(input);
        }
    }
}