<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn_Up.aspx.cs" Inherits="CavalryP.SignIn_Up" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <link href="index1.css" rel="Stylesheet" type="text/css" />
  <link href="~/Styles/GlobalS.css" rel="stylesheet" type="text/css" media="screen" runat="server" />
</head>
<body>
    <form runat="server">
        <button onclick="document.getElementById('id01').style.display='block'" style="width:auto; float:right" >Sign Up</button>
        <div id="id01" runat="server" class="modal">
            <span onclick="document.getElementById('id01').style.display='none'" class="close" title="Close Modal">&times;</span>
            <div class="modal-content" action="/action_page.php" runat="server">
                <div class="container">
                    <h1 style="color:rgb(0,175,239);">Sign Up</h1>
                    <p style="color:rgb(0,175,239);">Please fill in this form to create an account.</p>
                    <hr/>
                    <table style="margin:auto;">       
                        <tr>
                            <td>
                                <label for="email"><b>Email</b></label>
                                <input runat="server" id="emailId" type="text" placeholder="Enter Email" name="email" required="required"/>

                            </td>

                        </tr>
                        <tr>
                            <td>                 
                                <label for="psw"><b>Password</b></label>
                                <input runat="server" id="pswId" type="password" placeholder="Enter Password" name="psw" required="required"/>

                            </td>
                            <td>
                                <label for="psw-repeat"><b>Repeat Password</b></label>
                                <input runat="server" id="pswrepeatId" type="password" placeholder="Repeat Password" name="psw-repeat" required="required"/>

                            </td>

                        </tr>
                        <tr>
                            <td>
                                <label for="fname"><b>First Name</b></label>
                                <input runat="server" id="fnameId" type="text" placeholder="Enter First Name" name="fname" required="required"/>

                            </td>
                            <td>
                                <label for="lname"><b>Last Name</b></label>
                                <input runat="server" id="lnameId" type="text" placeholder="Enter Last Name " name="lname" required="required"/>

                            </td>

                        </tr>       
                        <tr>
                            <td>
                                <label for="mphone"><b>Mobile Phone </b></label>
                                <input id="mphoneId" runat="server" placeholder="(123) 456-7890" type="text"  name="txtInput" onkeydown="javascript:backspacerDOWN(this,event);" onkeyup="javascript:backspacerUP(this,event);"/>
                              
                            </td>
                         
                        </tr>
        </table>
        <asp:Label ID="error2" runat="server" ForeColor="Red" Text=""></asp:Label>
      <!--label>
        <input type="checkbox" checked="checked" name="remember" style="margin-bottom:15px"/> Remember me
      </label-->

      <!--p>By creating an account you agree to our <a href="#" style="color:dodgerblue">Terms & Privacy</a>.</p-->

      <div class="clearfix">
        <button type="button" onclick="document.getElementById('id01').style.display='none'" class="cancelbtn">Cancel</button>
        <button type="submit" runat="server"  class="signupbtn" style="background-color:rgb(0,175,239)" onserverclick="Sign_Up" >Sign Up</button>
      </div>
    </div>
  </div>
</div>



<button onclick="document.getElementById('id02').style.display='block'" style="width:auto; float:right" >Login</button>


<div id="id02" runat="server" class="modal">
  
  <div  class="modal-content animate" >
   
    <div class="container1">
    <h1 style="color:rgb(0,175,239);">Login</h1>
      <p style="color:rgb(0,175,239);">Please fill in this form to login.</p>
      <hr/>
      <label for="uname"><b>Email</b></label>
      <input type="text" runat="server" id="unameId" placeholder="Enter Email" name="uname" required="required"/>

      <label for="psw"><b>Password</b></label>
      <input type="password" runat="server" id="passwordId" placeholder="Enter Password" name="psw" required="required"/>
     <button type="submit" runat="server"   style="background-color:rgb(0,175,239); border-color:white; color:white;"  onserverclick="Log_In">Login</button>
        <!--label>
        <input type="checkbox" checked="checked" name="remember"/> Remember me
      </label-->        
        <asp:Label ID="error1" runat="server" ForeColor="Red" Text=""></asp:Label>
    </div>

    <div class="container1" >       
      <button type="button" onclick="document.getElementById('id02').style.display='none'" class="cancelbtn1">Cancel</button>
        <span class="psw1"> <a href="#">Forgot password?</a></span>
    </div>
    
  </div>
</div>

        <script>
    // Get the modal
    var modal = document.getElementById('id01');
    var modal2 = document.getElementById('id02');

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
        if (event.target == modal2) {
            modal2.style.display = "none";
        }

    }
        </script>
    <script src="jquery.1.7.2_js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.maskedinput/1.4.1/jquery.maskedinput.js"></script>
    

<script src="https://s3-us-west-2.amazonaws.com/s.cdpn.io/3/masking-input.js" data-autoinit="true"></script> 
        <p>
            &nbsp;</p>
        <asp:Label ID="unknownstatus" runat="server" Font-Size="50px" ForeColor="White"></asp:Label>
    </form>
</body>
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
</html>
