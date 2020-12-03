<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="CavalryP.GlobalForm.StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Cavalry</title>
      <link href="~/Styles/GlobalS.css" rel="stylesheet" type="text/css" media="screen" runat="server" />

 <style>
body {font-family: Arial, Helvetica, sans-serif;}
* {box-sizing: border-box}

/* Full-width input fields */
input[type=text], input[type=password] {
  width: 100%;
  padding: 15px;
  margin: 5px 0 22px 0;
  display: inline-block;
  border: none;
  background: #f1f1f1;
}

input[type=text]:focus, input[type=password]:focus {
  background-color: #ddd;
  outline: none;
}

hr {
  border: 1px solid #f1f1f1;
  margin-bottom: 25px;
}

/* Set a style for all buttons */
button {
  background-color: rgb(93,123,157);
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
  opacity: 0.9;
}

button:hover {
  opacity:1;
}

/* Extra styles for the cancel button */
.cancelbtn {
  padding: 14px 20px;
  background-color: #f44336;
}

/* Float cancel and signup buttons and add an equal width */
.cancelbtn, .signupbtn {
  float: left;
  width: 50%;
}

/* Add padding to container elements */
.container {
  padding: 16px;
}

/* Clear floats */
.clearfix::after {
  content: "";
  clear: both;
  display: table;
}

/* Change styles for cancel button and signup button on extra small screens */
@media screen and (max-width: 300px) {
  .cancelbtn, .signupbtn {
     width: 100%;
  }
}
.buttons{
    width:500px;
    height:30px;    
    border:none;
    background-color:white;
   
}
.buttons:hover{
    background-color:lightgray;
}
     .auto-style1 {
         width: 1004px;
     }
     .auto-style2 {
         
         width: 1100px;
            margin: auto;
   padding: 10px;
     }
     .auto-style3 {
         width: 100%;
     }
     .auto-style4 {
         width: 558px;
     }
     .auto-style5 {
         border-style: none;
         border-color: inherit;
         border-width: medium;
         background-color: white;
     }
     .auto-style6 {
         width: 765px;
     }
     </style>
    </head>
<body style="background-color:rgb(93,123,157);">

    <form id="form1" runat="server">
    <div style="text-align: center">
        <br />
        <br />
        <br />
        <br />
        <div style="text-align: center">
            <div style="margin:0 auto; border-radius:15px 15px 15px 15px; background-color:rgb(242,242,242)"  Visible="false" id="unknownstatus" runat="server" class="auto-style6">    
                <asp:Label ID="updateStatus"  runat="server" Font-Size="20px" ForeColor="Black"></asp:Label>
            <br />
            </div>
        </div>
       <br /> 
        <br />
  <div id="signupd" runat="server" visible="false" class="auto-style2" style="margin:auto; background-color: #FFFFFF; border-left-style: solid; border-left-width: thin; border-right-style: solid; border-right-width: thin; border-top-style: none; border-top-width: thin; border-bottom-style: solid; border-bottom-width: thin; text-align: left; border-radius:5px 5px 5px 5px;">
          <div style="margin:auto; text-align: center;">

            <table class="auto-style3" style="border-style: none">
                <tr>
                    <td style="text-align: right">

            <asp:Button ID="Button1" runat="server" Text="Log In" CssClass="buttons" OnClick="lbutton_Click" Width="500px" Height="30px" />
                    </td>
                    <td style="text-align: left">
            <asp:Button ID="Button2" runat="server" Text="Sign Up" CssClass="auto-style5" BorderColor="White" OnClick="sbutton_Click" BackColor="#CCCCCC" Width="500px" Height="30px" />
                    </td>
                </tr>
            </table>
        </div>
    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sign Up</h1>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Please fill in this form to create an account.</p>
<table style="margin:auto;" class="auto-style1">       
                        <tr>
                            <td>
                                <label for="email"><b>Email</b></label>
                                <input runat="server" id="emailId" type="text" placeholder="Enter Email" name="email" />

                            </td>

                        </tr>
                        <tr>
                            <td>                 
                                <label for="psw"><b>Password</b></label>
                                <input runat="server" id="pswId" type="password" placeholder="Enter Password" name="psw" />

                            </td>
                            <td class="auto-style4">
                                <label for="psw-repeat"><b>Repeat Password</b></label>
                                <input runat="server" id="pswrepeatId" type="password" placeholder="Repeat Password" name="psw-repeat" />

                            </td>

                        </tr>
                        <tr>
                            <td>
                                <label for="fname"><b>First Name</b></label>
                                <input runat="server" id="fnameId" type="text" placeholder="Enter First Name" name="fname" />

                            </td>
                            <td class="auto-style4">
                                <label for="lname"><b>Last Name</b></label>
                                <input runat="server" id="lnameId" type="text" placeholder="Enter Last Name " name="lname" />

                            </td>

                        </tr>       
                        <tr>
                            <td>
                                <label for="mphone"><b>Mobile Phone </b></label>
                                <input id="mphoneId" runat="server" placeholder="(123) 456-7890" type="text"  name="txtInput" onkeydown="javascript:backspacerDOWN(this,event);" onkeyup="javascript:backspacerUP(this,event);"/>
                              
                            </td>
                         
                        </tr>
        </table> 
      <div style="text-align: center">
    <asp:Label ID="error2" runat="server" ForeColor="Red" Text=""></asp:Label>
   </div>
    <div class="clearfix">
      <button type="button" class="cancelbtn">Cancel</button>
      <button type="submit" class="signupbtn" runat="server" onserverclick="Sign_Up">Sign Up</button>
    </div>
  </div>
        <div id="logind" runat="server" class="auto-style2" style="border-radius:5px 5px 5px 5px; border-style: none solid solid solid; border-width: thin; width:1100px; margin:auto; background-color: #FFFFFF; text-align: left;">
                <div style="margin:auto; text-align: center;">

            <table class="auto-style3" style="border-style: none">
                <tr>
                    <td style="text-align: right">

            <asp:Button ID="lbutton" runat="server" Text="Log In" CssClass="buttons" OnClick="lbutton_Click" BackColor="#CCCCCC" Width="500px" Height="30px"/>
                    </td>
                    <td style="text-align: left">
            <asp:Button ID="sbutton" runat="server" Text="Sign Up" CssClass="buttons" BorderColor="White" OnClick="sbutton_Click" Width="500px" Height="30px" />
                    </td>
                </tr>
            </table>
        </div>
    <h1>&nbsp;&nbsp; Log In</h1>
    <p>&nbsp;&nbsp;&nbsp;&nbsp; Please fill in this form to log in</p>
    <hr/>
      <label for="uname"><b>Email</b></label>
      <input type="text" runat="server" id="unameId" placeholder="Enter Email" name="uname" />

      <label for="psw"><b>Password</b></label>
      <input type="password" runat="server" id="passwordId" placeholder="Enter Password" name="psw" />
   <div style="text-align: center">
       <asp:Label ID="error1" runat="server" ForeColor="Red" Text=""></asp:Label>
   </div>
            
    <div class="clearfix">
      <button type="button" class="cancelbtn">Cancel</button>
      <button type="submit" runat="server" onserverclick="Log_In" class="signupbtn">Log In</button>
    </div>
  </div>
        </div>
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
</body>
</html>
