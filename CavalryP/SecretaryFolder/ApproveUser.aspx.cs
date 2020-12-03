using Forms.Secretary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.SecretaryFolder
{
    public partial class ApproveUser : System.Web.UI.Page
    {
        static string uid = "";
        static string idOfU = "";
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
                    popUser();
            }
        }
        void popUser()
        {
            ApproveUsersFunction inter = new ApproveUsersFunction();
            listU.DataSource = inter.UnknownUsers();
            listU.DataBind();
            if (listU.Rows.Count == 0)
            {
                updateUser.Visible = false;
                NoUser.Text = "No Unknown User Exists";
            }

        }
        protected void Report_Click(object sender, EventArgs e)
        {

            Session["Value"] = uid+"@secretary";
            Response.Redirect("~/SecretaryFolder/AccInformation.aspx");
            
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            ApproveUsersFunction inter = new ApproveUsersFunction();
            inter.UpdateUserStatus(new Basic.SoftwareUsers.User(idOfU, Mail.Text, "", Fname.Text, Lname.Text, Mphone.Text, statusdd.Text));
            popUser();
        }

        protected void findReq_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            idOfU = ((Label)listU.Rows[id].FindControl("Id")).Text;
            Mail.Text = ((Label)listU.Rows[id].FindControl("mail")).Text;
            Fname.Text = ((Label)listU.Rows[id].FindControl("fname")).Text;
            Lname.Text = ((Label)listU.Rows[id].FindControl("lname")).Text;
            Mphone.Text = ((Label)listU.Rows[id].FindControl("cell")).Text;
           
        }

  
        
    }
}