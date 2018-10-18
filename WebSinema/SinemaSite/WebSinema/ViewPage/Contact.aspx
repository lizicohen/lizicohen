<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebSinema.ViewPage.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentMain" runat="server">
    <h2><%: Title %>.</h2>
    <h3>concat with we</h3>
    <address>
       TelAviv, 125 Jerusalem street. 
        <abbr title="Phone">P:</abbr>
		03-570000    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>


  
</asp:Content>
