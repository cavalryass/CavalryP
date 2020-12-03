using Basic.Loan;
using Forms.ClientForms;
using Forms.ClientForms.Loans;
using Forms.Manager;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.ManagerFolder.Loan
{
    public partial class Loans2Employee : System.Web.UI.Page
    {
        Loans2Function loan = new Loans2Function();
        static string cid = "";
        static string status;
        static Loans2 l;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    cid = Session["Value"].ToString().Split('@')[0];
                    status = Session["Value"].ToString().Split('@')[1];

                }
                catch (Exception ex)
                {
                    Response.Redirect("~/GlobalForm/StartPage.aspx");
                }
                l = loan.FindLoan2ByClientId(cid);
                fill();
                visabaleStep("1", "","");
                if (status == "Client")
                {
                    downloadDoc.Visible = false;
                    Send.Visible = false;
                    Finish.Visible = false;
                    com1.Attributes.Add("readonly", "readonly");
                    com2.Attributes.Add("readonly", "readonly");
                    com3.Attributes.Add("readonly", "readonly");
                    com4.Attributes.Add("readonly", "readonly");
                    com5.Attributes.Add("readonly", "readonly");
                }
                else
                {
                    Submit.Visible = false;
                    if (l.Source)
                        downloadS.Visible = true;

                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            updateDetails();
            try
            {
                loan.Submit(l);
            }
            catch (Exception ex)
            {
                string id = "";
                if (ex.Message.Split('@').Length > 2)
                    id = ex.Message.Split('@')[2];
                visabaleStep(ex.Message.Split('@')[1], ex.Message.Split('@')[0],id);
            }
        }
        #region function
        void visabaleStep(string step, string error,string id)
        {
            if (step.Contains("1"))
            {
                step1.Visible = true;
                step2.Visible = false;
                step3.Visible = false;
                step4.Visible = false;
                step5.Visible = false;
                error1.Text = error;
            }
            if (step.Contains("2"))
            {
                step1.Visible = false;
                step2.Visible = true;
                step3.Visible = false;
                step4.Visible = false;
                step5.Visible = false;
                if (id != "")
                {
                    foreach (var v in l.CAccList)
                        if (v.Id == Convert.ToInt32(id))
                        {
                            AccNametxt.Value = v.AccountName;
                            AccNumtxt.Value = v.AccountNum;
                            OCreditortxt.Value = v.OriginalCreditor;
                            companyStxt.Value = v.CompanySold;
                            AccTypetxt.Value = v.AccountType;
                            DateOpentxt.Value = v.DateOpened;
                            AccStatustxt.SelectedValue = v.AccountStatus;
                            Pstatustxt.Value = v.PaymentStatus;
                            supdate.Value = v.StatusUpdated;
                            Balancetxt.Value = v.Balance;
                            BUpdate.Value = v.BalanceUpdated;
                            creditLimittxt.Value = v.CreditLimit;
                            MonthlyPaymenttxt.Value = v.MonthlyPayment;
                            PDAmounttxt.Value = v.PastDueAmount;
                            HBalancetxt.Value = v.HighestBalance;
                            Termstxt.Value = v.Terms;
                            Responsibilitytxt.Value = v.Responsibility;
                            Statmenttxt.Value = v.YourStatement;
                            Commentstxt.Value = v.Comments;
                            OBalancetxt.Value = v.OriginalBalance;

                            l.CAccList.Remove(v);
                            break;
                        }
                    AddAcc.Text = "Update";
                }
                error2.Text = error;
            }
            if (step.Contains("3"))
            {
                step1.Visible = false;
                step2.Visible = false;
                step3.Visible = true;
                step4.Visible = false;
                step5.Visible = false;
                if (id != "")
                {
                    foreach (var v in l.InqList)
                        if (v.Id == Convert.ToInt32(id))
                        {
                            Bnametxt.Value = v.NameOfBank;
                            InqDate.Value = v.InquiryDate;
                            REmDAtetxt.Value = v.RemovalDate;
                            Btype.Value = v.BusinessType;
                            CInformation.Value = v.ContactInformation;

                            l.InqList.Remove(v);
                            break;
                        }
                    popInqs();
                    AddInq.Text = "Update";
                }
                error3.Text = error;
            }
            if (step.Contains("4"))
            {
                step1.Visible = false;
                step2.Visible = false;
                step3.Visible = false;
                step4.Visible = true;
                step5.Visible = false;
            }
            if (step.Contains("5"))
            {
                step1.Visible = false;
                step2.Visible = false;
                step3.Visible = false;
                step4.Visible = false;
                step5.Visible = true;
                error4.Text = error;
            }
        }
        void fill()
        {
            openCCtxt.Value = l.OpenCC;
            openRCtxt.Value = l.OpenRC;
            openRELoanstxt.Value = l.OpenRELoans;
            openILoanstxt.Value = l.OpenILoans;
            TotalOpenAcctxt.Value = l.TotalOpenAcc;
            AccEverLatetxt.Value = l.AcceverLate;
            CollectionAcc.Value = l.CollectionAcc;
            AvgAccAgeM.Value = l.AvgAccAge.Split('/')[0];
            AvgAccAgeY.Value = l.AvgAccAge.Split('/')[1];
            OldestAccM.Value = l.OldestAcc.Split('/')[0];
            OldestAccY.Value = l.OldestAcc.Split('/')[1];
            CRDebt.Value = l.CRDebt;
            REDebt.Value = l.REDebt;
            ILDebt.Value = l.ILDebt;
            CollectionDebt.Value = l.CollectionDebt;
            TDebt.Value = l.TDebt;
            record.Value = l.PublicRecords;
            Experiantxt.Value = l.Experian;
            Equifaxtxt.Value = l.Equifax;
            TransUniotxt.Value = l.TransUnio;
            fico2.Value = l.Fico2;
            fico3.Value = l.Fico3;
            fico8.Value = l.Fico8;
            com1.Text = l.Comment.Split('@')[0];
            com2.Text = l.Comment.Split('@')[1];
            com3.Text = l.Comment.Split('@')[2];
            com4.Text = l.Comment.Split('@')[3];
            com5.Text = l.Comment.Split('@')[4];
            popAccs();
            popInqs();
            OpenCCE.Value = l.OpenCC;
            OpenRCE.Value = l.OpenRC;
            OpenRLE.Value = l.OpenRELoans;
            OpenILE.Value = l.OpenILoans;
            TotalOAE.Value = l.TotalOpenAcc;
            AccEverLateE.Value = l.AcceverLate;
            CollectionAccE.Value = l.CollectionAcc;
            AvgAccAgeME.Value = l.AvgAccAge.Split('/')[0];
            AvgAccAgeYE.Value = l.AvgAccAge.Split('/')[1];
            OldestAccME.Value = l.OldestAcc.Split('/')[0];
            OldestAccYE.Value = l.OldestAcc.Split('/')[1];
            CreditRCD.Value = l.CRDebt;
            RealEstateDE.Value = l.REDebt;
            InstallmentDebtE.Value = l.ILDebt;
            CollectionDebtE.Value = l.CollectionDebt;
            TotalDebtE.Value = l.TDebt;
            PublicRecordE.Value = l.PublicRecords;
            ExperianE.Value = l.Experian;
            EquifaxE.Value = l.Equifax;
            TransUnioE.Value = l.TransUnio;
            fico2E.Value = l.Fico2;
            fico3E.Value = l.Fico3;
            fico8E.Value = l.Fico8;
            popGV1();
            popGV2();

        }
        public void popAccs()
        {
            if (l.CAccList.Count == 0)
                CAccs.Visible = false;
            else
            {
                CAccs.Visible = true;
                CAccs.DataSource = l.CAccList;
                CAccs.DataBind();
            }
        }
        public void popInqs()
        {
            if (l.InqList.Count == 0)
                InqGV.Visible = false;
            else
            {
                InqGV.Visible = true;
                InqGV.DataSource = l.InqList;
                InqGV.DataBind();
            }
        }
        public void popGV1()
        {
            if (l.CAccList.Count == 0)
                GridView1.Visible = false;
            else
            {
                GridView1.Visible = true;
                GridView1.DataSource = l.CAccList;
                GridView1.DataBind();
            }
        }
        public void popGV2()
        {
            if (l.InqList.Count == 0)
                GridView2.Visible = false;
            else
            {
                GridView2.Visible = true;
                GridView2.DataSource = l.InqList;
                GridView2.DataBind();
            }
        }

        void updateDetails()
        {
            saveLocal();
            Loans2Function i = new Loans2Function();
            i.Save(l);
        }
        void saveLocal()
        {
            l.ClientId = cid;
            l.OpenCC = openCCtxt.Value;
            l.OpenRC = openRCtxt.Value;
            l.OpenRELoans = openRELoanstxt.Value;
            l.OpenILoans = openILoanstxt.Value;
            l.TotalOpenAcc = TotalOpenAcctxt.Value;
            l.AcceverLate = AccEverLatetxt.Value;
            l.CollectionAcc = CollectionAcc.Value;
            l.AvgAccAge = AvgAccAgeM.Value + "/" + AvgAccAgeY.Value;
            l.OldestAcc = OldestAccM.Value + "/" + OldestAccY.Value;
            l.CRDebt = CRDebt.Value;
            l.REDebt = REDebt.Value;
            l.ILDebt = ILDebt.Value;
            l.CollectionDebt = CollectionDebt.Value;
            l.TDebt = TDebt.Value;
            l.PublicRecords = record.Value;
            l.Experian = Experiantxt.Value;
            l.Equifax = Equifaxtxt.Value;
            l.TransUnio = TransUniotxt.Value;
            l.Fico2 = fico2.Value;
            l.Fico3 = fico3.Value;
            l.Fico8 = fico8.Value;
            l.Comment = com1.Text + "@" + com2.Text + "@" + com3.Text + "@" + com4.Text + "@" + com5.Text;
        }
        #endregion

        protected void AddAcc_Click(object sender, EventArgs e)
        {
            try
            {
                string su;
                if (supdate.Value == "")
                    su = supdateChange.Text;
                else
                    su = supdate.Value;
                string dop;
                if (DateOpentxt.Value == "")
                    dop = DateOpenChange.Text;
                else
                    dop = DateOpentxt.Value;
                string bu;
                if (BUpdate.Value == "")
                    bu = BUpdateChange.Text;
                else
                    bu = BUpdate.Value;
                CAccount c = new CAccount(AccNametxt.Value, AccNumtxt.Value, OCreditortxt.Value, companyStxt.Value, AccTypetxt.Value, dop, AccStatustxt.Text, Pstatustxt.Value, su, Balancetxt.Value, bu, creditLimittxt.Value, MonthlyPaymenttxt.Value, PDAmounttxt.Value, HBalancetxt.Value, OBalancetxt.Value, Termstxt.Value, Responsibilitytxt.Value, Statmenttxt.Value, Commentstxt.Value, "Open", "0");
                c.Id = loan.getIdDynamicCAcc(l.CAccList);
                loan.AddAccount(c);
                l.CAccList.Add(c);
                popAccs();
                AccNametxt.Value = "";
                OCreditortxt.Value = "";
                AccTypetxt.Value = "";
                supdate.Value = "";
                BUpdate.Value = "";
                MonthlyPaymenttxt.Value = "";
                HBalancetxt.Value = "";
                Responsibilitytxt.Value = "";
                AccNumtxt.Value = "";
                companyStxt.Value = "";
                DateOpentxt.Value = "";
                Pstatustxt.Value = "";
                Balancetxt.Value = "";
                creditLimittxt.Value = "";
                PDAmounttxt.Value = "";
                Termstxt.Value = "";
                Statmenttxt.Value = "";
                Commentstxt.Value = "";
                OBalancetxt.Value = "";
                AddAcc.Text = "Add";
                popAccs();
            }
            catch (Exception ex)
            {
                error2.Text = ex.Message.Split('@')[0];
            }
        }

        protected void AddInq_Click(object sender, EventArgs e)
        {
            try
            {
                string ind;
                if (InqDate.Value == "")
                    ind = InqDateChange.Text;
                else
                    ind = InqDate.Value;
                string rem;
                if (REmDAtetxt.Value == "")
                    rem = REmDAteChange.Text;
                else
                    rem = REmDAtetxt.Value;
                Inquiries inq = new Inquiries(Bnametxt.Value, ind, rem, Btype.Value, CInformation.Value, "0");
                inq.Id = loan.getIdDynamicInq(l.InqList);
                loan.AddInquiries(inq);
                l.InqList.Add(inq);
                popInqs();
            }
            catch (Exception ex)
            {
                error3.Text = ex.Message.Split('@')[0];
            }
            Bnametxt.Value = "";
            InqDate.Value = "";
            REmDAtetxt.Value = "";
            Btype.Value = "";
            CInformation.Value = "";
            AddInq.Text = "Add";
        }

        protected void Next1_Click(object sender, EventArgs e)
        {
            updateDetails();
            visabaleStep("2", "","");
        }

        protected void Next3_Click(object sender, EventArgs e)
        {
            updateDetails();
            visabaleStep("3", "","");
        }

        protected void next4_Click(object sender, EventArgs e)
        {
            updateDetails();
            visabaleStep("4", "", "");
        }

        protected void next5_Click(object sender, EventArgs e)
        {
            updateDetails();
            visabaleStep("5", "", "");
        }

        protected void previous4_Click(object sender, EventArgs e)
        {
            updateDetails();
            visabaleStep("4", "", "");
        }

        protected void previous3_Click(object sender, EventArgs e)
        {
            updateDetails();
            visabaleStep("3", "", "");
        }

        protected void previous2_Click(object sender, EventArgs e)
        {
            updateDetails();
            visabaleStep("2", "", "");
        }

        protected void previous_Click(object sender, EventArgs e)
        {
            updateDetails();
            visabaleStep("1", "", "");
        }

        protected void lastP_Click1(object sender, EventArgs e)
        {
            if (status == "Client")
            {
                Session["Value"] = cid;
                Response.Redirect("~/ClientP.aspx");
            }
            else
            {
                Session["Value"] = cid;
                Response.Redirect("~/ManagerFolder/ClientManagment.aspx");
            }
        }

        protected void BackSave_Click(object sender, EventArgs e)
        {
            try
            {
                loan.Save(l);
            }
            catch (Exception ex)
            {
                error1.Text = ex.Message;
            }
            if (status == "Client")
            {
                Session["Value"] = cid;
                Response.Redirect("~/ClientP.aspx");
            }
            else
            {
                //go to employee
            }
        }

        protected void Send_Click(object sender, EventArgs e)
        {

            try
            {
                saveLocal();
                loan.Send(l);
                Session["Value"] = status;
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('The Remarks Was Approved'); window.location = '" + Page.ResolveUrl("~/ManagerFolder/ClientManagment.aspx") + "';", true);

            }
            catch (Exception ex)
            {
                string id = "";
                if (ex.Message.Split('@').Length > 2)
                    id = ex.Message.Split('@')[2];
                visabaleStep(ex.Message.Split('@')[1], ex.Message.Split('@')[0],id);

            }
        }

        protected void Finish_Click(object sender, EventArgs e)
        {
            saveLocal();
            try
            {
                loan.Finish(l);
                Session["Value"] = status;
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('The Report Was Approved'); window.location = '" + Page.ResolveUrl("~/ManagerFolder/ClientManagment.aspx") + "';", true);

            }
            catch (Exception ex)
            {
                string id = "";
                if (ex.Message.Split('@').Length > 2)
                    id = ex.Message.Split('@')[2];
                visabaleStep(ex.Message.Split('@')[1], ex.Message.Split('@')[0],id);
            }
        }

        protected void change_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            AccNametxt.Value = ((Label)CAccs.Rows[id].FindControl("lAccountName")).Text;
            AccNumtxt.Value = ((Label)CAccs.Rows[id].FindControl("lAccountNum")).Text;
            OCreditortxt.Value = ((Label)CAccs.Rows[id].FindControl("lOriginalCreditor")).Text;
            companyStxt.Value = ((Label)CAccs.Rows[id].FindControl("lCompanySold")).Text;
            AccTypetxt.Value = ((Label)CAccs.Rows[id].FindControl("lAccountType")).Text;
            DateOpentxt.Visible = false;
            DateOpenChange.Visible = true;
            DateOpenChange.Text = ((Label)CAccs.Rows[id].FindControl("lDateOpened")).Text;
            AccStatustxt.SelectedValue = ((Label)CAccs.Rows[id].FindControl("lAccountStatus")).Text;
            Pstatustxt.Value = ((Label)CAccs.Rows[id].FindControl("lPaymentStatus")).Text;
            string myDate= Convert.ToDateTime(((Label)CAccs.Rows[id].FindControl("lStatusUpdated")).Text).ToShortDateString();
            supdateChange.Text = myDate;
            supdateChange.Visible = true;
            supdate.Visible = false;
            Balancetxt.Value = ((Label)CAccs.Rows[id].FindControl("lOriginalBalance")).Text;
            BUpdateChange.Visible = true;
            BUpdate.Visible = false;
            BUpdateChange.Text = ((Label)CAccs.Rows[id].FindControl("lBalanceUpdated")).Text;
            creditLimittxt.Value = ((Label)CAccs.Rows[id].FindControl("lCreditLimit")).Text;
            MonthlyPaymenttxt.Value = ((Label)CAccs.Rows[id].FindControl("MonthlyPayment")).Text;
            PDAmounttxt.Value = ((Label)CAccs.Rows[id].FindControl("lPastDueAmount")).Text;
            HBalancetxt.Value = ((Label)CAccs.Rows[id].FindControl("lHighestBalance")).Text;
            Termstxt.Value = ((Label)CAccs.Rows[id].FindControl("lTerms")).Text;
            Responsibilitytxt.Value = ((Label)CAccs.Rows[id].FindControl("lResponsibility")).Text;
            Statmenttxt.Value = ((Label)CAccs.Rows[id].FindControl("lYourStatement")).Text;
            Commentstxt.Value = ((Label)CAccs.Rows[id].FindControl("lComments")).Text;
            OBalancetxt.Value = ((Label)CAccs.Rows[id].FindControl("lOriginalBalance")).Text;
            foreach (var v in l.CAccList)
                if (v.Id == Convert.ToInt32(((Label)CAccs.Rows[id].FindControl("lId")).Text))
                {
                    l.CAccList.Remove(v);
                    break;
                }
            AddAcc.Text = "Update";
            CAccs.Visible = false;
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            foreach (var v in l.CAccList)
                if (v.Id == Convert.ToInt32(((Label)CAccs.Rows[id].FindControl("lId")).Text))
                {
                    l.CAccList.Remove(v);
                    break;
                }
            popAccs();
        }

        protected void Changeinq_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            Bnametxt.Value = ((Label)InqGV.Rows[id].FindControl("lNameOfBank")).Text;
            InqDate.Visible = false;
            InqDateChange.Visible = true;
            InqDateChange.Text = ((Label)InqGV.Rows[id].FindControl("lInquiryDate")).Text;
            REmDAtetxt.Visible = false ;
            REmDAteChange.Visible = true;
            REmDAteChange.Text = ((Label)InqGV.Rows[id].FindControl("lRemovalDate")).Text;
            Btype.Value = ((Label)InqGV.Rows[id].FindControl("lBusinessType")).Text;
            CInformation.Value = ((Label)InqGV.Rows[id].FindControl("lContactInformation")).Text;
            foreach (var v in l.InqList)
                if (v.Id == Convert.ToInt32(((Label)InqGV.Rows[id].FindControl("lId")).Text))
                {
                    l.InqList.Remove(v);
                    break;
                }
            AddInq.Text = "Update";
            InqGV.Visible = false;
        }

        protected void DeleteInq_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            foreach (var v in l.InqList)
                if (v.Id == Convert.ToInt32(((Label)InqGV.Rows[id].FindControl("lId")).Text))
                {
                    l.InqList.Remove(v);
                    break;
                }
            popInqs();
        }

        protected void downloadDoc_Click(object sender, EventArgs e)
        {
            try
            {
                AllLoansFunction a = new AllLoansFunction();

                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 25, 10, 25, 10);
                PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                a.LoansString(cid, "2", pdfDoc);

                pdfWriter.CloseStream = false;
                pdfDoc.Close();
                Response.Buffer = true;
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "attachment;filename=Loans Report.pdf");
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Write(pdfDoc);
                Response.End();
            }
            catch (Exception ex)
            { Response.Write(ex.Message); }
        }

        protected void downloadS_Click(object sender, EventArgs e)
        {
            ClientManagmentFunction c = new ClientManagmentFunction();
            Docs p = c.findSDoc(cid);
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

        protected void Edit_Click(object sender, EventArgs e)
        {
            editDiv.Visible = true;
            readDiv.Visible = false;
            Send.Visible = true;
            Edit.Visible = false;
        }

        protected void supdateChange_Click(object sender, EventArgs e)
        {
            supdate.Visible = true;
            supdateChange.Visible = false;
        }

        protected void DateOpenChange_Click(object sender, EventArgs e)
        {
            DateOpentxt.Visible = true;
            DateOpenChange.Visible = false;
        }

        protected void BUpdateChange_Click(object sender, EventArgs e)
        {
            BUpdate.Visible = true;
            BUpdateChange.Visible = false;
        }

        protected void InqDateChange_Click(object sender, EventArgs e)
        {
            InqDate.Visible = true;
            InqDateChange.Visible = false;
        }

        protected void REmDAteChange_Click(object sender, EventArgs e)
        {
            REmDAtetxt.Visible = true;
            REmDAteChange.Visible = false;
        }

        protected void CancelAcc_Click(object sender, EventArgs e)
        {
            AccNametxt.Value = "";
            AccNumtxt.Value = "";
            OCreditortxt.Value = "";
            companyStxt.Value = "";
            AccTypetxt.Value = "";
            DateOpentxt.Visible = true;
            DateOpenChange.Visible = false;
            Pstatustxt.Value = "";
            supdateChange.Visible = false;
            supdate.Visible = true;
            Balancetxt.Value = "";
            BUpdateChange.Visible = false;
            BUpdate.Visible = true;
            creditLimittxt.Value = "";
            MonthlyPaymenttxt.Value = "";
            PDAmounttxt.Value = "";
            HBalancetxt.Value = "";
            Termstxt.Value = "";
            Responsibilitytxt.Value = "";
            Statmenttxt.Value = "";
            Commentstxt.Value = "";
            OBalancetxt.Value = "";
            popAccs();
            AddAcc.Text = "Add";
            
        }

        protected void CancelInq_Click(object sender, EventArgs e)
        {
            Bnametxt.Value = "";
            InqDate.Visible = true;
            InqDateChange.Visible = false;
            REmDAtetxt.Visible = true;
            REmDAteChange.Visible = false;
            Btype.Value = "";
            CInformation.Value = "";
            popInqs();
            AddInq.Text = "Add";
        }
    }
}