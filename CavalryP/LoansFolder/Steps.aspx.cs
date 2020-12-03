using Forms.ClientForms;
using Forms.ClientForms.Loans;
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

namespace CavalryP
{
    public partial class Steps : System.Web.UI.Page
    {
      static string uid = "";
        static string mp = "";
        protected void Page_Load(object sender, EventArgs e)
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
            ShowButton(c.FindClient(uid).MiddleProcess);
            showC();
            
        }
        void showC()
        {
            UploadDocdfunction inter = new UploadDocdfunction();
            if(inter.reqDocsDD(uid).Count>0)
            {
                alerC.Visible = true;
            }
            else
            {
                alerC.Visible = false;
            }
        }
        public void ShowButton(string middleProcess)
        {
            mp = middleProcess;
            if (middleProcess.Contains("1"))
            {
                Step1.Visible = true;
                Step2.Visible = false;
                Step3.Visible = false;
                Step4.Visible = false;
                Step5.Visible = false;
            }
            if (middleProcess.Contains("2")||middleProcess=="1app")
            {
                Step1.Visible = true;
                Step2.Visible = true;
                Step3.Visible = false;
                Step4.Visible = false;
                Step5.Visible = false;
            }
            if (middleProcess.Contains("3")|| middleProcess == "2app")
            {
                Step1.Visible = true;
                Step2.Visible = true;
                Step3.Visible = true;
                Step4.Visible = false;
                Step5.Visible = false;
            }
            if (middleProcess.Contains("4")|| middleProcess == "3app")
            {
                Step1.Visible = true;
                Step2.Visible = true;
                Step3.Visible = true;
                Step4.Visible = true;
                Step5.Visible = false;
            }
            if (middleProcess.Contains("5")|| middleProcess == "4app")
            {
                Step1.Visible = true;
                Step2.Visible = true;
                Step3.Visible = true;
                Step4.Visible = true;
                Step5.Visible = true;
            }
            if (middleProcess.Contains("app"))
            {
                Waiting.Visible = true;
            }
        }
        protected void Setting_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid;
            Response.Redirect("~/ClientFolder/ClientP.aspx");            
        }

        protected void Step1_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid+"@Client";
            Response.Redirect("~/LoansFolder/Loans1Form.aspx");
        }

        protected void Step2_Click(object sender, EventArgs e)
        {
            if (mp=="1app")
            {
                WantUpload.Visible = true;
            }
            else
            {
                if (mp == "2napp")
                {
                    Session["Value"] = uid + "@Client";
                    Response.Redirect("~/LoansFolder/Loans2Form.aspx");
                }
                else
                {
                    try
                    {
                        AllLoansFunction a = new AllLoansFunction();

                        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 25, 10, 25, 10);

                        PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                        a.LoansString(uid, "2", pdfDoc);

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
            }
        }

        protected void logOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GlobalForm/StartPage.aspx");
        }

        protected void Docs_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid;
            Response.Redirect("~/LoansFolder/UploadDocs.aspx");
           
        }

        protected void uploadF_Click(object sender, EventArgs e)
        {
            //read and create loan
            if (File.Exists(Server.MapPath(" ") + FileUpload1.FileName) == true && (FileUpload1.FileName != string.Empty))
            {

                File.Delete(Server.MapPath(" ") + FileUpload1.FileName);

            }
            FileUpload1.SaveAs(Server.MapPath(" ") + FileUpload1.FileName);
            string fileName = Server.HtmlEncode(FileUpload1.FileName);
            // Get the extension of the uploaded file.
            string extension = System.IO.Path.GetExtension(fileName);
            // Allow only files with .doc or .xls extensions
            // to be uploaded.
            if (extension == ".pdf")
            {
                List<string> l = new List<string>();

                StringBuilder text = new StringBuilder();

                if (File.Exists(Server.MapPath(" ") + FileUpload1.FileName))
                {
                    PdfReader pdfReader = new PdfReader(Server.MapPath(" ") + FileUpload1.FileName);
                    AllLoansFunction a = new AllLoansFunction();
                    a.CreateLoanByFile(pdfReader, uid);

                    pdfReader.Close();
                }
                File.Delete(Server.MapPath(" ") + FileUpload1.FileName);

            }
            //save the upload file in the system for our employees
          
            
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string contentType = FileUpload1.PostedFile.ContentType;
            try
            {
                UploadDocdfunction inter = new UploadDocdfunction();
           
            inter.createDoc(uid, filename, contentType, "Source Loan 2", FileUpload1);
                Loans2Function loan2 = new Loans2Function();
                loan2.uploadAndCreate(uid);
                Waiting.Visible = true;
            }
            catch (Exception ex)
            {
                Error.Text = "Sorry Our System Work Only With Experian Document. You Can Fill In The Information Yourself";
            }
            Response.Redirect(Request.Url.AbsoluteUri);
            
            
        }

        protected void No_Click(object sender, EventArgs e)
        {
            Session["Value"] = uid + "@Client";
            Response.Redirect("~/LoansFolder/Loans2Form.aspx");
        }

        protected void Yes_Click(object sender, EventArgs e)
        {
            WantUpload.Visible = false;
            uploadS.Visible = true;
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            WantUpload.Visible = true;
            uploadS.Visible = false;
        }
    }
}