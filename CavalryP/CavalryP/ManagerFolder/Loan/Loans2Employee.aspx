<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loans2Employee.aspx.cs" Inherits="CavalryP.ManagerFolder.Loan.Loans2Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
       color: black;
       padding: 15px 32px;
       text-align: center;
       text-decoration: none;
       display: inline-block;
       font-size: 16px;
       margin: 4px 2px;
       cursor: pointer;
   }
   .button:hover{
       background-color: #5D7B9D;
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
       width:760px;
       background-color:rgba(196, 187, 187,0.3);         
       margin:auto;
       color:#5D7B9D;
       padding:10px 0px 10px 0px;
       text-align:center;
       border-radius:15px 15px 0px 0px;
   }
   .main{
       background-color:rgba(196, 187, 187,0.2);
       width:760px;
       margin:auto;
   }
   .readCSS{         
       width: 150px;
       height:20px;
       padding: 12px 20px;
       margin: 8px 0;
       box-sizing: border-box;
       border: none;
       background-color:rgb(243, 241, 241);
   }
   .editCss{          
       width:170px ;
       height:16px;
       padding: 12px 20px;
       margin: 8px 0;
       box-sizing: border-box;
       border-color:#5D7B9D;
       border-style:solid;
       border-width:2px;
       border-radius: 6px;
   }    
   .mydropdownlist1{
       color:black;
       height:45px;
       width:170px ;
       font-size: 15px;
       padding: 5px 10px;
       border-color:#5D7B9D;
       border-style:solid;
       border-width:2px;
       border-radius: 6px;background-color:white;
       font-weight: bold;
}
       .auto-style1 {
           width: 760px;
       }

       .bigeditcss {
           border: 2px solid #5D7B9D;
           width: 450px ;
           height: 30px;
           padding: 12px 20px;
           margin: 8px 0;
           box-sizing: border-box;
           border-radius: 6px;
       }
       .MyGridview  
{  
    margin-left:auto;  
    margin-right:auto;  
    width:800px;  
    height:500px;  
}  

       .auto-style9 {
           width: 248px;
       }
              
        .auto-style10 {
            width: 1602px;
        }
        .rightB{
           position: absolute;
right:    0;
bottom:   0;
        }
              
        .auto-style12 {
            width: 1789px;
        }
        .auto-style13 {
            width: 650px;
        }
        .auto-style14 {
            width: 1793px;
        }
              
        .auto-style15 {
            width: 1798px;
        }
              
        .auto-style18 {
            width: 711px;
        }
              
    .auto-style19 {
        color: #46AFEF;
    }
              
    .auto-style21 {
        width: 100%;
    }
    .auto-style22 {
        height: 62px;
    }
              
    .auto-style23 {
        border-style: none;
        border-color: inherit;
        border-width: medium;
        width: 286px;
        height: 20px;
        padding: 12px 20px;
        margin: 8px 0;
        box-sizing: border-box;
        background-color: rgb(243, 241, 241);
    }
              
    .auto-style25 {
        height: 70px;
    }
              
    .auto-style26 {
        margin-left: auto;
        margin-right: auto;
    }
              
    </style>  
</head>
<body >
      <form id="form1" runat="server">  
       <div class="topnav">

<asp:Button ID="lastP" runat="server" CssClass="button" Text="Back" OnClientClick="return confirm('All The Changes You have Done Will Updated ByThe Customer')"  OnClick="lastP_Click1" />
    <asp:Button ID="downloadDoc" runat="server" Text="Download As Document" CssClass="button" OnClick="downloadDoc_Click"   />
<asp:Button ID="downloadS" runat="server" Text="Download Source" Visible="false" CssClass="button" OnClick="downloadS_Click"    />
 <div class="search-container">
<div>

      </div>
</div>
               </div>
     
          <br />
          <br />
          <div id="editDiv" runat="server" visible="false">
              <div id="step1" runat="server" style="text-align: center">
                   
           
          <div class="regform"><h1>Report</h1></div>
              <div class="main" style="color: #46AFEF">
            
            
            <br />
            

            <table  style="color: #5D7B9D; text-align: center; font-size: 20px; font-weight: bold;" class="auto-style1">
                <tr>
                    <td colspan="3" style="text-align: center; font-size: 30px; font-weight: bold;">Accounts Summary</td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" style="font-size: 25px; font-weight: bold; text-align: center;">My Account Summary</td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td>Open Credit Cards </td>
                    <td>Open Retail Cards</td>
                    <td>Open Real Estate Loans</td>
                </tr>
                <tr>
                    <td>
                                    <input id="openCCtxt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                    <input id="openRCtxt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                    <input id="openRELoanstxt" runat="server" class="editCss" type="text" /></td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td>Open Installment Loans</td>
                    <td>Total Open Accounts</td>
                    <td>Accounts Ever Late </td>
                </tr>
                <tr>
                    <td>
                                    <input id="openILoanstxt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                    <input id="TotalOpenAcctxt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                    <input id="AccEverLatetxt" runat="server" class="editCss" type="text" /></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Collections Accounts </td>
                    <td>Average Account Age</td>
                    <td>Oldest Account</td>
                </tr>
                <tr>
                    <td>
                                    <input id="CollectionAcc" runat="server" class="editCss" type="text" /></td>
                    <td>Month:<br />
                                    <input id="AvgAccAgeM" runat="server" class="editCss" type="text" /><br />
                                    Year:<br />
                                    <input id="AvgAccAgeY" runat="server" class="editCss" type="text" /></td>
                    <td>Month:<br />
                                    <input id="OldestAccM" runat="server" class="editCss" type="text" /><br />
                                    Year:<br />
                                    <input id="OldestAccY" runat="server" class="editCss" type="text" /></td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" style="font-size: 25px; font-weight: bold; text-align: center;">My Debt Summary</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Credit and Retail Card Debt</td>
                    <td>Real Estate Debt </td>
                    <td>Installment Loans Debt </td>
                </tr>
                <tr>
                    <td><strong>
                                    <input id="CRDebt" runat="server" class="editCss" type="text" /></strong></td>
                    <td>
                                    <input id="REDebt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                    <input id="ILDebt" runat="server" class="editCss" type="text" /></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Collections Debt </td>
                    <td>Total Debt</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                                    <input id="CollectionDebt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                    <input id="TDebt" runat="server" class="editCss" type="text" /></td>
                    <td>&nbsp;</td>
                </tr>
                </table>
            <br />
            <div style="background-color:white; text-align: center;">            
                <asp:Label ID="error1" ForeColor="Red" runat="server" Font-Size="XX-Large"></asp:Label></div>
            
            
            <br />        
            
        </div>
              
              
              <br />
              
              <asp:Label ID="Lcom1" runat="server" Text="Manager Comment" Font-Size="Larger" ForeColor="#5D7B9D"></asp:Label>
              
              
              <br />
              <br />
              
            <asp:TextBox ID="com1" runat="server" Height="80px" Width="1018px" BorderColor="#5D7B9D" BorderStyle="Dotted"></asp:TextBox>
              <br />
            <br />
            <br />
              <div style="text-align: right">
                   <asp:Button ID="Next1" runat="server" Text="Next" Font-Size="Large" Height="37px" Width="176px" BackColor="White" OnClick="Next1_Click" />
                    </div>
           <div>Step 1 Of 5</div>
              <br />
        </div>
              <div id="step2" runat="server">
            <br />
               <div class="regform"><h1>Report</h1></div>
        <div class="main" style="color: #46AFEF">
            
            
         
            <table class="auto-style8" style="color: #5D7B9D; text-align: center; font-size: 20px; font-weight: bold;">
                <tr>
                    <td colspan="4" style="text-align: center; font-size: 30px; font-weight: bold;">Accounts </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"><span>Account Name</span></td>
                    <td colspan="2"><span>Account #</span></td>
                    <td><span>Original Creditor</span></td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <input id="AccNametxt" runat="server" class="editCss" type="text" /></td>
                    <td colspan="2">
                                <input id="AccNumtxt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                <input id="OCreditortxt" runat="server" class="editCss" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"><span>Company Sold</span></td>
                    <td colspan="2">Account Type</td>
                    <td>Date Opened</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <input id="companyStxt" runat="server" class="editCss" type="text" /></td>
                    <td colspan="2">
                                <input id="AccTypetxt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                <input id="DateOpentxt" runat="server" class="editCss" type="date" />                         <asp:Button id="DateOpenChange" visible="false" runat="server" CssClass="editCss" OnClick="DateOpenChange_Click" BackColor="White" /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Account Status</td>
                    <td colspan="2">Payment Status</td>
                    <td>Status Updated</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <asp:DropDownList ID="AccStatustxt" runat="server" CssClass="mydropdownlist1">
                                    <asp:ListItem>Open</asp:ListItem>
                                    <asp:ListItem>Close</asp:ListItem>
                                    <asp:ListItem>Collection</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                    <td colspan="2">
                                <input id="Pstatustxt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                <input id="supdate" runat="server" class="editCss" type="date" />
                        <asp:Button id="supdateChange" visible="false" runat="server" CssClass="editCss" OnClick="supdateChange_Click" BackColor="White" /></td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style5" colspan="2"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style9">Balance</td>
                    <td colspan="2">Balance Updated</td>
                    <td>Credit Limit</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <input id="Balancetxt" runat="server" class="editCss" type="text" /></td>
                    <td colspan="2">
                                <input id="BUpdate" runat="server" class="editCss" type="date" />                      
                        <asp:Button id="BUpdateChange" visible="false" runat="server" CssClass="editCss" OnClick="BUpdateChange_Click" BackColor="White" /></td>
                    <td>
                                <input id="creditLimittxt" runat="server" class="editCss" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Monthly Payment</td>
                    <td colspan="2">Past Due Amount</td>
                    <td>Highest Balance</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <input id="MonthlyPaymenttxt" runat="server" class="editCss" type="text" /></td>
                    <td colspan="2">
                                <input id="PDAmounttxt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                <input id="HBalancetxt" runat="server" class="editCss" type="number" /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Terms</td>
                    <td colspan="2">Original Balance</td>
                    <td>Responsibility</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <input id="Termstxt" runat="server" class="editCss" type="text" /></td>
                    <td colspan="2">
                                <input id="OBalancetxt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                <input id="Responsibilitytxt" runat="server" class="editCss" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Your Statement</td>
                    <td colspan="3">Comments</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <input id="Statmenttxt" runat="server" class="editCss" type="text" /></td>
                    <td colspan="3">
                                <input id="Commentstxt" runat="server"  class="bigeditcss" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                                <asp:Button ID="CancelAcc" runat="server" BackColor="White" Font-Size="Large" Height="37px" OnClick="CancelAcc_Click" Text="Cancel" Width="197px" />
                            </td>
                    <td colspan="2">
                                <asp:Button ID="AddAcc" runat="server" BackColor="White" Font-Size="Large" Height="37px" OnClick="AddAcc_Click" Text="Add" Width="197px" />
                            </td>
                </tr>
            </table>
            
            
         
            <br />
            
            
            <div style="background-color:white; text-align: center;">            
                <asp:Label ID="error2" ForeColor="Red" runat="server" Font-Size="XX-Large"></asp:Label></div>
            
            
            <br />
            

            <br />

            
            
            
            
        </div>
                  <br />
                  <br />
            <asp:GridView ID="CAccs" runat="server" CssClass="myg" DataKeyNames="Id" AutoGenerateColumns="False" CellPadding="4"  ForeColor="#333333" GridLines="None" >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>   
                        <asp:TemplateField HeaderText="ID" Visible="false"  >
                            <ItemTemplate>
                                <asp:Label ID="lId" runat="server" Text='<%#Eval("Id") %>'  />
                              
                        
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Account Name" >
                            <ItemTemplate>
                                <asp:Label ID="lAccountName" runat="server" Text='<%#Eval("AccountName") %>'  />
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Account Number">
                            <ItemTemplate>
                                <asp:Label ID="lAccountNum" runat="server" Text='<%#Eval("AccountNum") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Original Creditor">
                            <ItemTemplate>
                                <asp:Label ID="lOriginalCreditor" runat="server" Text='<%#Eval("OriginalCreditor") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Company Sold">
                            <ItemTemplate>
                                <asp:Label ID="lCompanySold" runat="server" Text='<%#Eval("CompanySold") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Account Type">
                            <ItemTemplate>
                                <asp:Label ID="lAccountType" runat="server" Text='<%#Eval("AccountType") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date Opened">
                            <ItemTemplate>
                                <asp:Label ID="lDateOpened" runat="server" Text='<%#Eval("DateOpened") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Account Status">
                            <ItemTemplate>
                                <asp:Label ID="lAccountStatus" runat="server" Text='<%#Eval("AccountStatus") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Payment Status">
                            <ItemTemplate>
                                <asp:Label ID="lPaymentStatus" runat="server" Text='<%#Eval("PaymentStatus") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Status Updated">
                            <ItemTemplate>
                                <asp:Label ID="lStatusUpdated" runat="server" Text='<%#Eval("StatusUpdated") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Original Balance">
                            <ItemTemplate>
                                <asp:Label ID="lOriginalBalance" runat="server" Text='<%#Eval("OriginalBalance") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>                
                        <asp:TemplateField HeaderText="Balance Updated">
                            <ItemTemplate>
                                <asp:Label ID="lBalanceUpdated" runat="server" Text='<%#Eval(" BalanceUpdated") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Credit Limit">
                            <ItemTemplate>
                                <asp:Label ID="lCreditLimit" runat="server" Text='<%#Eval("CreditLimit") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Monthly Payment">
                            <ItemTemplate>
                                <asp:Label ID="MonthlyPayment" runat="server" Text='<%#Eval("MonthlyPayment") %>'  />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Past Due Amount">
                            <ItemTemplate>
                                <asp:Label ID="lPastDueAmount" runat="server" Text='<%#Eval("PastDueAmount") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Highest Balance">
                            <ItemTemplate>
                                <asp:Label ID="lHighestBalance" runat="server" Text='<%#Eval("HighestBalance") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Terms">
                            <ItemTemplate>
                                <asp:Label ID="lTerms" runat="server" Text='<%#Eval("Terms") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Responsibility">
                            <ItemTemplate>
                                <asp:Label ID="lResponsibility" runat="server" Text='<%#Eval("Responsibility") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Your Statement">
                            <ItemTemplate>
                                <asp:Label ID="lYourStatement" runat="server" Text='<%#Eval("YourStatement") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Comments">
                            <ItemTemplate>
                                <asp:Label ID="lComments" runat="server" Text='<%#Eval("Comments") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Status" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lstatus" runat="server" Text='<%#Eval("status") %>' Visible="false" />
                                <asp:Button ID="change" runat="server" Text="change" OnClick="change_Click" />
                                <asp:Button Text="Delete" runat="server" CommandName="Delete" ToolTip="Delete" OnClientClick="return confirm('Are you sure  you want to delete the Account?')" />
                            
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Loans Id" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="LoansId" runat="server" Text='<%#Eval("LoansId") %>' Visible="false" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="change1" runat="server" BackColor="White" Height="23px" Width="76px" Text="Change" OnClick="change_Click" />
                                <asp:Button Text="Delete" runat="server" BackColor="White" Height="23px" Width="76px" CommandName="Delete" ToolTip="Delete" OnClientClick="return confirm('Are you sure  you want to delete the Account?')" OnClick="Unnamed_Click" />
                                
                        </ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                       </asp:TemplateField>       
                    </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>            
            <br />
            
            <br />
              <div style="text-align: center; margin:auto;">
                <asp:Label ID="Lcom2" runat="server" Text="Manager Comment" Font-Size="Larger" ForeColor="#5D7B9D"></asp:Label>

                  <br />

            <asp:TextBox ID="com2" runat="server" Height="80px" Width="1018px" BorderColor="#5D7B9D" BorderStyle="Dotted"></asp:TextBox>
             <br />
             <br />
           
            <table class="auto-style14">
                <tr>
                    <td style="background-color: #FFFFFF; text-align: left;" class="auto-style13">
                   <asp:Button ID="previous" runat="server" Text="Previous" Font-Size="Large" Height="37px" Width="137px" BackColor="White" OnClick="previous_Click"  />
                    </td>
                    <td style="text-align: center; background-color: #FFFFFF;">
                        &nbsp;</td>
                    <td style="text-align: right; background-color: #FFFFFF;">
                   <asp:Button ID="Next3"  runat="server" Text="Next" Font-Size="Large" Height="37px" Width="155px" BackColor="White" OnClick="Next3_Click"  />
                    </td>
                </tr>
            </table>
       
                    
                  <br />
                  <div>
                   <asp:Label ID="Label2" runat="server" Text="Step 2 Of 5"></asp:Label>
                    </div>
       
                    
             </div>
       
        </div>
              <div id="step3" runat="server">
                    <div>
            <div class="regform"><h1>Report</h1></div>
        <div class="main" style="color: #46AFEF">
            
            
            <br />
            

            <table  style="color: #5D7B9D; text-align: center; font-size: 20px; font-weight: bold;" class="auto-style1">
                <tr>
                    <td colspan="3" style="text-align: center; font-size: 30px; font-weight: bold;">Inquiries</td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td>Bank Name</td>
                    <td>Imquiry Date</td>
                    <td>Removal Date</td>
                </tr>
                <tr>
                    <td>
                                <input id="Bnametxt" runat="server" class="editCss" type="text" /></td>
                    <td>
                                <input id="InqDate" runat="server" class="editCss" type="date" />                         
                        <asp:Button id="InqDateChange" visible="false" runat="server" CssClass="editCss" OnClick="InqDateChange_Click" BackColor="White" /></td>
                    <td>
                                <input id="REmDAtetxt" runat="server" class="editCss" type="date" />
                                                <asp:Button id="REmDAteChange" visible="false" runat="server" CssClass="editCss" OnClick="REmDAteChange_Click" BackColor="White" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">Business Type</td>
                    <td class="auto-style10">Contact Information:</td>
                    <td class="auto-style10">&nbsp;</td>
                </tr>
                <tr>
                    <td>
                                <input id="Btype" runat="server" class="editCss" type="text" /></td>
                    <td>
                                <input id="CInformation" runat="server"  class="editCss" type="text" /></td>
                    <td>
                                    &nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                                <asp:Button ID="CancelInq" runat="server" BackColor="White" Font-Size="Large" Height="27px" OnClick="CancelInq_Click" Text="Cancel" Width="138px" />
                            </td>
                    <td>
                                &nbsp;</td>
                    <td>
                                <asp:Button ID="AddInq" runat="server" BackColor="White" Font-Size="Large" Height="27px" OnClick="AddInq_Click" Text="Add" Width="138px" />
                            </td>
                </tr>
                </table>
            
            <br />
            
            
            <div style="background-color:white; text-align: center;">            
                <asp:Label ID="error3" ForeColor="Red" runat="server" Font-Size="XX-Large"></asp:Label></div>
            
            
            <br />
            <br />        
            
        </div>

        </div>
                    <br />
            <br />
            <div style="text-align: center">
                 <asp:GridView ID="InqGV" CssClass="MyGridview" runat="server" DataKeyNames="Id" AutoGenerateColumns="False" CellPadding="4"  ForeColor="#333333" GridLines="None" >
                     <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                     <Columns>                      
                        <asp:TemplateField HeaderText="Id" Visible="false" >
                            <ItemTemplate>
                                <asp:Label ID="lId" runat="server" Text='<%#Eval("Id") %>' Visible="false" />
                               
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Bank Name">
                            <ItemTemplate>
                                <asp:Label ID="lNameOfBank" runat="server" Text='<%#Eval("NameOfBank") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Inquiry Date">
                            <ItemTemplate>
                                <asp:Label ID="lInquiryDate" runat="server" Text='<%#Eval("InquiryDate") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Removal Date">
                            <ItemTemplate>
                                <asp:Label ID="lRemovalDate" runat="server" Text='<%#Eval("RemovalDate") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Business Type">
                            <ItemTemplate>
                                <asp:Label ID="lBusinessType" runat="server" Text='<%#Eval("BusinessType") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Contact Information">
                            <ItemTemplate>
                                <asp:Label ID="lContactInformation" runat="server" Text='<%#Eval("ContactInformation") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LoansId" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lLoansId" runat="server" Text='<%#Eval("LoansId") %>' Visible="false" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>         
                        <asp:TemplateField>
                            <ItemTemplate>                            
                               <asp:Button ID="Changeinq" runat="server" BackColor="White" Height="23px" Width="76px" Text="Change" OnClick="Changeinq_Click" />
                               <asp:Button ID="DeleteInq" Text="Delete" runat="server" BackColor="White" Height="23px" Width="76px" CommandName="Delete" ToolTip="Delete" OnClientClick="return confirm('Are you sure  you want to delete the Account?')" OnClick="DeleteInq_Click" />
                               
                            </ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:TemplateField>
                    </Columns>
                     <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
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
            <br />
               <br />
     <div style="text-align: center; margin:auto;">
                  
               <br />
               <br />
               <div style="background-color:white; text-align: center;">

            <asp:Label ID="Lcom3" runat="server" Text="Manager Comment" Font-Size="Larger" ForeColor="#5D7B9D"></asp:Label>

                   <br />

            <asp:TextBox ID="com3" runat="server" Height="80px" Width="1018px" BorderColor="#5D7B9D" BorderStyle="Dotted"></asp:TextBox>

         </div>
         </div>
              <br />
              <br />
            <br/>

               <table class="auto-style15">
                <tr>
                    <td class="auto-style38" style="background-color: #FFFFFF">
                   <asp:Button ID="previous2" runat="server" Text="Previous" Font-Size="Large" Height="37px" Width="142px" BackColor="White" OnClick="previous2_Click"   />
                    </td>
                    <td style="text-align: center; background-color: #FFFFFF;">
                        &nbsp;</td>
                    <td style="text-align: right; background-color: #FFFFFF;">
                   <asp:Button ID="next4" runat="server" Text="Next" Font-Size="Large" Height="37px" Width="178px" BackColor="White" OnClick="next4_Click"   />
                   
                    </td>
                </tr>
            </table>
            <div style="text-align: center">
                   <asp:Label ID="Label4" runat="server" Text="Step 3 Of 5"></asp:Label>
                    </div>
        </div> 
              <div id="step4" runat="server">

            <br />
           <div>
               <div class="regform"><h1>Report</h1></div>
               <div class="main" style="color: #46AFEF">
                   <br />
                   <table  style="color: #5D7B9D; text-align: center;" class="auto-style1">
                       <tr>
                           <td style="text-align: center; font-size: 30px; font-weight: bold;">Public Records</td>

                       </tr>
                       <tr>
                           <td>
                            <input id="record" runat="server" class="bigeditcss" placeholder="Enter Your Records (if you have)" type="text" /></td>

                       </tr>
                </table>
            
            <br />
            <div style="background-color:white; text-align: center;">            
                <asp:Label ID="error4" ForeColor="Red" runat="server" Font-Size="XX-Large"></asp:Label></div>
            
            
            
            <br />        
            
        </div>
        </div>
            <div style="text-align: center">

            <asp:Label ID="Lcom4" runat="server" Text="Manager Comment" Font-Size="Larger" ForeColor="#5D7B9D"></asp:Label>

                <br />

            <asp:TextBox ID="com4" runat="server" Height="80px" Width="1018px" BorderColor="#5D7B9D" BorderStyle="Dotted"></asp:TextBox>

            </div>
<br />       
            <br />

               <table class="auto-style15">
                <tr>
                    <td class="auto-style21" style="background-color: #FFFFFF">
                        <asp:Button ID="previous3" runat="server" BackColor="White" Font-Size="Large" Height="37px" OnClick="previous3_Click" Text="Previous" Width="123px" />
                    </td>
                    <td style="text-align: center; background-color: #FFFFFF;">
                        &nbsp;</td>
                    <td style="text-align: right; background-color: #FFFFFF;">
                        <asp:Button ID="next5" runat="server" BackColor="White" CssClass="auto-style59" Font-Size="Large" Height="37px" OnClick="next5_Click" Text="Next" Width="179px" />
                   
                    </td>
                </tr>
            </table>
            <div style="text-align: center">
                   <asp:Label ID="Label6" runat="server" Text="Step 4 Of 5"></asp:Label>
                    </div>
            <br />
        </div> 
              <div id="step5" runat="server">

            
            <br />
            <div>
                <div class="regform">
                    <h1>Report</h1>
                </div>
                <div class="main" style="color: #46AFEF">
                    <br />
                    <table class="auto-style1" style="color: #5D7B9D; text-align: center; font-size: 20px; font-weight: bold;">
                        <tr>
                            <td colspan="4" style="text-align: center; font-size: 30px; font-weight: bold;">Credit Score</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Experian </td>
                            <td>
                                <input id="Experiantxt" runat="server" class="editCss" type="number" /></td>
                            <td>Fico 2</td>
                            <td>
                                <input id="fico2" runat="server" class="editCss" type="number" /></td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Equifax </td>
                            <td>
                                <input id="Equifaxtxt" runat="server" class="editCss" type="number" /></td>
                            <td>Fico 3</td>
                            <td>
                                <input id="fico3" runat="server" class="editCss" type="number" /></td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Trans Unio</td>
                            <td>
                                <input id="TransUniotxt" runat="server" class="editCss" type="number" /></td>
                            <td>Fico 8</td>
                            <td>
                                <input id="fico8" runat="server" class="editCss" type="number" /></td>
                        </tr>
                    </table>
                    <br />
                    <br />
                </div>
            </div>

            <br />
            <br />
            <div style="text-align: center">
            <asp:Label ID="Lcom5" runat="server" Text="Manager Comment" Font-Size="Larger" ForeColor="#5D7B9D"></asp:Label>

                <br />

            <asp:TextBox ID="com5" runat="server" Height="80px" Width="1018px" BorderColor="#5D7B9D" BorderStyle="Dotted"></asp:TextBox>
            </div>
            <br />
             <table class="auto-style12">
                <tr>
                    <td class="auto-style18" style="background-color: #FFFFFF">
                   <asp:Button ID="previous4" runat="server" Text="Previous" Font-Size="Large" Height="37px" Width="124px" BackColor="White"  CssClass="auto-style69" OnClick="previous4_Click"    />
                    </td>
                    <td style="text-align: center; background-color: #FFFFFF;">
                        &nbsp;</td>
                    <td style="text-align: right; background-color: #FFFFFF;">
                   <asp:Button ID="Submit" runat="server" Text="Submit" Font-Size="Large" Height="37px" Width="89px" BackColor="White" OnClick="Submit_Click"     />
                   
                   <asp:Button ID="Send" runat="server" Text="Send" Font-Size="Large" Height="37px" Width="89px" BackColor="White" OnClick="Send_Click"    />
                   
                   <asp:Button ID="Finish" runat="server" Text="Finish" Font-Size="Large" Height="37px" Width="89px" BackColor="White" CssClass="auto-style83" OnClick="Finish_Click"   />
                   
                    </td>
                </tr>
            </table>
            <div style="text-align: center">
                   <asp:Label ID="Label5" runat="server" Text="Step 5 Of 5"></asp:Label>
                    </div>
        </div>

          </div>
           <div id="readDiv" runat="server">
              <div id="Div2" runat="server" style="text-align: center">
                   
           
          <div class="regform"><h1>Report</h1></div>
              <div class="main" style="color: #46AFEF">
            
            
                  <table class="auto-style21" style="color: #5D7B9D; text-align: center; font-size: 20px; font-weight: bold;">
                      <tr>
                          <td class="auto-style25" colspan="4" style="text-align: center; font-size: 30px; font-weight: bold;">Accounts Summary</td>
                      </tr>
                      <tr>
                          <td class="auto-style25" colspan="4" style="font-size: 25px; font-weight: bold; text-align: center;" class="auto-style24">My Account Summary</td>
                      </tr>
                      <tr>
                          <td class="auto-style25">Open Credit Cards </td>
                          <td class="auto-style25">
                                    <input id="OpenCCE" runat="server" class="readCSS" readonly="true" type="text" /></td>
                          <td class="auto-style25">Open Retail Cards</td>
                          <td class="auto-style25">
                                    <input id="OpenRCE" runat="server" class="readCSS" readonly="true" type="text" /></td>
                      </tr>
                      <tr>
                          <td class="auto-style25">Open Real Estate Loans</td>
                          <td class="auto-style25">
                                    <input id="OpenRLE" runat="server" class="readCSS" readonly="true" type="text" /></td>
                          <td class="auto-style25">Open Installment Loans</td>
                          <td class="auto-style25">
                                    <input id="OpenILE" runat="server" class="readCSS" readonly="true" type="text" /></td>
                      </tr>
                      <tr>
                          <td class="auto-style25">Total Open Accounts</td>
                          <td class="auto-style25">
                                    <input id="TotalOAE" runat="server" class="readCSS" readonly="true" type="text" /></td>
                          <td class="auto-style25">Accounts Ever Late </td>
                          <td class="auto-style25">
                                    <input id="AccEverLateE" runat="server" class="readCSS" readonly="true" type="text" /></td>
                      </tr>
                      <tr>
                          <td class="auto-style25">Collections Accounts </td>
                          <td class="auto-style25">
                                    <input id="CollectionAccE" runat="server" class="readCSS" readonly="true" type="text" /></td>
                          <td class="auto-style25">Average Account Age</td>
                          <td class="auto-style25" style="font-size: 14px">Month<input id="AvgAccAgeME" runat="server" class="readCSS" style="width:100px; color:black;"  readonly="true" type="text" /><br />
                                    Year:<input id="AvgAccAgeYE" runat="server" class="readCSS" style="width:100px" readonly="true" type="text" /></td>
                      </tr>
                      <tr>
                          <td class="auto-style25">Oldest Account</td>
                          <td class="auto-style25" style="font-size: 14px">Month<input id="OldestAccME" runat="server" class="readCSS" style="width:100px;" readonly="true" type="text" /><br />
                                    Year:<input id="OldestAccYE" runat="server" style="width:100px;" class="readCSS" readonly="true" type="text" /></td>
                          <td class="auto-style25">&nbsp;</td>
                          <td class="auto-style25">&nbsp;</td>
                      </tr>
                      <tr >
                          <td class="auto-style25" colspan="4" style="font-size: 25px; font-weight: bold; text-align: center;">My Debt Summary</td>
                      </tr>
                      <tr>
                          <td class="auto-style25">Credit and Retail Card Debt</td>
                          <td class="auto-style25"><strong>
                                    <input id="CreditRCD" runat="server" class="readCSS" readonly="true" type="text" /></strong></td>
                          <td class="auto-style25">Real Estate Debt </td>
                          <td class="auto-style25">
                                    <input id="RealEstateDE" runat="server" class="readCSS" readonly="true" type="text" /></td>
                      </tr>
                      <tr>
                          <td class="auto-style25">Installment Loans Debt </td>
                          <td class="auto-style25">
                                    <input id="InstallmentDebtE" runat="server" class="readCSS" readonly="true" type="text" /></td>
                          <td class="auto-style25">Collections Debt </td>
                          <td class="auto-style25">
                                    <input id="CollectionDebtE" runat="server" class="readCSS" readonly="true" type="text" /></td>
                      </tr>
                      <tr>
                          <td class="auto-style22 auto-style25">Total Debt</td>
                          <td class="auto-style22 auto-style25">
                                    <input id="TotalDebtE" runat="server" class="readCSS" readonly="true" type="text" /></td>
                          <td class="auto-style22 auto-style25"></td>
                          <td class="auto-style22 auto-style25"></td>
                      </tr>
                      <tr>
                          <td class="auto-style25" colspan="4" style="font-size: 25px; font-weight: bold; text-align: center;">Public Records</td>
                      </tr>
                      <tr>
                          <td class="auto-style25" colspan="4" style="font-size: 25px; font-weight: bold; text-align: center;">
                            <input id="PublicRecordE" runat="server" class="auto-style23" readonly="true" placeholder="Enter Your Records (if you have)" type="text" /></td>
                      </tr>
                      <tr>
                          <td class="auto-style25" colspan="4" style="font-size: 25px; font-weight: bold; text-align: center;">Credit Score</td>
                      </tr>
                      <tr>
                          <td class="auto-style25">Experian </td>
                          <td class="auto-style25">
                                <input id="ExperianE" runat="server" class="readCSS" readonly="true" type="number" /></td>
                          <td class="auto-style25">Equifax </td>
                          <td class="auto-style25">
                                <input id="EquifaxE" runat="server" class="readCSS" readonly="true" type="number" /></td>
                      </tr>
                      <tr >
                          <td class="auto-style25">Trans Unio</td>
                          <td class="auto-style25">
                                <input id="TransUnioE" runat="server" class="readCSS" readonly="true" type="number" /></td>
                          <td class="auto-style25">Fico 2</td>
                          <td class="auto-style25">
                                <input id="fico2E" runat="server" class="readCSS" readonly="true" type="number" /></td>
                      </tr>
                      <tr>
                          <td class="auto-style25">Fico 3</td>
                          <td class="auto-style25">
                                <input id="fico3E" runat="server" class="readCSS" readonly="true" type="number" /></td>
                          <td class="auto-style25">Fico 8</td>
                          <td class="auto-style25">
                                <input id="fico8E" runat="server" class="readCSS" readonly="true" type="number" /></td>
                      </tr>
                  </table>
            
            
            <br />
            

            <br />
            
            
            <br />        
            
        </div>
                  <br />
                  <br />
                  <br />
                  <br />
                  <br />
                  <br />
        </div>              
            <br />
               <div><h1 style="text-align: center; color: #5D7B9D;">Account</h1>
                  <br />
                   <br />
                   <asp:GridView ID="GridView1" runat="server" CssClass="myg" DataKeyNames="Id" AutoGenerateColumns="False" CellPadding="4"  ForeColor="#333333" GridLines="None" >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>   
                        <asp:TemplateField HeaderText="ID" Visible="false"  >
                            <ItemTemplate >
                                <asp:Label ID="lId" runat="server" Text='<%#Eval("Id") %>' Visible="false" />
                                                       
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Height="30px" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Account Name" >
                            <ItemTemplate>
                                <asp:Label ID="lAccountName" runat="server" Text='<%#Eval("AccountName") %>'  />
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Height="30px" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Account Number">
                            <ItemTemplate>
                                <asp:Label ID="lAccountNum" runat="server" Text='<%#Eval("AccountNum") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Original Creditor">
                            <ItemTemplate>
                                <asp:Label ID="lOriginalCreditor" runat="server" Text='<%#Eval("OriginalCreditor") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Company Sold">
                            <ItemTemplate>
                                <asp:Label ID="lCompanySold" runat="server" Text='<%#Eval("CompanySold") %>' />
                            </ItemTemplate>
                            <ControlStyle BackColor="White" Height="20px" />
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Account Type">
                            <ItemTemplate>
                                <asp:Label ID="lAccountType" runat="server" Text='<%#Eval("AccountType") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date Opened">
                            <ItemTemplate>
                                <asp:Label ID="lDateOpened" runat="server" Text='<%#Eval("DateOpened") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Account Status">
                            <ItemTemplate>
                                <asp:Label ID="lAccountStatus" runat="server" Text='<%#Eval("AccountStatus") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Payment Status">
                            <ItemTemplate>
                                <asp:Label ID="lPaymentStatus" runat="server" Text='<%#Eval("PaymentStatus") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Status Updated">
                            <ItemTemplate>
                                <asp:Label ID="lStatusUpdated" runat="server" Text='<%#Eval("StatusUpdated") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Original Balance">
                            <ItemTemplate>
                                <asp:Label ID="lOriginalBalance" runat="server" Text='<%#Eval("OriginalBalance") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>             
                        <asp:TemplateField HeaderText="Balance Updated">
                            <ItemTemplate>
                                <asp:Label ID="lBalanceUpdated" runat="server" Text='<%#Eval(" BalanceUpdated") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Credit Limit">
                            <ItemTemplate>
                                <asp:Label ID="lCreditLimit" runat="server" Text='<%#Eval("CreditLimit") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Monthly Payment">
                            <ItemTemplate>
                                <asp:Label ID="MonthlyPayment" runat="server" Text='<%#Eval("MonthlyPayment") %>'  />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Past Due Amount">
                            <ItemTemplate>
                                <asp:Label ID="lPastDueAmount" runat="server" Text='<%#Eval("PastDueAmount") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Highest Balance">
                            <ItemTemplate>
                                <asp:Label ID="lHighestBalance" runat="server" Text='<%#Eval("HighestBalance") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Terms">
                            <ItemTemplate>
                                <asp:Label ID="lTerms" runat="server" Text='<%#Eval("Terms") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Responsibility">
                            <ItemTemplate>
                                <asp:Label ID="lResponsibility" runat="server" Text='<%#Eval("Responsibility") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Your Statement">
                            <ItemTemplate>
                                <asp:Label ID="lYourStatement" runat="server" Text='<%#Eval("YourStatement") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Comments">
                            <ItemTemplate>
                                <asp:Label ID="lComments" runat="server" Text='<%#Eval("Comments") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="status" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lstatus" runat="server" Text='<%#Eval("status") %>' Visible="false" />
                                <asp:Button ID="change" runat="server" Text="change" OnClick="change_Click" />
                                <asp:Button Text="Delete" runat="server" CommandName="Delete" ToolTip="Delete" OnClientClick="return confirm('Are you sure  you want to delete the Account?')" />
                            
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LoansId" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="LoansId" runat="server" Text='<%#Eval("LoansId") %>' Visible="false" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Height="30px" />
                        </asp:TemplateField>
                        <asp:TemplateField>
                            

                            <ItemTemplate>
                                <asp:Label ID="lId" runat="server" Text='<%#Eval("Id") %>' Visible="false" />
                                                       
                                
</ItemTemplate>


<ItemStyle HorizontalAlign="Center"></ItemStyle>
                       </asp:TemplateField>       
                    </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>   
               <br />
       <br />
                   <br />
              
                    <h1 style="text-align: center; color: #5D7B9D;" class="auto-style19">Inquiries</h1>
       
              
                    <br />
            <br />
            <div style="text-align: center">
                 <asp:GridView ID="GridView2" CssClass="auto-style26" runat="server" DataKeyNames="Id" AutoGenerateColumns="False" CellPadding="4"  ForeColor="#333333" GridLines="None" Height="524px" Width="707px" >
                     <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                     <Columns>                      
                        <asp:TemplateField HeaderText="Id" Visible="False" >
                            <ItemTemplate>
                                <asp:Label ID="lId" runat="server" Text='<%#Eval("Id") %>' Visible="false" />
                            
                               <asp:Button ID="Changeinq" runat="server" Text="Change" OnClick="Changeinq_Click" />
                               <asp:Button ID="DeleteInq" Text="Delete" runat="server" CommandName="Delete" ToolTip="Delete" OnClientClick="return confirm('Are you sure  you want to delete the Account?')" OnClick="DeleteInq_Click" />
                            
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Bank Name">
                            <ItemTemplate>
                                <asp:Label ID="lNameOfBank" runat="server" Text='<%#Eval("NameOfBank") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Inquiry Date">
                            <ItemTemplate>
                                <asp:Label ID="lInquiryDate" runat="server" Text='<%#Eval("InquiryDate") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Removal Date">
                            <ItemTemplate>
                                <asp:Label ID="lRemovalDate" runat="server" Text='<%#Eval("RemovalDate") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Business Type">
                            <ItemTemplate>
                                <asp:Label ID="lBusinessType" runat="server" Text='<%#Eval("BusinessType") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Contact Information">
                            <ItemTemplate>
                                <asp:Label ID="lContactInformation" runat="server" Text='<%#Eval("ContactInformation") %>' />
                            </ItemTemplate>
                            <HeaderStyle Height="30px" />
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LoansId" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lLoansId" runat="server" Text='<%#Eval("LoansId") %>' Visible="false" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>         
                        <asp:TemplateField>
                            

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:TemplateField>
                    </Columns>
                     <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
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
            <br />
               <br />
              <br />
              <br />
            <br/>
              <div id="Div6" runat="server">

            
            <br />
            <div>
            </div>

            <br />
            <br />
            <br />
             <table class="auto-style12">
                <tr>
                    <td class="auto-style18" style="background-color: #FFFFFF">
                        &nbsp;</td>
                    <td style="text-align: center; background-color: #FFFFFF;">
                        &nbsp;</td>
                    <td style="text-align: right; background-color: #FFFFFF;">
                   
                   <asp:Button ID="Edit" runat="server" Text="Edit" Font-Size="Large" Height="37px" Width="89px" BackColor="White" OnClick="Edit_Click"    />
                   
                   <asp:Button ID="Button12" runat="server" Text="Send" Font-Size="Large" Height="37px" Width="89px" BackColor="White" OnClick="Send_Click" Visible="False"    />
                   
                   <asp:Button ID="Button13" runat="server" Text="Finish" Font-Size="Large" Height="37px" Width="89px" BackColor="White" CssClass="auto-style83" OnClick="Finish_Click"   />
                   
                    </td>
                </tr>
            </table>
            <div style="text-align: center">
                    </div>
        </div>

          </div>
               </div>
    </form>

</body>
</html>
