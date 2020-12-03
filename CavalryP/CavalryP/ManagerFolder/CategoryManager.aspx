<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoryManager.aspx.cs" Inherits="CavalryP.ManagerFolder.CategoryManager" %>

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
              width: 180px;
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
              width:180px ;
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
              padding: 10px;
              text-align: center;
              text-decoration: none;
              display: inline-block;
              font-size: 16px;
              margin: 4px 2px;
              cursor: pointer;
              border-radius: 4px;
        }
          .auto-style1 {
            width: 324px;
        }
          .auto-style2 {
            width: 182px;
        }
          .auto-style8 {
            margin-left: auto;
            margin-right: auto;
            width: 720px;
        }
          .auto-style9 {
            width: 902px;
            height: 34px;
        }
          .auto-style10 {
            width: 324px;
            height: 34px;
        }
          .gvButton{
              height:27px;
              background-color:white;
              border-color:rgb(93,123,157);
              border-radius:5px;

          }
        .auto-style11 {
            width: 564px;
        }
        .auto-style12 {
            width: 123px;
        }
        .auto-style13 {
            height: 33px;
        }
        .auto-style14 {
            margin-left: auto;
            margin-right: auto;
            width: 758px;
        }
        .auto-style16 {
            width: 152px;
        }
        .auto-style18 {
            width: 250px;
        }
        .auto-style19 {
            width: 253px;
        }
        .auto-style20 {
            width: 549px;
        }
     
        .auto-style23 {
            width: 180px;
        }
        .auto-style24 {
            width: 902px;
        }
        .auto-style26 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            background-color: rgb(93,123,157);
            color: white;
            padding: 10px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px 4px 131px;
            cursor: pointer;
            border-radius: 4px;
        }
    
        .auto-style28 {
            width: 179px;
        }
        .auto-style29 {
            width: 37px;
        }
        .auto-style30 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            background-color: rgb(93,123,157);
            color: white;
            padding: 10px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px 4px 0px;
            cursor: pointer;
            border-radius: 4px;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server">
        <div  runat="server" id="catdiv">
             <div class="topnav">
                 <asp:Button ID="Account" runat="server" CssClass="button"  Text="Account" OnClick="Account_Click" />
                 <asp:Button ID="clients" runat="server" CssClass="button"  OnClick="clients_Click" Text="Clients" /> 
           <div class="search-container">
                    <div>
                          <button runat="server" class="button" style="color: #000000" onserverclick="LogOut_Click">
                            Log Out</button>
                    </div>
                </div>
                
            </div>
            <br />
            <br />
            <div class="header" style="border-radius:2px 2px 2px 2px"><h1>Categories</h1></div>
            <br />
            <br />
            <div id="addCatDiv" runat="server" visible="false" class="main">
                <br />
                <div id="Add" runat="server" style="text-align: center">
            <table style="text-align: left; font-size: 21px;" class="auto-style14">
                <tr>
                    <td colspan="4" style="text-align: center; font-size: 25px; font-style: inherit;" class="auto-style13" >
                        Add New Sub Category</td>
                </tr>
                <tr>
                    <td class="auto-style20" >
                        Name Of Category</td>
                    <td class="auto-style2" colspan="3" >
                        <asp:TextBox ID="nametxt" runat="server" CssClass="readCSS"  AutoPostBack="true" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20" >
                        &nbsp;Sub Category Of</td>
                    <td class="auto-style19" colspan="2">
                        <asp:DropDownList ID="DropDownList1" runat="server" ToolTip="By Choosing New You Create A Main Category" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" CssClass="mydropdownlist1">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="mainCtxt" runat="server" CssClass="readCSS"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20" >
                        Type Of Transaction</td>
                    <td class="auto-style2" colspan="3" >
                        <asp:DropDownList ID="txtkind0" CssClass="mydropdownlist1" runat="server" Text='<%#Eval("kind")%>' >
                            <asp:ListItem>All</asp:ListItem>
                            <asp:ListItem>Expenses</asp:ListItem>
                            <asp:ListItem>Income</asp:ListItem>
                            <asp:ListItem>Regular</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29" colspan="2" >
                        <asp:Button ID="cancel" runat="server" CssClass="smalluttons" Text="cancel" OnClick="cancel_Click" />
                    </td>
                    <td colspan="2" style="text-align: right" >

                        <asp:Button ID="create" CssClass="smalluttons" runat="server" Text="create" OnClick="create_Click" />

                    </td>
                </tr>
                </table>

                    </div>
                    <div id="Update" runat="server" visible="false" style="text-align: center">
                        <table style="text-align: left; font-size: 21px;" class="auto-style8">
                <tr>
                    <td colspan="3" style="text-align: center; font-size: 25px; font-style: inherit;">
                        Update Sub Category</td>
                </tr>
                <tr>
                    <td class="auto-style24">
                        Name</td>
                    <td class="auto-style1" colspan="2">
                        <asp:TextBox ID="Uname" runat="server" CssClass="readCSS" AutoPostBack="true" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style24">
                        Sub Category Of</td>
                    <td class="auto-style18">
                        <asp:DropDownList ID="umDD" ToolTip="By Choosing New You Create A Main Category" runat="server" CssClass="mydropdownlist1" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="UmainCtxt" runat="server" CssClass="readCSS"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        Kind</td>
                    <td class="auto-style10" colspan="2">
                        <asp:DropDownList ID="Ukind" runat="server" CssClass="mydropdownlist1" Text='<%#Eval("kind")%>' >
                            <asp:ListItem>All</asp:ListItem>
                            <asp:ListItem>Expenses</asp:ListItem>
                            <asp:ListItem>Income</asp:ListItem>
                            <asp:ListItem>Regular</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="text-align: left">
                        <asp:Button ID="Ucancel" runat="server" CssClass="smalluttons" Text="cancel" OnClick="Ucancel_Click" />
                    </td>
                    <td  colspan="2" style="text-align: right">

                        <asp:Button ID="UpdateB" runat="server" CssClass="smalluttons" Text="Update" OnClick="UpdateB_Click" />

                    </td>
                </tr>
                </table>

                    </div>
                <br />
                <div style="text-align: center">
                <asp:Label ID="Error" runat="server" Font-Size="X-Large" ForeColor="#FF3300"></asp:Label>
                </div>
                    <br />
            </div>
            
                <br />
                <div>
                    
                     

                </div>
            <br />
                

                <div style="text-align: center">
                    <asp:GridView ID="catGV" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" ShowHeaderWhenEmpty="True" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin:0 auto;" Width="663px" >
                                        
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
                                 <HeaderTemplate>
                               
</HeaderTemplate>
                                 <ItemTemplate>
                                     <asp:Label ID="lId" Text='<%#Eval("Id")%>' runat="server" />
                              
                                 </ItemTemplate>
                                 <EditItemTemplate>
                                     <asp:Label ID="txtId" Text='<%#Eval("Id")%>' runat="server" />
                                 </EditItemTemplate>                              
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Name">
                                 <ItemTemplate>
                                     <asp:Label ID="lname" Text='<%#Eval("name")%>' runat="server" />
                                 </ItemTemplate>
                                 <EditItemTemplate>
                                     <asp:TextBox ID="txtname" Text='<%#Eval("name")%>' runat="server" />
                                 </EditItemTemplate>
                                 <ItemStyle BackColor="White" Height="20px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Main Category" Visible="false">
                                 <ItemTemplate>
                                     <asp:Label ID="lmainC" Visible="false" Text='<%#Eval("mainC")%>' runat="server" />
                                 </ItemTemplate>
                                 <EditItemTemplate>
                                     <asp:TextBox ID="txtmainC" Visible="false" Text='<%#Eval("mainC")%>' runat="server" />
                                 </EditItemTemplate>
                                 <ItemStyle BackColor="White" Height="20px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Main Category">
                                 <ItemTemplate>
                                     <asp:Label ID="lnameOfMainc" Text='<%#Eval("nameOfMainc")%>' runat="server" />
                                 </ItemTemplate>
                                 <EditItemTemplate>
                                     <asp:TextBox ID="txtnameOfMainc" Text='<%#Eval("nameOfMainc")%>' runat="server" />
                                 </EditItemTemplate>
                                 <ItemStyle BackColor="White" Height="20px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Kind">
                                 <ItemTemplate>
                                     <asp:Label ID="lkind" Text='<%#Eval("kind")%>' runat="server" />
                                 </ItemTemplate>
                                 <EditItemTemplate>                                     
                                       <asp:DropDownList ID="txtkind" Text='<%#Eval("kind")%>' runat="server">
                                        <asp:ListItem>All</asp:ListItem>
                                        <asp:ListItem>Expenses</asp:ListItem>
                                        <asp:ListItem>Income</asp:ListItem>
                                        <asp:ListItem>Regular</asp:ListItem>                                       
                                           </asp:DropDownList>
                                 </EditItemTemplate>
                               
                                 <ItemStyle BackColor="White" Height="20px" />
                               
                        </asp:TemplateField>                       
                        <asp:TemplateField>
                            <HeaderTemplate>
                                 <asp:Button Text="Add Category" CssClass="gvButton" Width="200px" runat="server" ID="addCat" OnClick="addCat_Click"  />
                            </HeaderTemplate>
                            
                            <ItemTemplate>
                                <asp:Button Text="Delete" CssClass="gvButton" runat="server" CommandName="Delete" ToolTip="Delete" OnClientClick="return confirm('Are you sure you want to delete the category?')" OnClick="Delete_Click" />
                                <asp:Button ID="Edit" CssClass="gvButton" runat="server" OnClick="Edit_Click" Text="Edit" />
                              <asp:Button ID="info" CssClass="gvButton" runat="server"  Text="Generate Report" OnClick="info_Click" />
                                    
                            </ItemTemplate>
                            
                            <ItemStyle BackColor="White" Height="20px" />
                            
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </div>
                
                <br />
                <div id="catInfo" runat="server" class="auto-style13" visible="false">                    
                  
                    <div style="text-align: center">
                        <h1>The following fields are not required to fill</h1>
                         <table style="margin:0 auto; font-size: 20px;" class="auto-style11">
                        <tr>
                            
                           
                            <td id="from" class="auto-style12" runat="server">
                                 From
                            </td>
                            <td  runat="server" class="auto-style16">                                
                                    <input id="datef" runat="server"  type="date" style="background-color:white" class="readCSS" onchange="myFunction()" /></td>
                            <td  class="auto-style35" runat="server">
                                Until</td>
                            <td id="to" class="auto-style28" runat="server">
                                   <input id="dateT" runat="server"  type="date" style="background-color:white" class="readCSS"  />
                            </td>
                           
                            <td class="auto-style26">
                                <asp:Button ID="search" runat="server" Text="Search" BackColor="Transparent" BorderColor="Transparent" ForeColor="White" Font-Size="Small" Width="57px" OnClick="search_Click" style="height: 26px"  />
                            </td>
                        </tr>
                    </table>
                         <br />  
                    <asp:Label ID="error2" runat="server" ForeColor="Red" Font-Size="X-Large"></asp:Label>

                      
                    </div>
                <br />

                </div>
                <br />
                <br />
            <br />
                 <br />
             <br />
             <br />
             <br />
            <div id="searchResultDiv" runat="server" visible="false">
                <div class="regform">
                    <h1><asp:Label ID="catReportHeader" runat="server"></asp:Label></h1>
                    <p><asp:Label ID="subTitelReport" runat="server"></asp:Label></p>
</div>
                <br />
                <br />

            <asp:GridView ID="GV" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataKeyNames="Id" 
                         style="margin:0 auto;" Width="1123px" CssClass="auto-style23">
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
                                     <asp:Label ID="lId0" Visible="false" Text='<%#Eval("Id")%>' runat="server" />
                                 </ItemTemplate>                                 
                                 <ItemStyle HorizontalAlign="Center" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Kind">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("Kind")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" Height="40px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="From">
                                 <ItemTemplate>
                                     <asp:Label ID="Lrf" Text='<%#Eval("Requestfrom")%>' runat="server" />
                                 </ItemTemplate>                                 
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" Height="40px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="To">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("RequestTo")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" Height="40px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Amount">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("Amount")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" Height="40px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Date">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("Date")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" Height="40px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Category" Visible="False">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("Category")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" Height="40px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Check Number">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("CheckNum")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" Height="40px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Bank Name">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("BankName")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" Height="40px" />
                             </asp:TemplateField>
                               <asp:TemplateField HeaderText="Enter To Bank">
                                 <ItemTemplate>
                                     <asp:CheckBox onclick="return false;" Checked='<%#Convert.ToBoolean(Eval("enterb"))%>' runat="server" />
                                 </ItemTemplate>
                                   <ItemStyle HorizontalAlign="Center" BackColor="White" Height="40px" />
                             </asp:TemplateField>  
                             <asp:TemplateField HeaderText="Invoice">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("InvoiceNum")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" Height="40px" />
                             </asp:TemplateField>                                                    
                             <asp:TemplateField HeaderText="Comment">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("Comment")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" BackColor="White" Height="40px" Width="300px" />
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Publish" Visible="False">
                                 <ItemTemplate>
                                     <asp:Label Text='<%#Eval("UserId")%>' runat="server" />
                                 </ItemTemplate>
                                 <ItemStyle HorizontalAlign="Center" />
                             </asp:TemplateField>
                            
                         </Columns>
                     </asp:GridView>
                <br />
                </div>
<div id="catinfoDiv" runat="server" >
    <br />

</div>
      
                </div>
    </form>
     <script>
        function myFunction() {
            var x = document.getElementById("dateT");
            x.setAttribute("min", document.getElementById("datef").value);
           
        }

     </script>
</body>
</html>
