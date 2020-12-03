using Forms.Secretary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.SecretaryFolder
{

    public partial class AccInformation : System.Web.UI.Page
    {
        static string infoId = "";
        AccInfoFunction i = new AccInfoFunction();
        static string uid = "";
        static string status = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    uid = Session["Value"].ToString().Split('@')[0];
                    status = Session["Value"].ToString().Split('@')[1];
                }
                catch (Exception ex)
                {
                    Response.Redirect("~/GlobalForm/StartPage.aspx");
                }
                if (status == "manager")
                {
                    AccManager.Visible = true;
                    ManagedUsers.Visible = false;
                }
                else
                {
                    AccManager.Visible = false;
                    ManagedUsers.Visible = true;
                }
                dateP2.Attributes["max"] = DateTime.Now.ToString("yyyy-MM-dd");
                popsF();
                popsT("Regular");
                popF();
                fromtxt.Text = fromDD.SelectedValue;
                popT("Regular");
                totxt.Text = toDD.SelectedValue;
                fromtxt.Visible = false;
                totxt.Visible = false;
                popC("Regular");
                show(false);
                popGV1();
            }
        }
        void popsF()
        {
            sFromdd.DataSource = i.FromSource(DropDownList1.SelectedValue);
            sFromdd.DataBind();
            sFromdd.Items.Add("All");
        }
        void popsT(string s)

        {
            sTodd.DataSource = i.FromSource(s);
            sTodd.DataBind();
            sTodd.Items.Add("All");
        }
        void popF()
        {
            fromDD.DataSource = i.FromSource(ddkind.SelectedValue);
            fromDD.DataBind();
        }
        void popT(string s)

        {
            toDD.DataSource = i.FromSource(s);
            toDD.DataBind();
        }
        void popC(string s)
        {
            List<string> l = i.CategorySource(s);
            foreach (var v in l)
            {
                var o = new ListItem(v);
                if (v.ToUpper() == v)
                    o.Attributes.Add("disabled", "disabled");

                ddcategory.Items.Add(o);

            }
        }
        protected void ddkind_SelectedIndexChanged(object sender, EventArgs e)
        {
            fromDD.Visible = true;
            toDD.Visible = true;
            fromtxt.Visible = false;
            totxt.Visible = false;
            tpL.Visible = false;
            fromDD.DataSource = i.FromSource(ddkind.SelectedValue);
            fromDD.DataBind();
            toDD.DataSource = i.FromSource("Regular");
            toDD.DataBind();
            if (ddkind.SelectedValue == "Income")
            {
                fromDD.Visible = false;
                totxt.Text = toDD.SelectedValue;
            }
            else
            {
                if (ddkind.SelectedValue == "Expenses")
                {
                    toDD.Visible = false;
                    fromtxt.Text = fromDD.SelectedValue;
                }
                else
                {
                    if (ddkind.SelectedValue == "Third party")
                    {
                        tpL.Visible = true;
                        fromDD.Visible = true;
                        toDD.Visible = true;
                        fromtxt.Visible = true;
                        totxt.Visible = true;
                        fromtxt.Text = "";
                        totxt.Text = "";
                    }
                    else
                    {
                        fromDD.Visible = true;
                        toDD.Visible = true;
                        fromtxt.Visible = false;
                        totxt.Visible = false;
                        fromtxt.Text = fromDD.SelectedValue;
                        totxt.Text = toDD.SelectedValue;
                    }
                }
            }
            ddcategory.DataSource = i.CategorySource(ddkind.SelectedValue);
            ddcategory.DataBind();
            
        }

        protected void DropDownListAccountFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            fromtxt.Text = fromDD.SelectedValue;
            if (ddkind.SelectedValue == "Third party")
            {
                fromtxt.Visible = false;
                totxt.Visible = true;
                totxt.Text = "";
            }
            else
            {
                toDD.DataSource = i.FromWhenChoose(fromDD.SelectedValue);
                toDD.DataBind();
                if (totxt.Text != ""&& totxt.Text!=fromDD.SelectedValue)
                    toDD.SelectedValue = totxt.Text;
            }
        }

        protected void DropDownListAccountTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            totxt.Text = toDD.SelectedValue;
            if (ddkind.SelectedValue == "Third party")
            {
                totxt.Visible = false;                
                fromtxt.Visible = true;
                fromtxt.Text = "";
            }
            else
            {
                fromDD.DataSource = i.ToWhenChoose(toDD.SelectedValue);
                fromDD.DataBind();
                if (fromtxt.Text != ""&& fromtxt.Text!=toDD.SelectedValue)
                    fromDD.SelectedValue = fromtxt.Text;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sFromdd.Visible = true;
            sTodd.Visible = true;
            ftxt.Visible = false;
            ttxt.Visible = false;
            popsF();
            popsT("Regular");
            if (DropDownList1.SelectedValue == "Income")
            {
                sFromdd.Visible = false;
                sTodd.Visible = true;
            }
            else
            {
                if (DropDownList1.SelectedValue == "Expenses")
                {
                    sFromdd.Visible = true;
                    sTodd.Visible = false;
                }
                else
                {
                    if (DropDownList1.SelectedValue == "Third party") 
                    {
                        sFromdd.Visible = true;
                        sTodd.Visible = true;
                        ftxt.Visible = true;
                        ttxt.Visible = true;
                        ftxt.Text = "";
                        ttxt.Text = "";
                    }
                    else {
                        sFromdd.Visible = true;
                        sTodd.Visible = true;
                        ftxt.Visible = false;
                        ttxt.Visible = false;
                        ftxt.Text = sFromdd.SelectedValue;
                        ttxt.Text = sTodd.SelectedValue;
                    }
                }
            }
           

        }

        protected void Fromdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ftxt.Text = sFromdd.SelectedValue;
            if (DropDownList1.SelectedValue == "Third party")
            {
                sTodd.Visible = true;
                sTodd.Text = "";
            }
            else
            {
                sTodd.DataSource = i.FromWhenChoose(sFromdd.SelectedValue);
                sTodd.DataBind();
            }
        }

        protected void Todd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ttxt.Text = sTodd.SelectedValue;
            if (ddkind.SelectedValue == "Third party")
            {
                ftxt.Visible = true;
                ftxt.Text = "";
            }
            else
            {
                sFromdd.DataSource = i.ToWhenChoose(sTodd.SelectedValue);
                if (ftxt.Text != "" && ftxt.Text != sTodd.SelectedValue)
                    sFromdd.SelectedValue = ftxt.Text;
            }
        }
        void popGV1()
        {
            GridView1.DataSource = i.SearchInfo(DateTime.Now.ToShortDateString(), "All", "All","", "All");
            GridView1.DataBind();
            if (GridView1.Rows.Count == 0)
                maindiv.Visible = true;
        }
        protected void search_Click(object sender, EventArgs e)
        {
            try
            {
                GridView1.DataSource=i.SearchInfo(dateP2.Value, ftxt.Text, ttxt.Text, amount.Text, DropDownList2.Text);
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                Comment.Text = ex.Message;
            }
        }


        protected void ManagedUsers_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid;
            Response.Redirect("~/SecretaryFolder/ApproveUser.aspx");
        }

        protected void checkNumtxt_TextChanged(object sender, EventArgs e)
        {
            if (checkNumtxt.Text != "")
                show(true);
            else
                show(false);
        }
        void show(bool ans)
        {
            bankNameL.Visible = ans;
            invoiceL.Visible = ans;
            bankNametxt.Visible = ans;
            invoicetxt.Visible = ans;
        }

        protected void logOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GlobalForm/StartPage.aspx");
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            AccInfoFunction inter = new AccInfoFunction();
            try
            {
                if (Add.Text == "Add")
                {
                    inter.AddButton(new Basic.ManagerAccess.AccInfo(ddkind.Text, dateP1.Value, fromtxt.Text, totxt.Text, comenttxt.Text, amounttxt.Text, uid, ddcategory.Text, checkNumtxt.Text, bankNametxt.Text, invoicetxt.Text, enterb.Checked));
                }
                else
                {
                    inter.UpdateButton(new Basic.ManagerAccess.AccInfo(Convert.ToInt32(infoId), ddkind.Text, dateP1.Value, fromtxt.Text, totxt.Text, comenttxt.Text, amounttxt.Text, uid, ddcategory.Text, checkNumtxt.Text, bankNametxt.Text, invoicetxt.Text, enterb.Checked));
                }
            }
            catch(Exception ex)
            {
                comment2.Text = ex.Message;
            }
            Add.Text = "Add";
                popGV1();
            maindiv.Visible = false;
        }

        protected void ShowAdd_Click(object sender, EventArgs e)
        {
            maindiv.Visible = true;
            dateP1.Attributes["max"] = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void Select_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            infoId= ((Label)GridView1.Rows[id].FindControl("lID")).Text;
            string chose= ((Label)GridView1.Rows[id].FindControl("lkind")).Text;
            ddkind.SelectedValue = chose;
            popC(chose);
            popF();
            popT(chose);
            dateP1.Value= ((Label)GridView1.Rows[id].FindControl("ldate")).Text;
            fromDD.SelectedValue= ((Label)GridView1.Rows[id].FindControl("lfrom")).Text;
            toDD.SelectedValue= ((Label)GridView1.Rows[id].FindControl("lto")).Text;
            amounttxt.Text= ((Label)GridView1.Rows[id].FindControl("lamount")).Text;
            ddcategory.SelectedValue= ((Label)GridView1.Rows[id].FindControl("lcategory")).Text;
            checkNumtxt.Text= ((Label)GridView1.Rows[id].FindControl("lcheckNum")).Text;
            bankNametxt.Text = ((Label)GridView1.Rows[id].FindControl("lbankName")).Text;
            if (checkNumtxt.Text!="")
            {
                bankNameL.Visible = true;
                bankNametxt.Visible = true;
                invoiceL.Visible = true;
                invoicetxt.Visible = true;
            }
            invoicetxt.Text = ((Label)GridView1.Rows[id].FindControl("linvoice")).Text;
            enterb.Checked =((CheckBox)GridView1.Rows[id].FindControl("lenter")).Checked;
            comenttxt.Text = ((Label)GridView1.Rows[id].FindControl("lcomment")).Text;
            maindiv.Visible = true;
            Add.Text = "Update";
            dateP1.Attributes["max"] = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void AccManager_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid;
            Response.Redirect("~/ManagerFolder/AccountManager.aspx");
        }
    }
}