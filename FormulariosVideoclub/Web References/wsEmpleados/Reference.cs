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

namespace FormulariosVideoclub.wsEmpleados {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="wsEmpleadosSoap", Namespace="http://tempuri.org/")]
    public partial class wsEmpleados : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsertarEmpleadoOperationCompleted;
        
        private System.Threading.SendOrPostCallback verEmpleadosOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarEmpleadoOperationCompleted;
        
        private System.Threading.SendOrPostCallback actualizarOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarEmpleadoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsEmpleados() {
            this.Url = global::FormulariosVideoclub.Properties.Settings.Default.FormulariosVideoclub_wsEmpleados_wsEmpleados;
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
        public event InsertarEmpleadoCompletedEventHandler InsertarEmpleadoCompleted;
        
        /// <remarks/>
        public event verEmpleadosCompletedEventHandler verEmpleadosCompleted;
        
        /// <remarks/>
        public event BuscarEmpleadoCompletedEventHandler BuscarEmpleadoCompleted;
        
        /// <remarks/>
        public event actualizarCompletedEventHandler actualizarCompleted;
        
        /// <remarks/>
        public event eliminarEmpleadoCompletedEventHandler eliminarEmpleadoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertarEmpleado", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertarEmpleado(int id_empleado, string nombre, string Ap, string Am, int edad, string puesto, int sxdia, string calle, string colonia, int ncasa, string fr) {
            object[] results = this.Invoke("InsertarEmpleado", new object[] {
                        id_empleado,
                        nombre,
                        Ap,
                        Am,
                        edad,
                        puesto,
                        sxdia,
                        calle,
                        colonia,
                        ncasa,
                        fr});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertarEmpleadoAsync(int id_empleado, string nombre, string Ap, string Am, int edad, string puesto, int sxdia, string calle, string colonia, int ncasa, string fr) {
            this.InsertarEmpleadoAsync(id_empleado, nombre, Ap, Am, edad, puesto, sxdia, calle, colonia, ncasa, fr, null);
        }
        
        /// <remarks/>
        public void InsertarEmpleadoAsync(int id_empleado, string nombre, string Ap, string Am, int edad, string puesto, int sxdia, string calle, string colonia, int ncasa, string fr, object userState) {
            if ((this.InsertarEmpleadoOperationCompleted == null)) {
                this.InsertarEmpleadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertarEmpleadoOperationCompleted);
            }
            this.InvokeAsync("InsertarEmpleado", new object[] {
                        id_empleado,
                        nombre,
                        Ap,
                        Am,
                        edad,
                        puesto,
                        sxdia,
                        calle,
                        colonia,
                        ncasa,
                        fr}, this.InsertarEmpleadoOperationCompleted, userState);
        }
        
        private void OnInsertarEmpleadoOperationCompleted(object arg) {
            if ((this.InsertarEmpleadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertarEmpleadoCompleted(this, new InsertarEmpleadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/verEmpleados", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet verEmpleados() {
            object[] results = this.Invoke("verEmpleados", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void verEmpleadosAsync() {
            this.verEmpleadosAsync(null);
        }
        
        /// <remarks/>
        public void verEmpleadosAsync(object userState) {
            if ((this.verEmpleadosOperationCompleted == null)) {
                this.verEmpleadosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnverEmpleadosOperationCompleted);
            }
            this.InvokeAsync("verEmpleados", new object[0], this.verEmpleadosOperationCompleted, userState);
        }
        
        private void OnverEmpleadosOperationCompleted(object arg) {
            if ((this.verEmpleadosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.verEmpleadosCompleted(this, new verEmpleadosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarEmpleado", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet BuscarEmpleado(int id) {
            object[] results = this.Invoke("BuscarEmpleado", new object[] {
                        id});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarEmpleadoAsync(int id) {
            this.BuscarEmpleadoAsync(id, null);
        }
        
        /// <remarks/>
        public void BuscarEmpleadoAsync(int id, object userState) {
            if ((this.BuscarEmpleadoOperationCompleted == null)) {
                this.BuscarEmpleadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarEmpleadoOperationCompleted);
            }
            this.InvokeAsync("BuscarEmpleado", new object[] {
                        id}, this.BuscarEmpleadoOperationCompleted, userState);
        }
        
        private void OnBuscarEmpleadoOperationCompleted(object arg) {
            if ((this.BuscarEmpleadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarEmpleadoCompleted(this, new BuscarEmpleadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/actualizar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string actualizar(int id_empleado, string nombre, string Ap, string Am, int edad, string puesto, int sxdia, string calle, string colonia, int ncasa, string fr) {
            object[] results = this.Invoke("actualizar", new object[] {
                        id_empleado,
                        nombre,
                        Ap,
                        Am,
                        edad,
                        puesto,
                        sxdia,
                        calle,
                        colonia,
                        ncasa,
                        fr});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void actualizarAsync(int id_empleado, string nombre, string Ap, string Am, int edad, string puesto, int sxdia, string calle, string colonia, int ncasa, string fr) {
            this.actualizarAsync(id_empleado, nombre, Ap, Am, edad, puesto, sxdia, calle, colonia, ncasa, fr, null);
        }
        
        /// <remarks/>
        public void actualizarAsync(int id_empleado, string nombre, string Ap, string Am, int edad, string puesto, int sxdia, string calle, string colonia, int ncasa, string fr, object userState) {
            if ((this.actualizarOperationCompleted == null)) {
                this.actualizarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnactualizarOperationCompleted);
            }
            this.InvokeAsync("actualizar", new object[] {
                        id_empleado,
                        nombre,
                        Ap,
                        Am,
                        edad,
                        puesto,
                        sxdia,
                        calle,
                        colonia,
                        ncasa,
                        fr}, this.actualizarOperationCompleted, userState);
        }
        
        private void OnactualizarOperationCompleted(object arg) {
            if ((this.actualizarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.actualizarCompleted(this, new actualizarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarEmpleado", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string eliminarEmpleado(int id) {
            object[] results = this.Invoke("eliminarEmpleado", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarEmpleadoAsync(int id) {
            this.eliminarEmpleadoAsync(id, null);
        }
        
        /// <remarks/>
        public void eliminarEmpleadoAsync(int id, object userState) {
            if ((this.eliminarEmpleadoOperationCompleted == null)) {
                this.eliminarEmpleadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarEmpleadoOperationCompleted);
            }
            this.InvokeAsync("eliminarEmpleado", new object[] {
                        id}, this.eliminarEmpleadoOperationCompleted, userState);
        }
        
        private void OneliminarEmpleadoOperationCompleted(object arg) {
            if ((this.eliminarEmpleadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarEmpleadoCompleted(this, new eliminarEmpleadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void InsertarEmpleadoCompletedEventHandler(object sender, InsertarEmpleadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertarEmpleadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertarEmpleadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void verEmpleadosCompletedEventHandler(object sender, verEmpleadosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class verEmpleadosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal verEmpleadosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void BuscarEmpleadoCompletedEventHandler(object sender, BuscarEmpleadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarEmpleadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarEmpleadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void eliminarEmpleadoCompletedEventHandler(object sender, eliminarEmpleadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarEmpleadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarEmpleadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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