<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadDocs.aspx.cs" Inherits="CavalryP.LoansFolder.UploadDocs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link href="~/Styles/GlobalS.css" rel="stylesheet" type="text/css" media="screen" runat="server" />

    <style type="text/css">
     
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            width: 249px;
        }
        .auto-style4 {
            width: 249px;
        }
        .auto-style5 {
            width: 793px;
        }
        .gvStyle{
            margin:0 auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
                    <asp:Button ID="Back" runat="server" Text="Back" BackColor="White" OnClick="Back_Click" Height="46px" Width="85px" />
        <div class="regform">
            <h1 style="color: #536D8C">Requested Files</h1>
        </div>
        <div class="main" style="text-align: center">
             <table id="UploadDiv" runat="server" class="auto-style5">
            
            <tr>
                <td class="auto-style2" colspan="2">
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style3" style="font-size: 10px">
                    <asp:DropDownList ID="kindDD" runat="server" Height="16px" OnSelectedIndexChanged="kindDD_SelectedIndexChanged" Width="147px">
                    </asp:DropDownList>
                    <br />
                    *Here you can choose the requested file you want to upload</td>
                <td class="auto-style2">
                    <asp:Label ID="comment" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="margin:auto;">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td style="text-align: center">
                    <asp:Button ID="btnUpload" runat="server" OnClick="Upload" Text="Upload" Width="87px" />
                </td>
            </tr>
        </table>

            <asp:GridView ID="GridView1" CssClass="gvStyle"  runat="server" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000" AutoGenerateColumns="False" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" RowStyle-BackColor="#A1DCF2" CellPadding="4" ForeColor="#333333" GridLines="None" Width="405px">
<AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="File Name"   ItemStyle-HorizontalAlign="Center"/>
                    <asp:BoundField DataField="Request" HeaderText="Kind"  ItemStyle-HorizontalAlign="Center" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:LinkButton ID="Delete" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="Delete_Click" Text="Delete"></asp:LinkButton>
                        </ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />

<HeaderStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True"></HeaderStyle>

                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />

<RowStyle BackColor="#F7F6F3"  ForeColor="#333333"></RowStyle>
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>

        </div>
       
        <div aria-sort="none" style="text-align: center">
        <asp:Label ID="error" runat="server" Font-Size="XX-Large" ForeColor="#FF3300"></asp:Label>
            </div>
    </form>
</body>
</html>
