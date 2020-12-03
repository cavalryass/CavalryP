using Basic.Loan;
using Basic.SoftwareUsers;
using Forms.ClientForms;
using Forms.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.ManagerFolder
{
    public partial class ClientManagment : System.Web.UI.Page
    {
        static string uid = "";
       
        static Client saveClient=new Client();
       
        ClientManagmentFunction inter = new ClientManagmentFunction();
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
                List<Client> cl= inter.AllClient();
                listC.DataSource = cl;
                listC.DataBind();
               
                clientProfile.Visible = false;
               steps.Visible = false;
                Docs.Visible = false;
                DocDiv.Visible = false;
            }
        }
        void fillClient()
        {
            Nametxt.Text = saveClient.Fname + " " + saveClient.Lname;
            emailtxt.Text = saveClient.Mail;
            companyNtxt.Text = saveClient.CompanyName;
            addresstxt.Text = saveClient.Address + " " + saveClient.City+ " " + saveClient.State + " " +saveClient.Zip;
            worhPtxt.Text = saveClient.WorkNum;
            HomePtxt.Text = saveClient.HomeNum;
            mobilePtxt.Text = saveClient.MobileNum;
            faxtxt.Text = saveClient.Fax;
            notestxt.Text = saveClient.Memo;

        }
        protected void findReq_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            clientProfile.Visible = true;
            saveClient.MiddleProcess = ((Label)listC.Rows[id].FindControl("middleProcess")).Text;
            saveClient.Lname = ((Label)listC.Rows[id].FindControl("lname")).Text;
            saveClient.Fname=((Label)listC.Rows[id].FindControl("fname")).Text;
            saveClient.Mail = ((Label)listC.Rows[id].FindControl("mail")).Text;
            saveClient.CompanyName = ((Label)listC.Rows[id].FindControl("companyName")).Text;
            saveClient.Address = ((Label)listC.Rows[id].FindControl("address")).Text;
            saveClient.City = ((Label)listC.Rows[id].FindControl("city")).Text;
            saveClient.State = ((Label)listC.Rows[id].FindControl("state")).Text;
            saveClient.Zip= ((Label)listC.Rows[id].FindControl("zip")).Text;
            saveClient.Suite= ((Label)listC.Rows[id].FindControl("suite")).Text;
            saveClient.WorkNum= ((Label)listC.Rows[id].FindControl("tel1")).Text;
            saveClient.HomeNum = ((Label)listC.Rows[id].FindControl("tel2")).Text;
            saveClient.MobileNum = ((Label)listC.Rows[id].FindControl("cell")).Text;
            saveClient.Fax = ((Label)listC.Rows[id].FindControl("fax")).Text;
            saveClient.SalesRep= ((Label)listC.Rows[id].FindControl("salesRep")).Text;
            saveClient.Memo= ((Label)listC.Rows[id].FindControl("memo")).Text;
            saveClient.Id = ((Label)listC.Rows[id].FindControl("Id")).Text;
            saveClient.Request=Convert.ToBoolean(((Label)listC.Rows[id].FindControl("Request")).Text);
            if (saveClient.MiddleProcess != "")
                showLoan.Visible = true;
            else
                showLoan.Visible = false;

            fillClient();
        }

        protected void Step1_Click(object sender, EventArgs e)
        {
            Session["Value"] = saveClient.Id + "@" + uid;
            Response.Redirect("~/ManagerFolder/Loan/Loans1Employee.aspx");            

        }

        protected void Step2_Click(object sender, EventArgs e)
        {
            Session["Value"] = saveClient.Id + "@" + uid;
            Response.Redirect("~/ManagerFolder/Loan/Loans2Employee.aspx");
           
        }

        protected void clients_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid;
            Response.Redirect("~/ManagerFolder/CategoryManager.aspx"); 
        }

        protected void Account_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid;
            Response.Redirect("~/ManagerFolder/AccountManager.aspx");
        }

        protected void Docs_Click(object sender, EventArgs e)
        {
            DocDiv.Visible = true;
            popDoc();
            popReqDoc();
        }

        protected void send_Click(object sender, EventArgs e)
        {
            ClientManagmentFunction c = new ClientManagmentFunction();
            string selectedDocs = "";
            if (id1.Checked)
            {
                selectedDocs += "Tax Returns@";
                id1.Visible = false;
            }
            if (id2.Checked)
            {
                id2.Visible = false;
                selectedDocs += "Bank Statements@";
            }
            if (id3.Checked)
            {
                id3.Visible = false;
                selectedDocs += "Pay Stubs@"; 
            }
            if (id4.Checked)
            {
                id4.Visible = false;
                selectedDocs += "Proof of Insurance@";
            }
            if (id5.Checked)
            {
                id5.Visible = false;
                selectedDocs += "Drivers License State ID@";
            }
            if (id6.Checked)
            {
                id6.Visible = false;
                selectedDocs += "Social Security@";
            }
            if (id7.Checked)
            {
                id7.Visible = false;
                selectedDocs += "Utilities Bills@";
            }
            if (id8.Checked)
            {
                id8.Visible = false;
                selectedDocs += "PL Report@";
            }
            c.AddNewRD(selectedDocs, saveClient.Id);
            popReqDoc();
        }
        void popDoc()
        {
            ClientManagmentFunction c = new ClientManagmentFunction();
            GridView1.DataSource = c.UploadDocs(saveClient.Id);
            GridView1.DataBind();
        }
        void popReqDoc()
        {
            ClientManagmentFunction c = new ClientManagmentFunction();
            ReqDocGV.DataSource = c.listOfReqDocs(saveClient.Id);
            ReqDocGV.DataBind();
        }
        protected void DownloadFile(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            ClientManagmentFunction c = new ClientManagmentFunction();
            Docs p = c.findDocById(id);
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = p.ContentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + p.Name);
            Response.BinaryWrite(p.Data);
            Response.Flush();
            Response.End();
        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GlobalForm/StartPage.aspx");
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;

            inter.DeleteReqDoc(Convert.ToInt32(((Label)ReqDocGV.Rows[id].FindControl("LId")).Text));// (Convert.ToInt32(((Label)catGV.Rows[id].FindControl("lId")).Text));
            popReqDoc();
        }

        protected void ReqDocGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            ReqDocGV.EditIndex = e.NewEditIndex;
            popReqDoc();
        }

        protected void ReqDocGV_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            ReqDocGV.EditIndex = -1;
            popReqDoc();
        }

        protected void ReqDocGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            int id = Convert.ToInt32(ReqDocGV.DataKeys[e.RowIndex].Value.ToString());
            string s2 = (ReqDocGV.Rows[e.RowIndex].FindControl("comtxt") as TextBox).Text;
            string s1= (ReqDocGV.Rows[e.RowIndex].FindControl("kindtxt") as Label).Text;
            
            
            inter.UpdatReqdoc(new Basic.ManagerAccess.ReqDocs(id, saveClient.Id, s1, s2));
            ReqDocGV.EditIndex = -1;
            popReqDoc();
        }

        protected void showLoan_ServerClick(object sender, EventArgs e)
        {
            if (saveClient.MiddleProcess.Contains("1"))
            {
                Step1.Visible = true;
                Step2.Visible = false;
                Step3.Visible = false;
                Step4.Visible = false;
                Step5.Visible = false;
                Docs.Visible = true;
            }
            if (saveClient.MiddleProcess.Contains("2"))
            {
                Step1.Visible = true;
                Step2.Visible = true;
                Step3.Visible = false;
                Step4.Visible = false;
                Step5.Visible = false;
                Docs.Visible = true;
            }
            if (saveClient.MiddleProcess.Contains("3"))
            {
                Step1.Visible = true;
                Step2.Visible = true;
                Step3.Visible = true;
                Step4.Visible = false;
                Step5.Visible = false;
                Docs.Visible = true;
            }
            if (saveClient.MiddleProcess.Contains("4"))
            {
                Step1.Visible = true;
                Step2.Visible = true;
                Step3.Visible = true;
                Step4.Visible = true;
                Step5.Visible = false;
                Docs.Visible = true;
            }
            if (saveClient.MiddleProcess.Contains("5"))
            {
                Step1.Visible = true;
                Step2.Visible = true;
                Step3.Visible = true;
                Step4.Visible = true;
                Step5.Visible = true;
                Docs.Visible = true;
            }
            steps.Visible = true;
            buttons.Visible = true;
        }

        protected void emailtxt_Click(object sender, EventArgs e)
        {
            string email = emailtxt.Text;
            Session["Value"] = uid + " " + email;
            Session["PrevPage"] = "~/ManagerFolder/ClientManagment.aspx";
            Response.Redirect("~/GlobalForm/SendEmail.aspx");
        }

        protected void searchB_Click(object sender, EventArgs e)
        {

            listC.DataSource = inter.AllClientSearch(searchResult.Value);
            listC.DataBind();
        }

        protected void ShowA_Click(object sender, EventArgs e)
        {
            s1.Visible = false;           
            listC.DataSource = inter.AllClient();
            listC.DataBind();
        }

        protected void showS1_Click(object sender, EventArgs e)
        {
            s1.Visible = true;
           
        }

        protected void editClient_Click(object sender, EventArgs e)
        {
            deleteClient.Visible = true;
            cProfile.Visible = false;
            editProfile.Visible = true;
            saveChanges.Visible = true;
            editClient.Visible = false;
            editFName.Text = saveClient.Fname;
            editLName.Text = saveClient.Lname;
            editEmail.Text = emailtxt.Text;
            editaddress.Text = saveClient.Address;
            editstate.SelectedValue = saveClient.State;
            editZip.Text = saveClient.Zip;
            editCity.Text = saveClient.City;
            EditCompanyName.Text = companyNtxt.Text;
            EditWorkPhone.Text = worhPtxt.Text;
            EditHomePhone.Text = HomePtxt.Text;
            EditMobilePhone.Text = mobilePtxt.Text;
            EditFax.Text = faxtxt.Text;
            EditNote.Text = notestxt.Text;
        }

        protected void deleteClient_Click(object sender, EventArgs e)
        {
            ClientManagmentFunction inter = new ClientManagmentFunction();
            inter.DeleteClient(saveClient.Id);
        }

        protected void saveChanges_Click(object sender, EventArgs e)
        {
            ClientManagmentFunction inter = new ClientManagmentFunction();
            saveClient.Mail = editEmail.Text;
            saveClient.Fname = editFName.Text;
            saveClient.Lname = editLName.Text;
            saveClient.Address = editaddress.Text;
            saveClient.State = editstate.Text;
            saveClient.City = editCity.Text;
            saveClient.Zip = editZip.Text;
            saveClient.CompanyName = EditCompanyName.Text;
            saveClient.WorkNum = EditWorkPhone.Text;
            saveClient.HomeNum = EditHomePhone.Text;
            saveClient.Fax = EditFax.Text;
            saveClient.MobileNum = EditMobilePhone.Text;
            saveClient.Memo = EditNote.Text;
            try
            {
                inter.EditClient(saveClient);
                fillClient();
                deleteClient.Visible = false;
                cProfile.Visible = true;
                editProfile.Visible = false;
                saveChanges.Visible = false;
                editClient.Visible = true;
            }
            catch (Exception ex)
            {
                error.Text = ex.Message;
            }
            
           

        }

        protected void editZip_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClientFirsTimeFunction c = new ClientFirsTimeFunction();
                editstate.SelectedValue = c.findStateByZip(Convert.ToInt32(editZip.Text));
            }
            catch
            {
                error.Text = "Unavailable Zip Code";
            }
        }
    }
}