
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebSinema.index" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="atk" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">
   

    <form id="frmMain" runat="server">


     <!--search-->

     <div class="d-flex justify-content-center" >
             
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager> 
        <asp:Label Text="Search Movei:" runat="server"  />
        <asp:TextBox ID="txtSearch" class="ml-1" runat="server" width="400" /> 
           <div class="btn  glyphicon glyphicon-search">
           <asp:Button ID="BtnSearch" OnClick="BtnSearch_Click" runat="server" Text="search" class="btn "  /> 
            </div>
    
    
         
    <atk:AutoCompleteExtender ID="txtSearch_AutoCompleteExtender"
        runat="server" TargetControlID="txtSearch"
        ServicePath="WebService.asmx"
        ServiceMethod="GetMoveiNameList"
        CompletionInterval="100" EnableCaching="false" CompletionSetCount="10"
        MinimumPrefixLength="1" FirstRowSelected="false">
    </atk:AutoCompleteExtender>
</div>
         
  <div class="row"><div class="col-md-6">                   
    <div class="row" id="allCards">
    <Div id="form1" runat="server" class="col-md-12">
<label class="mt-2 h3 text-center text-primary text-justify">The popolar moveis </label>
  <div class="card-deck  mt-3">
      
      <div class="card border-danger mb-3 "  id="card1" runat="server" onclick="runButton1()">
          <div class="card-header bg-danger " >
              <Label runat="server" id="lblN3_1" class="card-title h6 "></Label>
          </div>
          <div class="card-body" >
              <p runat="server" id="lblI3_1" ></p>
           <label> Rating: <span runat="server"  id="lblR3_1" class="card-text h6 mt-1"></span> </label>
            <label>Janer:  <span runat="server" id="lblJ3_1" class="card-text h6 mt-1"></span></label>
              <div style="display:none">
              <asp:Button  ID="card11" OnClick="getDetails1_Click"  runat="server"  />
            </div>
          </div>
          
      </div>
         
     <div class="card border-danger mb-3"  id="card2" onclick="runButton2()">
          <div class="card-header bg-danger">
              <Label runat="server" id="lblN3_2" class="card-title h6"></Label>
          </div>
          <div class="card-body">
              <p runat="server" id="lblI3_2"  ></p>
              <label>Ratingg: <span runat="server" id="lblR3_2" class="card-text h6 mt-1 "> </span></label>
              <label>Janer: <span runat="server" id="lblJ3_2" class="card-text h6 mt-1 "></span> </label>
              <div style="display:none">
               <asp:Button  ID="card22" OnClick="getDetails2_Click" runat="server" />
                </div>
              
          </div>
          
      </div>
      <div class="card border-danger mb-3"  id="card3" onclick="runButton3()">
          <div class="card-header bg-danger">
              <p runat="server"  id="lblN3_3" class="card-title h6"></p>
          </div>
          <div class="card-body">
              <p runat="server" id="lblI3_3"></p>
            <label>Rating: <span runat="server" id="lblR3_3" class="card-text h6 mt-1"> </span></label> 
              <label>Janer: <span runat="server" id="lblJ3_3" class="card-text h6 mt-1" > </span></label>
              <div style="display:none">
                    <asp:Button Text="get details" ID="card33" OnClick="getDetails3_Click" runat="server" />
               </div>
          </div>
          
      </div>

  </div>
       </div>
           </div>          

    
        <div class="row">
            <div class="col-md-12">
        <div class="card border-primary mt-3 " id="cardDetails">
          <div class="card-header bg-danger">
              <h4 class="card-title">Details Movei</h4>
          </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
          <div class="card-body container">
              
            <%--  <p  runat="server" id="imgDetails" ></p>--%>
              </div>
              <table class="ml-2 col-11 tabel">
                  <tr>
                      <th runat="server" id="moveiName" class="ml-1">MoveiName</th>
                      <th><p runat="server" id="imgDetails" class="text-right"> </p></th>
                  </tr>
                  <tr>
                      <td runat="server" class="m-1">MovieDirect</td>
                      <td id="moveiDirect" runat="server" class="ml-2"></td>
                  </tr>
                   <tr>
                      <td runat="server" class="ml-1">Rating</td>
                      <td id="rating" runat="server"></td>
                  </tr>
                   <tr>
                      <td runat="server" class="ml-1">Janer</td>
                      <td id="janer" runat="server">
                         
                       </td>
                  </tr>
                   <tr>
                      <td runat="server" class="ml-1">Description</td>
                      <td  id="description" runat="server" class="text-justify " ></td>
                  </tr>
                   </table>
                   
                       
                      <div runat="server" class="row m-3"> 
                          <asp:Button id="btnShowFeedback" class="btn btn-primary " runat="server" Text="show Feedback"  />  
                       <asp:Button id="btnAddfeadback" class="btn btn-primary ml-2" runat="server" Text="Add Feedback"  />  
                  <asp:Button id="BtnShowTimes" class="btn btn-primary ml-2" runat="server" Text="Show Times And Places" OnClick="BtnShowTimes_Click" />

                      </div>
                  
                   
                  
                   
             
                    
                    </ContentTemplate>
                 <Triggers>
                     <asp:AsyncPostBackTrigger ControlID="card11" />
                <asp:AsyncPostBackTrigger ControlID="card22" />
                <asp:AsyncPostBackTrigger ControlID="card33" />
                     <asp:AsyncPostBackTrigger ControlID="BtnSearch" />
            </Triggers>
            </asp:UpdatePanel>
          </div>
    </div>
            </div>

   
         <div id="divFeedback" class="col-md-12 mt-3">
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
             <ContentTemplate>             
       
        
         <div id="gvShowFeedback">
            <asp:GridView ID="gvFeedback" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">

                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="FeedbackText" HeaderText="Feedback" ReadOnly="True" SortExpression="Name" />
                        <asp:BoundField DataField="Rating" HeaderText="Rating" ReadOnly="True" />
                        
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
             </div>
    
                   </ContentTemplate>
                 <Triggers>
                     <asp:AsyncPostBackTrigger ControlID="btnRiting" />
              
            </Triggers>
            
        </asp:UpdatePanel>  

             <div id="wrightFeadback" class="mt-3 mb-5">
                  <asp:TextBox runat="server"
                      class="col-md-12 "
        ID="txtFeedback" 
        TextMode="MultiLine" 
        Columns="200" 
        Rows="7" 
        PlaceHolder="Add description" />
    
    <ajaxToolkit:HtmlEditorExtender 
        ID="htmlEditorExtender1" 
        TargetControlID="txtFeedback"        
        runat="server" >            
    </ajaxToolkit:HtmlEditorExtender>
            
              <asp:TextBox runat="server"
                ID="txtRating"     
                placeholder="add rating" />
             <asp:Button runat="server" OnClick="BtnAdd_Click" Text="add" CssClass="btn btn-primary" id="btnRiting"/>
             </div>
         </div>
   
</div>

<div id="allMovei" class="mt-4 col-md-5 offset-1" >
    <h4 class="text-primary">All Moveis</h4>
        <asp:GridView ID="GvAll" runat="server" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="SelectedRow" ToolTip="select Movei">
            <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
            <Columns>
                <asp:BoundField DataField="MoveiName" HeaderText="Name Movei"></asp:BoundField>
                <asp:BoundField DataField="RatingAvg" HeaderText="Rating"></asp:BoundField>
                <asp:TemplateField HeaderText="Poster">
                    <ItemTemplate>
                        <asp:Image runat="server" ImageUrl='<%# "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("MoveiImage")) %>' ID="Image" Width="80" Height="80"></asp:Image>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Janer" HeaderText="Janer"></asp:BoundField>
            </Columns>
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
    </div>
    
</div>
       
        </form>
  
     <script>
         
         $(document).ready(function () {
             
             $("#cardDetails").hide();
              $("#wrightFeadback").hide();

             
         
             
         $("#allCards").on("click", function () {
             $("#cardDetails").show();
            // $("#wrightFeadback").hide();
             // $("#divFeedback").hide();
             $("#wrightFeadback").show();
         });

          

             $("#ContentMain_BtnSearch").on("click", function () {
                 
                 $("#cardDetails").show();
                   $("#wrightFeadback").show();
                 
            //  $("#divFeedback").hide();
             });

            $("#ContentMain_btnAddfeadback").on("click", function () {
                alert();
         $("#ContentMain_wrightFeadback").show();
         });
             $("#ContentMain_btnShowFeedback").on("click", function () {
                 alert();
                // $("#ContentMain_gvShowFeedback").show();
                $("#divFeedback").show();
         }); 
        
         });
         function btnAddfeadback() {
        $("#wrightFeadback").show();
         }

         function btnShowfeadback() {
             console.log(s)
        $("#gvShowFeedback").show();
         }
   
            
    function runButton1() {
        document.getElementById('ContentMain_card11').click()
        // $("#cardDetails").show();
         }
           function runButton2() {
               document.getElementById('ContentMain_card22').click()
            //    $("#cardDetails").show();
         }
           function runButton3() {
               document.getElementById('ContentMain_card33').click()
            //    $("#cardDetails").show();
}
</script>
 </asp:Content>


