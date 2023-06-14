﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace FormulariosVideoclub.wsProductos {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="wsProductosSoap", Namespace="http://tempuri.org/")]
    public partial class wsProductos : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback insertarProductoOperationCompleted;
        
        private System.Threading.SendOrPostCallback verProductosOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarOperationCompleted;
        
        private System.Threading.SendOrPostCallback actualizarOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsProductos() {
            this.Url = global::FormulariosVideoclub.Properties.Settings.Default.FormulariosVideoclub_wsProductos_wsProductos;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event insertarProductoCompletedEventHandler insertarProductoCompleted;
        
        /// <remarks/>
        public event verProductosCompletedEventHandler verProductosCompleted;
        
        /// <remarks/>
        public event BuscarCompletedEventHandler BuscarCompleted;
        
        /// <remarks/>
        public event actualizarCompletedEventHandler actualizarCompleted;
        
        /// <remarks/>
        public event eliminarCompletedEventHandler eliminarCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/insertarProducto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string insertarProducto(int id_producto, int id_proovedor, string tipo_prod, string nombre, string año, string genero, string tipo_publico, int cantidad, string fecha_registro) {
            object[] results = this.Invoke("insertarProducto", new object[] {
                        id_producto,
                        id_proovedor,
                        tipo_prod,
                        nombre,
                        año,
                        genero,
                        tipo_publico,
                        cantidad,
                        fecha_registro});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void insertarProductoAsync(int id_producto, int id_proovedor, string tipo_prod, string nombre, string año, string genero, string tipo_publico, int cantidad, string fecha_registro) {
            this.insertarProductoAsync(id_producto, id_proovedor, tipo_prod, nombre, año, genero, tipo_publico, cantidad, fecha_registro, null);
        }
        
        /// <remarks/>
        public void insertarProductoAsync(int id_producto, int id_proovedor, string tipo_prod, string nombre, string año, string genero, string tipo_publico, int cantidad, string fecha_registro, object userState) {
            if ((this.insertarProductoOperationCompleted == null)) {
                this.insertarProductoOperationCompleted = new System.Threading.SendOrPostCallback(this.OninsertarProductoOperationCompleted);
            }
            this.InvokeAsync("insertarProducto", new object[] {
                        id_producto,
                        id_proovedor,
                        tipo_prod,
                        nombre,
                        año,
                        genero,
                        tipo_publico,
                        cantidad,
                        fecha_registro}, this.insertarProductoOperationCompleted, userState);
        }
        
        private void OninsertarProductoOperationCompleted(object arg) {
            if ((this.insertarProductoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.insertarProductoCompleted(this, new insertarProductoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/verProductos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet verProductos() {
            object[] results = this.Invoke("verProductos", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void verProductosAsync() {
            this.verProductosAsync(null);
        }
        
        /// <remarks/>
        public void verProductosAsync(object userState) {
            if ((this.verProductosOperationCompleted == null)) {
                this.verProductosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnverProductosOperationCompleted);
            }
            this.InvokeAsync("verProductos", new object[0], this.verProductosOperationCompleted, userState);
        }
        
        private void OnverProductosOperationCompleted(object arg) {
            if ((this.verProductosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.verProductosCompleted(this, new verProductosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Buscar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet Buscar(long id) {
            object[] results = this.Invoke("Buscar", new object[] {
                        id});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarAsync(long id) {
            this.BuscarAsync(id, null);
        }
        
        /// <remarks/>
        public void BuscarAsync(long id, object userState) {
            if ((this.BuscarOperationCompleted == null)) {
                this.BuscarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarOperationCompleted);
            }
            this.InvokeAsync("Buscar", new object[] {
                        id}, this.BuscarOperationCompleted, userState);
        }
        
        private void OnBuscarOperationCompleted(object arg) {
            if ((this.BuscarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarCompleted(this, new BuscarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/actualizar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string actualizar(int id_producto, int id_proovedor, string tipo_prod, string nombre, string año, string genero, string tipo_publico, int cantidad, string fecha_registro) {
            object[] results = this.Invoke("actualizar", new object[] {
                        id_producto,
                        id_proovedor,
                        tipo_prod,
                        nombre,
                        año,
                        genero,
                        tipo_publico,
                        cantidad,
                        fecha_registro});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void actualizarAsync(int id_producto, int id_proovedor, string tipo_prod, string nombre, string año, string genero, string tipo_publico, int cantidad, string fecha_registro) {
            this.actualizarAsync(id_producto, id_proovedor, tipo_prod, nombre, año, genero, tipo_publico, cantidad, fecha_registro, null);
        }
        
        /// <remarks/>
        public void actualizarAsync(int id_producto, int id_proovedor, string tipo_prod, string nombre, string año, string genero, string tipo_publico, int cantidad, string fecha_registro, object userState) {
            if ((this.actualizarOperationCompleted == null)) {
                this.actualizarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnactualizarOperationCompleted);
            }
            this.InvokeAsync("actualizar", new object[] {
                        id_producto,
                        id_proovedor,
                        tipo_prod,
                        nombre,
                        año,
                        genero,
                        tipo_publico,
                        cantidad,
                        fecha_registro}, this.actualizarOperationCompleted, userState);
        }
        
        private void OnactualizarOperationCompleted(object arg) {
            if ((this.actualizarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.actualizarCompleted(this, new actualizarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string eliminar(int id) {
            object[] results = this.Invoke("eliminar", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarAsync(int id) {
            this.eliminarAsync(id, null);
        }
        
        /// <remarks/>
        public void eliminarAsync(int id, object userState) {
            if ((this.eliminarOperationCompleted == null)) {
                this.eliminarOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarOperationCompleted);
            }
            this.InvokeAsync("eliminar", new object[] {
                        id}, this.eliminarOperationCompleted, userState);
        }
        
        private void OneliminarOperationCompleted(object arg) {
            if ((this.eliminarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarCompleted(this, new eliminarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void insertarProductoCompletedEventHandler(object sender, insertarProductoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class insertarProductoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal insertarProductoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void verProductosCompletedEventHandler(object sender, verProductosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class verProductosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal verProductosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BuscarCompletedEventHandler(object sender, BuscarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void actualizarCompletedEventHandler(object sender, actualizarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class actualizarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal actualizarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void eliminarCompletedEventHandler(object sender, eliminarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591