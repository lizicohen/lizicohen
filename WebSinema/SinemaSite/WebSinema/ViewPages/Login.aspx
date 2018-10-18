<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebSinema.ViewPages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">
    <h2><%: Title %></h2>
    <form id="frmLogin" runat="server">
   <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Enter your user name and password.</h4>
                    <hr />
                  <div class="form-group" dir="ltr">
            <asp:Label runat="server" AssociatedControlID="txtLogUser" CssClass="control-label">User name</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="txtLogUser" CssClass="form-control" placeholder="Enter userName"/>
                
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtLogPass" CssClass=" control-label">Password</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="txtLogPass" TextMode="Password" CssClass="form-control" placeholder="Enter Password"/>
               
            </div>
        </div>
                  
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <div class="checkbox">
                                <asp:CheckBox runat="server" ID="cbRememberMe" />
                                <asp:Label runat="server" AssociatedControlID="cbRememberMe">Remember me?</asp:Label>
                                <a href="Register.aspx" runat="server" class="ml-5" >  I'm not register yet</a>
                            </div>
                        </div>
                    </div>

                    <div id="errMsg" runat="server" style="display:none">
                        <div class="alert alert-danger col-md-8">
                            <strong>Error!</strong>  the user Name or password isn't correct! 
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="LogIn_Click" Text="Log in" CssClass="btn btn-primary " />
                        </div>
                    </div>
                </div>
              
            </section>
        </div>

    </div> 
  </form>
</asp:Content>
