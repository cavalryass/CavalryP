<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="ClientManagment.aspx.cs" Inherits="CavalryP.ManagerFolder.ClientManagment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
       <link href="~/Styles/GlobalS.css" rel="stylesheet" type="text/css" media="screen" runat="server" />

    <style type="text/css">
        
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

    .button:hover {
        background-color: #008CBA;
    }
        .auto-style3 {
            height: 30px;
            width: 651px;
        }
        .dropdown-check-list {
  display: inline-block;
}

.dropdown-check-list .anchor {
  position: relative;
  cursor: pointer;
  display: inline-block;
  padding: 5px 50px 5px 10px;
  border: 1px solid #ccc;
}

.dropdown-check-list .anchor:after {
  position: absolute;
  content: "";
  border-left: 2px solid black;
  border-top: 2px solid black;
  padding: 5px;
  right: 10px;
  top: 20%;
  -moz-transform: rotate(-135deg);
  -ms-transform: rotate(-135deg);
  -o-transform: rotate(-135deg);
  -webkit-transform: rotate(-135deg);
  transform: rotate(-135deg);
}

.dropdown-check-list .anchor:active:after {
  right: 8px;
  top: 21%;
}

.dropdown-check-list ul.items {
  padding: 2px;
  display: none;
  margin: 0;
  border: 1px solid #ccc;
  border-top: none;
}

.dropdown-check-list ul.items li {
  list-style: none;
}

.dropdown-check-list.visible .anchor {
  color: #0094ff;
}

.dropdown-check-list.visible .items {
  display: block;
}
.split {
      height: 60%;
  bottom:0;
  position: fixed;
  z-index: 1;
  
  overflow-x: hidden;
  padding-top: 20px;
}

.left {
  left: 0;
  background-color:white;
  width:20%;
}

.right {
    width:80%;
  right: 0;
  background-color:white;
}

.centered {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  text-align: center;
}

.centered img {
  width: 150px;
  border-radius: 50%;
} 
.stepB{
           Height:142px;
           Width:228px;
           border: none;
           color:black;
           padding: 20px;
           text-align: center;
           text-decoration: none;
           display: inline-block;
           font-size: 30px;
           margin: 4px 2px; 
           cursor: pointer;
           border-radius:30px;
           background-color:#cacecf;
       }    
       .stepBh:hover {
  background-color:rgb(134,135,124);
}
        .auto-style4 {
            width: 623px;
            height: 30px;
        }
        .auto-style5 {
            height: 32px;
            width: 918px;
        }
        .auto-style7 {
            width: 516px;
        }
        .select
{
    border-radius: 5px;
   -webkit-appearance: none;
}
        .auto-style9 {
            height: 33px;
        }
        .auto-style10 {
            width: 77%;
        }
        .auto-style11 {
            width: 166px;
        }
        .auto-style12 {
            width: 166px;
            height: 24px;
        }
        .auto-style13 {
            height: 24px;
        }
        .tab {
  overflow: hidden;
  border: 1px solid #ccc;
  background-color: #f1f1f1;
}

/* Style the buttons inside the tab */
.tab button {
  background-color: inherit;
  float: left;
  border: none;
  outline: none;
  cursor: pointer;
  padding: 14px 16px;
  transition: 0.3s;
  font-size: 17px;
}

/* Change background color of buttons on hover */
.tab button:hover {
  background-color: #ddd;
}

/* Create an active/current tablink class */
.tab button.active {
  background-color: #ccc;
}

/* Style the tab content */
.tabcontent {
  display: none;
  padding: 6px 12px;
  border: 1px solid #ccc;
  border-top: none;
}
        .auto-style14 {
            width: 226px;
        }
        .auto-style15 {
            height: 24px;
            width: 226px;
        }
        .auto-style16 {
            width: 166px;
            height: 23px;
        }
        .auto-style17 {
            width: 226px;
            height: 23px;
        }
        .auto-style18 {
            height: 23px;
        }
        .auto-style19 {
            width: 57px;
        }
        .auto-style20 {
            height: 23px;
            width: 36px;
        }
        .auto-style21 {
            height: 24px;
            width: 36px;
        }
        .auto-style22 {
            width: 36px;
        }
        .auto-style23 {
            width: 133px;
        }
        .auto-style24 {
            width: 133px;
            height: 23px;
        }
        .auto-style25 {
            margin-left: 25px;
        }
        .wrapper {
    border:1px solid #000;
    display:inline-block;
}

input,
button {
    background-color:transparent;
    border:0;
}
        .auto-style26 {
            width: 166px;
            height: 26px;
        }
        .auto-style27 {
            width: 226px;
            height: 26px;
        }
        .auto-style28 {
            width: 36px;
            height: 26px;
        }
        .auto-style29 {
            width: 133px;
            height: 26px;
        }
        .auto-style30 {
            height: 26px;
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
        }
        .w3-myfont {
  font-family: "Comic Sans MS", cursive, sans-serif;
}
        .header {
    padding: 60px;
    text-align: center;
    background: #5D7B9D;
    color: white;
    font-size: 30px;
}
    </style>
</head>
<body >
    <form id="form1" runat="server">
       <div class="topnav">
            <asp:Button ID="Account" runat="server" CssClass="button"  OnClick="Account_Click" Text="Account" />
           <asp:Button ID="Category" runat="server" CssClass="button" OnClick="clients_Click" Text="Category" />    
           <div class="search-container">
                    <div>
                        <button runat="server" class="button" style="color: #000000" onserverclick="LogOut_Click">
                            Log Out
                        </button>
                    </div>
                </div>
                
            </div>
        <div class="header" style="text-align: center">
        <p class="w3-jumbo">Clients:</p></div>
                <div id="searchOptions">
            <div>
                <asp:Button ID="showS1" runat="server" Text="Search" OnClick="showS1_Click" />
                <asp:Button ID="ShowAll" runat="server" Text="Show All Client" OnClick="ShowA_Click" />
            </div>
                    <div id="s1" runat="server" style="margin-left:10px;"><h5> Write First Name Or Last Name Or Email Or Phone Number Or You can write more than one of themrite more than one of them</h5>
             <div class="wrapper" style="margin-left:18px;">                
    <input type="text" style="width:120px" id="searchResult" runat="server" placeholder="Search..." />
    <button runat="server" id="searchB" style="background-color:rgb(93,123,157);" onserverclick="searchB_Click"><i class="fa fa-search"></i></button>
</div>
                        </div>
                   
        </div>
             
          <div class="split left">
                          
             
             <asp:GridView ID="listC" runat="server" AutoGenerateColumns="False" CssClass="auto-style19" HorizontalAlign="Left" ShowHeader="False" style="margin-left: 17px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:TemplateField HeaderText="Id" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="Id" runat="server" Text='<%#Eval("Id")%>' Visible="false" />
                    </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="mail" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="mail" runat="server" Text='<%#Eval("Mail")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="name" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="fname" runat="server" Text='<%#Eval("Fname")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="name" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lname" runat="server" Text='<%#Eval("Lname")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="cn" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="companyName" runat="server" Text='<%#Eval("CompanyName")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="address" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="address" runat="server" Text='<%#Eval("Address")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="suite" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="suite" runat="server" Text='<%#Eval("Suite")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="city" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="city" runat="server" Text='<%#Eval("City")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="state" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="state" runat="server" Text='<%#Eval("State")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="zip" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="zip" runat="server" Text='<%#Eval("Zip")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="tel1" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="tel1" runat="server" Text='<%#Eval("WorkNum")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="tel2" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="tel2" runat="server" Text='<%#Eval("HomeNum")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="cell" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="cell" runat="server" Text='<%#Eval("MobileNum")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="fax" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="fax" runat="server" Text='<%#Eval("Fax")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="salesRep" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="salesRep" runat="server" Text='<%#Eval("SalesRep")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="memo" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="memo" runat="server" Text='<%#Eval("Memo")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="middleProcess" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="middleProcess" runat="server" Text='<%#Eval("MiddleProcess")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Request" Visible="false" >
                    <ItemTemplate>
                        <asp:Label ID="Request" runat="server" Text='<%#Eval("Request")%>'  />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="find">
                    <ItemTemplate>
                        <asp:Button ID="findReq" Height="40px"  BackColor="Transparent" Width="156px" BorderColor="#0075c4" ForeColor="#0075c4" Font-Bold="true" runat="server" OnClick="findReq_Click" Text='<%# Eval("Fname")+" "+Eval("Lname") %>' ToolTip='<%#Eval("MobileNum")%>' />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:BoundField />
            </Columns>
                 <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                 <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                 <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#F7F7F7" />
                 <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                 <SortedDescendingCellStyle BackColor="#E5E5E5" />
                 <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
              </div>
        <div class="split right">
            <div id="clientProfile" runat="server" style="text-align: left">

                <table id="cProfile" runat="server" class="auto-style10" >
                    <tr>
                        <td colspan="5" style="text-align:left; font-size: 30px;">Clients Details:</td>
                    </tr>
                    <tr>
                        <td class="auto-style11" style="border-style: none none solid none; border-width: 0px 0px 1px 0px">Name</td>
                        <td style="text-align: center;" class="auto-style14">
                            <asp:Label ID="Nametxt" runat="server" Text=""></asp:Label>
                        </td>
                       <td>&nbsp;</td>
                        <td style="border-style: none none solid none; border-width: 0px 0px 1px 0px" class="auto-style23">Email</td>
                        <td style="text-align: center;">
                            <asp:Button ID="emailtxt" runat="server" Text="" CssClass="buttonAsLink" OnClick="emailtxt_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td class="auto-style14" style="text-align: center">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style23">&nbsp;</td>
                        <td style="text-align: center">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11" style="border-style: none none solid none; border-width: 0px 0px 1px 0px">Billing Address</td>
                        <td style="text-align: center;" class="auto-style14">
                            <asp:Label ID="addresstxt" runat="server"></asp:Label>
                        </td>
                        <td class="auto-style22">&nbsp;</td>
                        <td style="border-style: none none solid none; border-width: 0px 0px 1px 0px" class="auto-style23">Company Name</td>
                        <td style="text-align: center;">
                            <asp:Label ID="companyNtxt" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style16"></td>
                        <td class="auto-style17" style="text-align: center"></td>
                        <td class="auto-style20"></td>
                        <td class="auto-style24"></td>
                        <td class="auto-style18" style="text-align: center"></td>
                    </tr>
                    <tr>
                        <td class="auto-style12" style="border-style: none none solid none; border-width: 0px 0px 1px 0px">Work Phone</td>
                        <td class="auto-style15" style="text-align: center;">
                            <asp:Label ID="worhPtxt" runat="server"></asp:Label>
                        </td>
                        <td class="auto-style21"></td>
                        <td class="auto-style23" style="border-style: none none solid none; border-width: 0px 0px 1px 0px">Home Phone</td>
                        <td class="auto-style13" style="text-align: center;">
                            <asp:Label ID="HomePtxt" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td class="auto-style14" style="text-align: center">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style23">&nbsp;</td>
                        <td style="text-align: center">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style12" style="border-style: none none solid none; border-width: 0px 0px 1px 0px">Mobile Phone</td>
                        <td style="text-align: center;" class="auto-style15">
                            <asp:Label ID="mobilePtxt" runat="server" placeholder="(123) 456-7890"  onkeydown="javascript:backspacerDOWN(this,event);" onkeyup="javascript:backspacerUP(this,event);"></asp:Label>
                        </td>
                        <td class="auto-style21"></td>
                        <td style="border-style: none none solid none; border-width: 0px 0px 1px 0px" class="auto-style23">Fax</td>
                        <td style="text-align: center;" class="auto-style13">
                            <asp:Label ID="faxtxt" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td class="auto-style14" style="text-align: center">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style23">&nbsp;</td>
                        <td style="text-align: center">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11" style="border-style: none none solid none; border-width: 0px 0px 1px 0px">Notes</td>
                        <td style="text-align: center;" class="auto-style14">
                            <asp:TextBox ID="notestxt" runat="server"></asp:TextBox>
                        </td>
                        <td >&nbsp;</td>
                        <td class="auto-style23">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    </table>

                <table id="editProfile" runat="server" visible="false" class="auto-style10" >
                    <tr>
                        <td colspan="5" style="text-align: left; font-size: 30px;" >Clients Details:</td>
                    </tr>
                    <tr>
                        <td class="auto-style11">Name</td>
                        <td style="text-align: center;" class="auto-style14">
  First Name: <asp:TextBox ID="editFName" runat="server" BackColor="#DDDDDD" Height="32px" Width="102px"></asp:TextBox>
        <br />
                            <br /> Last Name: <asp:TextBox ID="editLName" runat="server" BackColor="#DDDDDD" Height="32px" Width="102px"></asp:TextBox>
                        </td>
                       <td>&nbsp;</td>
                        <td>Email</td>
                        <td style="text-align: center;">
                            <asp:TextBox ID="editEmail" runat="server" BackColor="#DDDDDD" Height="32px" Width="185px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style26"></td>
                        <td class="auto-style27" style="text-align: center"></td>
                        <td class="auto-style28"></td>
                        <td class="auto-style29"></td>
                        <td style="text-align: center" class="auto-style30"></td>
                    </tr>
                    <tr>
                        <td class="auto-style26">Billing Address</td>
                        <td class="auto-style27" style="text-align: center">
                            <asp:TextBox ID="editaddress" runat="server" BackColor="#DDDDDD" Height="32px" Width="185px"></asp:TextBox>
                        </td>
                        <td class="auto-style28"></td>
                        <td class="auto-style29">State</td>
                        <td style="text-align: center" class="auto-style30"><asp:DropDownList ID="editstate" CssClass="auto-style26" runat="server" DataTextField="Text" DataValueField="Value" EnableIncrementalSearch="true" CaseSensitiveSearch="true" Width="130px" BackColor="#DDDDDD">
                                          
                                        <asp:ListItem >AL</asp:ListItem>
                                        <asp:ListItem >AK</asp:ListItem>
                                        <asp:ListItem >AZ</asp:ListItem>
                                        <asp:ListItem >AR</asp:ListItem>
                                        <asp:ListItem >CA</asp:ListItem>
                                        <asp:ListItem >CO</asp:ListItem>
                                        <asp:ListItem >CT</asp:ListItem>
                                        <asp:ListItem >DC</asp:ListItem>
                                        <asp:ListItem >DE</asp:ListItem>
                                        <asp:ListItem >FL</asp:ListItem>
                                        <asp:ListItem >GA</asp:ListItem>
                                        <asp:ListItem >HI</asp:ListItem>
                                        <asp:ListItem >ID</asp:ListItem>
                                        <asp:ListItem >IL</asp:ListItem>
                                        <asp:ListItem >IN</asp:ListItem>
                                        <asp:ListItem >IA</asp:ListItem>
                                        <asp:ListItem >KS</asp:ListItem>
                                        <asp:ListItem >KY</asp:ListItem>
                                        <asp:ListItem >LA</asp:ListItem>
                                        <asp:ListItem >ME</asp:ListItem>
                                        <asp:ListItem >MD</asp:ListItem>
                                        <asp:ListItem >MA</asp:ListItem>
                                        <asp:ListItem >MI</asp:ListItem>
                                        <asp:ListItem >MN</asp:ListItem>
                                        <asp:ListItem >MS</asp:ListItem>
                                        <asp:ListItem >MO</asp:ListItem>
                                        <asp:ListItem >NE</asp:ListItem>
                                        <asp:ListItem >NV</asp:ListItem>
                                        <asp:ListItem >NH</asp:ListItem>
                                        <asp:ListItem >NJ</asp:ListItem>
                                        <asp:ListItem >NM</asp:ListItem>
                                        <asp:ListItem >NY</asp:ListItem>
                                        <asp:ListItem >NC</asp:ListItem>
                                        <asp:ListItem >ND</asp:ListItem>
                                        <asp:ListItem >OH</asp:ListItem>
                                        <asp:ListItem >OK</asp:ListItem>
                                        <asp:ListItem>OR</asp:ListItem>
                                        <asp:ListItem >PA</asp:ListItem>
                                        <asp:ListItem >RI</asp:ListItem>
                                        <asp:ListItem >SC</asp:ListItem>
                                        <asp:ListItem >SD</asp:ListItem>
                                        <asp:ListItem >TN</asp:ListItem>
                                        <asp:ListItem >TX</asp:ListItem>
                                        <asp:ListItem >UT</asp:ListItem>
                                        <asp:ListItem >VT</asp:ListItem>
                                        <asp:ListItem >VA</asp:ListItem>
                                        <asp:ListItem >WA</asp:ListItem>
                                        <asp:ListItem >WV</asp:ListItem>
                                        <asp:ListItem >WI</asp:ListItem>
                                        <asp:ListItem >WY</asp:ListItem>

                                    </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="auto-style26">&nbsp;</td>
                        <td class="auto-style27" style="text-align: center">&nbsp;</td>
                        <td class="auto-style28">&nbsp;</td>
                        <td class="auto-style29">&nbsp;</td>
                        <td style="text-align: center" class="auto-style30">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style26">City</td>
                        <td class="auto-style27" style="text-align: center">
                            <asp:TextBox ID="editCity" runat="server" BackColor="#DDDDDD" Height="32px" Width="185px"></asp:TextBox>
                        </td>
                        <td class="auto-style28">&nbsp;</td>
                       <td>Zip</td>
                        <td style="text-align: center" class="auto-style30">
                            <asp:TextBox ID="editZip" runat="server" BackColor="#DDDDDD" Height="32px" Width="185px" AutoPostBack="true" placeholder="12345"  onkeydown="javascript:backspacerDOWN1(this,event);" onkeyup="javascript:backspacerUP1(this,event);" OnTextChanged="editZip_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style26"></td>
                        <td class="auto-style27" style="text-align: center"></td>
                        <td class="auto-style28"></td>
                        <td class="auto-style29"></td>
                        <td style="text-align: center" class="auto-style30"></td>
                    </tr>
                    <tr>
                        <td class="auto-style11">Company Name</td>
                        <td style="text-align: center;" class="auto-style14">
                            <asp:TextBox ID="EditCompanyName" runat="server" BackColor="#DDDDDD" Height="32px" Width="185px"></asp:TextBox>
                        </td>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style23">Work Phone</td>
                        <td style="text-align: center;">
                            <asp:TextBox ID="EditWorkPhone" runat="server" BackColor="#DDDDDD" Height="32px" Width="185px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style16"></td>
                        <td class="auto-style17" style="text-align: center"></td>
                        <td class="auto-style20"></td>
                        <td class="auto-style24"></td>
                        <td class="auto-style18" style="text-align: center"></td>
                    </tr>
                    <tr>
                        <td class="auto-style11">Home Phone</td>
                        <td class="auto-style14" style="text-align: center;">
                            <asp:TextBox ID="EditHomePhone" runat="server" BackColor="#DDDDDD" Height="32px" Width="185px"></asp:TextBox>
                        </td>
                        <td class="auto-style22"></td>
                        <td class="auto-style23">Mobile Phone</td>
                        <td style="text-align: center;">
                            <asp:TextBox ID="EditMobilePhone" runat="server" BackColor="#DDDDDD" Height="32px" Width="185px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style26"></td>
                        <td class="auto-style27" style="text-align: center"></td>
                        <td class="auto-style28"></td>
                        <td class="auto-style29"></td>
                        <td style="text-align: center" class="auto-style30"></td>
                    </tr>
                    <tr>
                        <td class="auto-style12">Fax</td>
                        <td style="text-align: center;" class="auto-style15">
                            <asp:TextBox ID="EditFax" runat="server" BackColor="#DDDDDD" Height="32px" Width="185px"></asp:TextBox>
                        </td>
                        <td class="auto-style21"></td>
                        <td class="auto-style23">&nbsp;</td>
                        <td style="text-align: center;" class="auto-style13">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td class="auto-style14" style="text-align: center">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style23">&nbsp;</td>
                        <td style="text-align: center">&nbsp;</td>
           <td>  &nbsp;</td>
                    </tr>
                    <tr>
<td> Notes</td>
                        <td style="text-align: center;" colspan="4">
                            <asp:TextBox ID="EditNote" runat="server" BackColor="#DDDDDD" Height="58px" Width="517px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="border-style: none; border-width: 0px 0px 1px 0px; text-align: center; font-size: 25px; color: #FF0000;" colspan="5">
                            <asp:Label ID="error" runat="server"></asp:Label>
                        </td>
                    </tr>
                    </table>
                
                <br />
                <br />
                <div style="text-align: right">
                    <asp:Button ID="saveChanges" runat="server" Text="Save " Height="42px" OnClick="saveChanges_Click" Visible="False" Width="87px" />
                    <asp:Button ID="deleteClient" runat="server" Text="Delete" Height="42px" OnClick="deleteClient_Click" Visible="False" Width="87px" />
                    <asp:Button ID="editClient" runat="server" Text="Edit" Height="42px" OnClick="editClient_Click" Width="87px" />
                </div>
                <br />
                <div class="tab">
                    <button id="showLoan" class="tablinks" runat="server" onserverclick="showLoan_ServerClick">Loan</button>
  <button class="tablinks" onclick="openCity(event, 'Paris')">option 2</button>
  <button class="tablinks" onclick="openCity(event, 'Tokyo')">option 3</button>
</div>

            </div>
                 <div id="steps" runat="server">
                     <table id="buttons" visible="false" runat="server" class="auto-style93" style="width:100%; text-align: center;">
                         <tr>
                             <td class="auto-style9" colspan="5" style="font-size: 25px">
                                 Steps The Customer Has Doneteps The Customer Has Done</td>
                             
                         </tr>
                         <tr>
                             <td class="auto-style25" colspan="5">
                                 <asp:Button ID="Step1" runat="server" Text="Application" CssClass="stepB stepBh" OnClick="Step1_Click" />
                                 <asp:Button ID="Step2" runat="server" Text="Report" CssClass="stepB stepBh" OnClick="Step2_Click" />
                                 <asp:Button ID="Step3" runat="server" Text="Step 3" CssClass="stepB stepBh" />
                                 <asp:Button ID="Step4" runat="server" Text="Step 4" CssClass="stepB stepBh" />
                                 <asp:Button ID="Step5" runat="server" Text="Step 5"  CssClass="stepB stepBh" />
                             </td>
                             
                         </tr>
                         <tr>
                             <td class="auto-style25">
                                 &nbsp;</td>
                             <td class="auto-style25">
                                 &nbsp;</td>
                             <td class="auto-style25">
                                 <asp:Button ID="Docs" runat="server"  Text="Documents" CssClass="stepB stepBh" OnClick="Docs_Click"  />
                             </td>
                             <td class="auto-style25">
                                 &nbsp;</td>
                             <td class="auto-style25">
                                 &nbsp;</td>                          
                             
                         </tr>
                 </table>
             </div> 
        <div id="DocDiv" runat="server"    >                  
            <br />
            <br />
            <table class="auto-style5" style=" margin: 0 auto;">
                <tr>
                    <td class="auto-style3" style="text-align: center" colspan="2">
            
                        Select Documents You Need From Client:</td>
                </tr>
                <tr>
                    <td class="auto-style3" style="text-align: center" colspan="2">
            
             <div id="list1" runat="server" class="dropdown-check-list" tabindex="100" style="text-align: center">
  <span class="anchor" style="text-align: left">Select Requierd Document</span>
  <ul class="items" id="itemsL" runat="server">
    <li style="text-align: left"><input type="checkbox" id="id1" runat="server" />Tax Returns </li>
    <li style="text-align: left"><input type="checkbox" id="id2" runat="server" />Bank Statements</li>
    <li style="text-align: left"><input type="checkbox" id="id3" runat="server"/>Pay Stubs </li>
    <li style="text-align: left"><input type="checkbox" id="id4" runat="server"/>Proof of Insurance </li>
    <li style="text-align: left"><input type="checkbox" id="id5" runat="server"/>Drivers License State ID </li>
    <li style="text-align: left"><input type="checkbox" id="id6" runat="server"/>Social Security </li>
    <li style="text-align: left"><input type="checkbox" id="id7" runat="server"/>Utilities Bills</li>
      <li style="text-align: left"><input type="checkbox" id="id8" runat="server"/>PL Report</li>
  </ul>
</div>
                       
                  
                  
                    
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" style="text-align: center" colspan="2">
            <asp:Button ID="send" runat="server" Text="send" OnClick="send_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: left" class="auto-style7">
                        Client Documentations
                    </td>
                    <td style="text-align: left">
                        Requsted Documentations</td>
                </tr>
                
                <tr>
                    <td style="text-align: center" class="auto-style7">
            <asp:GridView ID="GridView1" runat="server" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000" AutoGenerateColumns="False" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" RowStyle-BackColor="#A1DCF2" CellPadding="4" ForeColor="#333333" GridLines="None" Width="405px">
<AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="File Name" />
                    <asp:BoundField DataField="Request" HeaderText="Type" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkDownload" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="DownloadFile" Text="Download"></asp:LinkButton>
                        </ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />

<HeaderStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True"></HeaderStyle>

                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />

<RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
                    </td>
                    <td style="text-align: center">
           
                        <asp:GridView ID="ReqDocGV" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" ShowHeaderWhenEmpty="True" 
                    OnRowEditing="ReqDocGV_RowEditing" OnRowCancelingEdit="ReqDocGV_RowCancelingEdit" OnRowUpdating="ReqDocGV_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None" Width="403px">
                                        
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
                        <asp:TemplateField HeaderText="Id" Visible="false">
                                 <ItemTemplate>
                                     <asp:Label ID="lId" Text='<%#Eval("Id")%>' runat="server" />
                                 </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="Idtxt" Text='<%#Eval("Id")%>' runat="server" />
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Type">
                                 <ItemTemplate>
                                     <asp:Label ID="lkind" Text='<%#Eval("kind")%>' runat="server" />
                                 </ItemTemplate>   
                            <EditItemTemplate>
                                <asp:Label ID="kindtxt" Text='<%#Eval("kind")%>' runat="server" />
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Comment">
                                 <ItemTemplate>
                                     <asp:Label ID="lcomment" Text='<%#Eval("Comment")%>' runat="server" />
                                 </ItemTemplate>      
                            <EditItemTemplate>
                                <asp:TextBox ID="comtxt" Text='<%#Eval("Comment")%>' runat="server" />
                            </EditItemTemplate>
                        </asp:TemplateField>                      
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button Text="Delete" runat="server" CommandName="Delete" ToolTip="Delete" OnClientClick="return confirm('Are you sure you want to delete the category?')" OnClick="Delete_Click" Width="80px" />
                                <asp:Button ID="Edit" runat="server" CommandName="Edit" ToolTip="Edit" Text="Edit" Width="80px" />
                               </ItemTemplate>
                            <EditItemTemplate>
                                 <asp:Button ID="Update" runat="server" CommandName="Update" ToolTip="Update" Text="Update" Width="80px" />
                                 <asp:Button ID="Cancel" runat="server" CommandName="Cancel" ToolTip="Cancel" Text="Cancel" Width="80px" />
                            </EditItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
           
                        
                        
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </div>
            </div>




         <script>
            var checkList = document.getElementById('list1');
            checkList.getElementsByClassName('anchor')[0].onclick = function (evt) {
                if (checkList.classList.contains('visible'))
                    checkList.classList.remove('visible');
                else
                    checkList.classList.add('visible');
            }
         </script>
    </form>
       <script>
           var zChar = new Array(' ', '(', ')', '-', '.');
           var maxphonelength = 13;
           var phonevalue1;
           var phonevalue2;
           var cursorposition;

           function ParseForNumber1(object) {
               phonevalue1 = ParseChar(object.value, zChar);
           }

           function ParseForNumber2(object) {
               phonevalue2 = ParseChar(object.value, zChar);
           }

           function backspacerUP(object, e) {
               if (e) {
                   e = e
               } else {
                   e = window.event
               }
               if (e.which) {
                   var keycode = e.which
               } else {
                   var keycode = e.keyCode
               }

               ParseForNumber1(object)

               if (keycode >= 48) {
                   ValidatePhone(object)
               }
           }

           function backspacerDOWN(object, e) {
               if (e) {
                   e = e
               } else {
                   e = window.event
               }
               if (e.which) {
                   var keycode = e.which
               } else {
                   var keycode = e.keyCode
               }
               ParseForNumber2(object)
           }

           function GetCursorPosition() {

               var t1 = phonevalue1;
               var t2 = phonevalue2;
               var bool = false
               for (i = 0; i < t1.length; i++) {
                   if (t1.substring(i, 1) != t2.substring(i, 1)) {
                       if (!bool) {
                           cursorposition = i
                           bool = true
                       }
                   }
               }
           }

           function ValidatePhone(object) {

               var p = phonevalue1

               p = p.replace(/[^\d]*/gi, "")

               if (p.length < 3) {
                   object.value = p
               } else if (p.length == 3) {
                   pp = p;
                   d4 = p.indexOf('(')
                   d5 = p.indexOf(')')
                   if (d4 == -1) {
                       pp = "(" + pp;
                   }
                   if (d5 == -1) {
                       pp = pp + ")";
                   }
                   object.value = pp;
               } else if (p.length > 3 && p.length < 7) {
                   p = "(" + p;
                   l30 = p.length;
                   p30 = p.substring(0, 4);
                   p30 = p30 + ")"

                   p31 = p.substring(4, l30);
                   pp = p30 + p31;

                   object.value = pp;

               } else if (p.length >= 7) {
                   p = "(" + p;
                   l30 = p.length;
                   p30 = p.substring(0, 4);
                   p30 = p30 + ")"

                   p31 = p.substring(4, l30);
                   pp = p30 + p31;

                   l40 = pp.length;
                   p40 = pp.substring(0, 8);
                   p40 = p40 + "-"

                   p41 = pp.substring(8, l40);
                   ppp = p40 + p41;

                   object.value = ppp.substring(0, maxphonelength);
               }

               GetCursorPosition()

               if (cursorposition >= 0) {
                   if (cursorposition == 0) {
                       cursorposition = 2
                   } else if (cursorposition <= 2) {
                       cursorposition = cursorposition + 1
                   } else if (cursorposition <= 5) {
                       cursorposition = cursorposition + 2
                   } else if (cursorposition == 6) {
                       cursorposition = cursorposition + 2
                   } else if (cursorposition == 7) {
                       cursorposition = cursorposition + 4
                       e1 = object.value.indexOf(')')
                       e2 = object.value.indexOf('-')
                       if (e1 > -1 && e2 > -1) {
                           if (e2 - e1 == 4) {
                               cursorposition = cursorposition - 1
                           }
                       }
                   } else if (cursorposition < 11) {
                       cursorposition = cursorposition + 3
                   } else if (cursorposition == 11) {
                       cursorposition = cursorposition + 1
                   } else if (cursorposition >= 12) {
                       cursorposition = cursorposition
                   }

                   var txtRange = object.createTextRange();
                   txtRange.moveStart("character", cursorposition);
                   txtRange.moveEnd("character", cursorposition - object.value.length);
                   txtRange.select();
               }

           }

           function ParseChar(sStr, sChar) {
               if (sChar.length == null) {
                   zChar = new Array(sChar);
               } else zChar = sChar;

               for (i = 0; i < zChar.length; i++) {
                   sNewStr = "";

                   var iStart = 0;
                   var iEnd = sStr.indexOf(sChar[i]);

                   while (iEnd != -1) {
                       sNewStr += sStr.substring(iStart, iEnd);
                       iStart = iEnd + 1;
                       iEnd = sStr.indexOf(sChar[i], iStart);
                   }
                   sNewStr += sStr.substring(sStr.lastIndexOf(sChar[i]) + 1, sStr.length);

                   sStr = sNewStr;
               }

               return sNewStr;
           }
           var clipboard = new Clipboard('.btn');

           clipboard.on('success', function (e) {
               console.log(e);
           });

           clipboard.on('error', function (e) {
               console.log(e);
           });
       </script>
    <script>
        var zChar1 = new Array(' ', '(', ')', '-', '.');
        var maxphonelength1 = 5;
        var phonevalue11;
        var phonevalue21;
        var cursorposition1;

        function ParseForNumber11(object) {
            phonevalue11 = ParseChar1(object.value, zChar1);
        }

        function ParseForNumber21(object) {
            phonevalue21 = ParseChar1(object.value, zChar1);
        }

        function backspacerUP1(object, e) {
            if (e) {
                e = e
            } else {
                e = window.event
            }
            if (e.which) {
                var keycode = e.which
            } else {
                var keycode = e.keyCode
            }

            ParseForNumber11(object)

            if (keycode >= 48) {
                ValidatePhone1(object)
            }
        }

        function backspacerDOWN1(object, e) {
            if (e) {
                e = e
            } else {
                e = window.event
            }
            if (e.which) {
                var keycode = e.which
            } else {
                var keycode = e.keyCode
            }
            ParseForNumber21(object)
        }

        function GetCursorPosition1() {

            var t1 = phonevalue11;
            var t2 = phonevalue21;
            var bool = false
            for (i = 0; i < t1.length; i++) {
                if (t1.substring(i, 1) != t2.substring(i, 1)) {
                    if (!bool) {
                        cursorposition1 = i
                        bool = true
                    }
                }
            }
        }

        function ValidatePhone1(object) {

            var p = phonevalue11

            p = p.replace(/[^\d]*/gi, "")

            if (p.length < 3) {
                object.value = p
            } else if (p.length == 3) {
                pp = p;

                object.value = pp;
            } else if (p.length > 3 && p.length < 5) {
                p = p;
                l30 = p.length;
                p30 = p.substring(0, 4);
                p30 = p30

                p31 = p.substring(4, l30);
                pp = p30 + p31;

                object.value = pp;

            } else  {
                p = p;
                l30 = p.length;
                p30 = p.substring(0, 4);
                p30 = p30

                p31 = p.substring(4, l30);
                pp = p30 + p31;

                l40 = pp.length;
                p40 = pp.substring(0, 8);
                p40 = p40

                p41 = pp.substring(8, l40);
                ppp = p40 + p41;

                object.value = ppp.substring(0, maxphonelength1);
            }

            GetCursorPosition1()

            if (cursorposition1 >= 0) {
                if (cursorposition1 == 0) {
                    cursorposition1 = 2
                } else if (cursorposition1 <= 2) {
                    cursorposition1 = cursorposition1 + 1
                } else if (cursorposition1 <= 5) {
                    cursorposition1 = cursorposition1 + 2
                } else if (cursorposition1 == 6) {
                    cursorposition1 = cursorposition1 + 2
                } else if (cursorposition1 == 7) {
                    cursorposition1 = cursorposition1 + 4
                    e1 = object.value.indexOf(')')
                    e2 = object.value.indexOf('-')
                    if (e1 > -1 && e2 > -1) {
                        if (e2 - e1 == 4) {
                            cursorposition1 = cursorposition1 - 1
                        }
                    }
                } else if (cursorposition1 < 11) {
                    cursorposition1 = cursorposition1 + 3
                } else if (cursorposition1 == 11) {
                    cursorposition1 = cursorposition1 + 1
                } else if (cursorposition1 >= 12) {
                    cursorposition1 = cursorposition1
                }

                var txtRange = object.createTextRange();
                txtRange.moveStart("character", cursorposition1);
                txtRange.moveEnd("character", cursorposition1 - object.value.length);
                txtRange.select();
            }

        }

        function ParseChar1(sStr, sChar) {
            if (sChar.length == null) {
                zChar1 = new Array(sChar);
            } else zChar1 = sChar;

            for (i = 0; i < zChar1.length; i++) {
                sNewStr = "";

                var iStart = 0;
                var iEnd = sStr.indexOf(sChar[i]);

                while (iEnd != -1) {
                    sNewStr += sStr.substring(iStart, iEnd);
                    iStart = iEnd + 1;
                    iEnd = sStr.indexOf(sChar[i], iStart);
                }
                sNewStr += sStr.substring(sStr.lastIndexOf(sChar[i]) + 1, sStr.length);

                sStr = sNewStr;
            }

            return sNewStr;
        }
        var clipboard = new Clipboard('.btn');

        clipboard.on('success', function (e) {
            console.log(e);
        });

        clipboard.on('error', function (e) {
            console.log(e);
        });
    </script>
</body>
</html>
