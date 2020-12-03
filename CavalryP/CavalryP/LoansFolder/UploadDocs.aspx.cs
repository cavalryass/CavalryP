using Basic.Loan;
using Forms.ClientForms.Loans;
using Forms.Manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.LoansFolder
{
    public partial class UploadDocs : System.Web.UI.Page
    {
        UploadDocdfunction inter = new UploadDocdfunction();
       static string cid = "";
        static List<Docs> l = new List<Docs>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    cid = Session["Value"].ToString().Split('@')[0];
                }
                catch (Exception ex)
                {
                    Response.Redirect("~/GlobalForm/StartPage.aspx");
                }
                popKindDD();
                popDoc();
                if (kindDD.Items.Count == 0)
                {
                    kindDD.Items.Add("No Files To Upload");
                    error.Text = "No Files To Upload";
                }            }

        }
        void popKindDD()
        {
            kindDD.DataSource = inter.reqDocsDD(cid);
            kindDD.DataBind();
            if (kindDD.Items.Count == 0)
            {
                UploadDiv.Visible = false;
                error.Text = "No Files To Upload";
            }
        }
        protected void kindDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            comment.Text = inter.comment(cid, kindDD.SelectedValue);
        }

        protected void Upload(object sender, EventArgs e)
        {

            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string contentType = FileUpload1.PostedFile.ContentType;
            //try
            //{
                inter.createDoc(cid, filename, contentType, kindDD.Text, FileUpload1);
            //}
            //catch(Exception ex)
            //{
            //    error.Text = ex.Message;
            //}
            Response.Redirect(Request.Url.AbsoluteUri);
            popKindDD();
            popDoc();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Session["Value"] = cid;
            Response.Redirect("~/LoansFolder/Steps.aspx");
        }
        void popDoc()
        {
            ClientManagmentFunction c = new ClientManagmentFunction();
            GridView1.DataSource = c.UploadDocs(cid);
            GridView1.DataBind();
            
        }
      

        protected void Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            ClientManagmentFunction f = new ClientManagmentFunction();
           
            f.DeleteDoc(id);// (Convert.ToInt32(((Label)catGV.Rows[id].FindControl("lId")).Text));
            
            popDoc();
        }
    }
}