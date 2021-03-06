﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.WindDirection {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WindDirection.IGetLocation")]
    public interface IGetLocation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetLocation/GetLocationID", ReplyAction="http://tempuri.org/IGetLocation/GetLocationIDResponse")]
        long GetLocationID(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetLocation/GetLocationID", ReplyAction="http://tempuri.org/IGetLocation/GetLocationIDResponse")]
        System.Threading.Tasks.Task<long> GetLocationIDAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetLocation/GetWindDirection", ReplyAction="http://tempuri.org/IGetLocation/GetWindDirectionResponse")]
        string GetWindDirection(long location_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetLocation/GetWindDirection", ReplyAction="http://tempuri.org/IGetLocation/GetWindDirectionResponse")]
        System.Threading.Tasks.Task<string> GetWindDirectionAsync(long location_id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGetLocationChannel : WebApplication.WindDirection.IGetLocation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetLocationClient : System.ServiceModel.ClientBase<WebApplication.WindDirection.IGetLocation>, WebApplication.WindDirection.IGetLocation {
        
        public GetLocationClient() {
        }
        
        public GetLocationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetLocationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetLocationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetLocationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public long GetLocationID(string name) {
            return base.Channel.GetLocationID(name);
        }
        
        public System.Threading.Tasks.Task<long> GetLocationIDAsync(string name) {
            return base.Channel.GetLocationIDAsync(name);
        }
        
        public string GetWindDirection(long location_id) {
            return base.Channel.GetWindDirection(location_id);
        }
        
        public System.Threading.Tasks.Task<string> GetWindDirectionAsync(long location_id) {
            return base.Channel.GetWindDirectionAsync(location_id);
        }
    }
}
