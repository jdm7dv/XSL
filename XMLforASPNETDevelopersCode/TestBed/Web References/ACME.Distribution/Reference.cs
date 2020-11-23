﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3705.0
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.0.3705.0.
// 
namespace ACME.Distribution {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ACMEProductsSoap", Namespace="http://www.ACMEDistribution.com/Products")]
    public class ACMEProducts : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public ACMEProducts() {
            this.Url = "http://localhost/TestBed/Chapter10/listing10.14.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ACMEDistribution.com/Products/CheckStock", RequestNamespace="http://www.ACMEDistribution.com/Products", ResponseNamespace="http://www.ACMEDistribution.com/Products", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet CheckStock(int productID) {
            object[] results = this.Invoke("CheckStock", new object[] {
                        productID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCheckStock(int productID, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CheckStock", new object[] {
                        productID}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndCheckStock(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ACMEDistribution.com/Products/GetOrders", RequestNamespace="http://www.ACMEDistribution.com/Products", ResponseNamespace="http://www.ACMEDistribution.com/Products", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetOrders(string CustomerID) {
            object[] results = this.Invoke("GetOrders", new object[] {
                        CustomerID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetOrders(string CustomerID, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetOrders", new object[] {
                        CustomerID}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetOrders(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ACMEDistribution.com/Products/GetProductByName", RequestNamespace="http://www.ACMEDistribution.com/Products", ResponseNamespace="http://www.ACMEDistribution.com/Products", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetProductByName(string productName) {
            object[] results = this.Invoke("GetProductByName", new object[] {
                        productName});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetProductByName(string productName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetProductByName", new object[] {
                        productName}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetProductByName(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ACMEDistribution.com/Products/GetProductByID", RequestNamespace="http://www.ACMEDistribution.com/Products", ResponseNamespace="http://www.ACMEDistribution.com/Products", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetProductByID(int id) {
            object[] results = this.Invoke("GetProductByID", new object[] {
                        id});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetProductByID(int id, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetProductByID", new object[] {
                        id}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetProductByID(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ACMEDistribution.com/Products/GetProducts", RequestNamespace="http://www.ACMEDistribution.com/Products", ResponseNamespace="http://www.ACMEDistribution.com/Products", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetProducts() {
            object[] results = this.Invoke("GetProducts", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetProducts(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetProducts", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetProducts(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
    }
}