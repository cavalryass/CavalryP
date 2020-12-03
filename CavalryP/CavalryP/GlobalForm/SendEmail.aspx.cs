using Forms.GlobalClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.GlobalForm
{
    public partial class SendEmail : System.Web.UI.Page
    {
        static string uid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    uid = Session["Value"].ToString().Split(' ')[0];
                    email.Value = Session["Value"].ToString().Split(' ')[1];
                }
            }
            catch
            {
                Response.Redirect("~/GlobalForm/StartPage.aspx");
            }
        }

        protected void sendEB_Click(object sender, EventArgs e)
        {
            try
            {
                SendEmailC send = new SendEmailC();
                send.SendEmailF(email.Value, subject.Value, message.Value);
            }
            catch(Exception ex)
            {
                error.Text = ex.Message;
            }
            error.Text = "The Email Was Sent Successfully";
            email.Value = "";
            message.Value = "";
            subject.Value = "";
        }

        protected void Back_ServerClick(object sender, EventArgs e)
        {
            Session["Value"] = uid;            
            Response.Redirect(Session["PrevPage"].ToString());
        }

        protected void LogOut_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("~/GlobalForm/StartPage.aspx");
        }
    }
}