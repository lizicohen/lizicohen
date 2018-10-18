<%@ Page Title="EnterManager" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddMovei.aspx.cs" Inherits="WebSinema.ViewPages.AddMovei" %>
<%@ Register assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="atk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 141px;
        }
        .auto-style2 {
            width: 451px;
        }
        .auto-style3 {
            display: block;
            font-size: 1rem;
            line-height: 1.5;
            color: #495057;
            background-clip: padding-box;
            border-radius: .25rem;
            transition: none;
            border: 1px solid #ced4da;
            background-color: #fff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">


 <h3 class="mt-3 ml-3">Add Movei and Time</h3>
        <form runat="server" id="frmAddMovei" >
           
   <asp:ScriptManager  runat="server" ID="ScriptManager1" ></asp:ScriptManager>

<div class="row">
    
     

   
           
        <div class="card border-primary mt-3" style="max-width: 25rem;" id="cardAddMuvei">
            <div class="card-header bg-danger">
                <h4 class="card-title">Add Muvei</h4>
            </div>
            <div class="card-body">
                <%--<ajaxToolkit:Rating ID="ThaiRating" runat="server"
                    CurrentRating="2"
                    MaxRating="5"
                    StarCssClass="ratingStar"
                    WaitingStarCssClass="savedRatingStar"
                    FilledStarCssClass="filledRatingStar"
                    EmptyStarCssClass="emptyRatingStar" RatingAlign="Vertical" RatingDirection="RightToLeftBottomToTop">

          </ajaxToolkit:Rating>
       --%>
             
                <table>
                    <tr>
                        <th runat="server" class="auto-style2">Movei ID</th>
                        <th runat="server">
                            <asp:TextBox ID="txtMuveiID" runat="server" TextMode="number" CssClass="auto-style3" MaxLength="10" Width="186px"></asp:TextBox>
                        </th>
                    </tr>
                    <tr >
                        <th runat="server" class="auto-style2">Movei Name</th>
                        <th runat="server" class="mt-2">
                            <asp:TextBox ID="txtMuviName" runat="server"></asp:TextBox>
                        </th>
                    </tr>
                      <tr class="mt-1">
                        <td runat="server" class="auto-style2">MovieDirect</td>
                        <td runat="server">
                            <asp:TextBox ID="txtDirect" runat="server"></asp:TextBox></td>
                    </tr>

                      <tr class="mt-1">
                        <td runat="server" class="auto-style2">Janer</td>
                        <td runat="server">
                            <asp:TextBox ID="txtJaner" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr class="mt-1">
                        <td runat="server" class="auto-style2">Poster</td>
                        <td>
                           <asp:FileUpload ID="fileUpload" runat="server" class="ml-2 mt-1"/>
                    </tr>
                       
                        
  
                </table>
                
                 <asp:Label runat="server" class="auto-style1 mt-1">Discription</asp:Label>
                <asp:TextBox runat="server"
        ID="txtDescription" 
        TextMode="MultiLine" 
        Columns="200" 
        Rows="10" 
        PlaceHolder="Add description" Width="332px" />
    
    <ajaxToolkit:HtmlEditorExtender 
        ID="htmlEditorExtender1" 
        TargetControlID="txtDescription"        
        runat="server" >            
    </ajaxToolkit:HtmlEditorExtender>
<%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMuveiID" forecolor="Red" ErrorMessage="Required ID"></asp:RequiredFieldValidator>--%>
                <asp:Button runat="server" CssClass="btn btn-primary m-3" OnClick="AddMoveis_Click" ID="AddMoveis" Text="Add Moveis" />
            </div>
        </div>
   
        <div class="card border-primary mt-3 ml-5" style="max-width: 20rem;" id="cardAddTime">
            <div class="card-header bg-danger">
                <h4 class="card-title">Add Time And Place</h4>
            </div>
            <div class="card-body">

                <table>
                    <tr>
                        <th runat="server">Muvei ID</th>
                        <th runat="server">
                             <asp:TextBox ID="txtIdMuvei" runat="server" TextMode="number" CssClass="auto-style3" MaxLength="10" Width="186px"></asp:TextBox>
          
                        </th>
                    </tr>
                     <tr>
                        <td runat="server">Price</td>
                        <td runat="server">
                            <asp:TextBox ID="txtPrice" type="number" runat="server"></asp:TextBox></td>
                    </tr>

                    <tr>
                        <th runat="server">Place</th>
                        <th runat="server">
                            <asp:TextBox ID="txtPlace" runat="server"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th runat="server">Region</th>
                        <th runat="server">
                            <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <td runat="server">Date</td>
                        <td runat="server">
                            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>

                            <atk:CalendarExtender ID="txtDate_CalendarExtender" runat="server" TargetControlID="txtDate" />

                        </td>
                    </tr>

                    <tr>
                        <td runat="server">Hour:</td>
                        <td runat="server">
                            <asp:TextBox ID="txtHour" type="time" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td runat="server">Number card to sell</td>
                        <td runat="server">
                            <asp:TextBox ID="txtNumsell" type="number" runat="server"></asp:TextBox></td>
                    </tr>

                </table>
                </div>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtIdMuvei" forecolor="Red" ErrorMessage="Required ID"></asp:RequiredFieldValidator>--%>
              <%--  <div class="form-group row">
                    <label>
                        File input</>
        <asp:input type="file" id="userImg" class="form-control-file" />
                        <small class="form-text text-muted">Max 25mb size</small>
                </div>--%>
             <asp:Button runat="server" CssClass="btn btn-primary" OnClick="AddTime_Click" ID="AddTime" Text="Add Time and Place" />
            
            </div>
        </div>
             
    </form>

</asp:Content>