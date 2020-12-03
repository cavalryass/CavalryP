<%@ Page Language="C#"  MasterPageFile="~/MasterForm/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="Loans1Form.aspx.cs" Inherits="CavalryP.LoansFolder.Loans1Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderClient" runat="server">
    <style type="text/css">
   
     
     .regform{
            width:1400px;
            background-color:rgba(196, 187, 187,0.3);            
            margin:auto;
            color:#5D7B9D;
            padding:10px 0px 10px 0px;
            text-align:center;
            border-radius:15px 15px 0px 0px;
        }
     .main{
            background-color:rgba(196, 187, 187,0.2);
            width:1400px;
            margin:auto;
        }
     .readCSS{           
         width: 100%;
         height:20px;
         padding: 12px 20px;
         margin: 8px 0;
         box-sizing: border-box;
         border-color:#5D7B9D;
         border-style:solid;
         border-width:2px;
         border-radius: 12px;
         background-color:#F9F9F9;
         color:#5D7B9D;
         }
      .myButton{
  font-size: 25px;
  border: none;
  padding: 8px 20px;
  position: relative;
 
  color:black;
  background-color:transparent;
 
}
.myButton:hover{
    background-color:#5D7B9D;
     color:white;
}
        .auto-style1 {
            width: 174px;
        }
        .auto-style2 {
            width: 1290px;
        }
     
        .auto-style4 {
            width: 295px;
        }
        .auto-style6 {
            margin-left: 41px;
        }
     
        .auto-style7 {
            height: 28px;
        }
     
     </style>
    <button  class="myButton" style="margin-left:20px;" runat="server" onserverclick="Back_Click"><asp:Label ID="LoansB" runat="server" Text="Back" Font-Size="17px"    /></button>
   </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ClientContent" runat="server">
    <br />
           <br />
       <div id="ReadDetails" runat="server">
        <div>
<div class="regform"><h1>Application</h1>
            </div>
        <div class="main" style="color: #008CBA">
            
            <br />
            <br />


            <table class="auto-style6" style="color: #5D7B9D; font-weight: bold; font-size: 20px;">
                <tr>
                    <td colspan="4">Business Legal Name:</td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">
                    <asp:TextBox ID="BusinessLegalName" runat="server" CssClass="readCSS"   Height="16px"  Width="1252px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39" colspan="2">Business Legal Entity - DBA - If Applicable:</td>
                    <td class="auto-style39" colspan="2">Pirmary Contact</td>
                </tr>
                <tr>
                    <td colspan="2" style="color: #008CBA">
                    <asp:TextBox ID="dbaName" CssClass="readCSS" runat="server"  Height="16px"  Width="439px"></asp:TextBox>
                    </td>
                    <td colspan="2">
                    <asp:TextBox ID="PrimaryContact" CssClass="readCSS" runat="server"  Height="16px" Width="440px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">
                        <table class="nav-justified" style="color: #5D7B9D; font-weight: bold; font-size: 20px;">
                            <tr>
                                <td>Tax I.D:</td>
                                <td>Social Security</td>
                                <td>Telephone:</td>
                                <td>Email Addreess:</td>
                            </tr>
                            <tr>
                                <td>
                    <asp:TextBox ID="taxid" runat="server" CssClass="readCSS"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="sstxt" runat="server" CssClass="readCSS"  Height="16px"  Width="240px" ></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="telephone" CssClass="readCSS" runat="server"  Height="16px" Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="emailAddress" CssClass="readCSS" runat="server"  Height="16px" Width="240px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7"></td>
                                <td class="auto-style7"></td>
                                <td class="auto-style7"></td>
                                <td class="auto-style7"></td>
                            </tr>
                            <tr>
                                <td>Street Address (no P.O Boxes):</td>
                                <td>City:</td>
                                <td>State:</td>
                                <td>Zip:</td>
                            </tr>
                            <tr>
                                <td>
                    <asp:TextBox ID="Address" runat="server" CssClass="readCSS"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="city" runat="server" CssClass="readCSS"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="state" runat="server" CssClass="readCSS"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="zip" runat="server" CssClass="readCSS"  Height="16px" Width="240px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                    <asp:CheckBox ID="own" runat="server" AutoPostBack="true" OnCheckedChanged="own_CheckedChanged"  Text="Own" onclick="return false;" />
                                    <asp:CheckBox ID="rent" runat="server" AutoPostBack="true" OnCheckedChanged="rent_CheckedChanged" Text="Rent" onclick="return false;" />
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>Mailing Address (if different):</td>
                                <td>City:</td>
                                <td>State:</td>
                                <td>Zip:</td>
                            </tr>
                            <tr>
                                <td>
                    <asp:TextBox ID="mailAddress" runat="server" CssClass="readCSS"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="mailCity" runat="server" CssClass="readCSS"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="mailState" runat="server" CssClass="readCSS"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="mailZip" runat="server" CssClass="readCSS"  Height="16px" Width="240px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">
                        <table class="auto-style2" style="color: #5D7B9D">
                            <tr>
                                <td>
                                <asp:CheckBox ID="Ccorporation" runat="server" AutoPostBack="true"   Text="C Corporation" />
                                </td>
                                <td>
                                <asp:CheckBox ID="SCorporation" runat="server" AutoPostBack="true"   Text="S Corporation" />
                                </td>
                                <td>
                                <asp:CheckBox ID="LLC" runat="server" AutoPostBack="true"   Text="Limited Liability Company" />
                                </td>
                                <td>
                                <asp:CheckBox ID="businessIndividual" runat="server" AutoPostBack="true"  Text="Business Individual" />
                                </td>
                                <td colspan="2">
                                <asp:CheckBox ID="NonProfit" runat="server" AutoPostBack="true"   Text="Non-Profit" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                <asp:CheckBox ID="soleProprietor" runat="server" AutoPostBack="true"   Text="Sole Proprietor" />
                                </td>
                                <td>
                                <asp:CheckBox ID="limitedPartnership" runat="server" AutoPostBack="true"  Text="Limited Partnership" />
                                </td>
                                <td>
                                <asp:CheckBox ID="generalPartnership" runat="server" AutoPostBack="true"   Text="General Partnership" />
                                </td>
                                <td>
                                <asp:CheckBox ID="LLP" runat="server" AutoPostBack="true"   Text="LLP" />
                                </td>
                                <td>
                                <asp:CheckBox ID="other" runat="server" AutoPostBack="true"   Text="Other" />
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td class="auto-style1">
                                <asp:TextBox ID="othertxt" CssClass="readCSS" runat="server"  Width="130px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA" class="auto-style7">
                        <table class="nav-justified" style="color: #5D7B9D; font-weight: bold; font-size: 20px;">
                            <tr>
                                <td colspan="2">Date Business Established:</td>
                                <td>State of Incorporatin:</td>
                                <td>Number of Employees After Financing:</td>
                            </tr>
                            <tr>
                                <td>Month<asp:TextBox ID="month" runat="server" CssClass="readCSS"  Height="16px"  Width="80px"></asp:TextBox>
                                </td>
                                <td>Year<asp:TextBox ID="year" runat="server" CssClass="readCSS"  Height="16px"  Width="80px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="incorporationState" runat="server" CssClass="readCSS"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="employeesNum" runat="server" CssClass="readCSS"   Width="240px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style38">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">Explain Nature of Business:</td>
                </tr>
                <tr>
                    <td class="auto-style39" colspan="4" style="color: #008CBA">
                    <asp:TextBox ID="explain" runat="server" CssClass="readCSS"  Height="46px" Width="1252px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">
                        <table class="auto-style2" style="color: #5D7B9D">
                            <tr>
                                <td>
                                <asp:CheckBox ID="manufacturing" runat="server" AutoPostBack="true"   Text="Manufacturing" />
                                </td>
                                <td>
                                <asp:CheckBox ID="wholesale" runat="server" AutoPostBack="true"   Text="Wholesale" />
                                </td>
                                <td>
                                <asp:CheckBox ID="retail" runat="server" AutoPostBack="true"   Text="Retail" />
                                </td>
                                <td>
                                <asp:CheckBox ID="service" runat="server" AutoPostBack="true"   Text="Service" />
                                </td>
                                <td>
                                <asp:CheckBox ID="agricultural" runat="server" AutoPostBack="true"  Text="Agricultural" />
                                </td>
                                <td>
                                <asp:CheckBox ID="construction" runat="server" AutoPostBack="true"  Text="Construction" />
                                </td>
                                <td>
                                <asp:CheckBox ID="other2" runat="server" AutoPostBack="true"   Text="Other" />
                                </td>
                                <td>
                                <asp:TextBox ID="othertxt2" runat="server" CssClass="readCSS"   Width="130px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">List any Affiliated Companies</td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">
                    <asp:TextBox ID="listCompanies" runat="server" CssClass="readCSS"  Height="30px"  Width="1252px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="color: #008CBA">&nbsp;</td>
                </tr>
            </table>
            






       
        </div>
        </div>
       </div>
  
        <br />
     <div style="text-align: right">
          <asp:Button ID="Button2" runat="server" BackColor="White" Font-Size="Medium" ForeColor="Black" Height="34px" OnClick="Submit1_Click" Text="Submit" Width="97px" />
     </div>
           <asp:Label ID="message" runat="server"></asp:Label>
        <br />
                   
        <br />
        <br />       
        
          
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ClientFooter" runat="server">
</asp:Content>
