﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterForm/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="CavalryP.MasterForm.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderClient" runat="server">
    <style type="text/css">
       
          
          .myTable{
           margin-left: auto; 
           margin-right: auto;
      }
         
          .readCSS{  
              margin: 8px 0;
              box-sizing: border-box;
              border: none;
              background-color:rgb(243, 241, 241);
              width: 150px;
              height:18px;
              padding: 12px 20px;
             
              

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
              border-color:rgb(93,123,157);
              border-radius:2px;

          }
        .auto-style1 {
            height: 42px;
            width: 437px;
        }
        .split {
  height: 80%;
  bottom:0;
  position: fixed;
  z-index: 1;
  border:none;
  overflow-x: hidden;
  padding-top: 20px;
}

.left {
  left: 0;
  background-color:white;
  width:25%;
}

.right {
    width:75%;
  right: 0;
  background-color:white;
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

    .button:hover {
        background-color: #008CBA;
    }

.clientButton {
  background-color: rgb(93,123,157); /* Green */
  border: none;
  color: white;
  padding: 16px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 4px 2px;
  transition-duration: 0.4s;
  cursor: pointer;

  background-color: white; 
  color: black; 
  border: 2px solid rgb(93,123,157);
}
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
    border-radius: 0px 0px 15px 15px;
}
.clientButton:hover {
  background-color: rgb(93,123,157);
  color: white;
}


    </style>
    <asp:Button ID="Report" runat="server" CssClass="button" Text="Accounts Reports"  OnClick="Report_Click" />
                  
      </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ClientContent" runat="server">
            <br />
            <br />
            <div class="split left">
            
        <asp:Label ID="NoUser" runat="server" Font-Size="50px"></asp:Label>
        <asp:GridView ID="listU" runat="server" AutoGenerateColumns="False" CssClass="auto-style19" HorizontalAlign="Left" ShowHeader="False" style="margin-left: 25px">
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
                <asp:TemplateField HeaderText="cell" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="cell" runat="server" Text='<%#Eval("MobileNum")%>' Visible="false" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="find">
                    <ItemTemplate>
                        <asp:Button ID="findReq" runat="server" OnClick="findReq_Click" Text='<%# Eval("Fname")+" "+Eval("Lname") %>' ToolTip='<%#Eval("MobileNum")%>' CssClass="clientButton" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:BoundField />
            </Columns>
        </asp:GridView>

          </div>
              
            <div class="regform" style="border-radius:2px 2px 2px 2px"><h1>Unknown Users</h1></div>
            <div class="main" style="text-align: center">
        <table id="updateUser" runat="server" class="auto-style1" style="font-weight: bold; font-size: 25px; margin:0 auto; text-align: left; color: #000000;">
            <tr>
                <td class="auto-style2">Mail:</td>
                <td>
                    <asp:TextBox ID="Mail" runat="server" ReadOnly="true" CssClass="readCSS" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">First Name:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="Fname" runat="server" ReadOnly="true" CssClass="readCSS"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><span class="auto-style6"><strong>Last</strong></span> Name:</td>
                <td>
                    <asp:TextBox ID="Lname" runat="server" ReadOnly="true" CssClass="readCSS"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Mobile Phone:</td>
                <td>
                    <asp:TextBox ID="Mphone" runat="server" ReadOnly="true" CssClass="readCSS"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Status:</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="statusdd" runat="server" CssClass="mydropdownlist1">
                        <asp:ListItem>Client</asp:ListItem>
                        <asp:ListItem>Manager</asp:ListItem>
                        <asp:ListItem>Secretary</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Update" runat="server" CssClass="smalluttons" Text="Update"  OnClick="Update_Click" />
                </td>
            </tr>
        </table>
                <br />
                <br />
                <div style="text-align: center">
                </div>
                    <br />
            </div>
            
    
   

       
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ClientFooter" runat="server">
</asp:Content>
