using Basic.SoftwareUsers;
using ConnectToDB.UsersCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Forms.SignIn_Up
{
    public class SignUp_In
    {
        public User SignIN(User u)
        {
            UserC inter = new UserC();
            if (u.Mail == "")
                throw new Exception("The Mail Is Empty");
            if (u.Password == "")
                throw new Exception("The Password Is Empty");
            User u1 = inter.FindUserByMail(u.Mail);
            if (u1.Mail != u.Mail || u1.Password != u.Password)
                throw new Exception("The Mail Or The Password Is Incorrect");
            return u1;
        }
        public void SignUp(User u,string password)
        {
            UserC inter = new UserC();
            if (u.Fname == "")
                throw new Exception("The First Name Is Empty");
            if (u.Lname == "")
                throw new Exception("The Last Name Is Empty");
            if (u.MobileNum == "")
                throw new Exception("The Mobile Number Is Empty");
            if (u.Mail == "")
                throw new Exception("The Mail Is Empty");
            if (u.Password == "")
                throw new Exception("The Password Is Empty");
            if (u.Password != password)
                throw new Exception("The Passwords Don't Match");
            if (inter.CheckIfExist(u.Mail))
                throw new Exception("This User Already Exist");
            //send mail to the user
            #region send mail to user
            var fromAddress = new MailAddress("cavalryassociatesmailbox@gmail.com", "Cavalry Associates");
            var toAddress = new MailAddress(u.Mail, u.Fname + " " + u.Lname);

            const string fromPassword = "aqaq1234";
            const string subject = "In Process";
            const string body = "<h1>Thank you for signing up to <em> Cavalry Associates</em></h1>" +
                "We will do our best to respond to your inquiry as soon as possible" + "<p>" +
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
            #region send mail to employee
            //suppose to find themail that should be send to
            var fromAddress2 = new MailAddress("cavalryassociatesmailbox@gmail.com", "Cavalry Associates");
            var toAddress2 = new MailAddress("cavalryassociatesmailbox@gmail.com", u.Fname + " " + u.Lname + " new user");
            const string fromPassword2 = "aqaq1234";
            string subject2 = "New User " + u.Fname + " " + u.Lname;
            string body2 = "<h1>New User: " + u.Mail + " added to the system</h1>" +
                  "<img src=\"https://app.synccos.com/assets/images/cavalry-signin.png\" alt=\"Trulli\" width=\"500\" height=\"333\"></p>";


            var smtp2 = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress2.Address, fromPassword2)
            };
            using (var message = new MailMessage(fromAddress2, toAddress2)
            {
                Subject = subject2,
                Body = body2
            })
            {
                message.IsBodyHtml = true;
                smtp2.Send(message);
            }
            #endregion
            inter.CreateUser(new User(u.Mail, u.Password, u.Fname, u.Lname, u.MobileNum, "Unknown"));

        }
        public bool FirstTime(string uid)
        {
            ClientC c = new ClientC();
            return c.CheckFirstTime(uid);            
        }
    }
}
