using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Forms.GlobalClass
{
    public class SendEmailC
    {
    
        public void SendEmailF(string emailAddress, string sub, string mes)
        {
            if (emailAddress == "")
                throw new Exception("There Isn't Email Address");
            foreach (var v in emailAddress.Split(new string[] { ".com" }, StringSplitOptions.None))
            {
                if (v != "")
                {
                    string oneEmail = v + ".com";

                    var fromAddress = new MailAddress("cavalryassociatesmailbox@gmail.com", "Cavalry Associates");
                    var toAddress = new MailAddress(oneEmail);
                    const string fromPassword = "aqaq1234";
                    string subject = sub;
                    string body = mes + "<br/><br/><br/><br/><br/>" +
                      "Find Us At:   "+   @"https://synccos.azurewebsites.net/GlobalForm/StartPage"+ "<br/><br/><br/>"+"<img src=\"https://app.synccos.com/assets/images/cavalry-signin.png\" alt=\"Trulli\" width=\"500\" height=\"333\"></p>";


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
                }
            }
        }
    }
}
