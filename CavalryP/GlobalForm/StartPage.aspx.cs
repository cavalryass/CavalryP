using Basic.SoftwareUsers;
using Forms.SignIn_Up;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.GlobalForm
{
    public partial class StartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Log_In(object sender, EventArgs e)
        {
            SignUp_In c = new SignUp_In();
            User u = new User();
            try
            {
                u = c.SignIN(new User(unameId.Value, passwordId.Value));
            }
            catch (Exception ex)
            {
                error1.Text = ex.Message;
            }
            if (u.Status == "Unknown")
            {
                
                unknownstatus.Visible = true;
                updateStatus.Text = "<br /> Hello " +unameId.Value+" " +

                   "Your account is currently not active." + " <br /><br />" + "An administrator needs to activate your account before you can login.<br />";
            }
            if (u.Status == "Client")
            {
                if (c.FirstTime(u.Id))
                {
                    Session["Value"] = u.Id;
                    Response.Redirect("~/ClientFolder/ClientFirstTime.aspx");
                }
                else
                {
                    Session["Value"] = u.Id;
                    Response.Redirect("~/ClientFolder/ClientP.aspx");
                }

            }
            if (u.Status == "Manager")
            {
                Session["Value"] = u.Id;
                Response.Redirect("~/ManagerFolder/AccountManager.aspx");
            }
            if (u.Status == "Secretary")
            {
                Session["Value"] = u.Id + "@secretary";
                Response.Redirect("~/SecretaryFolder/AccInformation.aspx");
            }
        }
        protected void Sign_Up(object sender, EventArgs e)
        {
            SignUp_In c = new SignUp_In();

            try
            {
                c.SignUp(new User(emailId.Value, pswId.Value, fnameId.Value, lnameId.Value, mphoneId.Value, "Unknown"), pswrepeatId.Value);
            }
            catch (Exception ex)
            {
                error2.Text = ex.Message;
            }
            unknownstatus.Visible = true;
            updateStatus.Text = "<br /> Thank you for signing up to  Cavalry Associates " + "<br /> <br />" +

                   "Your account is currently not active." + "<br /> " + "An administrator needs to activate your account before you can login.<br />";
        }

        protected void lbutton_Click(object sender, EventArgs e)
        {
            logind.Visible = true;
            signupd.Visible = false;            
            

        }

        protected void sbutton_Click(object sender, EventArgs e)
        {
            logind.Visible = false;
            signupd.Visible = true;
            
        }
    }
}