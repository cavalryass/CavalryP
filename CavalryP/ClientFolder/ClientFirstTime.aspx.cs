using Basic.SoftwareUsers;
using Forms.ClientForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.ClientFolder
{
    public partial class ClientFirstTime : System.Web.UI.Page
    {
        static string uid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    uid = Session["Value"].ToString();
                }
                catch
                {
                    Response.Redirect("~/GlobalForm/StartPage.aspx");
                }

                ClientFirsTimeFunction c = new ClientFirsTimeFunction();
                User u = c.userInformation(uid);
                createmail.Text = u.Mail;
                Fname.Text = u.Fname;
                Lname.Text = u.Lname;
                celltxt.Text = u.MobileNum;
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            try
            {
                ClientFirsTimeFunction c = new ClientFirsTimeFunction();
                c.CreateClient(new Client(createmail.Text, Fname.Text, Lname.Text, companynametxt.Text, addresstxt.Text, suitetxt.Text, citytxt.Text, statedd.Text, ziptxt.Text, tel1txt.Text, tel2txt.Text, celltxt.Text, faxtxt.Text, "", memotxt.Text));
                Session["Value"] = uid;
                Response.Redirect("~/ClientP.aspx");
            }
            catch(Exception ex)
            {
                Error.Text = ex.Message;
            }
        }

        protected void ziptxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClientFirsTimeFunction c = new ClientFirsTimeFunction();
                statedd.SelectedValue= c.findStateByZip(Convert.ToInt32(ziptxt.Text));
            }
            catch
            {
                Error.Text = "Unavailable Zip Code";
            }
        }
    }
}