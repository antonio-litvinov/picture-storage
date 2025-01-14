﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://tempuri.org/")]
public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback PictureAddOperationCompleted;
    
    private System.Threading.SendOrPostCallback PictureDeleteOperationCompleted;
    
    private System.Threading.SendOrPostCallback PictureLoadOperationCompleted;
    
    private System.Threading.SendOrPostCallback PictureListOperationCompleted;
    
    private System.Threading.SendOrPostCallback CommentSaveOperationCompleted;
    
    private System.Threading.SendOrPostCallback CommentLoadOperationCompleted;
    
    private System.Threading.SendOrPostCallback UserAddOperationCompleted;
    
    private System.Threading.SendOrPostCallback UserDeleteOperationCompleted;
    
    private System.Threading.SendOrPostCallback UserListOperationCompleted;
    
    private System.Threading.SendOrPostCallback UserLoadOperationCompleted;
    
    /// <remarks/>
    public Service() {
        this.Url = "http://localhost:2483/PictureService/Service.asmx";
    }
    
    /// <remarks/>
    public event PictureAddCompletedEventHandler PictureAddCompleted;
    
    /// <remarks/>
    public event PictureDeleteCompletedEventHandler PictureDeleteCompleted;
    
    /// <remarks/>
    public event PictureLoadCompletedEventHandler PictureLoadCompleted;
    
    /// <remarks/>
    public event PictureListCompletedEventHandler PictureListCompleted;
    
    /// <remarks/>
    public event CommentSaveCompletedEventHandler CommentSaveCompleted;
    
    /// <remarks/>
    public event CommentLoadCompletedEventHandler CommentLoadCompleted;
    
    /// <remarks/>
    public event UserAddCompletedEventHandler UserAddCompleted;
    
    /// <remarks/>
    public event UserDeleteCompletedEventHandler UserDeleteCompleted;
    
    /// <remarks/>
    public event UserListCompletedEventHandler UserListCompleted;
    
    /// <remarks/>
    public event UserLoadCompletedEventHandler UserLoadCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PictureAdd", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Guid PictureAdd([System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] Picture, string UserID) {
        object[] results = this.Invoke("PictureAdd", new object[] {
                    Picture,
                    UserID});
        return ((System.Guid)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginPictureAdd(byte[] Picture, string UserID, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("PictureAdd", new object[] {
                    Picture,
                    UserID}, callback, asyncState);
    }
    
    /// <remarks/>
    public System.Guid EndPictureAdd(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Guid)(results[0]));
    }
    
    /// <remarks/>
    public void PictureAddAsync(byte[] Picture, string UserID) {
        this.PictureAddAsync(Picture, UserID, null);
    }
    
    /// <remarks/>
    public void PictureAddAsync(byte[] Picture, string UserID, object userState) {
        if ((this.PictureAddOperationCompleted == null)) {
            this.PictureAddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPictureAddOperationCompleted);
        }
        this.InvokeAsync("PictureAdd", new object[] {
                    Picture,
                    UserID}, this.PictureAddOperationCompleted, userState);
    }
    
    private void OnPictureAddOperationCompleted(object arg) {
        if ((this.PictureAddCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.PictureAddCompleted(this, new PictureAddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PictureDelete", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void PictureDelete(string ID) {
        this.Invoke("PictureDelete", new object[] {
                    ID});
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginPictureDelete(string ID, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("PictureDelete", new object[] {
                    ID}, callback, asyncState);
    }
    
    /// <remarks/>
    public void EndPictureDelete(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    /// <remarks/>
    public void PictureDeleteAsync(string ID) {
        this.PictureDeleteAsync(ID, null);
    }
    
    /// <remarks/>
    public void PictureDeleteAsync(string ID, object userState) {
        if ((this.PictureDeleteOperationCompleted == null)) {
            this.PictureDeleteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPictureDeleteOperationCompleted);
        }
        this.InvokeAsync("PictureDelete", new object[] {
                    ID}, this.PictureDeleteOperationCompleted, userState);
    }
    
    private void OnPictureDeleteOperationCompleted(object arg) {
        if ((this.PictureDeleteCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.PictureDeleteCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PictureLoad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] PictureLoad(string ID) {
        object[] results = this.Invoke("PictureLoad", new object[] {
                    ID});
        return ((byte[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginPictureLoad(string ID, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("PictureLoad", new object[] {
                    ID}, callback, asyncState);
    }
    
    /// <remarks/>
    public byte[] EndPictureLoad(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((byte[])(results[0]));
    }
    
    /// <remarks/>
    public void PictureLoadAsync(string ID) {
        this.PictureLoadAsync(ID, null);
    }
    
    /// <remarks/>
    public void PictureLoadAsync(string ID, object userState) {
        if ((this.PictureLoadOperationCompleted == null)) {
            this.PictureLoadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPictureLoadOperationCompleted);
        }
        this.InvokeAsync("PictureLoad", new object[] {
                    ID}, this.PictureLoadOperationCompleted, userState);
    }
    
    private void OnPictureLoadOperationCompleted(object arg) {
        if ((this.PictureLoadCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.PictureLoadCompleted(this, new PictureLoadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PictureList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Guid[] PictureList(string UserID) {
        object[] results = this.Invoke("PictureList", new object[] {
                    UserID});
        return ((System.Guid[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginPictureList(string UserID, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("PictureList", new object[] {
                    UserID}, callback, asyncState);
    }
    
    /// <remarks/>
    public System.Guid[] EndPictureList(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Guid[])(results[0]));
    }
    
    /// <remarks/>
    public void PictureListAsync(string UserID) {
        this.PictureListAsync(UserID, null);
    }
    
    /// <remarks/>
    public void PictureListAsync(string UserID, object userState) {
        if ((this.PictureListOperationCompleted == null)) {
            this.PictureListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPictureListOperationCompleted);
        }
        this.InvokeAsync("PictureList", new object[] {
                    UserID}, this.PictureListOperationCompleted, userState);
    }
    
    private void OnPictureListOperationCompleted(object arg) {
        if ((this.PictureListCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.PictureListCompleted(this, new PictureListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CommentSave", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void CommentSave(string ID, string Comment) {
        this.Invoke("CommentSave", new object[] {
                    ID,
                    Comment});
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginCommentSave(string ID, string Comment, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("CommentSave", new object[] {
                    ID,
                    Comment}, callback, asyncState);
    }
    
    /// <remarks/>
    public void EndCommentSave(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    /// <remarks/>
    public void CommentSaveAsync(string ID, string Comment) {
        this.CommentSaveAsync(ID, Comment, null);
    }
    
    /// <remarks/>
    public void CommentSaveAsync(string ID, string Comment, object userState) {
        if ((this.CommentSaveOperationCompleted == null)) {
            this.CommentSaveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCommentSaveOperationCompleted);
        }
        this.InvokeAsync("CommentSave", new object[] {
                    ID,
                    Comment}, this.CommentSaveOperationCompleted, userState);
    }
    
    private void OnCommentSaveOperationCompleted(object arg) {
        if ((this.CommentSaveCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.CommentSaveCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CommentLoad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string CommentLoad(string ID) {
        object[] results = this.Invoke("CommentLoad", new object[] {
                    ID});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginCommentLoad(string ID, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("CommentLoad", new object[] {
                    ID}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndCommentLoad(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void CommentLoadAsync(string ID) {
        this.CommentLoadAsync(ID, null);
    }
    
    /// <remarks/>
    public void CommentLoadAsync(string ID, object userState) {
        if ((this.CommentLoadOperationCompleted == null)) {
            this.CommentLoadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCommentLoadOperationCompleted);
        }
        this.InvokeAsync("CommentLoad", new object[] {
                    ID}, this.CommentLoadOperationCompleted, userState);
    }
    
    private void OnCommentLoadOperationCompleted(object arg) {
        if ((this.CommentLoadCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.CommentLoadCompleted(this, new CommentLoadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UserAdd", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Guid UserAdd(string Login, string Password) {
        object[] results = this.Invoke("UserAdd", new object[] {
                    Login,
                    Password});
        return ((System.Guid)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginUserAdd(string Login, string Password, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("UserAdd", new object[] {
                    Login,
                    Password}, callback, asyncState);
    }
    
    /// <remarks/>
    public System.Guid EndUserAdd(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Guid)(results[0]));
    }
    
    /// <remarks/>
    public void UserAddAsync(string Login, string Password) {
        this.UserAddAsync(Login, Password, null);
    }
    
    /// <remarks/>
    public void UserAddAsync(string Login, string Password, object userState) {
        if ((this.UserAddOperationCompleted == null)) {
            this.UserAddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUserAddOperationCompleted);
        }
        this.InvokeAsync("UserAdd", new object[] {
                    Login,
                    Password}, this.UserAddOperationCompleted, userState);
    }
    
    private void OnUserAddOperationCompleted(object arg) {
        if ((this.UserAddCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.UserAddCompleted(this, new UserAddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UserDelete", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void UserDelete(string ID) {
        this.Invoke("UserDelete", new object[] {
                    ID});
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginUserDelete(string ID, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("UserDelete", new object[] {
                    ID}, callback, asyncState);
    }
    
    /// <remarks/>
    public void EndUserDelete(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    /// <remarks/>
    public void UserDeleteAsync(string ID) {
        this.UserDeleteAsync(ID, null);
    }
    
    /// <remarks/>
    public void UserDeleteAsync(string ID, object userState) {
        if ((this.UserDeleteOperationCompleted == null)) {
            this.UserDeleteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUserDeleteOperationCompleted);
        }
        this.InvokeAsync("UserDelete", new object[] {
                    ID}, this.UserDeleteOperationCompleted, userState);
    }
    
    private void OnUserDeleteOperationCompleted(object arg) {
        if ((this.UserDeleteCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.UserDeleteCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UserList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public System.Guid[] UserList() {
        object[] results = this.Invoke("UserList", new object[0]);
        return ((System.Guid[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginUserList(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("UserList", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public System.Guid[] EndUserList(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Guid[])(results[0]));
    }
    
    /// <remarks/>
    public void UserListAsync() {
        this.UserListAsync(null);
    }
    
    /// <remarks/>
    public void UserListAsync(object userState) {
        if ((this.UserListOperationCompleted == null)) {
            this.UserListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUserListOperationCompleted);
        }
        this.InvokeAsync("UserList", new object[0], this.UserListOperationCompleted, userState);
    }
    
    private void OnUserListOperationCompleted(object arg) {
        if ((this.UserListCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.UserListCompleted(this, new UserListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UserLoad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string UserLoad(string ID) {
        object[] results = this.Invoke("UserLoad", new object[] {
                    ID});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginUserLoad(string ID, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("UserLoad", new object[] {
                    ID}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndUserLoad(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void UserLoadAsync(string ID) {
        this.UserLoadAsync(ID, null);
    }
    
    /// <remarks/>
    public void UserLoadAsync(string ID, object userState) {
        if ((this.UserLoadOperationCompleted == null)) {
            this.UserLoadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUserLoadOperationCompleted);
        }
        this.InvokeAsync("UserLoad", new object[] {
                    ID}, this.UserLoadOperationCompleted, userState);
    }
    
    private void OnUserLoadOperationCompleted(object arg) {
        if ((this.UserLoadCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.UserLoadCompleted(this, new UserLoadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void PictureAddCompletedEventHandler(object sender, PictureAddCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class PictureAddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal PictureAddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public System.Guid Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((System.Guid)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void PictureDeleteCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void PictureLoadCompletedEventHandler(object sender, PictureLoadCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class PictureLoadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal PictureLoadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public byte[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((byte[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void PictureListCompletedEventHandler(object sender, PictureListCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class PictureListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal PictureListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public System.Guid[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((System.Guid[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void CommentSaveCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void CommentLoadCompletedEventHandler(object sender, CommentLoadCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CommentLoadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal CommentLoadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void UserAddCompletedEventHandler(object sender, UserAddCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class UserAddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal UserAddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public System.Guid Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((System.Guid)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void UserDeleteCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void UserListCompletedEventHandler(object sender, UserListCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class UserListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal UserListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public System.Guid[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((System.Guid[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void UserLoadCompletedEventHandler(object sender, UserLoadCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class UserLoadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal UserLoadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
