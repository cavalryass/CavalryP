using Basic.SoftwareUsers;
using Forms.SignIn_Up;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP
{
    public partial class SignIn_Up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Log_In(object sender, EventArgs e)
        {
            SignUp_In c = new SignUp_In();
            User u=new User();           
            try
            {
               u=c.SignIN(new User(unameId.Value, passwordId.Value));
            }
            catch(Exception ex)
            {
                error1.Text = ex.Message;
            }
            if(u.Status=="Unknown")
            {
                unknownstatus.Text = "< h1 > Thank you for signing up to < em > Cavalry Associates </ em ></ h1 > " +

                   "We will do our best to respond to your inquiry as soon as possible";
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
                    Response.Redirect("~/ClientP.aspx");
                }
                
            }
            if (u.Status == "Manager")
            {
                Session["Value"] = u.Id;
                Response.Redirect("~/ManagerFolder/AccountManager.aspx");
            }
            if (u.Status == "Secretary")
            {
                Session["Value"] = u.Id+"@secretary";
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
            
            unknownstatus.Text = " Thank you for signing up to Cavalry Associates \r\n" +

                 "We will do our best to respond to your inquiry as soon as possible";
        }

    }
}