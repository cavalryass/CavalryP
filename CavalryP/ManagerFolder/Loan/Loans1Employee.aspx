<%@ Page Language="C#" MasterPageFile="~/MasterForm/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="Loans1Employee.aspx.cs" Inherits="CavalryP.ManagerFolder.Loan2.Loans1Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderClient" runat="server">
    <style>
     *{
         padding:0;
         margin:0;
         box-sizing:border-box;
     }
            .topnav {
  overflow: hidden;
  background-color: #e7e7e7;
}
.button {
  background-color: #e7e7e7;
  border: none;
  color: white;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 4px 2px;
  cursor: pointer;
}
.button:hover{
background-color: #008CBA;
}
.topnav .search-container {
  float: right;
}

.topnav input[type=text] {
  padding: 6px;
  margin-top: 8px;
  font-size: 17px;
  border: none;
}
.topnav .search-container button {
  float: right;
  padding: 6px 10px;
  margin-top: 8px;
  margin-right: 16px;
  background: #ddd;
  font-size: 17px;
  border: none;
  cursor: pointer;
}

.topnav .search-container button:hover {
  background: #ccc;
}

     
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
         border: none;
       
         }
     .editCss{            
         width: 100%;
         height:20px;
         padding: 12px 20px;
         margin: 8px 0;
         box-sizing: border-box;
         border-color:#5D7B9D;
         border-style:solid;
         border-width:2px;
         background-color:#F9F9F9;
         }
     .auto-style37 {
         width: 100%;
     }
     .auto-style38 {
            width: 238px;
        }
     .auto-style39 {
         height: 21px;
     }

        .auto-style45 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            padding: 12px 20px;
            margin: 8px 0;
            box-sizing: border-box;
        }
        .auto-style47 {
            width: 337px;
        }
        .auto-style48 {
            height: 21px;
            width: 337px;
        }
        .auto-style49 {
            width: 499px;
        }
        .auto-style50 {
            height: 21px;
            width: 499px;
        }

        .auto-style52 {
            width: 472px;
        }
        .auto-style53 {
            height: 21px;
            width: 472px;
        }

        .auto-style54 {
            width: 499px;
            height: 56px;
        }
        .auto-style55 {
            height: 56px;
        }

    </style>  
 <button  class="button" runat="server" onserverclick="Back_Click"><asp:Label ID="LoansB" runat="server" Text="Back" ForeColor="Black"  /></button>
   </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ClientContent" runat="server">
             <div class="col-3">
           
           <br />
           <br />
           <br />
       <div id="ReadDetails" runat="server">
        <div>
<div class="regform"><h1>Application</h1></div>
        <div class="main">
            






            <table class="auto-style37" style="color: #5D7B9D; font-weight: bold; font-size: 18px;">
                <tr>
                    <td class="auto-style54">Business Legal Name:</td>
                    <td colspan="3" class="auto-style55">
                    <asp:TextBox ID="BusinessLegalName" runat="server" CssClass="auto-style45" BackColor="Transparent"  Height="16px" ReadOnly="true" Width="508px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style49">Business Legal Entity - DBA - If Applicable</td>
                    <td class="auto-style47">
                    <asp:TextBox ID="dbaName" CssClass="readCSS" runat="server" BackColor="Transparent" Height="16px" ReadOnly="true" Width="282px"></asp:TextBox>
                    </td>
                    <td>Pirmary Contact</td>
                    <td class="auto-style52">
                    <asp:TextBox ID="PrimaryContact" CssClass="readCSS" runat="server" BackColor="Transparent" Height="16px" ReadOnly="true" Width="315px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style49">Tax I.D</td>
                    <td class="auto-style47">
                    <asp:TextBox ID="taxid" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                    <td>Social Security</td>
                    <td class="auto-style52">
                    <asp:TextBox ID="sstxt" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style49">Telephone</td>
                    <td class="auto-style47">
                    <asp:TextBox ID="telephone" CssClass="readCSS" runat="server" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                    <td>Email Addreess</td>
                    <td class="auto-style52">
                    <asp:TextBox ID="emailAddress" CssClass="readCSS" runat="server" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style49">Street Address (no P.O Boxes)</td>
                    <td class="auto-style47">
                    <asp:TextBox ID="Address" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                    <td>City</td>
                    <td class="auto-style52">
                    <asp:TextBox ID="city" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style50"><asp:CheckBox ID="rent" runat="server" AutoPostBack="true" OnCheckedChanged="rent_CheckedChanged" Text="Rent" onclick="return false;" />
                    <asp:CheckBox ID="own" runat="server" AutoPostBack="true" OnCheckedChanged="own_CheckedChanged"  Text="Own" onclick="return false;" />
                    </td>
                    <td class="auto-style48"></td>
                    <td class="auto-style39"></td>
                    <td class="auto-style53"></td>
                </tr>
                <tr>
                    <td class="auto-style49">State</td>
                    <td class="auto-style47">
                    <asp:TextBox ID="state" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                    <td>Zip</td>
                    <td class="auto-style52">
                    <asp:TextBox ID="zip" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style49">Mailing Address (if different)</td>
                    <td class="auto-style47">
                    <asp:TextBox ID="mailAddress" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                    <td>City</td>
                    <td class="auto-style52">
                    <asp:TextBox ID="mailCity" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style49">State</td>
                    <td class="auto-style47">
                    <asp:TextBox ID="mailState" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                    <td>Zip</td>
                    <td class="auto-style52">
                    <asp:TextBox ID="mailZip" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <table class="auto-style37">
                            <tr>
                                <td>
                                    <asp:CheckBox ID="Ccorporation" runat="server" AutoPostBack="true" onclick="return false;" Text="C Corporation" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="SCorporation" runat="server" AutoPostBack="true" onclick="return false;" Text="S Corporation" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="LLC" runat="server" AutoPostBack="true" onclick="return false;" Text="Limited Liability Company" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="businessIndividual" runat="server" AutoPostBack="true" onclick="return false;" Text="Business Individual" />
                                </td>
                                <td colspan="2">
                                    <asp:CheckBox ID="NonProfit" runat="server" AutoPostBack="true" onclick="return false;" Text="Non-Profit" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="soleProprietor" runat="server" AutoPostBack="true" onclick="return false;" Text="Sole Proprietor" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="limitedPartnership" runat="server" AutoPostBack="true" onclick="return false;" Text="Limited Partnership" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="generalPartnership" runat="server" AutoPostBack="true" onclick="return false;" Text="General Partnership" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="LLP" runat="server" AutoPostBack="true" onclick="return false;" Text="LLP" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="other" runat="server" AutoPostBack="true" onclick="return false;" Text="Other" />
                                    &nbsp;&nbsp;&nbsp;&nbsp; </td>
                                <td>
                                    <asp:TextBox ID="othertxt" runat="server" BackColor="Transparent" CssClass="readCSS" ReadOnly="true" Width="130px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style49">Date Business Established</td>
                    <td class="auto-style47">Month<asp:TextBox ID="month" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="80px"></asp:TextBox>
                            <br />
                        Year<asp:TextBox ID="year" runat="server" CssClass="readCSS" BackColor="Transparent" Height="16px" ReadOnly="true" Width="80px"></asp:TextBox>
                            </td>
                    <td>State of Incorporatin</td>
                    <td class="auto-style52">
                    <asp:TextBox ID="incorporationState" runat="server" CssClass="auto-style45" BackColor="Transparent" Height="16px" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style49">Number of Employees After Financing</td>
                    <td class="auto-style47">
                    <asp:TextBox ID="employeesNum" runat="server" CssClass="readCSS" BackColor="Transparent" ReadOnly="true" Width="240px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style52">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style49">Explain Nature of Business</td>
                    <td colspan="3">
                    <asp:TextBox ID="explain" runat="server" CssClass="auto-style45" BackColor="Transparent" Height="46px" ReadOnly="true" Width="870px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <table class="auto-style37">
                            <tr>
                                <td>
                                    <asp:CheckBox ID="manufacturing" runat="server" AutoPostBack="true" onclick="return false;" Text="Manufacturing" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="wholesale" runat="server" AutoPostBack="true" onclick="return false;" Text="Wholesale" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="retail" runat="server" AutoPostBack="true" onclick="return false;" Text="Retail" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="service" runat="server" AutoPostBack="true" onclick="return false;" Text="Service" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="agricultural" runat="server" AutoPostBack="true" onclick="return false;" Text="Agricultural" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="construction" runat="server" AutoPostBack="true" onclick="return false;" Text="Construction" />
                                </td>
                                <td>
                                    <asp:CheckBox ID="other2" runat="server" AutoPostBack="true" onclick="return false;" Text="Other" />
                                </td>
                                <td>
                                    <asp:TextBox ID="othertxt2" runat="server" BackColor="Transparent" CssClass="readCSS" ReadOnly="true" Width="130px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style49">List any Affiliated Companies</td>
                    <td colspan="3">
                    <asp:TextBox ID="listCompanies" runat="server" CssClass="auto-style45" BackColor="Transparent" Height="30px" ReadOnly="true" Width="852px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style49">&nbsp;</td>
                    <td class="auto-style47">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style52">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style49">&nbsp;</td>
                    <td class="auto-style47">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style52">&nbsp;</td>
                </tr>
            </table>
            






         
            






       
        </div>
        </div>
       </div>
       <div id="EditDetails" runat="server" visible="false">
        <div>
<div class="regform"><h1>Application</h1></div>
        <div class="main" style="color: #46AFEF">
            
            
            
            
            <br />
            






            <table class="auto-style37" style="color: #5D7B9D; font-size: 18px; font-weight: bold;">
                <tr>
                    <td colspan="7" class="auto-style39">Business Legal Name:</td>
                </tr>
                <tr>
                    <td colspan="7">
                    <asp:TextBox ID="BusinessLegalNameE" runat="server" CssClass="editCss"   Height="16px" Width="1252px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39" colspan="5">Business Legal Entity - DBA - If Applicable:</td>
                    <td class="auto-style39" colspan="2">Pirmary Contact</td>
                </tr>
                <tr>
                    <td colspan="5">
                    <asp:TextBox ID="dbaNameE" CssClass="editCss" runat="server" Height="16px"  Width="439px"></asp:TextBox>
                    </td>
                    <td colspan="2">
                    <asp:TextBox ID="PrimaryContactE" CssClass="editCss" runat="server"  Height="16px"  Width="440px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="7">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="7">
                        <table class="nav-justified">
                            <tr>
                                <td>Tax I.D:</td>
                                <td>Social Security</td>
                                <td>Telephone:</td>
                                <td>Email Addreess:</td>
                            </tr>
                            <tr>
                                <td>
                    <asp:TextBox ID="taxidE" runat="server" CssClass="editCss"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="sstxtE" runat="server" CssClass="editCss"  Height="16px" Width="240px" ></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="telephoneE" CssClass="editCss" runat="server"  Height="16px" Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="emailAddressE" CssClass="editCss" runat="server" Height="16px"  Width="240px" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>Street Address (no P.O Boxes):</td>
                                <td>City:</td>
                                <td>State:</td>
                                <td>Zip:</td>
                            </tr>
                            <tr>
                                <td>
                    <asp:TextBox ID="AddressE" runat="server" CssClass="editCss"  Height="16px" Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="cityE" runat="server" CssClass="editCss"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="stateE" runat="server" CssClass="editCss"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="zipE" runat="server" CssClass="editCss"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td><asp:CheckBox ID="rentE" runat="server" AutoPostBack="true" OnCheckedChanged="rent_CheckedChanged" Text="Rent"  />
                    &nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="ownE" runat="server" AutoPostBack="true" OnCheckedChanged="own_CheckedChanged"  Text="Own"  />
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
                    <asp:TextBox ID="mailAddressE" runat="server" CssClass="editCss"  Height="16px" Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="mailCityE" runat="server" CssClass="editCss" Height="16px"  Width="240px" ></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="mailStateE" runat="server" CssClass="editCss"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                                <td>
                    <asp:TextBox ID="mailZipE" runat="server" CssClass="editCss"  Height="16px"  Width="240px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="7">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="7">
                        <table class="auto-style37">
                            <tr>
                                <td>
                                <asp:CheckBox ID="CcorporationE" runat="server" AutoPostBack="true" OnCheckedChanged="Ccorporation_CheckedChanged" Text="C Corporation" />
                                </td>
                                <td>
                                <asp:CheckBox ID="SCorporationE" runat="server" AutoPostBack="true" OnCheckedChanged="SCorporation_CheckedChanged" Text="S Corporation" />
                                </td>
                                <td>
                                <asp:CheckBox ID="LLCE" runat="server" AutoPostBack="true" OnCheckedChanged="LLC_CheckedChanged"  Text="Limited Liability Company" />
                                </td>
                                <td>
                                <asp:CheckBox ID="businessIndividualE" runat="server" AutoPostBack="true" OnCheckedChanged="businessIndividual_CheckedChanged" Text="Business Individual" />
                                </td>
                                <td colspan="2">
                                <asp:CheckBox ID="NonProfitE" runat="server" AutoPostBack="true" OnCheckedChanged="NonProfit_CheckedChanged" Text="Non-Profit" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                <asp:CheckBox ID="soleProprietorE" runat="server" AutoPostBack="true" OnCheckedChanged="soleProprietor_CheckedChanged"  Text="Sole Proprietor" />
                                </td>
                                <td>
                                <asp:CheckBox ID="limitedPartnershipE" runat="server" AutoPostBack="true" OnCheckedChanged="limitedPartnership_CheckedChanged"  Text="Limited Partnership" />
                                </td>
                                <td>
                                <asp:CheckBox ID="generalPartnershipE" runat="server" AutoPostBack="true" OnCheckedChanged="generalPartnership_CheckedChanged"  Text="General Partnership" />
                                </td>
                                <td>
                                <asp:CheckBox ID="LLPE" runat="server" AutoPostBack="true" OnCheckedChanged="LLP_CheckedChanged"  Text="LLP" />
                                </td>
                                <td>
                                <asp:CheckBox ID="otherE1" runat="server" AutoPostBack="true" OnCheckedChanged="other_CheckedChanged"  Text="Other" />
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td>
                                <asp:TextBox ID="othertxtE1" CssClass="editCss" runat="server"  Width="130px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="7">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">Date Business Established:</td>
                    <td class="auto-style38">State of Incorporatin:</td>
                    <td>Number of Employees After Financing:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Month</td>
                    <td>
                                <asp:TextBox ID="monthE" runat="server" CssClass="editCss"  Height="16px" Width="80px"></asp:TextBox>
                            </td>
                    <td>Year</td>
                    <td>
                                <asp:TextBox ID="yearE" runat="server" CssClass="editCss"  Height="16px" Width="80px"></asp:TextBox>
                            </td>
                    <td class="auto-style38">
                    <asp:TextBox ID="incorporationStateE" runat="server" CssClass="editCss"  Height="16px"  Width="240px"></asp:TextBox>
                    </td>
                    <td>
                    <asp:TextBox ID="employeesNumE" runat="server" CssClass="editCss"   Width="240px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="7">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="7">Explain Nature of Business:</td>
                </tr>
                <tr>
                    <td class="auto-style39" colspan="7">
                    <asp:TextBox ID="explainE" runat="server" CssClass="editCss"  Height="46px" Width="1252px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="7">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="7">
                        <table class="auto-style37">
                            <tr>
                                <td>
                                <asp:CheckBox ID="manufacturingE" runat="server" AutoPostBack="true" OnCheckedChanged="manufacturing_CheckedChanged" Text="Manufacturing" />
                                </td>
                                <td>
                                <asp:CheckBox ID="wholesaleE" runat="server" AutoPostBack="true" OnCheckedChanged="wholesale_CheckedChanged" Text="Wholesale" />
                                </td>
                                <td>
                                <asp:CheckBox ID="retailE" runat="server" AutoPostBack="true" OnCheckedChanged="retail_CheckedChanged" Text="Retail" />
                                </td>
                                <td>
                                <asp:CheckBox ID="serviceE" runat="server" AutoPostBack="true" OnCheckedChanged="service_CheckedChanged"  Text="Service" />
                                </td>
                                <td>
                                <asp:CheckBox ID="agriculturalE" runat="server" AutoPostBack="true" OnCheckedChanged="agricultural_CheckedChanged"  Text="Agricultural" />
                                </td>
                                <td>
                                <asp:CheckBox ID="constructionE" runat="server" AutoPostBack="true" OnCheckedChanged="construction_CheckedChanged"  Text="Construction" />
                                </td>
                                <td>
                                <asp:CheckBox ID="other2E" runat="server" AutoPostBack="true" OnCheckedChanged="other2_CheckedChanged"  Text="Other" />
                                </td>
                                <td>
                                <asp:TextBox ID="othertxt2E" runat="server" CssClass="editCss"   Width="130px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="7">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="7">List any Affiliated Companies</td>
                </tr>
                <tr>
                    <td colspan="7">
                    <asp:TextBox ID="listCompaniesE" runat="server" CssClass="editCss"  Height="30px" Width="1252px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="7">&nbsp;</td>
                </tr>
            </table>
            

            
            
            
            
        </div>
        </div>
       </div>
        <br />
     <div style="text-align: right">
          <asp:Button ID="Edit" runat="server" BackColor="White" Font-Size="Medium" ForeColor="Black" Height="25px" OnClick="Edit_Click" Text="Edit" Width="97px" />
          <asp:Button ID="Button2" runat="server" BackColor="White" Font-Size="Medium" ForeColor="Black" Height="25px" OnClick="Submit1_Click" Text="Submit" Width="97px" />
     </div>
           <asp:Label ID="message" runat="server"></asp:Label>
        <br />
                   
        <br />
        <br />       
        
                   
        
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ClientFooter" runat="server">
</asp:Content>
