﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccInformation.aspx.cs" Inherits="CavalryP.SecretaryFolder.AccInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link href="~/Styles/GlobalS.css" rel="stylesheet" type="text/css" media="screen" runat="server" />

    <style type="text/css">
            
          .regform{
            width:1400px;
            background-color:rgba(0,0,0,0.15);            
            margin:auto;
            color:rgb(93,123,157);
            padding:10px 0px 10px 0px;
            text-align:center;
            border-radius:15px 15px 15px 15px;
        }
          .myTable{
           margin-left: auto; 
  margin-right: auto;
      }
          .main{
            background-color:rgba(0,0,0,0.1);
            width:1400px;
            margin:auto;
            border-radius:0px 0px 15px 15px;
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
              background-color:white;
              border:none;
              border-radius:5px;


          }
        .auto-style1 {
            height: 20px;
        }
        .auto-style2 {
            height: 48px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style10 {
            width: 1882px;
        }
        .auto-style11 {
            width: 164px;
            height: 96px;
        }
        .auto-style12 {
            width: 201px;
            height: 96px;
        }
        .auto-style13 {
            height: 96px;
        }
        .auto-style14 {
            height: 48px;
            width: 232px;
        }
        .auto-style15 {
            width: 1206px;
        }
        .auto-style16 {
            height: 48px;
            width: 220px;
        }
        .auto-style17 {
            border: 2px solid rgb(93,123,157);
            padding: 12px 20px;
            margin: 8px 0;
            box-sizing: border-box;
            border-radius: 6px;
        }
        .auto-style18 {
            height: 48px;
            width: 108px;
        }
        .auto-style19 {
            height: 48px;
            width: 155px;
        }
        .auto-style20 {
            border: 2px solid rgb(93,123,157);
            color: black;
            height: 30px;
            width: 150px;
            padding: 5px 10px;
            border-radius: 6px;
            background-color: white;
            margin-bottom: 0px;
        }
        .auto-style21 {
            height: 25px;
        }
        .auto-style22 {
            height: 96px;
            width: 248px;
        }
        .auto-style23 {
            height: 96px;
            width: 110px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
       <div>
           <div class="topnav">
                <asp:Button ID="ManagedUsers" runat="server" CssClass="button" Text="Managed Users" OnClick="ManagedUsers_Click" />
               <asp:Button ID="AccManager" runat="server" CssClass="button" Text="Back" OnClick="AccManager_Click"  />
               
           <div class="search-container">
                    <div>
                          <button runat="server" class="button" style="color: #000000" onserverclick="logOut_Click">
                            Log Out</button>
                    </div>
                </div>
                
                       
                
            </div>
            <br />
            <br />
            <div class="header" style="border-radius:2px 2px 2px 2px"><h1>Accounts Reports</h1></div>
           <br />
           <br />
           <div class="main" id="maindiv" runat="server" visible="false" style="text-align: center">
                    <table style="color: #000000; text-align: center; font-size: 20px; margin:0 auto" class="auto-style15">
                        <tr>
                             <td class="auto-style19">
                                 Type</td>
                             <td class="auto-style16">
                                <asp:DropDownList ID="ddkind"  runat="server"  Width="133px"   AutoPostBack="true" OnSelectedIndexChanged="ddkind_SelectedIndexChanged" CssClass="auto-style20">
                                    <asp:ListItem>Regular</asp:ListItem>
                                    <asp:ListItem>Income</asp:ListItem>
                                    <asp:ListItem>Expenses</asp:ListItem>
                                    <asp:ListItem>Third party</asp:ListItem>
                                </asp:DropDownList>
                             </td>
                             <td class="auto-style18">
                                 </td>
                             <td class="auto-style14">
                                 </td>
                             <td class="auto-style14">
                                 </td>
                             <td class="auto-style14">
                                 </td>
                         </tr>
                        <tr>
                             <td class="auto-style21" colspan="6" style="font-size: small">
                                 <asp:Label ID="tpL" runat="server" Text="* By clicking On Third Party One Of The Account Must Be An External Account Unrelated To The Company" Visible="false"></asp:Label>
                             </td>
                         </tr>
                        <tr>
                             <td class="auto-style19">
                                 From Account:</td>
                             <td class="auto-style16">
                                 <asp:DropDownList ID="fromDD" runat="server"  Width="156px"  AutoPostBack="True" OnSelectedIndexChanged="DropDownListAccountFrom_SelectedIndexChanged" CssClass="mydropdownlist1">
                                 </asp:DropDownList>
                             </td>
                             <td class="auto-style18">
                                 <asp:TextBox ID="fromtxt" runat="server" Height="16px" CssClass="auto-style17" Width="115px"></asp:TextBox>
                             </td>
                             <td class="auto-style14">
                                 To Account:</td>
                             <td class="auto-style14">
                                 <asp:DropDownList ID="toDD"  runat="server" CssClass="mydropdownlist1"  Width="156px" AutoPostBack="True" OnSelectedIndexChanged="DropDownListAccountTo_SelectedIndexChanged"  >
                                 </asp:DropDownList>
                             </td>
                             <td class="auto-style14">
                                 <asp:TextBox ID="totxt" runat="server" Height="16px" CssClass="auto-style17" Width="114px"></asp:TextBox>
                             </td>
                         </tr>
                        <tr>
                             <td class="auto-style19">
                                 Category:</td>
                             <td class="auto-style16">
                                 <asp:DropDownList ID="ddcategory" CssClass="mydropdownlist1"  runat="server"  Width="156px"   >
                                 </asp:DropDownList>                              
                             </td>
                             <td class="auto-style18">
                                 &nbsp;</td>
                             <td class="auto-style14">
                                Date:</td>
                             <td class="auto-style14">
                                 <input id="dateP1" runat="server" class="readCSS" style="width:170px;" type="date"  /></td>
                             <td class="auto-style14">
                                 &nbsp;</td>
                         </tr>
                        <tr>
                             <td class="auto-style19">
                                 Check Number:</td>
                             <td class="auto-style16">
                                 <asp:TextBox ID="checkNumtxt" runat="server" OnTextChanged="checkNumtxt_TextChanged" AutoPostBack="true"  Width="150px" Height="22px" CssClass="readCSS"   ></asp:TextBox>                              
                             </td>
                             <td class="auto-style18">
                                 &nbsp;</td>
                             <td class="auto-style14">
                                Amount:</td>
                             <td class="auto-style14">
                                 <asp:TextBox ID="amounttxt" runat="server" Width="150px" Height="18px" CssClass="readCSS"  ></asp:TextBox>
                             </td>
                             <td class="auto-style14">
                                 <asp:CheckBox ID="enterb" runat="server" Text="Enter to Bank" />                    
                             </td>
                         </tr>
                        <tr>
                             <td class="auto-style19">
                                 <asp:Label ID="bankNameL" runat="server" Text="Bank's Name" Visible="false"></asp:Label>
                             </td>
                             <td class="auto-style16">
                                 <asp:TextBox ID="bankNametxt" runat="server" Height="22px" Width="150px" CssClass="readCSS" ></asp:TextBox>                
                             </td>
                             <td class="auto-style18">
                                 &nbsp;</td>
                             <td class="auto-style14">
                                 <asp:Label ID="invoiceL" runat="server" Text="Invoice" Visible="false"></asp:Label>
                             </td>
                             <td class="auto-style14">
                                 <asp:TextBox ID="invoicetxt" runat="server" Width="150px" Height="18px" CssClass="readCSS" ></asp:TextBox>
                             </td>
                             <td class="auto-style14">
                                 &nbsp;</td>
                         </tr>
                        <tr>
                             <td class="auto-style19">
                                 &nbsp;</td>
                             <td class="auto-style16">
                                 &nbsp;</td>
                             <td class="auto-style2" colspan="2">
                                 &nbsp;</td>
                             <td class="auto-style2">
                                 &nbsp;</td>
                             <td class="auto-style2">
                                 &nbsp;</td>
                         </tr>
                        <tr>
                             <td class="auto-style1" colspan="2" >
                                 Comment</td>
                             <td class="auto-style1" colspan="4" >
                     <asp:TextBox ID="comenttxt" runat="server" Height="80px" Width="424px" CssClass="readCSS"></asp:TextBox>
                             </td>
                         </tr>
                        <tr>
                             <td class="auto-style5" colspan="2" >
                        <asp:Button ID="cancel" runat="server" Text="Cancel" CssClass="smalluttons"  />
                             </td>
                             <td class="auto-style5" colspan="2" >
                                 &nbsp;</td>
                             <td class="auto-style5" >
                                 <asp:Button ID="Add" runat="server" Text="Add" CssClass="smalluttons" OnClick="Add_Click"  />
                             </td>
                             <td class="auto-style5" >
                                 &nbsp;</td>
                         </tr>
                     </table>
                <br />
                <br />
                <div style="text-align: center">
                        <asp:Label ID="comment2" runat="server" ForeColor="#FF3300" Font-Size="X-Large"></asp:Label>
                
                      <asp:Label ID="Label7" runat="server" Text="Label" Visible="false"></asp:Label>
                
                </div>
                    <br />
            </div>
            
        

       </div>
            <div  >
                <p>
                    <asp:Label ID="Label1" runat="server" Text="Reports: " ForeColor="White" Font-Size="XX-Large"></asp:Label>                  
                </p>
                <div id="AddUpdateinfo" runat="server" style="margin-left: 14px">
                    <div>
                    <asp:Label ID="idL" runat="server" Text="" Visible="false"></asp:Label>  
               </div>
                    <asp:Label ID="comentL" runat="server" Text="Comment" ForeColor="White"></asp:Label>
                    
                    </div>
               <div id="searchdiv" runat="server" class="auto-style49" style="text-align: center">
                       <table class="auto-style10" style="margin:0 auto">
                           <tr>
                               <td class="auto-style13" colspan="13" style="font-size: x-large">
                                   Choose The Filter Details:</td>
                           </tr>
                           <tr>
                               <td class="auto-style13">
                      Date:
                               </td>
                               <td class="auto-style22">
                                   <input id="dateP2" runat="server" class="readCSS" style="width:170px;"  type="date" />
                                   
                                   
                </td>
                       <td>
                           Type:
                       </td>
                               
                               <td class="auto-style13">
                                   <asp:DropDownList ID="DropDownList1" runat="server"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" CssClass="mydropdownlist1" >
                                       <asp:ListItem>Regular</asp:ListItem>
                                       <asp:ListItem>Income</asp:ListItem>
                                       <asp:ListItem>Expenses</asp:ListItem>
                                       <asp:ListItem>Third party</asp:ListItem>
                                       <asp:ListItem>All</asp:ListItem>
                                   </asp:DropDownList>
                                   </td>
                               <td class="auto-style13">
                
                                   From Account:</td>
                               <td class="auto-style12">
                    <asp:DropDownList ID="sFromdd" runat="server" CssClass="mydropdownlist1" OnSelectedIndexChanged="Fromdd_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

                                    <asp:TextBox ID="ftxt" runat="server" CssClass="readCSS" Visible="false" ></asp:TextBox>

                                    </td>
                               <td class="auto-style13">

                                   To Account:</td>
                               <td class="auto-style11">
                    <asp:DropDownList ID="sTodd" runat="server"  OnSelectedIndexChanged="Todd_SelectedIndexChanged" AutoPostBack="true" CssClass="mydropdownlist1"></asp:DropDownList>
                                   <asp:TextBox ID="ttxt" runat="server"  CssClass="readCSS" Visible="false"></asp:TextBox>
                               </td>
                               <td class="auto-style13">
                    
                                   Amount:</td>
                               <td class="auto-style13">
                    
                                   <asp:TextBox ID="amount" runat="server" CssClass="readCSS" ></asp:TextBox>

                               </td>
                               <td class="auto-style23">
                                   Enter To Bank:</td>
                               <td class="auto-style13">
                                   <asp:DropDownList ID="DropDownList2" runat="server" CssClass="mydropdownlist1">
                                       <asp:ListItem>All</asp:ListItem>
                                       <asp:ListItem>True</asp:ListItem>
                                       <asp:ListItem Value="False">False</asp:ListItem>
                                   </asp:DropDownList>

                               </td>
                               <td class="auto-style13">
                    
                    <asp:Button ID="search" runat="server" Text="Search" CssClass="smalluttons" OnClick="search_Click"  />

                               </td>
                           </tr>
                       </table>                 

               </div>
                
                 
                <br />
                <div style="text-align: center" >
                <br />
                
                    <asp:Label ID="Comment" runat="server" ForeColor="#FF3300" Font-Size="Large"></asp:Label>
                    <br />
                          <br />       
                  <div id="AccountReportDiv" runat="server" >
                <div class="regform">
                    <h1><asp:Label ID="AccountReportTitle" runat="server">Report</asp:Label></h1>
</div>
                      </div>
                <br />
                <br />

                <asp:GridView ID="GridView1" runat="server" DataKeyNames="Id" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style48"  style="margin: 0 auto" Width="1495px" ForeColor="#333333" GridLines="None">
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle ForeColor="#333333" BackColor="#F7F6F3" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField >
                               <HeaderTemplate>
                    <asp:Button runat="server" ID="ShowAdd" CssClass="gvButton" Height="30px"  Width="100px" OnClick="ShowAdd_Click" Text="Add New"  />
                </HeaderTemplate>
                             <ItemTemplate>
                                 <asp:Button ID="Select" ForeColor="#000066" runat="server"  BackColor="Transparent" BorderColor="Transparent" Text="Edit" Font-Bold="False"  Font-Underline="True" OnClick="Select_Click" />
                                 <asp:Button ID="Delete" ForeColor="#000066" runat="server" CommandName="Delete" BackColor="Transparent" BorderColor="Transparent" Text="Delete" Font-Bold="False" OnClientClick="return confirm('Are you sure?');" Font-Underline="True" />                                 
                             </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" ForeColor="#006699" BackColor="White"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ID" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lID" runat="server" Text='<%#Eval("Id") %>' Visible="false" />
                                </ItemTemplate>
                            <ControlStyle Width="50px" />
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Type">
                            <ItemTemplate>
                                <asp:Label ID="lkind" runat="server" Text='<%#Eval("Kind") %>' />
                            </ItemTemplate>
                            <ControlStyle Width="100px" />
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="ldate" runat="server" Text='<%#Eval("Date") %>' />
                            </ItemTemplate>
                            <ControlStyle Width="100px" />
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="From Account">
                            <ItemTemplate>
                                <asp:Label ID="lfrom" runat="server" Text='<%#Eval("Requestfrom") %>' />
                            </ItemTemplate>
                            <ControlStyle Width="100px" />
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="To Account">
                            <ItemTemplate>
                                <asp:Label ID="lto" runat="server" Text='<%#Eval("RequestTo") %>' />
                            </ItemTemplate>
                            <ControlStyle Width="100px" />
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>                        
                        <asp:TemplateField HeaderText="Amount">
                            <ItemTemplate>
                                <asp:Label ID="lamount" runat="server" Text='<%# "$"+Eval("Amount") %>' />
                            </ItemTemplate>
                            <ControlStyle Width="100px" />
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Publish" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lpublish" runat="server" Visible="false" Text='<%#Eval("userId") %>' />
                            </ItemTemplate>
                            <ControlStyle Width="100px" />
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Category">
                            <ItemTemplate>
                                <asp:Label ID="lcategory" runat="server" Text='<%#Eval("Category") %>' />
                            </ItemTemplate>
                            <ControlStyle Width="100px" />
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Check Number">
                            <ItemTemplate>
                                <asp:Label ID="lcheckNum" runat="server" Text='<%#Eval("CheckNum") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Bank Name">
                            <ItemTemplate>
                                <asp:Label ID="lbankName" runat="server" Text='<%#Eval("BankName") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Invoice Number">
                            <ItemTemplate>
                                <asp:Label ID="linvoice" runat="server" Text='<%#Eval("InvoiceNum") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Enter To Bank">
                            
                            <ItemTemplate>
                                <asp:CheckBox ID="lenter" runat="server" Checked='<%#Convert.ToBoolean(Eval("Enterb")) %>' onclick="return false;" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" />
                        </asp:TemplateField>
                       <asp:TemplateField HeaderText="Comment">
                            <ItemTemplate>
                                <asp:Label ID="lcomment" runat="server" Text='<%#Eval("Comment") %>'  />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" BackColor="White" Width="200px" />
                        </asp:TemplateField>
                        
                    </Columns>
                </asp:GridView>
                
                    <br />
                
                </div>
                
             </div>
    </form>
</body>
</html>
