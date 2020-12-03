using Basic.Loan;
using Basic.SoftwareUsers;
using ConnectToDB.LoansCommand;
using ConnectToDB.UsersCommand;
using Forms.GlobalClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Forms.ClientForms
{
    public class Loans1Function
    {
        #region Help function
        void Loan1Checks(Loans1 l)//check if all the files filled
        {
            if (l.BusinessName == "")
                throw new Exception("The Business Legal Name Field Is Empty");
            if (l.Pcontact == "")
                throw new Exception("The Pirmary Contact Field Is Empty");
            if (l.TaxID == "")
                throw new Exception("The Tax ID Field Is Empty");
            if (l.SS == "")
                throw new Exception("The Social Security Field Is Empty");
            if (l.Tel == "")
                throw new Exception("The Telephone Field Is Empty");
            if (l.Mail == "")
                throw new Exception("The Email Address Field Is Empty");
            if (l.Street == "")
                throw new Exception("The Street Address Field Is Empty");
            if (l.City == "")
                throw new Exception("The City Field Is Empty");
            if (l.State == "")
                throw new Exception("The State Field Is Empty");
            if (l.Zip == "")
                throw new Exception("The Zip Field Is Empty");
            if (l.DateBE == "")
                throw new Exception("The Date Business Established Field Is Empty");
            if (l.StateoOI == "")
                throw new Exception("The State of Incorporatin Field Is Empty");
            if (l.EmployeesNum == "")
                throw new Exception("The Number of Employees After Financing Field Is Empty");

        }

        #endregion
        void CreatLoans1(Loans1 l)//create a loan
        {
            Loan1Checks(l);
            Loans1C inter = new Loans1C();
            inter.CreateLoan1(l);
            ClientC client = new ClientC();
            Client c = client.FindClient(l.ClientId);
            c.MiddleProcess = "1";
            client.UpdateClient(c);
            //send mail to the manager
            #region send mail to employee
            //need to change
            string managerMail = "cavalryassociatesmailbox@gmail.com";
            var fromAddress = new MailAddress("cavalryassociatesmailbox@gmail.com", "Cavalry Associates");
            var toAddress = new MailAddress(managerMail, c.Fname + " " + c.Lname + " Ask For Loan");
            const string fromPassword = "aqaq1234";
            string subject = c.Fname + " " + c.Lname + " Ask For Loan";
            string body = "<h1> The Client: "+c.Fname+" "+c.Lname+" "+c.Mail+ " Ask For A Loan</h1>" +
                  "<img src=\"https://app.synccos.com/assets/images/cavalry-signin.png\" alt=\"Trulli\" width=\"500\" height=\"333\"></p>";


            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                message.IsBodyHtml = true;
                smtp.Send(message);
            }
            #endregion
        }        
        void UpdateLoan1(Loans1 l)
        {
            Loans1C inter = new Loans1C();
            Loan1Checks(l);
            inter.UpdateLoan1(l);
            
        }
        public void Submit(Loans1 l,string status,string uid)
        {
            if (status == "Client")
            {
                ClientC interc = new ClientC();
                if (interc.FindIfClientHasLoan(l.ClientId))
                {
                    //ClientGlobal global = new ClientGlobal();
                    UpdateLoan1(FindLoan1ByClient(l.ClientId));
                    throw new Exception("The First Stage Has Been Successfully Updated");
                }
                else
                {
                    Loans1 l1 = new Loans1(FindLoan1ByClient(l.ClientId));
                    l.Id = l1.Id;
                    CreatLoans1(l);
                    UserC u = new UserC();
                    SendEmailC send = new SendEmailC();
                    ClientC c = new ClientC();
                    Client c1 = c.FindClient(uid);
                    string message = "Client: " + c1.Mail + " " + c1.MobileNum + " " + c1.Fname + " " + c1.Lname + "Want a loan";
                    send.SendEmailF(u.FindNeedEmail("Manager",uid),"Ask For Loan"+c1.Fname+" "+c1.Lname,message);

                }
            }
            else
            {
                //status will be the employee id
                UpdateLoan1(FindLoan1ByClient(l.ClientId));
                ClientGlobal global = new ClientGlobal();
                Client c= global.FindClient(l.ClientId);
                if (c.MiddleProcess == "1")
                {
                    c.MiddleProcess = "1app";
                    global.UpdateClient(c);
                }
                SendEmailC send = new SendEmailC();
                ClientC clientC = new ClientC();
                Client c1 = clientC.FindClient(uid);
                string message = "Hello "+ c1.Fname + " " + c1.Lname + "We wanted to let you know that the application approved";
                send.SendEmailF(c1.Mail, "Approved Application", message);


            }
        }
        public Loans1 pageLoad(string clientId)
        {
            Loans1 l = FindLoan1ByClient(clientId);
            if (l.Id == -1)
            {
                ClientGlobal global = new ClientGlobal();
                Client c = global.FindClient(clientId);
                l.Tel = c.MobileNum;
                l.Mail = c.Mail;
                l.Street = c.Address;
                l.Mstreet = c.Address;
                l.City = c.City;
                l.Mcity = c.City;
                l.State = c.State;
                l.Mstate = c.State;
                l.Zip = c.Zip;
                l.Mzip = c.Zip;
                l.DateBE = " / ";
            }
            return l;

        }

        public Loans1 FindLoan1ByClient(string cid)
        {
            Loans1C l = new Loans1C();
            return l.FindLoan1ByClient(cid);
        }
        public void SubmitLoan1(Loans1 l1, string clientId)
        {
            Loans1 l = new Loans1();
            AllLoansFunction allLF = new AllLoansFunction();
            if (allLF.ClientHasLoan(clientId))
            {
                l = new Loans1(FindLoan1ByClient(clientId));
                l1.Id = l.Id;
                l = new Loans1(l1);
            }
            else
            {
                l = new Loans1(l1);
                l.Id = -1;
            }
            ClientC client = new ClientC();
            if (client.FindIfClientHasLoan(l.ClientId))
                throw new Exception("You Are In The Middle Of A Loan Application Process");
            if (l.BusinessName == "")
                throw new Exception("The Business Legal Name Field Is Empty");
            if (l.Pcontact == "")
                throw new Exception("The Pirmary Contact Field Is Empty");
            if (l.TaxID == "")
                throw new Exception("The Tax ID Field Is Empty");
            if (l.SS == "")
                throw new Exception("The Social Security Field Is Empty");
            if (l.Tel == "")
                throw new Exception("The Telephone Field Is Empty");
            if (l.Mail == "")
                throw new Exception("The Email Address Field Is Empty");
            if (l.Street == "")
                throw new Exception("The Street Address Field Is Empty");
            if (l.City == "")
                throw new Exception("The City Field Is Empty");
            if (l.State == "")
                throw new Exception("The State Field Is Empty");
            if (l.Zip == "")
                throw new Exception("The Zip Field Is Empty");
            if (l.DateBE == "")
                throw new Exception("The Date Business Established Field Is Empty");
            if (l.StateoOI == "")
                throw new Exception("The State of Incorporatin Field Is Empty");
            if (l.EmployeesNum == "")
                throw new Exception("The Number of Employees After Financing Field Is Empty");
            if (l.Id == -1)
                CreatLoans1(l);
            else
                UpdateLoan1(l);
        }
    }
}
