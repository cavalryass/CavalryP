using Basic.ManagerAccess;
using Forms.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.ManagerFolder
{
    public partial class CategoryManager : System.Web.UI.Page
    {
        static string idOfC = "";
        static string uid = "";
        CategoryManagment inter = new CategoryManagment();
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
                DropDownList1.DataSource = inter.MainCatSource();
                DropDownList1.DataBind();
                mainCtxt.Visible = false;
                DropDownList1.SelectedValue = "No Main Category";
                catinfoDiv.Visible = false;
                popCatGV();
                addCatDiv.Visible = false;
            }
        }

        protected void create_Click(object sender, EventArgs e)
        {
            Error.Text = "";

            try
            {
                inter.CreateCategory(new Category(nametxt.Text, mainCtxt.Text, txtkind0.Text));
                addCatDiv.Visible = false;
            }
            catch(Exception ex) 
            {
                Error.Text = ex.Message;
            }
            popCatGV();
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue != "New")
            {
                mainCtxt.Text = DropDownList1.SelectedValue;
                mainCtxt.Visible = false;
            }
            else
            {
                mainCtxt.Visible = true;
                mainCtxt.Text = "";
            }
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            nametxt.Text = "";
            mainCtxt.Text = "";
            DropDownList1.SelectedValue = "No Main Category";
            txtkind0.SelectedValue = "All";

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;

            inter.DeleteCategory(Convert.ToInt32(((Label)catGV.Rows[id].FindControl("lId")).Text));
            popCatGV();
        }
        void popCatGV()
        {
            catGV.DataSource = inter.CategoryList();
            catGV.DataBind();
        }

        protected void info_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            idOfC=((Label)catGV.Rows[id].FindControl("lId")).Text;
            catInfo.Visible = true;
            catReportHeader.Text = "All " + ((Label)catGV.Rows[id].FindControl("lname")).Text + " Report:";
            searchResultDiv.Visible = false;
            datef.Attributes["max"] = DateTime.Now.ToString("yyyy-MM-dd");
            dateT.Attributes["max"] = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void search_Click(object sender, EventArgs e)
        {
            try
            {
                
                GV.DataSource = inter.CategoryAIDetails(datef.Value, dateT.Value, idOfC);
                GV.DataBind();
                searchResultDiv.Visible = true;
                subTitelReport.Text = "";
                if(datef.Value!="")
                    subTitelReport.Text+="From "+ datef.Value;
                if (dateT.Value != "")
                    subTitelReport.Text += " Until " + dateT.Value;
                catInfo.Visible = false;
            }
            catch (Exception ex)
            {
                error2.Text = ex.Message;
            }
        }


        protected void Edit_Click(object sender, EventArgs e)
        {
            Add.Visible = false;
            Update.Visible = true;
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            idOfC= ((Label)catGV.Rows[id].FindControl("lId")).Text;
            Uname.Text= ((Label)catGV.Rows[id].FindControl("lname")).Text;
            umDD.DataSource = inter.MainCatSource();
            umDD.DataBind();
            string s= ((Label)catGV.Rows[id].FindControl("lnameOfMainc")).Text;
            umDD.SelectedValue = s;
            UmainCtxt.Text = s;
            UmainCtxt.Visible = false;
            Ukind.SelectedValue= ((Label)catGV.Rows[id].FindControl("lkind")).Text;
            addCatDiv.Visible = true;
        }

        protected void Ucancel_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            Update.Visible = false;
            nametxt.Text = "";
            mainCtxt.Text = "";
            mainCtxt.Visible = false;
            DropDownList1.SelectedValue = "No Main Category";
            txtkind0.SelectedValue = "All";
            addCatDiv.Visible = false;
        }

        protected void UpdateB_Click(object sender, EventArgs e)
        {
            try
            {
                inter.UpdateCategory(new Category(Uname.Text, UmainCtxt.Text, Ukind.Text));
                Add.Visible = true;
                addCatDiv.Visible = false;
            }
            catch (Exception ex)
            {
                Error.Text = ex.Message;
            }
        }

        protected void Account_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid;
            Response.Redirect("~/ManagerFolder/AccountManager.aspx");
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

        protected void addCat_Click(object sender, EventArgs e)
        {
            addCatDiv.Visible = true;          
        }

        
    }
}