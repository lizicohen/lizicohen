<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllUsers.aspx.cs" Inherits="WebSinema.ViewPages.AllUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">
 <form runat="server" id="frmMain">

    

     <asp:GridView ID="GVUsers" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
         <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

         <EditRowStyle BackColor="#2461BF"></EditRowStyle>

         <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>

         <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>

         <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White"></PagerStyle>

         <RowStyle BackColor="#EFF3FB"></RowStyle>

         <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

         <SortedAscendingCellStyle BackColor="#F5F7FB"></SortedAscendingCellStyle>

         <SortedAscendingHeaderStyle BackColor="#6D95E1"></SortedAscendingHeaderStyle>

         <SortedDescendingCellStyle BackColor="#E9EBEF"></SortedDescendingCellStyle>

         <SortedDescendingHeaderStyle BackColor="#4870BE"></SortedDescendingHeaderStyle>
     </asp:GridView>
 </form>
        

</asp:Content>
