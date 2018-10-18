<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebSinema.ViewPages.Register" %>
<%@ Register assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="atk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">
 <h1 class="mt-3 ml-3">Register</h1>
        <form runat="server" id="frmRegister" onSubmit="validationReg()" >
           
   <asp:ScriptManager  runat="server" ID="ScriptManager1" ></asp:ScriptManager>

<div class="row">
    <div class="col-md-6">
  <div class="form-group" dir="ltr">
            <asp:Label runat="server" AssociatedControlID="txtNewUserName" CssClass="control-label">User name</asp:Label>
            <div class="col-md-8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="txtNewUserName" runat="server" forecolor="Red" ErrorMessage="Required user name"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtNewUserName" CssClass="form-control" />
                
            </div>
        </div>
         
         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNewPassword" CssClass=" control-label">Password</asp:Label>
            <div class="col-md-8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" forecolor="Red" ControlToValidate="txtNewPassword" ErrorMessage="Required password"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtNewPassword" TextMode="Password" CssClass="form-control" MaxLength="30"  />
               
                <atk:PasswordStrength ID="txtNewPassword_PasswordStrength" runat="server" TargetControlID="txtNewPassword" />
               
            </div>  
        </div>
              
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtConfirmPassword" CssClass=" control-label">Confirm password</asp:Label>
            <div class="col-md-8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtConfirmPassword" forecolor="Red" ErrorMessage="Required confirm password"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password"  CssClass="form-control" MaxLength="20"/>
              
            </div>
        </div>    
              
		 <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtnewEmail" CssClass=" control-label">E-mail</asp:Label>
            <div class="col-md-8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewEmail" forecolor="Red" ErrorMessage="Required Email"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtnewEmail" TextMode="email" CssClass="form-control" />
             
            </div>
        </div>

		 <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNewTel" CssClass=" control-label">Tel</asp:Label>
            <div class="col-md-8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNewTel" forecolor="Red" ErrorMessage="Required Tel"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtNewTel" TextMode="number" CssClass="form-control" MaxLength="15"/>
              
            </div>
        </div>
      
            </div>
    <div class="col-md-6">
			<p class="h2">Details Credit Card</p>
			<div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNewfnPay" CssClass="control-label">First name wonner credit Card</asp:Label>
            <div class="col-md-8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNewfnPay" forecolor="Red" ErrorMessage="Required first name"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtNewfnPay"  CssClass="form-control" />
          </div>
            </div>
		     <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNewlnPay" CssClass=" control-label">Last name wonner credit Card</asp:Label>
            <div class="col-md-8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNewlnPay" forecolor="Red" ErrorMessage="Required last name"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtNewlnPay"  CssClass="form-control" />
            </div>
            </div>
        <div class="form-group mt-3">
                             <asp:RadioButtonList ID="imagecart" runat="server" CssClass="mt-3" RepeatDirection="Horizontal">
                                  <asp:ListItem Text='<img src="\Img\isracart.jpg" alt="isracart" Width="50px" class="ml-1"/>' Value="0" />
                                  <asp:ListItem Text='<img src="\Img\viza.png" alt="viza" Width="50px" class="ml-1" />' Value="1"/>
                                  <asp:ListItem Text='<img src="\Img\american.jpg" alt="american Express" Width="50px" class="ml-1"/>' Value="2"/>
                                  <asp:ListItem Text='<img src="\Img\diners.png" alt="diners" Width="50px" class="ml-1"/>' Value="3"/>
                                 <asp:ListItem Text='<img src="\Img\leumi.jpg" alt="leumi card" Width="50px" class="ml-1"/>' Value="4" />
                                 <asp:ListItem Text='<img src="\Img\mastercard.jpg" alt="mastercard" Width="50px" class="ml-1"/>' Value="5"/> 
                             </asp:RadioButtonList>
                </div>
        <div class="row">
             <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNewExpirty" CssClass=" control-label">Expirty Date credit Card</asp:Label>
            <div class="col-md-12">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" forecolor="Red" ControlToValidate="txtNewExpirty" ErrorMessage="Required Expirty"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtNewExpirty"  TextMode="Month" CssClass="form-control" />
            </div>
            </div>
         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtCvv" CssClass=" control-label">Cvv</asp:Label>
            <div class="col-md-8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtCvv" forecolor="Red" ErrorMessage="Required Cvv"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtCvv" TextMode="Number" MaxLength="3"  CssClass="form-control" />
            </div>
           </div>
        </div>
	         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNewIdWoner" CssClass=" control-label">Id card wonner Credit Card</asp:Label>
            <div class="col-md-8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtNewIdWoner" forecolor="Red" ErrorMessage="Required id"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtNewIdWoner" TextMode="Number" MaxLength="9" CssClass="form-control" />
                        </div>

            </div>
		     <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNewNumCard" CssClass=" control-label">Number Credit Card</asp:Label>
            <div class="col-md-8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtNewNumCard" forecolor="Red" ErrorMessage="Required number card"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtNewNumCard" TextMode="Number" MaxLength="16" CssClass="form-control" />
            </div>
        </div>
		    
        </div>
        </div>
            <div class="col-md-2 mt-5">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-primary mb-5" />
            </div>
  
            <script src="../Scripts/jquery-3.3.1.js"></script>
     <script src="registerValid.js"></script>

    </form>

</asp:Content>
