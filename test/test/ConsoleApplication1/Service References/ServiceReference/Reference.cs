﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name val from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        ConsoleApplication1.ServiceReference.XmlToJsonResponse XmlToJson(ConsoleApplication1.ServiceReference.XmlToJsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference.XmlToJsonResponse> XmlToJsonAsync(ConsoleApplication1.ServiceReference.XmlToJsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        int Fibonacci(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FibonacciAsync(int n);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJson", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApplication1.ServiceReference.XmlToJsonRequestBody Body;
        
        public XmlToJsonRequest() {
        }
        
        public XmlToJsonRequest(ConsoleApplication1.ServiceReference.XmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string val;
        
        public XmlToJsonRequestBody() {
        }
        
        public XmlToJsonRequestBody(string val) {
            this.val = val;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApplication1.ServiceReference.XmlToJsonResponseBody Body;
        
        public XmlToJsonResponse() {
        }
        
        public XmlToJsonResponse(ConsoleApplication1.ServiceReference.XmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string XmlToJsonResult;
        
        public XmlToJsonResponseBody() {
        }
        
        public XmlToJsonResponseBody(string XmlToJsonResult) {
            this.XmlToJsonResult = XmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : ConsoleApplication1.ServiceReference.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<ConsoleApplication1.ServiceReference.WebServiceSoap>, ConsoleApplication1.ServiceReference.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApplication1.ServiceReference.XmlToJsonResponse ConsoleApplication1.ServiceReference.WebServiceSoap.XmlToJson(ConsoleApplication1.ServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJson(request);
        }
        
        public string XmlToJson(string val) {
            ConsoleApplication1.ServiceReference.XmlToJsonRequest inValue = new ConsoleApplication1.ServiceReference.XmlToJsonRequest();
            inValue.Body = new ConsoleApplication1.ServiceReference.XmlToJsonRequestBody();
            inValue.Body.val = val;
            ConsoleApplication1.ServiceReference.XmlToJsonResponse retVal = ((ConsoleApplication1.ServiceReference.WebServiceSoap)(this)).XmlToJson(inValue);
            return retVal.Body.XmlToJsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference.XmlToJsonResponse> ConsoleApplication1.ServiceReference.WebServiceSoap.XmlToJsonAsync(ConsoleApplication1.ServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference.XmlToJsonResponse> XmlToJsonAsync(string val) {
            ConsoleApplication1.ServiceReference.XmlToJsonRequest inValue = new ConsoleApplication1.ServiceReference.XmlToJsonRequest();
            inValue.Body = new ConsoleApplication1.ServiceReference.XmlToJsonRequestBody();
            inValue.Body.val = val;
            return ((ConsoleApplication1.ServiceReference.WebServiceSoap)(this)).XmlToJsonAsync(inValue);
        }
        
        public int Fibonacci(int n) {
            return base.Channel.Fibonacci(n);
        }
        
        public System.Threading.Tasks.Task<int> FibonacciAsync(int n) {
            return base.Channel.FibonacciAsync(n);
        }
    }
}
