using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.SoftwareUsers
{
    public class Client
    {
        #region prop
        public string Id { get; set; }
        public string Mail { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string WorkNum { get; set; }
        public string HomeNum { get; set; }
        public string MobileNum { get; set; }
        public string Fax { get; set; }
        public string SalesRep { get; set; }
        public string Memo { get; set; }
        public string MiddleProcess { get; set; }
        public bool Request { get; set; }

        #endregion
        #region ctor
        public Client()
        {
            Id = "0";
            Mail = "";
            Fname = "";
            Lname = "";
            CompanyName = "";
            Address = "";
            Suite = "";
            City = "";
            State = "";
            Zip = "";
            WorkNum = "";
            HomeNum = "";
            MobileNum = "";
            Fax = "";
            SalesRep = "";
            Memo = "";
            MiddleProcess = "";
            Request = false;
        }
        public Client(string mail, string fname, string lname, string companyName, string address, string suite, string city, string state, string zip, string workNum, string homeNum, string mobileNum, string fax, string salesRep, string memo)
        {
            Id = "0";
            Mail = mail;
            Fname = fname;
            Lname = lname;
            CompanyName = companyName;
            Address = address;
            Suite = suite;
            City = city;
            State = state;
            Zip = zip;
            WorkNum = workNum;
            HomeNum = homeNum;
            MobileNum = mobileNum;
            Fax = fax;
            SalesRep = salesRep;
            Memo = memo;
            MiddleProcess = "";
            Request = false;
        }
        public Client(string id, string mail, string fname, string lname, string companyName, string address, string suite, string city, string state, string zip, string workNum, string homeNum, string mobileNum, string fax, string salesRep, string memo)
        {
            Id = id;
            Mail = mail;
            Fname = fname;
            Lname = lname;
            CompanyName = companyName;
            Address = address;
            Suite = suite;
            City = city;
            State = state;
            Zip = zip;
            WorkNum = workNum;
            HomeNum = homeNum;
            MobileNum = mobileNum;
            Fax = fax;
            SalesRep = salesRep;
            Memo = memo;
        }
        public Client(string id, string mail, string fname, string lname, string companyName, string address, string suite, string city, string state, string zip, string workNum, string homeNum, string mobileNum, string fax, string salesRep, string memo, string middleProcess, bool request) : this(id, mail, fname, lname, companyName, address, suite, city, state, zip, workNum, homeNum, mobileNum, fax, salesRep, memo)
        {
            MiddleProcess = middleProcess;
            Request = request;
        }
        public Client(Client c)
        {
            Id = c.Id;
            Mail = c.Mail;
            Fname = c.Fname;
            Lname = c.Lname;
            CompanyName = c.CompanyName;
            Address = c.Address;
            Suite = c.Suite;
            City = c.City;
            State = c.State;
            Zip = c.Zip;
            WorkNum = c.WorkNum;
            HomeNum = c.HomeNum;
            MobileNum = c.MobileNum;
            Fax = c.Fax;
            SalesRep = c.SalesRep;
            Memo = c.Memo;
            MiddleProcess = c.MiddleProcess;
            Request = c.Request;
        }

        #endregion
    }
}
