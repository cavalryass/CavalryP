<%@ Page Language="C#" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="ClientFirstTime.aspx.cs" Inherits="CavalryP.ClientFolder.ClientFirstTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="~/Styles/GlobalS.css" rel="stylesheet" type="text/css" media="screen" runat="server" />
    <title></title>
    <style>
        
          .myTable{
           margin-left: auto; 
  margin-right: auto;
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
        .auto-style1 {
            height: 42px;
        }
        .auto-style2 {
            width: 234px;
        }
        .auto-style3 {
            height: 42px;
            width: 234px;
        }
        .auto-style4 {
            width: 786px;
        }
        .auto-style6 {
            width: 251px;
        }
        .auto-style7 {
            width: 119px;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server">
       <div class="regform">
           <p style="font-size: 30px">To Continue The Process We Will Need You&nbsp; To Fill In The Following Details:</p></div>
            <div class="main">
              <table class="auto-style22" style="color: #5D7B9D; font-weight: bold; font-size: 20px;">
                        <tr>
                            <td class="auto-style2">
                                Enter Email:</td>
                            <td colspan="3" class="auto-style3">
                        <asp:TextBox ID="createmail" runat="server" CssClass="readCSS"  Width="400px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13">
                                First Name:
                                </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="Fname" runat="server" Width="90px" CssClass="readCSS"></asp:TextBox>
                            </td>
                            <td class="auto-style7">
                                Last Name:

                            </td>
                            <td class="auto-style14">
                                <asp:TextBox ID="Lname" runat="server" Width="90px" CssClass="readCSS"></asp:TextBox>
                            </td>
                        </tr>
                        
                        <tr>
                            <td class="auto-style1">
                                Enter Company Name:

                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="companynametxt" CssClass="readCSS" runat="server" Width="400px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                Billing Address:
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="addresstxt" CssClass="readCSS" runat="server"></asp:TextBox>
                            </td>
                            <td class="auto-style7">
                                Suite:
                            </td>
                            <td class="auto-style14">
                    <asp:TextBox ID="suitetxt" runat="server" CssClass="readCSS"></asp:TextBox>
                </td>
            </tr>
                        <tr>
                            <td colspan="4">
                                <table class="auto-style4">
                                    <tr>
                                        <td>
                                            Unit City:
                                        </td>
                                        <td>
                    <asp:TextBox ID="citytxt" runat="server" CssClass="readCSS"></asp:TextBox>
                                        </td>
                                        <td>
                                            State:
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="statedd" runat="server" CssClass="mydropdownlist1" DataTextField="Text" DataValueField="Value" EnableIncrementalSearch="true" CaseSensitiveSearch="true">
                                          
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

                                    </asp:DropDownList>
                    
                                        </td>
                                        <td>
                                            Zip Code:
                                        </td>
                                        <td>
                    <asp:TextBox ID="ziptxt" runat="server" CssClass="readCSS" AutoPostBack="true" OnTextChanged="ziptxt_TextChanged" placeholder="12345"  onkeydown="javascript:backspacerDOWN1(this,event);" onkeyup="javascript:backspacerUP1(this,event);"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </td>
            </tr>
            <tr>
                <td class="auto-style38">
                    Work Phone:
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="tel1txt" runat="server" CssClass="readCSS" Width="140px" placeholder="(123) 456-7890"  onkeydown="javascript:backspacerDOWN(this,event);" onkeyup="javascript:backspacerUP(this,event);"></asp:TextBox>
                    </td>
                <td class="auto-style7">
                    Home Phone:
                </td>
                <td class="auto-style40">
                    <asp:TextBox ID="tel2txt" runat="server" Width="140px" CssClass="readCSS" placeholder="(123) 456-7890" onkeydown="javascript:backspacerDOWN(this,event);" onkeyup="javascript:backspacerUP(this,event);"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    Mobile Phone:
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="celltxt" runat="server" Width="140px" CssClass="readCSS" placeholder="(123) 456-7890" onkeydown="javascript:backspacerDOWN(this,event);" onkeyup="javascript:backspacerUP(this,event);"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    Fax:
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="faxtxt" Width="140px" CssClass="readCSS" runat="server"></asp:TextBox>
                </td>
            </tr>            
            <tr>
                <td class="auto-style1">
                    Note:
                </td>
                <td class="auto-style27" colspan="3">
                    <asp:TextBox ID="memotxt" runat="server" CssClass="readCSS" Height="95px" Width="395px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="4" style="text-align: center">
                    <asp:Button ID="update" runat="server" Text="update" CssClass="smalluttons"  OnClick="update_Click" />
                </td>
            </tr>
       </table>
        
                <br />
                
                <br />
                <div style="text-align: center">
            <asp:Label ID="Error" runat="server"></asp:Label>
        
                </div>
                    <br />
            </div>
        
        
        <div>
        
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
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
