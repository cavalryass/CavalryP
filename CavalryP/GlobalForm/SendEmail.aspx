<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendEmail.aspx.cs" MaintainScrollPositionOnPostback="true" Inherits="CavalryP.GlobalForm.SendEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link href="~/Styles/GlobalS.css" rel="stylesheet" type="text/css" media="screen" runat="server" />

    <title></title>
    <style>
        body {font-family: Arial, Helvetica, sans-serif;}
        * {
            box-sizing: border-box;
        }
        input[type=text], select, textarea {
  width: 100%;
  padding: 12px;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
  margin-top: 6px;
  margin-bottom: 16px;
  resize: vertical;
}
        .sendE {
  background-color: rgb(93,123,157);
  color: white;
  padding: 12px 20px;
  border: none;
  border-radius: 4px;
  cursor: pointer;
}
        .sendE:hover {
  background-color:lightgray;
}
        .container {
  border-radius: 5px;
  background-color: #f2f2f2;
  padding: 20px;
}
               
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 94px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    
           <div class="topnav"><button  class="button" runat="server" onserverclick="Back_ServerClick"><asp:Label ID="LoansB" runat="server" Text="Back" ForeColor="Black"  /></button>

 <div class="search-container">
<div>

      <button class="button" runat="server" onserverclick="LogOut_ServerClick" style="color: #000000">Log Out</button>
      </div>
</div>
</div>
        <h1 style="text-align: center">Send Email</h1>
        <div class="container">
            
    <label for="fname">Email Address</label>
    <input type="text" id="email" name="emailA" placeholder="Email..." runat="server"/>

    <label for="lname">Subject</label>
    <input type="text" id="subject" name="subject" placeholder="Subject.." runat="server"/>

    
    <label for="subject">Message</label>
    <textarea id="message" name="message" runat="server" placeholder="Write Here..." style="height:200px"></textarea>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
            <asp:Button ID="sendEB" runat="server" CssClass="sendE" Text="Submit"  OnClick="sendEB_Click" />
    
                    </td>
                    <td style="text-align: center">
    
            <asp:Label ID="error" runat="server" Font-Size="XX-Large" ForeColor="Red" ></asp:Label>
                    </td>
                </tr>
            </table>
</div>
    </form>
</body>
</html>
