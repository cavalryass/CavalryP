using Basic.SoftwareUsers;
using Forms.ClientForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP
{
    public partial class ClientP : System.Web.UI.Page
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
                catch (Exception ex)
                {
                    Response.Redirect("~/GlobalForm/StartPage.aspx");
                }
                ClientGlobal c = new ClientGlobal();
                fill(c.FindClient(uid));
            }

        }
        public void fill(Client c)
        {
            emailtxt.Value = c.Mail;
            Fname.Value = c.Fname;
            Lname.Value = c.Lname;
            companynametxt.Value = c.CompanyName;
            addresstxt.Value = c.Address;
            suitetxt.Value = c.Suite;
            citytxt.Value = c.City;
            statedd.SelectedValue = c.State;
            ziptxt.Text = c.Zip;
            te1txt.Value = c.WorkNum;
            tel2txt.Value = c.HomeNum;
            celltxt.Value = c.MobileNum;
            faxtxt.Value = c.Fax;
            memotxt.Value = c.Memo;
            if (c.MiddleProcess != "")
            {
                LoansB.Text = "My Loan";
            }
            else
            {
                LoansB.Text = "Request Loan";
            }
        }
       

        protected void update_Click(object sender, EventArgs e)
        {
            try 
            {
                ClientProfile c = new ClientProfile();
                c.UpdateSetting(new Client(emailtxt.Value,Fname.Value,Lname.Value,companynametxt.Value,addresstxt.Value,suitetxt.Value,citytxt.Value,statedd.Text,ziptxt.Text,te1txt.Value,tel2txt.Value,celltxt.Value,faxtxt.Value,"",memotxt.Value), uid,password.Value);
            }
            catch(Exception ex)
            {
                message.Text = ex.Message;
            }
        }

       

        protected void logOut_Click(object sender, EventArgs e)
        {
                Response.Redirect("~/GlobalForm/StartPage.aspx");
            
        }

        

        protected void LoansB_ServerClick(object sender, EventArgs e)
        {
            if (LoansB.Text == "Request Loan")
            {
                Session["Value"] = uid + "@ClientFirst";
                Response.Redirect("~/LoansFolder/Loans1Form.aspx");
            }
            else
            {
                Session["Value"] = uid;
                Response.Redirect("~/LoansFolder/Steps.aspx");
            }
        }

        protected void cPassword_Click(object sender, EventArgs e)
        {
            passwordS.Visible = true;
        }

        protected void ziptxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClientFirsTimeFunction c = new ClientFirsTimeFunction();
                statedd.SelectedValue = c.findStateByZip(Convert.ToInt32(ziptxt.Text));
            }
            catch
            {
                message.Text = "Unavailable Zip Code";
            }
        }
    }
}