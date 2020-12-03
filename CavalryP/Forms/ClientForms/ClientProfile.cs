using Basic.Loan;
using Basic.ManagerAccess;
using Basic.SoftwareUsers;
using ConnectToDB.LoansCommand;
using ConnectToDB.ManagerAccess;
using ConnectToDB.UsersCommand;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Forms.ClientForms
{
    public class ClientProfile
    {
        #region client
     
        public void UpdateSetting(Client c,string cid,string password)
        {
            if (c.Mail == "")
                throw new Exception("The Email Filed Is Empty");
            if(c.Fname=="")
                throw new Exception("The First Name Filed Is Empty");
            if (c.Lname == "")
                throw new Exception("The Last Name Filed Is Empty");
            if (c.Address == "")
                throw new Exception("The Billing Address Filed Is Empty");
            if (c.Suite == "")
                throw new Exception("The Suite Field Is Empty");
            if (c.City == "")
                throw new Exception("The Unit City Filed Is Empty");
            if (c.Zip == "")
                throw new Exception("The Zip Code Filed Is Empty");
            if (c.MobileNum == "")
                throw new Exception("The Mobile Phone Filed Is Empty");
             UserC u = new UserC();
            User user = u.FindUser(c.Id);
            if (password != "")
                user.Password = password;
            user.Mail = c.Mail;
            user.MobileNum = c.MobileNum;
            user.Fname = c.Fname;
            user.Lname = c.Lname;
            u.UpdateUser(user);
            c.Id = cid;
            ClientGlobal global = new ClientGlobal();
            c.SalesRep =global.FindClient(c.Id).SalesRep;
            global.UpdateClient(c);
            throw new Exception("The Update Was Successful");
        }

        #endregion


        #region Loan2
        public void CreateLoan2(Loans2 l)//create second step when click save
        {
            ClientC inter1 = new ClientC();
            if (inter1.FindClient(l.ClientId).MiddleProcess == "1")
                throw new Exception("The Loan Didn't Approved Yet");
            Loans2C inter = new Loans2C();
            inter.CreateLoan2(l);
        }
        public void SendLoans2(Loans2 l)//send to approve 
        {
            Loans2C inter = new Loans2C();
            inter.UpdateLoan2(l);
            ClientC inter1 = new ClientC();
            Client c = inter1.FindClient(l.ClientId);
            c.MiddleProcess = "2";
            inter1.UpdateClient(c);
        }
        public List<CAccount> AddedCAcc(string LoanId)
        {
            CAccountC inter = new CAccountC();
            List<CAccount> l = inter.ListOfCAcc(LoanId);
            return l;
        }
        public List<Inquiries> AddedInq(string LoanId)
        {
            InquiriesC inter = new InquiriesC();
            List<Inquiries> l = inter.ListOfInq(LoanId);
            return l;
        }
        public CAccount getChosenCacc(int id)//to show in the update form
        {
            CAccountC inter = new CAccountC();
            return inter.FindCacc(id);
        }
        public Inquiries getChosenInq(int id)//to show in the update form
        {
            InquiriesC inter = new InquiriesC();
            return inter.FindInq(id);
        }
        public void updateChosenCacc(CAccount c)//when click update
        {
            CAccountC inter = new CAccountC();
            inter.UpdateCAcc(c);
        }
        public void updateChosenInq(Inquiries i)//when click update
        {
            InquiriesC inter = new InquiriesC();
            inter.UpdateInq(i);
        }
        public void deleteChosenCacc(int id)//when click delete
        {
            CAccountC inter = new CAccountC();
            inter.RemoveCAcc(id);
        }
        public void deleteChosenInq(int id)//when click delete
        {
            InquiriesC inter = new InquiriesC();
            inter.RemoveInq(id);
        }
        #endregion
        
        public void SaveUploadFile(string filename, string contentType,string uid, FileUpload FileUpload1,string kind)
        {
            using (Stream fs = FileUpload1.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);
                    DocsC p = new DocsC();
                    ReqDocsC rd = new ReqDocsC();
                    p.insertDb(new Docs(uid, filename, contentType, bytes,kind));
                    rd.deleteDB(rd.findByUserAndKind(uid,kind));
                }
            }

            

        }
    
    }
}
