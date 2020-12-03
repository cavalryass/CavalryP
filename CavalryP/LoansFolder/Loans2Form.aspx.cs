using Basic.Loan;
using Forms.ClientForms;
using Forms.ClientForms.Loans;
using Forms.Manager;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.LoansFolder
{
    public partial class Loans2Form : System.Web.UI.Page
    {
        Loans2Function loan = new Loans2Function();
        static string cid = "";
        static string status;
       static Loans2 l;
        static Loans2 l2;
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
                visabaleStep("1", "");
            }
        }   
      
        protected void Submit_Click(object sender, EventArgs e)
        {
                saveLocal();
                Loans2Function i = new Loans2Function();
                i.Save(l);
            
            try
            {
                loan.Submit(l);
            }
            catch(Exception ex)
            {
                visabaleStep(ex.Message.Split('@')[1],ex.Message.Split('@')[0]);
            }
        }
        #region function
        void visabaleStep(string step,string error)
        {
            if(step.Contains("1"))
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
                popAccs();
                error2.Text = error;
            }
            if (step.Contains("3"))
            {
                step1.Visible = false;
                step2.Visible = false;
                step3.Visible = true;
                step4.Visible = false;
                step5.Visible = false;
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
            openCC.Text = l.OpenCC;
            openRC.Text = l.OpenRC;
            openRELoans.Text = l.OpenRELoans;
            openILoans.Text = l.OpenILoans;
            TotalOpenAcc.Text = l.TotalOpenAcc;
            AccEverLate.Text = l.AcceverLate;
            CollectionAcc.Text = l.CollectionAcc;
            AvgAccAgeM.Text = l.AvgAccAge.Split('/')[0];
            AvgAccAgeY.Text = l.AvgAccAge.Split('/')[1];
            OldestAccM.Text = l.OldestAcc.Split('/')[0];
            OldestAccY.Text = l.OldestAcc.Split('/')[1];
            CRDebt.Text = l.CRDebt;
            REDebt.Text = l.REDebt;
            ILDebt.Text = l.ILDebt;
            CollectionDebt.Text = l.CollectionDebt;
            TDebt.Text = l.TDebt;
            record.Text = l.PublicRecords;
            Experiantxt.Text = l.Experian;
            Equifaxtxt.Text = l.Equifax;
            TransUniotxt.Text = l.TransUnio;
            fico2.Text = l.Fico2;
            fico3.Text = l.Fico3;
            fico8.Text = l.Fico8;
            com1.Text = l.Comment.Split('@')[0];
            com2.Text = l.Comment.Split('@')[1];
            com3.Text = l.Comment.Split('@')[2];
            com4.Text = l.Comment.Split('@')[3];
            com5.Text = l.Comment.Split('@')[4];
            popAccs();
            popInqs();

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

       
        void saveLocal()
        {
            l.ClientId = cid;
            l.OpenCC = openCC.Text;
            l.OpenRC = openRC.Text;
            l.OpenRELoans = openRELoans.Text;
            l.OpenILoans = openILoans.Text;
            l.TotalOpenAcc = TotalOpenAcc.Text;
            l.AcceverLate = AccEverLate.Text;
            l.CollectionAcc = CollectionAcc.Text;
            l.AvgAccAge = AvgAccAgeM.Text + "/" + AvgAccAgeY.Text;
            l.OldestAcc = OldestAccM.Text + "/" + OldestAccY.Text;
            l.CRDebt = CRDebt.Text;
            l.REDebt = REDebt.Text;
            l.ILDebt = ILDebt.Text;
            l.CollectionDebt = CollectionDebt.Text;
            l.TDebt = TDebt.Text;
            l.PublicRecords = record.Text;
            l.Experian = Experiantxt.Text;
            l.Equifax = Equifaxtxt.Text;
            l.TransUnio = TransUniotxt.Text;
            l.Fico2 = fico2.Text;
            l.Fico3 = fico3.Text;
            l.Fico8 = fico8.Text;
            l.Comment = com1.Text + "@" + com2.Text + "@" + com3.Text + "@" + com4.Text + "@" + com5.Text;
        }
        #endregion

        protected void AddAcc_Click(object sender, EventArgs e)
        {
            try
            {
                CAccount c = new CAccount(AccNametxt.Text, AccNumtxt.Text, OCreditortxt.Text, companyStxt.Text, AccTypetxt.Text, DateOpentxt.Value, AccStatustxt.Text, Pstatustxt.Text, supdatetxt.Value, Balancetxt.Text, BUpdate.Value, creditLimittxt.Text, MonthlyPaymenttxt.Text, PDAmounttxt.Text, HBalancetxt.Text, OBalancetxt.Text, Termstxt.Text, Responsibilitytxt.Text, Statmenttxt.Text, Commentstxt.Text, "Open", "0");
                loan.AddAccount(c);
                l.CAccList.Add(c);
                popAccs();
                AccNametxt.Text = "";
                OCreditortxt.Text = "";
                AccTypetxt.Text = "";
                supdatetxt.Value = "";
                BUpdate.Value = "";
                MonthlyPaymenttxt.Text = "";
                HBalancetxt.Text = "";
                Responsibilitytxt.Text = "";
                AccNumtxt.Text = "";
                companyStxt.Text = "";
                DateOpentxt.Value = "";
                Pstatustxt.Text = "";
                Balancetxt.Text = "";
                creditLimittxt.Text = "";
                PDAmounttxt.Text = "";
                Termstxt.Text = "";
                Statmenttxt.Text = "";
                Commentstxt.Text = "";
                OBalancetxt.Text = "";
                AddAcc.Text = "Add";
            }
            catch(Exception ex)
            {
                error2.Text = ex.Message.Split('@')[0];
            }
        }

        protected void AddInq_Click(object sender, EventArgs e)
        {
            try
            {
                Inquiries inq = new Inquiries(Bnametxt.Text, InqDate.Value, REmDAtetxt.Value, Btype.Text, CInformation.Text, "0");
                    loan.AddInquiries(inq);
                l.InqList.Add(inq);
                popInqs();
            }
            catch (Exception ex)
            {
                error3.Text = ex.Message.Split('@')[0];
            }
            Bnametxt.Text = "";
            InqDate.Value = "";
            REmDAtetxt.Value = "";
            Btype.Text = "";
            CInformation.Text = "";
            AddInq.Text = "Add";
        }

        protected void Next1_Click(object sender, EventArgs e)
        {
            visabaleStep("2","");
        }

        protected void Next3_Click(object sender, EventArgs e)
        {
            visabaleStep("3","");
        }

        protected void next4_Click(object sender, EventArgs e)
        {
            visabaleStep("4","");
        }

        protected void next5_Click(object sender, EventArgs e)
        {
            visabaleStep("5", "");
        }

        protected void previous4_Click(object sender, EventArgs e)
        {
            visabaleStep("4", "");
        }

        protected void previous3_Click(object sender, EventArgs e)
        {
           visabaleStep("3", "");
        }

        protected void previous2_Click(object sender, EventArgs e)
        {
           visabaleStep("2", "");
        }

        protected void previous_Click(object sender, EventArgs e)
        {
            visabaleStep("1", "");
        }

        protected void lastP_Click1(object sender, EventArgs e)
        {
           
            Session["Value"] = cid;
                Response.Redirect("~/ClientP.aspx");
           
        }
        bool ReturnValue()
        {
            return false;
        }
        protected void BackSave_Click(object sender, EventArgs e)
        {
            try
            {
                loan.Save(l);
                BackS.Visible = true;
                lastP.Visible = false;
            }
            catch(Exception ex)
            {
                error1.Text = ex.Message;
            }
           
        }

        protected void Send_Click(object sender, EventArgs e)
        {
            
            try
            {
                saveLocal();
                loan.Send(l);
            }
            catch (Exception  ex)
            {
                visabaleStep(ex.Message.Split('@')[1], ex.Message.Split('@')[0]);

            }
        }

        protected void Finish_Click(object sender, EventArgs e)
        {
            saveLocal();
            try
            {
                loan.Finish(l);
            }
            catch (Exception ex)
            {
                visabaleStep(ex.Message.Split('@')[1], ex.Message.Split('@')[0]);
            }
        }

        protected void change_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            AccNametxt.Text = ((Label)CAccs.Rows[id].FindControl("lAccountName")).Text;
            AccNumtxt.Text = ((Label)CAccs.Rows[id].FindControl("lAccountNum")).Text;
            OCreditortxt.Text = ((Label)CAccs.Rows[id].FindControl("lOriginalCreditor")).Text;
            companyStxt.Text = ((Label)CAccs.Rows[id].FindControl("lCompanySold")).Text;
            AccTypetxt.Text = ((Label)CAccs.Rows[id].FindControl("lAccountType")).Text;
            DateOpentxt.Value = ((Label)CAccs.Rows[id].FindControl("lDateOpened")).Text;
            AccStatustxt.SelectedValue = ((Label)CAccs.Rows[id].FindControl("lAccountStatus")).Text;
            Pstatustxt.Text = ((Label)CAccs.Rows[id].FindControl("lPaymentStatus")).Text;
            supdatetxt.Value = ((Label)CAccs.Rows[id].FindControl("lStatusUpdated")).Text;
            Balancetxt.Text = ((Label)CAccs.Rows[id].FindControl("lBalance")).Text;
            BUpdate.Value = ((Label)CAccs.Rows[id].FindControl("lBalanceUpdated")).Text;
            creditLimittxt.Text = ((Label)CAccs.Rows[id].FindControl("lCreditLimit")).Text;
            MonthlyPaymenttxt.Text = ((Label)CAccs.Rows[id].FindControl("MonthlyPayment")).Text;
            PDAmounttxt.Text = ((Label)CAccs.Rows[id].FindControl("lPastDueAmount")).Text;
            HBalancetxt.Text = ((Label)CAccs.Rows[id].FindControl("lHighestBalance")).Text;
            Termstxt.Text = ((Label)CAccs.Rows[id].FindControl("lTerms")).Text;
            Responsibilitytxt.Text = ((Label)CAccs.Rows[id].FindControl("lResponsibility")).Text;
            Statmenttxt.Text = ((Label)CAccs.Rows[id].FindControl("lYourStatement")).Text;
            Commentstxt.Text = ((Label)CAccs.Rows[id].FindControl("lComments")).Text;
           OBalancetxt.Text = ((Label)CAccs.Rows[id].FindControl("lOriginalBalance")).Text;
            foreach (var v in l.CAccList)
                if (v.Id == Convert.ToInt32(((Label)CAccs.Rows[id].FindControl("lId")).Text))
                {
                    l.CAccList.Remove(v);
                    break;
                }
            AddAcc.Text = "Update";
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
            Bnametxt.Text = ((Label)InqGV.Rows[id].FindControl("lNameOfBank")).Text;
            InqDate.Value = ((Label)InqGV.Rows[id].FindControl("lInquiryDate")).Text;
            REmDAtetxt.Value = ((Label)InqGV.Rows[id].FindControl("lRemovalDate")).Text;
            Btype.Text = ((Label)InqGV.Rows[id].FindControl("lBusinessType")).Text;
            CInformation.Text = ((Label)InqGV.Rows[id].FindControl("lContactInformation")).Text;
            foreach (var v in l.InqList)
                if (v.Id == Convert.ToInt32(((Label)InqGV.Rows[id].FindControl("lId")).Text))
                {
                    l.InqList.Remove(v);
                    break;
                }
            AddInq.Text = "Update";
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

        protected void openCCtxt_TextChanged(object sender, EventArgs e)
        {
            lastP.Visible = true;
            BackS.Visible = false;
        }

        protected void AccStatustxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastP.Visible = true;
            BackS.Visible = false;
        }
    }
}