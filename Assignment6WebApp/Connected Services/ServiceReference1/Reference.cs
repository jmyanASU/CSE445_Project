﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment6WebApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addMember", ReplyAction="http://tempuri.org/IService1/addMemberResponse")]
        void addMember(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addMember", ReplyAction="http://tempuri.org/IService1/addMemberResponse")]
        System.Threading.Tasks.Task addMemberAsync(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/hashPass", ReplyAction="http://tempuri.org/IService1/hashPassResponse")]
        string hashPass(string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/hashPass", ReplyAction="http://tempuri.org/IService1/hashPassResponse")]
        System.Threading.Tasks.Task<string> hashPassAsync(string pass);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Assignment6WebApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Assignment6WebApp.ServiceReference1.IService1>, Assignment6WebApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void addMember(string user, string pass) {
            base.Channel.addMember(user, pass);
        }
        
        public System.Threading.Tasks.Task addMemberAsync(string user, string pass) {
            return base.Channel.addMemberAsync(user, pass);
        }
        
        public string hashPass(string pass) {
            return base.Channel.hashPass(pass);
        }
        
        public System.Threading.Tasks.Task<string> hashPassAsync(string pass) {
            return base.Channel.hashPassAsync(pass);
        }
    }
}
