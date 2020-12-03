﻿<%@ Page Language="C#"  MasterPageFile="~/MasterForm/ClientMaster.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="Steps.aspx.cs" Inherits="CavalryP.Steps" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderClient" runat="server">
    <style>       
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

       }    
       .stepBh:hover {
  background-color: #cacecf;
}
       .littelbutton{
            background-color: white; 
            color: black;
            border: 2px solid #5D7B9D;
            Width:100px;
            Height:30px;            
            text-align: center;
            text-decoration: none;
            font-size: 16px;            
            cursor: pointer;

            }
       .auto-style1 {
           height: 30px;
       }
       .auto-style3 {
           margin-left: 120px;
       }
       .noHover{
    pointer-events: none;
}
       
       
       .auto-style4 {
           width: 880px;
       }
       .auto-style5 {
           width: 935px;
       }


    .container {
  margin-top: 30px;
}

button {
  font-size: 20px;
  border: 2px solid black;
  padding: 8px 20px;
  position: relative;
}
.button:hover {
        background-color: #5D7B9D;
        color:white;
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
.container .circle {
  position: absolute;
  top: -21px;
  right: -21px;
  width: 40px;
  height: 40px;
  -webkit-border-radius: 25px;
  -moz-border-radius: 25px;
  border-radius: 25px;
  background: #4da6ff;
  background-color:red;
}
       
    </style>
      <button class="myButton noHover" style="border-width: thin; border-style: none none solid none; border-color: #008CBA; color: #5D7B9D; font-weight: bold;">My Loan</button>
                    <button class="myButton" runat="server" onserverclick="Setting_Click">Setting</button>                    
             
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ClientContent" runat="server">
                <div id="AllSteps" runat="server" style="text-align: center">

                        <asp:Button ID="Step1" runat="server" CssClass="stepB stepBh" OnClick="Step1_Click" Text="Application" />

                        <asp:Button ID="Step2" runat="server" CssClass="stepB stepBh"  OnClick="Step2_Click" Text="Report" />
                        <asp:Button ID="Step3" runat="server"  CssClass="stepB stepBh" Text="Step 3" />
                        <asp:Button ID="Step4" runat="server" CssClass="stepB stepBh" Text="Step 4" />
                        <asp:Button ID="Step5" runat="server" CssClass="stepB stepBh" Text="Step 5" />
                        <div class="container">
                            <button class="stepB stepBh" runat="server"  onserverclick="Docs_Click" >Documents
                                <span class="circle" id="alerC" runat="server">!</span>

                            </button>

                        </div> 
                </div>
    <div id="Waiting" runat="server" style="font-size:50px; text-align: center;" visible="false">
        <br />
        We Are Awaiting Manager Approval
        <br />
    </div>
        <br />
        <div id="WantUpload" runat="server" visible="false" style="text-align: center;vertical-align: middle">
            <table style="margin-right: auto; margin-left:auto; background-color: #E2E2E2;" class="auto-style5" >
                <tr>
                    <td class="auto-style5" colspan="2" style="background-color: #DFDFDF">
                        <h1>Would You Want To Upload Bank Document</h1>
                    </td>
                </tr>
                <tr>
                    <td style="background-color: #DFDFDF;" class="auto-style1">
<asp:Button ID="No" runat="server" CssClass="littelbutton" Text="No" OnClick="No_Click"  />
                    </td>
                    <td style="background-color: #DFDFDF;" class="auto-style1">
                        <asp:Button ID="Yes" runat="server" Text="Yes" CssClass="littelbutton" OnClick="Yes_Click" />
                    </td>
                    
                </tr>
                <tr>
                    <td style="background-color: #DFDFDF;" class="auto-style1" colspan="2">
                        * By Clicking No Yow Can Fill The Information By Yourself</td>
                    
                </tr>
            </table>
        </div><br />

    <div id="uploadS" style="vertical-align: middle;text-align:center;" runat="server" visible="false">
                           <table style="margin:auto; background-color: #E2E2E2; font-size: 20px;" class="auto-style4">
                               <tr>
                                   <td style="text-align: center; font-size: 28px;" colspan="2">

                                       Select An Experian Bank Document To Fill In Data Automatically</td>
                               </tr>
                               <tr>
                                   <td class="auto-style3" style="text-align: center" colspan="2">
    
                           <asp:FileUpload ID="FileUpload1" runat="server"  />
                                   </td>
                               </tr>
                               <tr>
                                   <td style="text-align: center">

                                       <asp:Button ID="cancel" runat="server" CssClass="littelbutton" OnClick="cancel_Click" Text="CANCEL"  />

                                   </td>
                                   <td style="text-align: center" class="auto-style3">

                                       <asp:Button ID="uploadF" runat="server" CssClass="littelbutton" Text="UPLOAD" OnClick="uploadF_Click" />

                                   </td>
                               </tr>
                           </table>
    </div>
        <br />
        <div style="text-align: center">
        <asp:Label ID="Error" runat="server" Text="" ForeColor="Red" Font-Size="50px"></asp:Label>
            </div>
    <div>
        <br />
        <br /><br /><br /><br /><br /><br />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ClientFooter" runat="server">
</asp:Content>
















