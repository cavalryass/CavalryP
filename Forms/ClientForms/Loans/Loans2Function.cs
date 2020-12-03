using Basic.Loan;
using Basic.SoftwareUsers;
using ConnectToDB.LoansCommand;
using ConnectToDB.UsersCommand;
using Forms.GlobalClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.ClientForms.Loans
{
    public class Loans2Function
    {
        public Loans2 pageLoad(string clienId)
        {
            Loans2 loans2 = FindLoan2ByClientId(clienId);
            return loans2;

        }
       public void deleteCAcc(int id)
        {
            CAccountC c = new CAccountC();
            c.RemoveCAcc(id);
        }
       
        public Loans2 FindLoan2ByClientId(string clientId)
        {
            Loans2C inter = new Loans2C();
            return inter.FindLoan2ByClient(clientId);
        }
        public void Save(Loans2 l)//only save not change your status 
        {
            Loans2C loans2C = new Loans2C();
            if (loans2C.checkIfExist(l.ClientId))
                loans2C.UpdateLoan2(l);
            else
                loans2C.CreateLoan2(l);
        }
        public int getIdDynamicCAcc(List<CAccount> l)
        {
            int id = 0;
            foreach (var v in l)
                if (id < v.Id)
                    id = v.Id;
            id++;
            return id;
        }
        public int getIdDynamicInq(List<Inquiries> l)
        {
            int id = 0;
            foreach (var v in l)
                if (id < v.Id)
                    id = v.Id;
            id++;
            return id;
        }
        public void AddAccount(CAccount acc)
        {
            if (acc.AccountName == "")
                throw new Exception("The Account Name Field Is empty@2@"+acc.Id);
            if (acc.AccountNum == "")
                throw new Exception("The Account Number Field Is empty@2@" + acc.Id);
            if (acc.OriginalCreditor == "")
                throw new Exception("The Orginal Creditor Field Is empty@2@" + acc.Id);
            if (acc.CompanySold == "")
                throw new Exception("The Company Sold Field Is empty@2@" + acc.Id);
            if (acc.AccountType == "")
                throw new Exception("The Account Type Field Is empty@2@" + acc.Id);
            if (acc.DateOpened == "")
                throw new Exception("The Date Opened Field Is empty@2@" + acc.Id);
            if (acc.PaymentStatus == "")
                throw new Exception("The Payment Status Field Is empty@2@" + acc.Id);
            if (acc.StatusUpdated == "")
                throw new Exception("The Status Updated Field Is empty@2@" + acc.Id);
            if (acc.BalanceUpdated == "")
                throw new Exception("The Balance Field Is empty@2@" + acc.Id);
            if (acc.AccountName == "")
                throw new Exception("The Balance Updated Field Is empty@2@" + acc.Id);
            if (acc.MonthlyPayment == "")
                throw new Exception("The Monthly Payment Field Is empty@2@" + acc.Id);
            if (acc.PastDueAmount == "")
                throw new Exception("The Past Due Amount Field Is empty@2@" + acc.Id);
            if (acc.HighestBalance == "")
                throw new Exception("The Highest Balance Field Is empty@2@" + acc.Id);
            if (acc.Terms == "")
                throw new Exception("The Terms Field Is empty@2@" + acc.Id);
            if (acc.Responsibility == "")
                throw new Exception("The Responsibility Field Is empty@2@" + acc.Id);
            if (acc.YourStatement == "")
                throw new Exception("The Your Statment Field Is empty@2@" + acc.Id);
            



        }
        public void AddInquiries(Inquiries inq)
        {
            if (inq.NameOfBank == "")
                throw new Exception("The Bank Name Field Is empty@3@"+inq.Id);
            if (inq.InquiryDate == "")
                throw new Exception("The Inquiry Date Field Is empty@3@" + inq.Id);
            if (inq.RemovalDate == "")
                throw new Exception("The Removal Date Field Is empty@3@" + inq.Id);
            if (inq.BusinessType == "")
                throw new Exception("The Business Type Field Is empty@3@" + inq.Id);
            if (inq.ContactInformation == "")
                throw new Exception("The Contact Information Field Is empty@3@" + inq.Id);
            
        }
        public void uploadAndCreate(string cid)
        {
            ClientC c = new ClientC();
            Client client = c.FindClient(cid);
            client.MiddleProcess = "2";            
            c.UpdateClient(client);
            SendEmailC send = new SendEmailC();
            Client c1 = c.FindClient(cid);
            UserC u = new UserC();
            string message = "Client: " + c1.Mail + " " + c1.MobileNum + " " + c1.Fname + " " + c1.Lname + "Send he reports";
            send.SendEmailF(u.FindNeedEmail("Manager", cid), "Report Of " + c1.Fname + " " + c1.Lname, message);

        }
        public void Submit(Loans2 l)//save (update) and change the status and let the  employee knows
        {
            try
            {
                if (Convert.ToInt32(l.OpenCC) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Open Credit Cards@1");
            }
            try
            {
                if (Convert.ToInt32(l.OpenRC) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Open Retail Cards@1");
            }
            try
            {
                if (Convert.ToInt32(l.OpenRELoans) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Open Real Estate Loans@1");
            }
            try
            {
                if (Convert.ToInt32(l.OpenILoans) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Open Installment Loans@1");
            }
            try
            {
                if (Convert.ToInt32(l.TotalOpenAcc) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Total Open Account@1");
            }
            try
            {
                if (Convert.ToInt32(l.AcceverLate) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Account Ever Late@1");
            }
            try
            {
                if (Convert.ToInt32(l.CollectionAcc) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Collection Account@1");
            }
            try
            {
                if (Convert.ToInt32(l.AvgAccAge.Split('/')[0]) < 1|| Convert.ToInt32(l.AvgAccAge.Split('/')[0])>12)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Month Of Average Account Age @1");
            }
            try
            {
                if (Convert.ToInt32(l.AvgAccAge.Split('/')[1]) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Year Of Average Account Age @1");
            }
            try
            {
                if (Convert.ToInt32(l.OldestAcc.Split('/')[0]) < 1 || Convert.ToInt32(l.AvgAccAge.Split('/')[0]) > 12)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Month Of Oldest Account @1");
            }
            try
            {
                if (Convert.ToInt32(l.OldestAcc.Split('/')[1]) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Year Of Oldest Account @1");
            }
            try
            {
                if (Convert.ToInt32(l.CRDebt.Replace(",","")) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Credit And Retail Card Debt@1");
            }
            try
            {
                if (Convert.ToInt32(l.REDebt.Replace(",", "")) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Real Estate Debt@1");
            }
            try
            {
                if (Convert.ToInt32(l.ILDebt.Replace(",", "")) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Installment Loans Debt@1");
            }
            try
            {
                if (Convert.ToInt32(l.CollectionDebt.Replace(",", "")) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Collections Debt@1");
            }
            try
            {
                if (Convert.ToInt32(l.TDebt.Replace(",", "")) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Total Debt@1");
            }
            foreach (var v in l.CAccList)
                AddAccount(v);
            foreach (var v in l.InqList)
                AddInquiries(v);
            try
            {
                if(Convert.ToInt32(l.Experian) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Experian @5");
            }
            try
            {
                if (Convert.ToInt32(l.Equifax) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Equifax@5");
            }
            try
            {
                if (Convert.ToInt32(l.TransUnio) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Trans Unio @5");
            }
            Loans2C loans2C = new Loans2C();
            string message = "";
            ClientC c = new ClientC();
            Client c1 = c.FindClient(l.ClientId);
            if (loans2C.checkIfExist(l.ClientId))
            {
                loans2C.UpdateLoan2(l);
                message = c1.Fname + " " + c1.Lname + " " + c1.Mail + " " + c1.MobileNum + " " + "Change the report";
            }
            else
            {
                loans2C.CreateLoan2(l);
                message = c1.Fname + " " + c1.Lname + " " + c1.Mail + " " + c1.MobileNum + " " + "Send report";
            }
            c1.MiddleProcess = "2";
            c.UpdateClient(c1);
            SendEmailC send = new SendEmailC();
            UserC u = new UserC();
            send.SendEmailF(u.FindNeedEmail("Manager", l.ClientId), "Report Of " + c1.Fname + " " + c1.Lname, message);


        }
        public void Send(Loans2 l)
        {
            //try
            //{
            //    if (Convert.ToInt32(l.OpenCC.Replace(",", "")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Open Credit Cards@1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.OpenRC.Replace(",", "")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Open Retail Cards@1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.OpenRELoans.Replace(",", "")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Open Real Estate Loans@1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.OpenILoans.Replace(",", "")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Open Installment Loans@1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.TotalOpenAcc.Replace(",", "")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Total Open Account@1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.AcceverLate.Replace(",", "")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Account Ever Late@1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.CollectionAcc.Replace(",", "")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Collection Account@1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.AvgAccAge.Split('/')[0]) < 1 || Convert.ToInt32(l.AvgAccAge.Split('/')[0]) > 12)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Month Of Average Account Age @1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.AvgAccAge.Split('/')[1]) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Year Of Average Account Age @1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.OldestAcc.Split('/')[0]) < 1 || Convert.ToInt32(l.AvgAccAge.Split('/')[0]) > 12)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Month Of Oldest Account @1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.OldestAcc.Split('/')[1]) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Year Of Oldest Account @1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.CRDebt.Replace(",","")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Credit And Retail Card Debt@1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.REDebt.Replace(",", "")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Real Estate Debt@1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.ILDebt.Replace(",", "")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Installment Loans Debt@1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.CollectionDebt.Replace(",", "")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Collections Debt@1");
            //}
            //try
            //{
            //    if (Convert.ToInt32(l.TDebt.Replace(",", "")) < 0)
            //        throw new Exception();
            //}
            //catch
            //{
            //    throw new Exception("Unavailable Total Debt@1");
            //}
            foreach (var v in l.CAccList)
                AddAccount(v);
            foreach (var v in l.InqList)
                AddInquiries(v);
            try
            {
                if (Convert.ToInt32(l.Experian.Replace(",", "")) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Experian @5");
            }
            try
            {
                if (Convert.ToInt32(l.Equifax.Replace(",", "")) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Equifax@5");
            }
            try
            {
                if (Convert.ToInt32(l.TransUnio.Replace(",", "")) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Trans Unio @5");
            }
            Loans2C loans2C = new Loans2C();

            loans2C.UpdateLoan2(l);
            ClientC c = new ClientC();
            Client client = c.FindClient(l.ClientId);
            client.MiddleProcess = "2napp";
            c.UpdateClient(client);
            UserC u = new UserC();
            SendEmailC send = new SendEmailC();
            string message = "We want to let you know that there are several  problrm in your report. Please enter to our system(to the report) and change them. (you will have a comments in the system about the changes)";
            send.SendEmailF(client.Mail, "The Report Of" + client.Fname + " " + client.Lname, message);

        }
        public void Finish(Loans2 l)
        {
            try
            {
                if (Convert.ToInt32(l.OpenCC) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Open Credit Cards@1");
            }
            try
            {
                if (Convert.ToInt32(l.OpenRC) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Open Retail Cards@1");
            }
            try
            {
                if (Convert.ToInt32(l.OpenRELoans) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Open Real Estate Loans@1");
            }
            try
            {
                if (Convert.ToInt32(l.OpenILoans) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Open Installment Loans@1");
            }
            try
            {
                if (Convert.ToInt32(l.TotalOpenAcc) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Total Open Account@1");
            }
            try
            {
                if (Convert.ToInt32(l.AcceverLate) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Account Ever Late@1");
            }
            try
            {
                if (Convert.ToInt32(l.CollectionAcc) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Collection Account@1");
            }
            try
            {
                if (Convert.ToInt32(l.AvgAccAge.Split('/')[0]) < 1 || Convert.ToInt32(l.AvgAccAge.Split('/')[0]) > 12)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Month Of Average Account Age @1");
            }
            try
            {
                if (Convert.ToInt32(l.AvgAccAge.Split('/')[1]) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Year Of Average Account Age @1");
            }
            try
            {
                if (Convert.ToInt32(l.OldestAcc.Split('/')[0]) < 1 || Convert.ToInt32(l.AvgAccAge.Split('/')[0]) > 12)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Month Of Oldest Account @1");
            }
            try
            {
                if (Convert.ToInt32(l.OldestAcc.Split('/')[1]) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Year Of Oldest Account @1");
            }
            try
            {
                if (Convert.ToInt32(l.CRDebt) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Credit And Retail Card Debt@1");
            }
            try
            {
                if (Convert.ToInt32(l.REDebt) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Real Estate Debt@1");
            }
            try
            {
                if (Convert.ToInt32(l.ILDebt) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Installment Loans Debt@1");
            }
            try
            {
                if (Convert.ToInt32(l.CollectionDebt) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Collections Debt@1");
            }
            try
            {
                if (Convert.ToInt32(l.TDebt) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Total Debt@1");
            }
            foreach (var v in l.CAccList)
                AddAccount(v);
            foreach (var v in l.InqList)
                AddInquiries(v);
            try
            {
                if (Convert.ToInt32(l.Experian) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Experian @5");
            }
            try
            {
                if (Convert.ToInt32(l.Equifax) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Equifax@5");
            }
            try
            {
                if (Convert.ToInt32(l.TransUnio) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Trans Unio @5");
            }
            try
            {
                if (Convert.ToInt32(l.Fico2) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Fico 2 @5");
            }
            try
            {
                if (Convert.ToInt32(l.Fico8) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Fico 8 @5");
            }
            try
            {
                if (Convert.ToInt32(l.Fico3) < 0)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("Unavailable Fico 3 @5");
            }
            Loans2C loans2C = new Loans2C();
            loans2C.UpdateLoan2(l);
            ClientC c = new ClientC();
            Client client = c.FindClient(l.ClientId);
            client.MiddleProcess = "2app";
            c.UpdateClient(client);            
            string message = "We want to let you know that the report was approved";
            SendEmailC send = new SendEmailC();
            send.SendEmailF(client.Mail, "The Report Was Approved" , message);

        }
        public void CreateLoanByFile(string text)
        {

        }
    }
}
