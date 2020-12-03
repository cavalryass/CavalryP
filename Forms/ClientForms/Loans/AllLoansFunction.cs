using Basic.Loan;
using ConnectToDB.LoansCommand;
using ConnectToDB.UsersCommand;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.ClientForms
{
    public class AllLoansFunction
    {
        public bool ClientHasLoan(string id)
        {
            ClientC inter = new ClientC();
            return inter.FindIfClientHasLoan(id);
        }
        public void LoansString(string uid,string step, iTextSharp.text.Document pdfDoc)
        {
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(@"https://app.synccos.com/assets/images/cavalry-signin.png");
            image.ScalePercent(24f);
            image.ScaleAbsolute(40f, 40f);
            image.SetAbsolutePosition(520, 780);
            Loans2C inter = new Loans2C();
            Loans1C inter1 = new Loans1C();
            Loans1 l1 = inter1.FindLoan1ByClient(uid);
            Loans2 l2 = inter.FindLoan2ByClient(uid);
            pdfDoc.Open();
            using (MemoryStream ms = new MemoryStream())
            {
                iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance(@"https://app.synccos.com/assets/images/cavalry-signin.png");
                image1.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                if (image1.Height > image1.Width)
                {
                    //Maximum height is 800 pixels.
                    float percentage = 0.0f;
                    percentage = 700 / image1.Height;
                    image1.ScalePercent(percentage * 100);
                }
                else
                {
                    //Maximum width is 600 pixels.
                    float percentage = 0.0f;
                    percentage = 540 / image1.Width;
                    image1.ScalePercent(percentage * 100);
                }
                image1.SetAbsolutePosition((PageSize.A4.Width - image1.ScaledWidth) / 2, (PageSize.A4.Height - image1.ScaledHeight) / 2);

                //image1.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                pdfDoc.Add(image1);
                pdfDoc.NewPage();

            }
            BigHeader("Loans Report", pdfDoc);
            Header("Step 1", pdfDoc);
            #region loan1           
            pdfDoc.Add(new Phrase("\r\n\r\n\r\n"));
            PdfPTable table = new PdfPTable(3);

            PdfPCell cell = new PdfPCell(new Phrase("Business Information"));
            cell.Colspan = 3;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Business Legal Name:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.BusinessName);
            cell = new PdfPCell(new Phrase("Business Legal Entity - DBA - If Applicable:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.DBAName);
            cell = new PdfPCell(new Phrase("Pirmary Contact:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.Pcontact);
            cell = new PdfPCell(new Phrase("Tax I.D:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.TaxID);
            cell = new PdfPCell(new Phrase("Telephone:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.Tel);
            cell = new PdfPCell(new Phrase("Email Addreess:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.Mail);
            cell = new PdfPCell(new Phrase("Street Address (no P.O Boxes):"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.Street);
            cell = new PdfPCell(new Phrase("City:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.City);
            cell = new PdfPCell(new Phrase("State:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.State);
            cell = new PdfPCell(new Phrase("Zip:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.Zip);
            if (l1.Own)
            {
                cell = new PdfPCell(new Phrase("Own"));
                cell.Colspan = 3;
                table.AddCell(cell);
            }
            else
            {
                cell = new PdfPCell(new Phrase("Rent"));
                cell.Colspan = 3;
                table.AddCell(cell);
            }
            if (l1.Mstreet != "")
            {
                cell = new PdfPCell(new Phrase("Send Mail"));
                cell.Colspan = 3;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase("Mailing Address:"));
                cell.Colspan = 2;
                table.AddCell(cell);
                table.AddCell(l1.Mstreet);
                cell = new PdfPCell(new Phrase("City:"));
                cell.Colspan = 2;
                table.AddCell(cell);
                table.AddCell(l1.Mcity);
                cell = new PdfPCell(new Phrase("State:"));
                cell.Colspan = 2;
                table.AddCell(cell);
                table.AddCell(l1.Mstate);
                cell = new PdfPCell(new Phrase("Zip:"));
                cell.Colspan = 2;
                table.AddCell(cell);
                table.AddCell(l1.Mzip);
                
            }
           
            cell = new PdfPCell(new Phrase(l1.Chose1));
            cell.Colspan = 3;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Date Business Established:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.DateBE);
            cell = new PdfPCell(new Phrase("State of Incorporatin:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.StateoOI);
            cell = new PdfPCell(new Phrase("Number of Employees After Financing:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.EmployeesNum);
            cell = new PdfPCell(new Phrase("Explain Nature of Business:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.Explains);
            cell = new PdfPCell(new Phrase(l1.Chose2));
            cell.Colspan = 3;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("List any Affiliated Companies:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l1.Acompanies);
            pdfDoc.Add(table);
            #endregion
            Header("Step 2",pdfDoc);
            #region step2            
            pdfDoc.Add(new Phrase("\r\n\r\n\r\n"));
            table = new PdfPTable(3);            
            cell = new PdfPCell(new Phrase("My Account Summary"));
            cell.Colspan = 3;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Open Credit Cards:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.OpenCC);
            cell = new PdfPCell(new Phrase("Open Retail Cards:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.OpenRC);
            cell = new PdfPCell(new Phrase("Open Real Estate Loans:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.OpenRELoans);
            cell = new PdfPCell(new Phrase("Open Installment Loans:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.OpenILoans);
            cell = new PdfPCell(new Phrase("Total Open Accounts:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.TotalOpenAcc);
            cell = new PdfPCell(new Phrase("Accounts Ever Late:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.AcceverLate);
            cell = new PdfPCell(new Phrase("Collections Accounts:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.CollectionAcc);
            cell = new PdfPCell(new Phrase("Average Account Age:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.AvgAccAge.Split('/')[0] + " yrs " + l2.AvgAccAge.Split('/')[1] + " mos ");
            cell = new PdfPCell(new Phrase("Oldest Account:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.OldestAcc.Split('/')[0] + " yrs " + l2.OldestAcc.Split('/')[1] + " mos ");
            pdfDoc.Add(table);
            pdfDoc.Add(new Phrase("\r\n\r\n\r\n"));
            table = new PdfPTable(3);
            cell = new PdfPCell(new Phrase("My Debt Summary"));
            cell.Colspan = 3;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Credit and Retail Card Debt:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell("$" + l2.CRDebt);
            cell = new PdfPCell(new Phrase("Real Estate Debt:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell("$" + l2.REDebt);
            cell = new PdfPCell(new Phrase("Installment Loans Debt:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell("$" + l2.ILDebt);
            cell = new PdfPCell(new Phrase("Collections Debt:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell("$" + l2.TotalOpenAcc);
            cell = new PdfPCell(new Phrase("Total Debt:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell("$" + l2.TDebt);
            pdfDoc.Add(table);

            #endregion
            
            #region CACC
            Header("Open Accounts", pdfDoc);
            for (int l = 0; l < l2.CAccList.Count; l++)// (var v in l2.CAccList)
            {
                var v = l2.CAccList[l];
                string trys = v.AccountStatus;
                if (trys == "Open")
                {
                    pdfDoc.Add(image);
                    pdfDoc.Add(new Phrase("\r\n\r\n\r\n\r\n"));
                    PdfPTable table1 = new PdfPTable(3);
                    cell = new PdfPCell(new Phrase("ACCOUNT DETAILS"));
                    cell.Colspan = 3;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                    table1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Account Name:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.AccountName);
                    cell = new PdfPCell(new Phrase("Account #:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.AccountNum);
                    cell = new PdfPCell(new Phrase("Original Creditor:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.OriginalCreditor);
                    cell = new PdfPCell(new Phrase("Company Sold:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.CompanySold);
                    cell = new PdfPCell(new Phrase("Account Type:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.AccountType);
                    cell = new PdfPCell(new Phrase("Date Opened:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.DateOpened);
                    cell = new PdfPCell(new Phrase("Account Status:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.AccountStatus);
                    cell = new PdfPCell(new Phrase("Payment Status:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.PaymentStatus);
                    cell = new PdfPCell(new Phrase("Status Updated:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.StatusUpdated);
                    cell = new PdfPCell(new Phrase("Balance:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell("$"+v.Balance);
                    cell = new PdfPCell(new Phrase("Balance Updated:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.BalanceUpdated);
                    cell = new PdfPCell(new Phrase("Credit Limit:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell("$" + v.CreditLimit);
                    cell = new PdfPCell(new Phrase("Monthly Payment:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell("$" + v.MonthlyPayment);
                    cell = new PdfPCell(new Phrase("Monthly Payment:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell("$" + v.MonthlyPayment);
                    cell = new PdfPCell(new Phrase("Highest Balance:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell("$" + v.HighestBalance);
                    cell = new PdfPCell(new Phrase("Terms:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.Terms);
                    cell = new PdfPCell(new Phrase("Responsibility:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.Responsibility);
                    cell = new PdfPCell(new Phrase("Your Statement:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.YourStatement);
                    cell = new PdfPCell(new Phrase("Comments:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.Comments);
                    pdfDoc.Add(table1);
                    pdfDoc.NewPage();
                   
                }
            }
            Header("Closed Accounts",pdfDoc);
            foreach (var v in l2.CAccList)
            {
                if (v.AccountStatus == "Close")
                {
                    pdfDoc.Add(image);
                    pdfDoc.Add(new Phrase("\r\n\r\n\r\n\r\n"));
                    table = new PdfPTable(3);
                    cell = new PdfPCell(new Phrase("ACCOUNT DETAILS"));
                    cell.Colspan = 3;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Account Name:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.AccountName);
                    cell = new PdfPCell(new Phrase("Account #:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.AccountNum);
                    cell = new PdfPCell(new Phrase("Original Creditor:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.OriginalCreditor);
                    cell = new PdfPCell(new Phrase("Company Sold:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.CompanySold);
                    cell = new PdfPCell(new Phrase("Account Type:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.AccountType);
                    cell = new PdfPCell(new Phrase("Date Opened:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.DateOpened);
                    cell = new PdfPCell(new Phrase("Account Status:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.AccountStatus);
                    cell = new PdfPCell(new Phrase("Payment Status:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.PaymentStatus);
                    cell = new PdfPCell(new Phrase("Status Updated:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.StatusUpdated);
                    cell = new PdfPCell(new Phrase("Balance:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell("$" + v.Balance);
                    cell = new PdfPCell(new Phrase("Balance Updated:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.BalanceUpdated);
                    cell = new PdfPCell(new Phrase("Credit Limit:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell("$" + v.CreditLimit);
                    cell = new PdfPCell(new Phrase("Monthly Payment:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell("$" + v.MonthlyPayment);
                    cell = new PdfPCell(new Phrase("Monthly Payment:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell("$" + v.MonthlyPayment);
                    cell = new PdfPCell(new Phrase("Highest Balance:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell("$" + v.HighestBalance);
                    cell = new PdfPCell(new Phrase("Terms:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.Terms);
                    cell = new PdfPCell(new Phrase("Responsibility:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.Responsibility);
                    cell = new PdfPCell(new Phrase("Your Statement:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.YourStatement);
                    cell = new PdfPCell(new Phrase("Comments:"));
                    cell.Colspan = 2;
                    table.AddCell(cell);
                    table.AddCell(v.Comments);
                    pdfDoc.Add(table);
                    pdfDoc.NewPage();
                }
            }
            Header("Collection Accounts",pdfDoc);
            foreach (var v in l2.CAccList)
            {
                if (v.AccountStatus == "Collection")
                {
                    pdfDoc.Add(image);
                    pdfDoc.Add(new Phrase("\r\n\r\n\r\n\r\n"));
                    PdfPTable table1 = new PdfPTable(3);
                    cell = new PdfPCell(new Phrase("ACCOUNT DETAILS"));
                    cell.Colspan = 3;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                    table1.AddCell(cell);
                    cell = new PdfPCell(new Phrase("Account Name:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.AccountName);
                    cell = new PdfPCell(new Phrase("Account #:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.AccountNum);
                    cell = new PdfPCell(new Phrase("Original Creditor:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.OriginalCreditor);
                    cell = new PdfPCell(new Phrase("Company Sold:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.CompanySold);
                    cell = new PdfPCell(new Phrase("Account Type:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.AccountType);
                    cell = new PdfPCell(new Phrase("Date Opened:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.DateOpened);
                    cell = new PdfPCell(new Phrase("Account Status:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.AccountStatus);
                    cell = new PdfPCell(new Phrase("Payment Status:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.PaymentStatus);
                    cell = new PdfPCell(new Phrase("Status Updated:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.StatusUpdated);
                    cell = new PdfPCell(new Phrase("Balance:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell("$" + v.Balance);
                    cell = new PdfPCell(new Phrase("Balance Updated:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.BalanceUpdated);
                    cell = new PdfPCell(new Phrase("Credit Limit:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell("$" + v.CreditLimit);
                    cell = new PdfPCell(new Phrase("Monthly Payment:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell("$" + v.MonthlyPayment);
                    cell = new PdfPCell(new Phrase("Monthly Payment:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell("$" + v.MonthlyPayment);
                    cell = new PdfPCell(new Phrase("Highest Balance:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell("$" + v.HighestBalance);
                    cell = new PdfPCell(new Phrase("Terms:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.Terms);
                    cell = new PdfPCell(new Phrase("Responsibility:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.Responsibility);
                    cell = new PdfPCell(new Phrase("Your Statement:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.YourStatement);
                    cell = new PdfPCell(new Phrase("Comments:"));
                    cell.Colspan = 2;
                    table1.AddCell(cell);
                    table1.AddCell(v.Comments);
                    pdfDoc.Add(table1);
                    pdfDoc.NewPage();
                }
            }
            #endregion
            #region Inquiries
            Header("Inquiries",pdfDoc);
            int i = 0;
            pdfDoc.Add(image);
            pdfDoc.Add(new Phrase("\r\n\r\n\r\n"));
            foreach (var v in l2.InqList)
            {
                table = new PdfPTable(3);
                
                cell = new PdfPCell(new Phrase("Inquiry Date:"));
                cell.Colspan = 2;
                table.AddCell(cell);
                table.AddCell(v.InquiryDate);
                cell = new PdfPCell(new Phrase("Removal Date:"));
                cell.Colspan = 2;
                table.AddCell(cell);
                table.AddCell(v.RemovalDate);
                cell = new PdfPCell(new Phrase("Business Type:"));
                cell.Colspan = 2;
                table.AddCell(cell);
                table.AddCell(v.BusinessType);
                cell = new PdfPCell(new Phrase("Contact Information:"));
                cell.Colspan = 2;
                table.AddCell(cell);
                table.AddCell(v.ContactInformation);
                pdfDoc.Add(table);
                pdfDoc.Add(new Phrase("\r\n\r\n\r\n"));
                i++;

                if (i != 0 && i % 3 == 0)
                {
                    pdfDoc.NewPage();
                    pdfDoc.Add(image);
                    pdfDoc.Add(new Phrase("\r\n\r\n\r\n\r\n"));
                }
            }
            #endregion
            #region public records
            Header("Public Records",pdfDoc);
            pdfDoc.Add(image);
            pdfDoc.Add(new Phrase("\r\n\r\n\r\n"));
            pdfDoc.Add(new Phrase(l2.PublicRecords));
            pdfDoc.NewPage();
            #endregion
            #region Credirt Score
            Header("Credit Score",pdfDoc);            
            pdfDoc.Add(new Phrase("\r\n\r\n"));
            table = new PdfPTable(3);
            cell = new PdfPCell(new Phrase("Experian:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.Experian);
            cell = new PdfPCell(new Phrase("Equifax:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.Equifax);
            cell = new PdfPCell(new Phrase("Trans Unio:"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(l2.TransUnio);
            pdfDoc.Add(table);

           
            #endregion
        }
        void BigHeader(string text, iTextSharp.text.Document pdfDoc)
        {
            //pdfDoc.SetMargins(50, 50, 50, 50);
            //    Paragraph para = new Paragraph("Hello world. Checking Header Footer", new Font(Font.FontFamily.HELVETICA, 22));
            //    para.Alignment = Element.ALIGN_CENTER;
            var t = new PdfPTable(1);

            //Tell it to fill the page horizontally
            t.WidthPercentage = 100;

            //Create a single cell
            var c = new PdfPCell();

            //Tell the cell to vertically align in the middle
            c.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;

            //Tell the cell to fill the page vertically
            c.MinimumHeight = pdfDoc.PageSize.Height - (pdfDoc.BottomMargin + pdfDoc.TopMargin);
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 80, iTextSharp.text.Font.NORMAL);


            //Create a test paragraph
            var p = new Paragraph(text, font);
            p.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            c.AddElement(p);

            //Add the cell to the paragraph
            t.AddCell(c);
            pdfDoc.Add(t);
            // para = new Paragraph("My name is avital\r\n Try something....");    
            //pdfDoc.Add(para);

        }
        void Header(string text, iTextSharp.text.Document pdfDoc)
        {
            pdfDoc.NewPage();
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(@"https://app.synccos.com/assets/images/cavalry-signin.png");
            image.ScalePercent(24f);
            image.ScaleAbsolute(40f, 40f);
            image.SetAbsolutePosition(520, 780);
            pdfDoc.Add(image);
            //pdfDoc.SetMargins(50, 50, 50, 50);
            //    Paragraph para = new Paragraph("Hello world. Checking Header Footer", new Font(Font.FontFamily.HELVETICA, 22));
            //    para.Alignment = Element.ALIGN_CENTER;
            var t = new PdfPTable(1);

            //Tell it to fill the page horizontally
            t.WidthPercentage = 100;

            //Create a single cell
            var c = new PdfPCell();
            c.BorderColor = BaseColor.WHITE;
            //Tell the cell to vertically align in the middle
            c.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;

            //Tell the cell to fill the page vertically
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 30, iTextSharp.text.Font.NORMAL);


            //Create a test paragraph
            var p = new Paragraph(text, font);
            p.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            c.AddElement(p);

            //Add the cell to the paragraph
            t.AddCell(c);
            t.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            pdfDoc.Add(t);

        }
         List<List<string>> filebyLine(PdfReader pdfReader)
        {
            int intPageNum = pdfReader.NumberOfPages;
            List<List<string>> l = new List<List<string>>();
            List<string> words = new List<string>();
            string line;

            for (int i = 1; i <= intPageNum; i++)
            {
                var text = PdfTextExtractor.GetTextFromPage(pdfReader, i, new LocationTextExtractionStrategy());
                List<string> myl = new List<string>();
                words = text.Split('\n').ToList<string>();
                for (int j = 0, len = words.Count(); j < len; j++)
                {
                    line = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(words[j]));
                    myl.Add(line);

                }
                l.Add(myl);
            }
            return l;
        }
        public void CreateLoanByFile(PdfReader pdfReader,string cid)
        {
            splitThePages(filebyLine(pdfReader),cid);
        }
        Loans2 fillStep1(Loans2 l, List<string> str)//fill the details of step 1: Account And Debt Summary
        {
            string replacer;
            foreach(var v in str)
            {
                if(v.Contains("Open Credit Cards"))
                {
                    replacer = v.Replace("Open Credit Cards", "");
                    l.OpenCC = replacer.Replace(" ", "");
                }
                else
                {
                    if (v.Contains("Open Retail Cards"))
                    {
                        replacer=v.Replace("Open Retail Cards", "");
                        l.OpenRC = replacer.Replace(" ", "");
                    }
                    else
                    {
                        if (v.Contains("Open Real Estate Loans"))
                        {
                            replacer=v.Replace("Open Real Estate Loans", "");
                            l.OpenRELoans = replacer.Replace(" ", "");
                        }
                        else
                        {
                            if (v.Contains("Open Installment Loans"))
                            {
                                replacer=v.Replace("Open Installment Loans", "");
                                l.OpenILoans = replacer.Replace(" ", "");
                            }
                            else
                            {
                                if (v.Contains("Total Open Accounts"))
                                {
                                    replacer=v.Replace("Total Open Accounts", "");
                                    l.TotalOpenAcc = replacer.Replace(" ", "");
                                }
                                else
                                {
                                    if (v.Contains("Accounts Ever Late"))
                                    {
                                        replacer=v.Replace("Accounts Ever Late", "");
                                        l.AcceverLate = replacer.Replace(" ", "");
                                    }
                                    else
                                    {
                                        if (v.Contains("Collections Accounts"))
                                        {
                                            replacer=v.Replace("Collections Accounts", "");
                                            l.CollectionAcc = replacer.Replace(" ", "");
                                        }
                                        else
                                        {
                                            if (v.Contains("Average Account Age"))
                                            {
                                                replacer=v.Replace("Average Account Age", "");
                                                replacer= replacer.Replace("mos", "");
                                                l.AvgAccAge = replacer.Replace("yrs", "/");
                                            }
                                            else
                                            {
                                                if (v.Contains("Oldest Account"))
                                                {
                                                    replacer=v.Replace("Oldest Account", "");
                                                    replacer= replacer.Replace("mos", "");
                                                    l.OldestAcc = replacer.Replace("yrs", "/");
                                                }
                                                else
                                                {
                                                    if (v.Contains("Credit and Retail Card Debt"))
                                                    {
                                                        replacer=v.Replace("Credit and Retail Card Debt", "");
                                                        replacer= replacer.Replace("$", "");
                                                        l.CRDebt = replacer.Replace(" ", "");
                                                    }
                                                    else
                                                    {
                                                        if (v.Contains("Real Estate Debt"))
                                                        {
                                                            replacer=v.Replace("Real Estate Debt", "");
                                                            replacer= replacer.Replace("$", "");
                                                            l.REDebt = replacer.Replace(" ", "");
                                                        }
                                                        else
                                                        {
                                                            if (v.Contains("Installment Loans Debt"))
                                                            {
                                                                replacer=v.Replace("Installment Loans Debt", "");
                                                                replacer= replacer.Replace("$", "");
                                                                l.ILDebt = replacer.Replace(" ", "");
                                                            }
                                                            else
                                                            {
                                                                if (v.Contains("Collections Debt"))
                                                                {
                                                                    replacer=v.Replace("Collections Debt", "");
                                                                    replacer= replacer.Replace("$", "");
                                                                    l.CollectionDebt = replacer.Replace(" ", "");
                                                                }
                                                                else
                                                                {
                                                                    if (v.Contains("Total Debt"))
                                                                    {
                                                                        replacer=v.Replace("Total Debt", "");
                                                                        replacer= replacer.Replace("$", "");
                                                                        l.TDebt = replacer.Replace(" ", "");
                                                                    }                                                                    
                                                                }
                                                            }
                                                        }
                                                    }
                                                    }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return l;
        }
        Loans2 fillStep2(Loans2 l, List<string>str)
        {
            string replacer;
            CAccount cacc = new CAccount();
            foreach(var v in str)
            {
                if (v.Contains("Account Name"))
                {
                    replacer=v.Replace("Account Name", "");
                    if (replacer[0] == ' ')
                        replacer.Remove(0, 1);
                    cacc.AccountName = replacer;
                }
                else
                {
                    if (v.Contains("Account #"))
                    {
                        replacer=v.Replace("Account #", "");
                        if (replacer[0] == ' ')
                            replacer.Remove(0, 1);
                        cacc.AccountNum = replacer;
                    }
                    else
                    {
                        if (v.Contains("Original Creditor"))
                        {
                            replacer=v.Replace("Original Creditor", "");
                            if (replacer[0] == ' ')
                                replacer.Remove(0, 1);
                            cacc.OriginalCreditor = replacer;
                        }
                        else
                        {
                            if (v.Contains("Company Sold"))
                            {
                                replacer=v.Replace("Company Sold", "");
                                if (replacer[0] == ' ')
                                    replacer.Remove(0, 1);
                                cacc.CompanySold = replacer;
                            }
                            else
                            {
                                if (v.Contains("Original Balance"))
                                {
                                    replacer = v.Replace("Original Balance", "");
                                    if (replacer[0] == ' ')
                                        replacer.Remove(0, 1);
                                    cacc.OriginalBalance = replacer.Replace("$","");
                                }
                                else
                                {
                                    if (v.Contains("Account Type"))
                                    {
                                        replacer = v.Replace("Account Type", "");
                                        if (replacer[0] == ' ')
                                            replacer.Remove(0, 1);
                                        cacc.AccountType = replacer;
                                    }
                                    else
                                    {
                                        if (v.Contains("Date Opened"))
                                        {
                                            replacer = v.Replace("Date Opened", "");
                                            if (replacer[0] == ' ')
                                                replacer = replacer.Remove(0, 1);
                                            replacer = replacer.Substring(0, 12);
                                            cacc.DateOpened = Convert.ToDateTime(replacer).ToShortDateString();
                                        }
                                        else
                                        {
                                            if (v.Contains("Account Status!"))
                                            {
                                                if (v.Contains("Open"))
                                                    cacc.AccountStatus = "Open";
                                                if (v.Contains("Collection"))
                                                    cacc.AccountStatus = "Collection";
                                                if (v.Contains("Close"))
                                                    cacc.AccountStatus = "Close";
                                            }
                                            else
                                            {
                                                if (v.Contains("Payment Status"))
                                                {
                                                    replacer = v.Replace("Payment Status", "");
                                                    if (replacer[0] == ' ')
                                                        replacer.Remove(0, 1);
                                                    cacc.PaymentStatus = replacer;
                                                }
                                                else
                                                {
                                                    if (v.Contains("Balance Updated"))
                                                    {
                                                        replacer = v.Replace("Balance Updated", "");
                                                        if (replacer[0] == ' ')
                                                            replacer = replacer.Remove(0, 1);
                                                        cacc.BalanceUpdated = Convert.ToDateTime(replacer).ToShortDateString();
                                                    }

                                                    else
                                                    {
                                                        if (v.Contains("Highest Balance"))
                                                        {
                                                            replacer = v.Replace("Highest Balance", "");
                                                            if (replacer[0] == ' ')
                                                                replacer = replacer = replacer.Remove(0, 1);
                                                            cacc.HighestBalance = replacer.Replace("$", "");
                                                        }


                                                        else
                                                        {
                                                            if (v.Contains("Status Updated"))
                                                            {
                                                                replacer = v.Replace("Status Updated", "");
                                                                if (replacer[0] == ' ')
                                                                    replacer.Remove(0, 1);
                                                                cacc.StatusUpdated = Convert.ToDateTime(replacer).ToShortDateString();
                                                            }
                                                            else
                                                            {
                                                                if (v.Contains("Credit Limit"))
                                                                {
                                                                    replacer = v.Replace("Credit Limit", "");
                                                                    if (replacer[0] == ' ')
                                                                        replacer = replacer.Remove(0, 1);
                                                                    cacc.CreditLimit = replacer.Replace("$", "");
                                                                }
                                                                else
                                                                {
                                                                    if (v.Contains("Monthly Payment"))
                                                                    {
                                                                        replacer = v.Replace("Monthly Payment", "");
                                                                        if (replacer[0] == ' ')
                                                                            replacer = replacer.Remove(0, 1);
                                                                        cacc.MonthlyPayment = replacer.Replace("$", "");
                                                                    }
                                                                    else
                                                                    {
                                                                        if (v.Contains("Past Due Amount"))
                                                                        {
                                                                            replacer = v.Replace("Past Due Amount", "");
                                                                            if (replacer[0] == ' ')
                                                                                replacer = replacer.Remove(0, 1);
                                                                            cacc.PastDueAmount = replacer;
                                                                        }
                                                                        else
                                                                        {
                                                                            if (v.Contains("Balance"))
                                                                            {
                                                                                replacer = v.Replace("Balance", "");
                                                                                if (replacer[0] == ' ')
                                                                                    replacer = replacer.Remove(0, 1);
                                                                                replacer = replacer.Replace("$", "");
                                                                                cacc.Balance = replacer;
                                                                            }
                                                                            else
                                                                            {
                                                                                if (v.Contains("Terms"))
                                                                                {
                                                                                    replacer = v.Replace("Terms", "");
                                                                                    if (replacer[0] == ' ')
                                                                                        replacer = replacer.Remove(0, 1);
                                                                                    cacc.Terms = replacer;
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (v.Contains("Responsibility"))
                                                                                    {
                                                                                        replacer = v.Replace("Responsibility", "");
                                                                                        if (replacer[0] == ' ')
                                                                                            replacer = replacer.Remove(0, 1);
                                                                                        cacc.Responsibility = replacer;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (v.Contains("Your Statement"))
                                                                                        {
                                                                                            replacer = v.Replace("Your Statement", "");
                                                                                            if (replacer[0] == ' ')
                                                                                                replacer = replacer.Remove(0, 1);
                                                                                            cacc.YourStatement = replacer;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (v.Contains("Comments"))
                                                                                            {
                                                                                                replacer = v.Replace("Comments", "");
                                                                                                if (replacer[0] == ' ')
                                                                                                    replacer = replacer.Remove(0, 1);
                                                                                                cacc.Comments = replacer;
                                                                                            }

                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if(cacc.AccountNum!="")
            l.CAccList.Add(cacc);
            return l;
        }
        Loans2 fillStep3(Loans2 l, List<string> str)
        {
            string replacer;
            string lastrow="";
            Inquiries inq1 = new Inquiries();
            Inquiries inq2 = new Inquiries();
            foreach (var v in str)
            {
                
                if (v.Contains("Inquiry Date"))
                {
                    inq1.NameOfBank = lastrow.Split(lastrow.ElementAt(0))[1].ToString();

                    if (lastrow.Split(lastrow.ElementAt(0)).Length > 2)
                    {
                       inq2.NameOfBank = lastrow.Split(lastrow.ElementAt(0))[2].ToString();

                    }
                    replacer =v.Replace("Inquiry Date ", "@");
                    inq1.InquiryDate = Convert.ToDateTime(replacer.Split('@')[1]).ToShortDateString();
                    if(replacer.Split('@').Length > 2)
                    inq2.InquiryDate = Convert.ToDateTime(replacer.Split('@')[2]).ToShortDateString();
                }
                else
                {
                    if (v.Contains("Removal Date"))
                    {
                        replacer = v.Replace("Removal Date ", "@");
                        inq1.RemovalDate = Convert.ToDateTime(replacer.Split('@')[1]).ToShortDateString();
                        if (replacer.Split('@').Length > 2)
                            inq2.RemovalDate = Convert.ToDateTime(replacer.Split('@')[2]).ToShortDateString();
                    }
                    else
                    {
                        if (v.Contains("Business Type "))
                        {
                            replacer = v.Replace("Business Type", "@");
                            inq1.BusinessType = replacer.Split('@')[1];
                            if (replacer.Split('@').Length > 2)
                                inq2.BusinessType = replacer.Split('@')[2];
                        }
                        else
                        {
                            if (v.Contains("Contact Information "))
                            {
                                replacer = v.Replace("Contact Information", "@");
                                inq1.ContactInformation = replacer.Split('@')[1];
                                if (replacer.Split('@').Length > 2)
                                    inq2.ContactInformation = replacer.Split('@')[2];
                                l.InqList.Add(inq1);
                                if (replacer.Split('@').Length>2)
                                    l.InqList.Add(inq2);
                                inq1 = new Inquiries();
                                inq2 = new Inquiries();
                            }
                        }
                    }
                }
                lastrow = v;
            }
            return l;
        }
        Loans2 fillStep4(Loans2 l, List<string> str)
        {
            l.PublicRecords = "";
            bool flag = false;
            foreach(var v in str)
            {
                if (v == "Public Records")
                    flag = true;
                if (flag && v != "Public Records")
                    l.PublicRecords += v;
            }
            return l;
        }
        void splitThePages(List<List<string>> myL,string cid)
        {
            bool s1 = false;
            bool s2 = false;
            bool s3 = false;
            bool s4 = false;
            bool br = false;
            Loans2 l = new Loans2();
            l.ClientId = cid;
            l.Source = true;
           
                foreach (var str in myL)
                {
                    if (str.Contains("Account Summary") && !s1)
                    {
                        s1 = true;
                        l = fillStep1(l, str);                        
                    }
                    if (str.Contains("Open Accounts"))
                    {
                        s2 = true;
                        s3 = false;
                        s4 = false;
                    }
                    if (str.Contains("Inquiries"))
                    {
                        s2 = false;
                        s3 = true;
                        s4 = false;
                    }
                    if (str.Contains("Public Records"))
                    {
                        s2 = false;
                        s3 = false;
                        s4 = true;
                    }
                    if (str.Contains("Credit Score"))
                    {
                        br = true;
                        break;
                    }
                    if(s2)
                    {
                        l=fillStep2(l, str);
                        
                    }
                    if (s3)
                    {
                        l=fillStep3(l, str);
                        
                    }
                    if (s4)
                    {
                        l=fillStep4(l, str);
                        
                    }
                }
                
            Loans2C loans2C = new Loans2C();
            loans2C.CreateLoan2(l);
        }

    }
}

