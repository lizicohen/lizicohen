<%@ Page Title="Times and Places" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrdersMoveis.aspx.cs" Inherits="WebSinema.ViewPages.OrdersMoveis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">
    
  
    <form id="frmTimes" runat="server">
        <h2><%: Title %>.</h2>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div id="form1" runat="server">
            <%--<div class="row">
               <asp:SqlDataSource ID="DBTime" runat="server"
                    ConnectionString="<%$ ConnectionStrings:DB12%>"
                    SelectCommand="select * from TimeAndPlace">
                     
                    
                    <UpdateParameters>
                        <asp:Parameter Name="Place" />
                        <asp:Parameter Name="Date" />

                    </UpdateParameters>
            
                </asp:SqlDataSource>
                <asp:ListView id="DBTime1" runat="server" DataSourceID="DBTime"  GroupItemCount="5">
                    <LayoutTemplate>
                        
                        <table class="tabel table-responsive table-hover">
                            <tr class="d-flex" runat="server">
                                <th class="col-2" runat="server">Date</th>
                                <th class="col-2" runat="server">Time</th>
                                <th class="col-4" runat="server">Place</th>
                                <th class="col-2" runat="server">Region</th>
                                <th class="col-2" runat="server">Price</th>
                                <th class="col-3" runat="server"> Cards Left</th>
                                <th class="col-1" runat="server"></th>

                            </tr>

                            <tr runat="server" id="groupPlaceholder"></tr>

                        </table>
                        <asp:DataPager runat="server" PageSize="20">
                            <Fields>

                                <asp:NextPreviousPagerField ShowFirstPageButton="true"
                                    ShowLastPageButton="true"
                                    FirstPageText="|&lt;&lt"
                                    LastPageText=" &gt;&gt|"
                                    NextPageText=" &gt;"
                                    PreviousPageText="&lt; " />
                            </Fields>
                        </asp:DataPager>
                            </div>
                    </LayoutTemplate>

                    <GroupTemplate>
                        <tr runat="server" id="SinemaRow">
                            <td runat="server" id="itemPlaceholder"></td>
                        </tr>
                    </GroupTemplate>

                    <ItemTemplate>
                        <tr class="d-flex" runat="server" >

                            <td  class="col-2">
                                <asp:Label ID="lblDate" runat="server" Text='<%#Eval("Date" ,"{0:d}")%>' />
                            </td>
                            <td class="col-2"> 
                                <asp:Label ID="lblTime" runat="server" Text='<%#Eval("Date","{0:hh.mm tt}")%>'/>
                            </td>
                            <td class="col-4">
                                <asp:Label ID="lblPlace" runat="server" Text='<%#Eval("Place")%>' />
                            </td>
                            <td class="col-2">
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("Region")%>' />
                            </td>
                            <td class="col-2">
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("PriceCard")%>' />
                            </td>
                            <td class="col-2">
                                <asp:Label ID="Label3" runat="server" Text='<%#Eval("AmountCardsLeft")%>' />
                            </td>
                            <%--<td class="col-1">
                                <asp:LinkButton ID="btnBuy" Text="Buy" runat="server" CommandArgument='<%#Eval("OrdersID")%>'  OnCommand="BtnBuy_Command"/>
                            </td>--%>
       <%--                 </tr>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>

        <div>
           --%>
               <%--<asp:GridView ID="ListView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Place" HeaderText="Place" ReadOnly="True" SortExpression="Name" />
                        <asp:BoundField DataField="Date" HeaderText="Date" ReadOnly="True" />
                        
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
             --%>
            <div class="container">
                <div id="timesMoveis" runat="server">
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        
        <asp:BoundField DataField="Date" HeaderText="Date" DataFormatString="{0:d}" ItemStyle-Width="100px" >
<ItemStyle Width="100px"></ItemStyle>
        </asp:BoundField>
         <asp:BoundField DataField="Date" HeaderText="Time" DataFormatString="{0:hh.mm tt}" ItemStyle-Width="100px" >
<ItemStyle Width="100px"></ItemStyle>
        </asp:BoundField>
         <asp:BoundField DataField="Date" HeaderText="Day" DataFormatString="{0:ddd}"  ItemStyle-Width="90px">
<ItemStyle Width="90px"></ItemStyle>
        </asp:BoundField>
         <asp:BoundField DataField="Place" HeaderText="Place"  ItemStyle-Width="200px" >
<ItemStyle Width="200px"></ItemStyle>
        </asp:BoundField>
         <asp:BoundField DataField="Region" HeaderText="Region"  ItemStyle-Width="90px" >
<ItemStyle Width="90px"></ItemStyle>
        </asp:BoundField>
         <asp:BoundField DataField="PriceCard" HeaderText="Price"  ItemStyle-Width="60px" >
<ItemStyle Width="60px"></ItemStyle>
        </asp:BoundField>
         <asp:BoundField DataField="AmountCardsLeft" HeaderText="Card Left"  ItemStyle-Width="90px" >
<ItemStyle Width="90px"></ItemStyle>
        </asp:BoundField>
        <asp:TemplateField HeaderText="Cards Buy" ItemStyle-Width="110">
            <ItemTemplate>
                <asp:TextBox ID="txtCArdToBuy" runat="server" Text=1 Width=70% Input="number"/>
                
            </ItemTemplate>

<ItemStyle Width="110px"></ItemStyle>
        </asp:TemplateField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:Button ID="Buy" Text="Buy" runat="server" CommandName="Buy" CommandArgument="<%# Container.DataItemIndex %>" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>




        

 <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>--%>
               <div class="card border-primary mt-3 " runat="server" id="cardDetails" style="display:none" >
          <div class="card-header bg-danger">
              <h4 class="card-title ml-2">Details Orders</h4>
          </div>
           
          <div class="card-body container">
              
              </div>
              <table class="container">
                  <tr>
                      <th>MoveiName</th>
                      <th runat="server" id="txtmoveiName"></th>
                  </tr>
                  <tr>
                      <td >Date</td>
                      <td id="txtDate" runat="server"></td>
                  </tr>
                   <tr>
                      <td ">Place</td>
                      <td id="txtPlace" runat="server"></td>
                  </tr>
                    <tr>
                      <td >Price for card</td>
                      <td id="txtPrice" runat="server"></td>
                  </tr>
                   <tr>
                      <td >number cards</td>
                      <td id="txtNumCards" runat="server">
                         
                       </td>
                  </tr>
                  <tr>
                      <td >Sum for pay</td>
                      <td id="txtSum" runat="server">
                         
                       </td>
                  </tr>
                  <tr>
                      <th>user name</th>
                      <th runat="server" id="txtUser"></th>
                  </tr>
                   <tr>
                      <td >last  4 digits of credit card</td>
                      <td  id="txtCreditCard" runat="server"></td>
                  </tr>
                  <tr>
                       
                      <td runat="server" > <asp:CheckBox id="cbAgree" runat="server" /> I'm agree to all details order. </td>
                   
                   </tr>
                   <tr>
                       
                      <td runat="server" > <asp:Button id="btnPay" class="btn btn-info" runat="server" Text="Send" OnClick="BtnPay_Click" />  </td>
                   
                   </tr>
                  
                   
              </table>
</div>
<%--                       </ContentTemplate>
                 <Triggers>
                     <asp:AsyncPostBackTrigger ControlID="Buy" />
              
            </Triggers>
            </asp:UpdatePanel>--%>
</div>

        </div>

        </div>


    </form>
    <script src="../Scripts/jquery-3.3.1.js"></script>
  <script>
     // $(document).ready(function () {
     //     $("#ContentMain_cardDetails").hide();   
     // });
     // $("#imesMoveis").on("click", function(){
      ///    $("#cardDetails").show();   
     // });
  </script>
</asp:Content>
