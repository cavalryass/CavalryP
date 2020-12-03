<%@ Page Language="C#" MasterPageFile="~/MasterForm/ClientMaster.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="ClientP.aspx.cs" Inherits="CavalryP.ClientP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderClient" runat="server">
    <style type="text/css">
             .noHover{
    pointer-events: none;
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
        background-color: #5D7B9D;
        color:white;
    }
     .regform {
    width: 1200px;
    background-color: rgba(0,0,0,0.15);
    margin: auto;
    color: rgb(93,123,157);
    padding: 10px 0px 10px 0px;
    text-align: center;
    border-radius: 15px 15px 0px 0px;
}
.main {
    background-color: rgba(0,0,0,0.1);
    width: 1200px;
    margin: auto;
    border-radius: 0px 0px 15px 15px;
}
        .auto-style2 {
            height: 26px;
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
        .auto-style9 {
            height: 26px;
            width: 242px;
        }
        .auto-style11 {
            height: 26px;
            width: 333px;
        }
        
            .firstlabel{
            position:relative;
            color:#E5E5E5;
            text-transform:capitalize;
            font-size:14px;
            margin-left:25px;
            margin-top:30px;
        }
        .lastlabel{
            position:relative;
            color:#E5E5E5;
            text-transform:capitalize;
            font-size:14px;
            margin-left:25px;
            margin-top:30px;
        }
          .input1{
            
            width:200px;
            color:white;
            font-size:18px;            
            position:relative;
            line-height:40px;
            border-radius:4px;
            padding:0 22px;
            font-size:16px;            
            color:#555;
            height:27px;
        }
        .input2{
            position:relative;
            line-height:40px;
            width:503px;
            border-radius:4px;
            padding:0 22px;
            font-size:16px;
            color:#555;
            height:27px;
        }
        .input3{
            position:relative;
            line-height:40px;
            width:503px;
            height:90px;
            border-radius:4px;
            padding:0 22px;
            font-size:16px;
            color:#555;
            height:30px;
        }
.divf{
            padding:10px;
        }
        .auto-style2 {
            height: 54px;
        }
        .auto-style9 {
         width: 120px;
     }
     .auto-style16 {
         height: 54px;
         width: 157px;
     }             
     .auto-style21 {
         height: 54px;
         width: 71px;
     }
     .auto-style22 {
         width: 268435456px;
     }              
     .auto-style24 {
         height: 54px;
         width: 268435408px;
     }
     .auto-style26 {
         position: relative;
         line-height: 40px;
         width: 350px;
         border-radius: 6px;
         padding: 0 22px;
         font-size: 16px;
         color: #555;
         left: -1px;
         top: -1px;
     }
      .name{
            margin-left:25px;
            margin-top:30px;
            width:125px;
            color:white;
            font-size:18px;
            font-weight:700;
        }        
        .firstlabel{
            position:relative;
            color:#E5E5E5;
            text-transform:capitalize;
            font-size:14px;
            margin-left:25px;
            margin-top:30px;
        }
        .lastlabel{
            position:relative;
            color:#E5E5E5;
            text-transform:capitalize;
            font-size:14px;
            margin-left:25px;
            margin-top:30px;
        }
        #name{
            width:100%;
            height:100px;
        }
        .changePbutton{
            background-color: rgba(0,0,0,0.15);
        }
        .auto-style28 {
            height: 548px;
        }
        .auto-style29 {
            width: 1104px;
            height: 407px;
            margin-left: 28px;
            margin-right: 91px;
        }
        .auto-style30 {
            width: 191px;
            height: 47px;
        }
    </style>
    <button  class="button noHover" runat="server" style="border-width: thin; border-style: none none solid none; border-color: #5D7B9D; color: #5D7B9D; font-weight: bold;" ><asp:Label ID="Label1" runat="server"  Text="Settings" /></button>
<button  class="button" runat="server" onserverclick="LoansB_ServerClick"><asp:Label ID="LoansB" runat="server" Text="Request Loan" ForeColor="Black" /></button>

  </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ClientContent" runat="server">
 
        <br />
        <br />
    <div class="regform"><h1>Update Your Details</h1></div>
        <div class="main">
            <div class="divf">
                    <br />
                    <table class="auto-style29" style="color: #000000; font-size: 18px;">
                        <tr>
                            <td class="auto-style16">Name</td>
                            <td class="auto-style9" colspan="3" style="text-align: left">
                                  <input id="Fname" runat="server" class="input1" type="text" name="firdt_name" />
                                  <br />
                                  <h5>First Name</h5></td>
                            <td colspan="2" class="auto-style22" style="text-align: left">
                                <input id="Lname" runat="server" class="input1" type="text" name="last_name" />
                                <br />
                                <h5>Last Name</h5></td>
                            <td style="text-align: left">
                                &nbsp;</td>
                        </tr>

<tr>
    <td class="auto-style16" >Company</td>
    <td colspan="6" style="text-align: left"><input id="companynametxt" runat="server" class="input2" type="text" name="company" /></td>
</tr>
                        <tr>
    <td class="auto-style16">Email</td>
    <td colspan="6" class="auto-style2" style="text-align: left" ><input id="emailtxt" runat="server" class="input2" type="text" name="email" /></td>
</tr>
                        <tr>
    <td class="auto-style16"> Billing Address</td>
    <td colspan="6" class="auto-style2" style="text-align: left" ><input id="addresstxt" runat="server" class="input2" type="text" name="email" />
                </td>
</tr>
                        <tr>
    <td class="auto-style21" colspan="2" style="text-align: left">Suite</td>
    <td class="auto-style11" style="text-align: left"> <input id="suitetxt" runat="server" class="input1" type="text" name="email" /></td>
    <td class="auto-style24" colspan="2" style="text-align: left">Unit City</td>
    <td class="auto-style2" colspan="2" style="text-align: left"> <input id="citytxt" runat="server" class="input1" type="text" name="phone" /></td>
</tr>
                                       
      
                        <tr>
    <td class="auto-style21" colspan="2" style="text-align: left">State</td>
    <td class="auto-style11" style="text-align: left"> <asp:DropDownList ID="statedd" CssClass="auto-style26" runat="server" DataTextField="Text" DataValueField="Value" EnableIncrementalSearch="true" CaseSensitiveSearch="true" Width="130px" Height="22px">
                                          
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
    <td class="auto-style24" colspan="2" style="text-align: left">Zip Code</td>
    <td class="auto-style2" colspan="2" style="text-align: left"> <asp:TextBox id="ziptxt" runat="server" class="input1" AutoPostBack="true" OnTextChanged="ziptxt_TextChanged" placeholder="12345"  onkeydown="javascript:backspacerDOWN1(this,event);" onkeyup="javascript:backspacerUP1(this,event);"/></td>
</tr>
                                       
      
                        <tr>
    <td class="auto-style21" colspan="2" style="text-align: left">Work Phone </td>
    <td class="auto-style11" style="text-align: left"> <input id="te1txt" runat="server" class="input1" type="text" name="phone" placeholder="(123) 456-7890"  onkeydown="javascript:backspacerDOWN(this,event);" onkeyup="javascript:backspacerUP(this,event);"/></td>
    <td class="auto-style24" colspan="2" style="text-align: left">Home Phone </td>
    <td class="auto-style2" colspan="2" style="text-align: left"> <input id="tel2txt" runat="server" class="input1" type="text" name="phone0" placeholder="(123) 456-7890"  onkeydown="javascript:backspacerDOWN(this,event);" onkeyup="javascript:backspacerUP(this,event);"/></td>
</tr>
                                       
      
                        <tr>
    <td class="auto-style21" colspan="2" style="text-align: left">Mobile Phone </td>
    <td class="auto-style11" style="text-align: left"> <input id="celltxt" runat="server" class="input1" type="text" name="phone1" placeholder="(123) 456-7890"  onkeydown="javascript:backspacerDOWN(this,event);" onkeyup="javascript:backspacerUP(this,event);" /></td>
    <td class="auto-style24" colspan="2" style="text-align: left">Fax</td>
    <td class="auto-style2" colspan="2" style="text-align: left"> <input id="faxtxt" runat="server" class="input1" type="text" name="phone2" /></td>
</tr>
                                       
      
                         <tr>
    <td class="auto-style16">Note</td>
    <td colspan="6"  style="text-align: left" > <input id="memotxt" runat="server" class="input3"  type="text" name="phone" /></td>
</tr>

      
                         <tr>
    <td class="auto-style16">
        <asp:Button ID="cPassword"  runat="server" Text="Change Password" BorderStyle="None"  OnClick="cPassword_Click" CssClass="button" ClientIDMode="Predictable"   />
                             </td>
    <td colspan="6" class="auto-style2" style="text-align: left" > <div id="passwordS" visible="false" runat="server" style="color: #000000; text-align: left;">New Password:        <input id="password" runat="server" class="input1" type="text" name="password" /></div></td>
</tr>

      
                         <tr>
    <td class="auto-style2"></td>
    <td colspan="6" class="auto-style2" style="text-align: left" > </td>
</tr>

                    </table>
                                
             
                <br />
                <div style="text-align: center">
                <asp:Label ID="message" runat="server" Font-Size="50px" BackColor="White" ForeColor="Red"></asp:Label>
                </div>
                    <br />

                <div style="text-align: right">
                <button type="submit" runat="server" onserverclick="update_Click" class="myButton" >Update Details</button>
                </div>

                    <br />
                

            </div>
  </div>
        <div class="auto-style28">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
           
            <br />
            <br />
            <br />
            <br />
        </div>
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

            } else {
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
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ClientFooter" runat="server">
</asp:Content>