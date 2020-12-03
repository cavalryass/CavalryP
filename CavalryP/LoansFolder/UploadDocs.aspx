<%@ Page Language="C#" MasterPageFile="~/MasterForm/ClientMaster.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="UploadDocs.aspx.cs" Inherits="CavalryP.LoansFolder.UploadDocs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderClient" runat="server">
    <style type="text/css">
     .regform {
    width: 800px;
    background-color: rgba(0,0,0,0.15);
    margin: auto;
    color: rgb(93,123,157);
    padding: 10px 0px 10px 0px;
    text-align: center;
    border-radius: 15px 15px 15px 15px;
}
.main {
    background-color: rgba(0,0,0,0.1);
    width: 800px;
    margin: auto;
    border-radius: 15px 15px 15px 15px;
}
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            width: 386px;
        }
        .auto-style5 {
            width: 793px;
        }
        .gvStyle{
            margin:0 auto;
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
        .auto-style6 {
            width: 386px
        }
        .auto-style7 {
            margin-left: 60px
        }
    </style>
       <asp:Button ID="Back" runat="server" CssClass="myButton" Text="Back" style="margin-left:10px;"  OnClick="Back_Click" Font-Size="18px"  />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ClientContent" runat="server">
    <br />
    <br />

    <div class="regform">
            <h1 style="color: #536D8C">Requested Files</h1>
        </div>
    <br />
    <br />
        <div class="main" style="text-align: center; color: #000000;">
             <table id="UploadDiv" runat="server" class="auto-style5">
            
            <tr>
                <td class="auto-style2" colspan="2">
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style3" style="font-size: 10px">
                    <asp:DropDownList ID="kindDD" runat="server" ToolTip="Here you can choose the requested file you want to upload" Height="30px" OnSelectedIndexChanged="kindDD_SelectedIndexChanged" Width="169px" Font-Size="15px">
                    </asp:DropDownList>
                    <br />
                    <br />
                    <br />
                                   
                </td>
                <td class="auto-style2">
                    <asp:Label ID="comment" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" style="margin:auto; text-align: center;">
                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style7" />
                </td>
                <td style="text-align: center">
                    <asp:Button ID="btnUpload" runat="server" OnClick="Upload" Text="Upload" Width="87px" />
                </td>
            </tr>
        </table>
            <br />
            <br />
            <asp:GridView ID="GridView1" CssClass="gvStyle"  runat="server" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000" AutoGenerateColumns="False" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" RowStyle-BackColor="#A1DCF2" CellPadding="4" ForeColor="#333333" GridLines="None" Width="523px" Height="172px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:LinkButton ID="Delete" runat="server" CommandArgument='<%# Eval("Id") %>' OnClick="Delete_Click" Text="Delete"></asp:LinkButton>
                        </ItemTemplate>

                        <HeaderStyle HorizontalAlign="Center" />

<ItemStyle HorizontalAlign="Center" BackColor="White"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="File Name" HeaderStyle-HorizontalAlign="Center">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterStyle HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle BackColor="White" HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:BoundField DataField="Request" HeaderText="Kind"  ItemStyle-HorizontalAlign="Center" >
                    <HeaderStyle HorizontalAlign="Center" />
<ItemStyle HorizontalAlign="Left" BackColor="White" VerticalAlign="Middle"></ItemStyle>
                    </asp:BoundField>
                </Columns>
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
            </asp:GridView>

           
             <br />
             <br />

        </div>
       
        <div aria-sort="none" style="text-align: center">
        <asp:Label ID="error" runat="server" Font-Size="XX-Large" ForeColor="#FF3300"></asp:Label>
            </div> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ClientFooter" runat="server">
</asp:Content>