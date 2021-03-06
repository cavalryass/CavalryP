﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountManager.aspx.cs" Inherits="CavalryP.ManagerFolder.AccountManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <link href="~/Styles/GlobalS.css" rel="stylesheet" type="text/css" media="screen" runat="server" />

    <title></title>
    <style type="text/css">
          .header {
    padding: 60px;
    text-align: center;
    background: #5D7B9D;
    color: white;
    font-size: 30px;
}
        
          .myTable{
           margin-left: auto; 
  margin-right: auto;
      }
      
          .readCSS{  
              width: 150px;
              height:18px;
              padding: 12px 20px;
              margin: 8px 0;
              box-sizing: border-box; 
              border-color:rgb(93,123,157);
              border-style:solid;
              border-width:2px;
              border-radius: 6px;

          }
          .mydropdownlist1{
              color:black;
              height:30px;
              width:150px ;
              padding: 5px 10px;
              border-color:rgb(93,123,157);
              border-style:solid;
              border-width:2px;
              border-radius: 6px;
              background-color:white;

          }
          .smalluttons{
              background-color:rgb(93,123,157);              
              border: none;
              color: white;
              height:30px;
              width:90px;
              text-align: center;
              text-decoration: none;
              display: inline-block;
              font-size: 16px;
              margin: 4px 2px;
              cursor: pointer;
              border-radius: 4px;
        }
          .gvButton{
               height:27px;
              background-color:white;
              border-color:rgb(93,123,157);
              border-radius:5px;

          }

.buttonAsLink{
          background: none!important;
  border: none;
  padding: 0!important;
  /*optional*/
  font-family: arial, sans-serif;
  /*input has OS specific font-family*/
  color: #069;
  text-decoration: underline;
  cursor: pointer;
      }        .auto-style1 {
            height: 30px;
        }
        .auto-style2 {
            width: 356px;
            margin:0 auto;
        }
       
        .auto-style4 {
            width: 357px;
            margin: 0 auto;
        }
        .auto-style5 {
            width: 4584px;
            margin: 0 auto;
        }
       
        .auto-style6 {
            width: 1675px;
        }
        .auto-style7 {
            width: 4584px;
        }
       
        .auto-style8 {
            width: 308px;
        }
        .auto-style9 {
            width: 1491px;
        }
       
        .auto-style12 {
            width: 173px;
        }
       
        .auto-style13 {
            width: 739px;
        }
        .auto-style14 {
            width: 197px;
        }
               
        .auto-style16 {
            width: 545px;
            margin: 0 auto;
        }
        .auto-style17 {
            width: 543px;
            margin: 0 auto;
        }
       
        .auto-style18 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            background-color: rgb(93,123,157);
            color: white;
            height: 30px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            border-radius: 4px;
        }
       
        .auto-style19 {
            width: 306px;
        }
       
        .auto-style20 {
            width: 100%;
        }
        .auto-style21 {
            margin: 0 auto;
        }
       
    </style>
</head>
<body >
    <form id="form1" runat="server" >
      <div class="topnav">
                 <asp:Button ID="category" runat="server"   OnClick="category_Click" Text="Category" CssClass="button" />
                        <asp:Button ID="clients" runat="server" CssClass="button" OnClick="clients_Click" Text="Clients" />
          <asp:Button ID="AccRep" runat="server" OnClick="AccRep_Click" Text="Accounts Reports" CssClass="button" />
        <div class="search-container">
                    <div>
                          <button runat="server" class="button" style="color: #000000" onserverclick="LogOut_Click">
                            Log Out</button>
                    </div>
                </div>
                
                 
                
            </div>
       <br />
        <br />
            <div class="header" style="border-radius:2px 2px 2px 2px"><h1>Account</h1></div>
        <br />
        <br />
        <div class="main" id="maindiv" runat="server" visible="false">
                <br />
                
            <div id="AddDiv" runat="server" > 
                <table class="auto-style16" style="text-align: left; font-size: 21px;">
            <tr>
                <td colspan="2" style="text-align: center; font-size: 30px;" >Create New Account</td>
            </tr>
            <tr>
                <td >Account Number:</td>
                <td>
                    <input id="AccNum" runat="server" type="text" class="readCSS"/></td>
            </tr>
            <tr>
                <td class="auto-style4">Email Address (Account Notifications):</td>
                <td>
                    <input id="oMail" runat="server" class="readCSS" type="text"  /></td>
            </tr>
            <tr>
                <td class="auto-style6">Account Ownership:</td>
                <td style="text-align: left"> 
                        <asp:DropDownList ID="txtkind" runat="server" CssClass="mydropdownlist1">
                                             <asp:ListItem>Owner Account</asp:ListItem>
                                             <asp:ListItem>Company Account</asp:ListItem>
                                              <asp:ListItem>Credit</asp:ListItem>
                                         </asp:DropDownList>

                </td>
            </tr>
            <tr>
                <td class="auto-style6">Owners Equity (Within Account):</td>
                <td style="text-align: left">
                      <input id="equity" runat="server" class="readCSS" type="number"  value="0" />
  
                </td>

            </tr>
            <tr>
                <td class="auto-style1" style="color: #FFFFFF; font-size: 21px; font-weight: bold; text-align: center;" colspan="2"> 
                    <table class="auto-style20">
                        <tr>
                            <td> 
                    <asp:Button ID="Cancel0" runat="server" Text="Cancel" CssClass="smalluttons" OnClick="Cancel0_Click"  />

                            </td>
                            <td> 
                    <asp:Button ID="Add" runat="server" Text="Add" CssClass="smalluttons" OnClick="Add_Click" />

                            </td>
                        </tr>
                    </table>

                </td>
            </tr>
        </table>

            </div> 
            <div id="UpdateDiv" runat="server" visible="false" > 
        <table class="auto-style17" style="text-align: left; font-size: 21px;">
            <tr>
                <td colspan="2" style="text-align: center; font-size: 30px;"  >Update Account</td>
            </tr>
            <tr>
                <td class="auto-style7"  >Account Number:</td>
                <td>
                    <input id="UAccNum" runat="server" type="text" class="readCSS" /></td>
            </tr>
            <tr>
                <td class="auto-style7" >Email Address (Account Notifications):</td>
                <td>
                    <input id="UoMail" runat="server" class="readCSS" type="text"  /></td>
            </tr>
            <tr>
                <td class="auto-style7" >Account Ownership:</td>
                <td style="text-align: left"> 
                    <asp:DropDownList ID="Ukinddd" runat="server" CssClass="mydropdownlist1">
                                         <asp:ListItem>Owner Account</asp:ListItem>
                                         <asp:ListItem>Company Account</asp:ListItem>
                                          <asp:ListItem>Credit</asp:ListItem>
                                     </asp:DropDownList>

                </td>
            </tr>
            <tr>
                <td class="auto-style21" style="color: #FFFFFF; font-size: 21px; font-weight: bold; text-align: center;" colspan="2"> 
                    <table class="auto-style20">
                        <tr>
                            <td> 
                    <asp:Button ID="Cancel" runat="server" Text="Cancel" CssClass="smalluttons" OnClick="Cancel_Click"  />

                            </td>
                            <td> 
                    <asp:Button ID="Update" runat="server" Width="100px" Text="Update" CssClass="auto-style18" OnClick="Update_Click"  />

                            </td>
                        </tr>
                    </table>

                </td>
            </tr>
        </table>
        
    </div>
                <br />
                <div style="text-align: center">
              <asp:Label ID="Error" runat="server" BackColor="White" ForeColor="#FF3300" Font-Size="X-Large"></asp:Label>
        
                </div>
                    <br />
            </div>
            
                <br />
     
        

               <br />
        <div style="text-align: center">
        <asp:GridView ID="AccGV" runat="server" style="margin:0 auto;" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Width="1603px" GridLines="None">
           
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
                         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                         <Columns>
                        <asp:TemplateField HeaderText="Account Number">
                                 <ItemTemplate>
                                     <asp:Label ID="laccountNum" Text='<%#Eval("AccountNum")%>' runat="server" />
                                 </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Email">
                                 <ItemTemplate>
                                     <asp:Button ID="lownermail" CssClass="buttonAsLink" Text='<%#Eval("Ownermail")%>' runat="server" OnClick="lownermail_Click" />
                                 </ItemTemplate>                                
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Account's Balance ">
                                 <ItemTemplate>
                                     <asp:Label ID="lBalance" Text='<%#Eval("Balance")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Owner’s Equity ">
                                 <ItemTemplate>
                                     <asp:Label ID="lequity" Text='<%#Eval("Equity")%>' runat="server" />
                                 </ItemTemplate>                                
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Accounts<br/> open Balance ">
                                 <ItemTemplate>
                                     <asp:Label ID="ldebt" Text='<%#Eval("Debt")%>' runat="server" />
                                 </ItemTemplate>                               
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
             </asp:TemplateField>
                        <asp:TemplateField HeaderText="Uncleared <br/>Ledger Balance ">
                                 <ItemTemplate>
                                     <asp:Label ID="lSBalance" Text='<%#Eval("SBalance")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Uncleared<br/>Owners Equity ">
                                 <ItemTemplate>
                                     <asp:Label ID="lSequity" Text='<%#Eval("Sequity")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Uncleared Accounts <br/> Open Balance">
                                 <ItemTemplate>
                                     <asp:Label ID="lSdebt" Text='<%#Eval("Sdebt")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
             </asp:TemplateField>
                        <asp:TemplateField HeaderText="Account Type ">
                                 <ItemTemplate>
                                     <asp:Label ID="lkind" Text='<%#Eval("Kind")%>' runat="server" />
                                 </ItemTemplate>                             
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Publish" Visible="false">
                                 <HeaderTemplate>
                 
</HeaderTemplate>
                                 <ItemTemplate>
                                     <asp:Label ID="luserMail" Visible="false" Text='<%#Eval("UserId")%>' runat="server" />
                            
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField >
                             <HeaderTemplate>
                    <asp:Button runat="server" ID="ShowAdd" CssClass="gvButton" Width="200px" OnClick="ShowAdd_Click" Text="Add New Account"  />
                </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Button ID="Edit" CssClass="gvButton" Text="Edit" runat="server"  ToolTip="Edit" Width="65px" OnClick="Edit_Click"/>
                                <asp:Button Text="Delete" CssClass="gvButton" runat="server" CommandName="Delete" ToolTip="Delete" Width="65px" OnClientClick="return confirm('Are you sure  you want to delete the Account?')" OnClick="Delete_Click" />
                               <asp:Button ID="info" runat="server" CssClass="gvButton" Text="Search Transaction " Width="130px" OnClick="info_Click" />
                                  
                            </ItemTemplate>
                            
<ItemStyle HorizontalAlign="Center" BackColor="White"></ItemStyle>
                            
                        </asp:TemplateField>
                    </Columns>
        </asp:GridView>
            </div>
        <br />
        <br />
        <br />
        <div id="information" runat="server" visible="false" style="text-align: center" >
           
            <h1>The following fields are not required to fill</h1>
            <table class="auto-style9" id="filterT" runat="server" style="margin:0 auto;">
                    <tr>
                        <td class="auto-style27">
                            From
                        </td>
                        <td class="auto-style8">
                            
                                 <input id="dateF" runat="server" type="date" class="readCSS" onchange="DateFunction()" />
                        </td>
                        <td class="auto-style29">       
                            To

                        </td>
                        <td class="auto-style12">  
                            <input id="dateT" runat="server" type="date" class="readCSS" />
                                </td>
                        <td class="auto-style14">Category</td>
                        <td >
                            <asp:DropDownList ID="catDD" runat="server" CssClass="mydropdownlist1">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style19">
                         From\To Whom</td>
                        <td class="auto-style13">
                            <asp:DropDownList ID="accDD" runat="server" CssClass="mydropdownlist1" AutoPostBack="true" OnSelectedIndexChanged="acccDD_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:TextBox ID="accTF" runat="server" BorderColor="Gray" BackColor="White" class="readCSS"></asp:TextBox>
                        </td>
                        <td style="text-align: left">
                            <asp:Button ID="filter" runat="server" Text="Search" CssClass="gvButton" OnClick="filter_Click"   />
                        </td>
                    </tr>
                </table>               
            <br />
              <asp:Label ID="Error1" runat="server" BackColor="White" ForeColor="#FF3300" Font-Size="X-Large"></asp:Label>
        </div>
            <br />
            <br />
            <div id="AccountReportDiv" runat="server" visible="false">
                <div class="regform">
                    <h1><asp:Label ID="AccountReportTitle" runat="server"></asp:Label></h1>
</div>
                <br />
                <br />
            <asp:GridView ID="infoGV" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataKeyNames="Id" 
                         style="margin:0 auto;" Width="1490px" CssClass="auto-style23">
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
                         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                         <Columns>
                             <asp:TemplateField HeaderText="ID" Visible="false">
                                 <ItemTemplate>
                                     <asp:Label ID="lId" Visible="false" Text='<%#Eval("Id")%>' runat="server" />
                                 </ItemTemplate>                                 
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Type">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("Kind")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="From Account">
                                 <ItemTemplate>
                                     <asp:Label ID="Lrf" Text='<%#Eval("Requestfrom")%>' runat="server" />
                                 </ItemTemplate>                                 
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="To Account">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("RequestTo")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Amount">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("Amount")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Date">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("Date")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>
                             
                             <asp:TemplateField HeaderText="Category">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("Category")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Check Number">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("CheckNum")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Bank Name">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("BankName")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>
                               <asp:TemplateField HeaderText="Enter To Bank">
                                 <ItemTemplate>
                                     <asp:CheckBox onclick="return false;" Checked='<%#Convert.ToBoolean(Eval("enterb"))%>' runat="server" />
                                 </ItemTemplate>
                                   <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>  
                             <asp:TemplateField HeaderText="Invoice Number">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("InvoiceNum")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>   
                             <asp:TemplateField HeaderText="Comment">
                                 <ItemTemplate>
                                     <asp:Label Width="200px" Text='<%#Eval("Comment")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Publish" Visible="false">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("UserId")%>' runat="server" Visible="false" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" />
                             </asp:TemplateField>
                            
                         </Columns>
                     </asp:GridView>
        </div>
            <br />

        
        <script>
        function DateFunction() {
            var x = document.getElementById("dateT");
            x.setAttribute("min", document.getElementById("dateF").value);
           
        }

        </script>
    </form>
</body>
</html>
