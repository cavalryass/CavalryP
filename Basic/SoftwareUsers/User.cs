using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.SoftwareUsers
{
    public class User
    {
        
        #region prop
        public string Id { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string MobileNum { get; set; }
        public string Status { get; set; }

        #endregion
        #region ctor
        public User()//empty
        {
            Id = "";
            Mail = "";
            Password = "";
            Fname = "";
            Lname = "";
            MobileNum = "";
            Status = "";
        }
        public User(string mail, string password)//for log in
        {
            Id = "";
            Mail = mail;
            Password = password;
            Fname = "";
            Lname = "";
            MobileNum = "";
            Status = "";
        }
        public User(string mail, string password, string fname, string lname, string mobileNum)//for sign up
        {
            Id = "";
            Mail = mail;
            Password = password;
            Fname = fname;
            Lname = lname;
            MobileNum = mobileNum;
            Status = "Unknown";
        }
        public User(string mail, string password, string fname, string lname, string mobileNum, string status)//most useful
        {
            Id = "";
            Mail = mail;
            Password = password;
            Fname = fname;
            Lname = lname;
            MobileNum = mobileNum;
            Status = status;
        }
        public User(string id, string mail, string password, string fname, string lname, string mobileNum, string status)//full
        {
            Id = id;
            Mail = mail;
            Password = password;
            Fname = fname;
            Lname = lname;
            MobileNum = mobileNum;
            Status = status;
        }
        public User(User u)//copy
        {
            Id = u.Id;
            Mail = u.Mail;
            Password = u.Password;
            Fname = u.Fname;
            Lname = u.Lname;
            MobileNum = u.MobileNum;
            Status = u.Status;
        }

        #endregion

    }
}
