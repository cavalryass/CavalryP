<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loans2Form.aspx.cs" Inherits="CavalryP.LoansFolder.Loans2Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <link href="~/Styles/GlobalS.css" rel="stylesheet" type="text/css" media="screen" runat="server" />

    <title></title>
    <style>
     *{
         padding:0;
         margin:0;
         box-sizing:border-box;
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
              
        .auto-style21 {
            width: 609px;
        }
              
        .auto-style22 {
            height: 31px;
        }
        .auto-style23 {
            height: 37px;
        }
              
    </style>  
</head>
<body >
      <form id="form1" runat="server">  
           <div class="topnav">
<asp:Button ID="lastP" runat="server" CssClass="button" Visible="false" OnClientClick="return confirm('Are You Sure You Want To Exit Without Saving?')" Text="Back" OnClick="lastP_Click1" />
               <asp:Button ID="BackS" runat="server" CssClass="button" Text="Back"  OnClick="lastP_Click1" />
<asp:Button ID="Save" runat="server" CssClass="button" Text="Save"   OnClick="BackSave_Click" />

 <div class="search-container">
<div>

      </div>
</div>
               </div>
       
          <br />
          <br />
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
                    <td colspan="3" style="font-size: 25px; font-weight: bold; text-align: center;" class="auto-style22">My Account Summary</td>
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
                                    <asp:TextBox id="openCC" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true"  /></td>
                    <td>
                         <asp:TextBox id="openRC" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true"  /></td>
                                                        <td>
                                    <asp:TextBox id="openRELoans" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
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
                        <asp:TextBox id="openILoans" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>

                    <td>
                        <asp:TextBox id="TotalOpenAcc" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                                    
                    <td>
                        <asp:TextBox id="AccEverLate" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>

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
                         <asp:TextBox id="CollectionAcc" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                                    
                    <td>Month:<br />
                                    <asp:TextBox id="AvgAccAgeM" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /><br />
                                    Year:<br />
                                    <asp:TextBox id="AvgAccAgeY" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>Month:<br />
                                    <asp:TextBox id="OldestAccM" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /><br />
                                    Year:<br />
                                    <asp:TextBox id="OldestAccY" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
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
                                    <asp:TextBox id="CRDebt" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></strong></td>
                    <td>
                                    <asp:TextBox id="REDebt" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                    <asp:TextBox id="ILDebt" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
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
                                    <asp:TextBox id="CollectionDebt" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                    <asp:TextBox id="TDebt" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                        
                    </td>
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
              
            <asp:TextBox ID="com1" runat="server" Height="80px" Width="1018px" BorderColor="#5D7B9D" BorderStyle="Dotted" ReadOnly="true"></asp:TextBox>
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
            
            
         
            <table class="auto-style8" style="color: #5D7B9D; text-align: center; font-weight: bold; font-size: 20px;">
                <tr>
                    <td colspan="3" style="text-align: center; font-size: 30px; font-weight: bold;">Accounts </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"><span>Account Name</span></td>
                    <td><span>Account #</span></td>
                    <td><span>Original Creditor</span></td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <asp:TextBox id="AccNametxt" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                <asp:TextBox id="AccNumtxt" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                <asp:TextBox id="OCreditortxt" runat="server" CssClass="editCss"  OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"><span>Company Sold</span></td>
                    <td>Account Type</td>
                    <td>Date Opened</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <asp:TextBox id="companyStxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                <asp:TextBox id="AccTypetxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                <input id="DateOpentxt" runat="server" class="editCss" type="date"  /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Account Status</td>
                    <td>Payment Status</td>
                    <td>Status Updated</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <asp:DropDownList ID="AccStatustxt" runat="server" CssClass="mydropdownlist1" OnSelectedIndexChanged="AccStatustxt_SelectedIndexChanged">
                                    <asp:ListItem>Open</asp:ListItem>
                                    <asp:ListItem>Close</asp:ListItem>
                                    <asp:ListItem>Collection</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                    <td>
                                <asp:TextBox id="Pstatustxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                <input id="supdatetxt" runat="server" class="editCss" type="date" /></td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style9">Balance</td>
                    <td>Balance Updated</td>
                    <td>Credit Limit</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <asp:TextBox id="Balancetxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true"/></td>
                    <td>
                                <input id="BUpdate" runat="server" class="editCss" type="date" /></td>
                    <td>
                                <asp:TextBox id="creditLimittxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Monthly Payment</td>
                    <td>Past Due Amount</td>
                    <td>Highest Balance</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <asp:TextBox id="MonthlyPaymenttxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                <asp:TextBox id="PDAmounttxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                <asp:TextBox id="HBalancetxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Terms</td>
                    <td>Original Balance</td>
                    <td>Responsibility</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <asp:TextBox id="Termstxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                <asp:TextBox id="OBalancetxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                <asp:TextBox id="Responsibilitytxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Your Statement</td>
                    <td colspan="2">Comments</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                <asp:TextBox id="Statmenttxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td colspan="2">
                                <asp:TextBox id="Commentstxt" runat="server"  CssClass="bigeditcss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
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
            <asp:GridView ID="CAccs" runat="server" CssClass="myg" DataKeyNames="Id" AutoGenerateColumns="False" CellPadding="4"  ForeColor="#333333" GridLines="None" Width="2000px" >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>   
                        <asp:TemplateField HeaderText="ID" Visible="false" >
                            <ItemTemplate>
                                <asp:Label ID="lId" runat="server" Text='<%#Eval("Id") %>' Visible="false" />
                                
                        
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
                        <asp:TemplateField HeaderText="status" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lstatus" runat="server" Text='<%#Eval("status") %>' Visible="false" />
                                <asp:Button ID="change" runat="server" Text="change" OnClick="change_Click" />
                                <asp:Button Text="Delete" runat="server" CommandName="Delete" ToolTip="Delete" OnClientClick="return confirm('Are you sure  you want to delete the Account?')" />
                            
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LoansId" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="LoansId" runat="server" Text='<%#Eval("LoansId") %>' Visible="false" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="change1" runat="server" BackColor="White" Height="23px" Width="76px" Text="change" OnClick="change_Click" />
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

            <asp:TextBox ID="com2" runat="server" Height="80px" Width="1018px" BorderColor="#5D7B9D" BorderStyle="Dotted" ReadOnly="true"></asp:TextBox>
             <br />
             <br />
            <div style="text-align: left">
            <table class="auto-style14">
                <tr>
                    <td style="background-color: #FFFFFF" class="auto-style13">
                   <asp:Button ID="previous" runat="server" Text="Previous" Font-Size="Large" Height="37px" Width="137px" BackColor="White" OnClick="previous_Click"  />
                    </td>
                    <td style="text-align: center; background-color: #FFFFFF;">
                        &nbsp;</td>
                    <td style="text-align: right; background-color: #FFFFFF;">
                   <asp:Button ID="Next3"  runat="server" Text="Next" Font-Size="Large" Height="37px" Width="155px" BackColor="White" OnClick="Next3_Click"  />
                    </td>
                </tr>
            </table>
       
                    </div>
                  <br />

            <div style="text-align: center">
                   <asp:Label ID="Label8" runat="server" Text="Step 2 Of 5"></asp:Label>
                    </div>

                  <br />
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
                                <asp:TextBox id="Bnametxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                <input id="InqDate" runat="server" class="editCss" type="date" /></td>
                    <td>
                                <input id="REmDAtetxt" runat="server" class="editCss" type="date" /></td>
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
                                <asp:TextBox id="Btype" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                <asp:TextBox id="CInformation" runat="server"  CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                    <td>
                                    &nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                                <asp:Button ID="AddInq" runat="server" BackColor="White" Font-Size="Large" Height="27px" OnClick="AddInq_Click" Text="Add" Width="138px" />
                            </td>
                    <td>&nbsp;</td>
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
                               <asp:Button ID="Changeinq" runat="server" Text="Change" OnClick="Changeinq_Click" />
                               <asp:Button ID="DeleteInq" Text="Delete" runat="server" CommandName="Delete" ToolTip="Delete" OnClientClick="return confirm('Are you sure  you want to delete the Account?')" OnClick="DeleteInq_Click" />
                                
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

            <asp:TextBox ID="com3" runat="server" Height="80px" Width="1018px" BorderColor="#5D7B9D" BorderStyle="Dotted" ReadOnly="true"></asp:TextBox>

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
                   <asp:Label ID="Label7" runat="server" Text="Step 3 Of 5"></asp:Label>
                    </div>
        </div>

           
          <br />
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
                            <asp:TextBox id="record" runat="server" CssClass="bigeditcss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" placeholder="Enter Your Records (if you have)" /></td>

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

            <asp:TextBox ID="com4" runat="server" Height="80px" Width="1018px" BorderColor="#5D7B9D" BorderStyle="Dotted" ReadOnly="true"></asp:TextBox>

            </div>
            <br />
            <br />
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
            <br />
            <div style="text-align: center">
                   <asp:Label ID="Label6" runat="server" Text="Step 4 Of 5"></asp:Label>
                    </div>
            
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
                            <td colspan="4" style="text-align: center; font-size: 30px; font-weight: bold;" class="auto-style23">Credit Score</td>
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
                                <asp:TextBox id="Experiantxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /> </td>
                            <td>Fico 2</td>
                            <td>
                                <asp:TextBox id="fico2" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
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
                                <asp:TextBox id="Equifaxtxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true"/> </td>
                            <td>Fico 3</td>
                            <td>
                                <asp:TextBox id="fico3" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
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
                                <asp:TextBox id="TransUniotxt" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
                            <td>Fico 8</td>
                            <td>
                                <asp:TextBox id="fico8" runat="server" CssClass="editCss" OnTextChanged="openCCtxt_TextChanged" AutoPostBack="true" /></td>
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

            <asp:TextBox ID="com5" runat="server" Height="80px" Width="1018px" BorderColor="#5D7B9D" BorderStyle="Dotted" ReadOnly="true"></asp:TextBox>
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
                   
                    </td>
                </tr>
            </table>
             <div style="text-align: center">
                   <asp:Label ID="Label5" runat="server" Text="Step 5 Of 5"></asp:Label>
                    </div>
        </div>
           
    </form>

</body>
</html>
