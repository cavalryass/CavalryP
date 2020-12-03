using Forms.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.ManagerFolder
{
    public partial class AccountManager : System.Web.UI.Page
    {
        static string uid = "";
        static string idOfS = "";
        AccountManagerFunction inter = new AccountManagerFunction();
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
                popAcc();
            }
        }


        protected void Add_Click(object sender, EventArgs e)
        {
            try
            {
                inter.AddAccount(new Basic.ManagerAccess.Account(AccNum.Value, oMail.Value, "0", equity.Value, "0", "0", equity.Value, "0", txtkind.Text, uid));
                maindiv.Visible = false;
            }
            catch(Exception ex)
            {
                Error.Text = ex.Message;
            }
            popAcc();
            
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            idOfS= ((Label)AccGV.Rows[id].FindControl("laccountNum")).Text;
            UAccNum.Value= ((Label)AccGV.Rows[id].FindControl("laccountNum")).Text;
            UoMail.Value = ((Button)AccGV.Rows[id].FindControl("lownermail")).Text;
            
            Ukinddd.Text = ((Label)AccGV.Rows[id].FindControl("lkind")).Text;
            AddDiv.Visible = false;
            UpdateDiv.Visible = true;
            maindiv.Visible = true;

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            try
            { 
                inter.UpdateAccount(new Basic.ManagerAccess.Account(UAccNum.Value, UoMail.Value, "","", "", "", "", "", Ukinddd.Text, ""),idOfS);
                UpdateDiv.Visible = false;
                AddDiv.Visible = true;
                maindiv.Visible = false;
            }
            catch (Exception ex)
            {
                Error.Text = ex.Message;
            }
            popAcc();
          
        }
        void popAcc()
        {
            AccGV.DataSource = inter.AllAccounts();
            AccGV.DataBind();
            if (AccGV.Rows.Count == 0)
                maindiv.Visible = true;
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            inter.DeleteAccount(((Label)AccGV.Rows[id].FindControl("laccountNum")).Text);
            popAcc();

        }

        protected void info_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            idOfS = ((Label)AccGV.Rows[id].FindControl("laccountNum")).Text;
            information.Visible = true;
            catDD.DataSource = inter.CategorySource();
            catDD.DataBind();
            accDD.DataSource = inter.F_WSource();
            accDD.DataBind();
            accDD.SelectedValue = "All";
            accTF.Visible = false;
            catDD.SelectedValue = "All";
            accTF.Text = "All";
            AccountReportDiv.Visible = false;
            AccountReportTitle.Text="Report Of "+ ((Label)AccGV.Rows[id].FindControl("laccountNum")).Text;
            
            dateF.Attributes["max"] = DateTime.Now.ToString("yyyy-MM-dd");
            dateT.Attributes["max"] = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void filter_Click(object sender, EventArgs e)
        {
            try
            {
                infoGV.DataSource = inter.SearchAccInfo(idOfS,dateF.Value,dateT.Value,catDD.Text,accTF.Text);
                infoGV.DataBind();
                AccountReportDiv.Visible = true;
                information.Visible = false;
            }
            catch (Exception ex)
            {
                Error1.Text = ex.Message;
            }
        }

        protected void acccDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accDD.SelectedValue != "Other")
            {
                accTF.Visible = false;
                accTF.Text = accDD.SelectedValue;
            }
            else
            {
                accTF.Visible = true;
                accTF.Text = "";
            }
        }

        protected void category_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid;
            Response.Redirect("~/ManagerFolder/CategoryManager.aspx");
        }

        protected void account_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid;
            Response.Redirect("~/ManagerFolder/CategoryManager.aspx");
        }

        protected void clients_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid;
            Response.Redirect("~/ManagerFolder/ClientManagment.aspx");
        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GlobalForm/StartPage.aspx");
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            maindiv.Visible = false;
            AddDiv.Visible = true;
            UpdateDiv.Visible = false;
        }

        protected void Cancel0_Click(object sender, EventArgs e)
        {
            AccNum.Value = "";
            oMail.Value = "";
            equity.Value = "";
        }

        protected void ShowAdd_Click(object sender, EventArgs e)
        {
            maindiv.Visible = true;
        }

        protected void lownermail_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            string email = ((Button)AccGV.Rows[id].FindControl("lownermail")).Text;
            Session["Value"] = uid+" "+ email;
            Session["PrevPage"] = "~/ManagerFolder/AccountManager.aspx";
            Response.Redirect("~/GlobalForm/SendEmail.aspx");
        }

        protected void AccRep_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid + "@manager";
            Response.Redirect("~/SecretaryFolder/AccInformation.aspx");
        }
    }
}