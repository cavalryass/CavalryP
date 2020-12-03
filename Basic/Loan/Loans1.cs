using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Loan
{
    public class Loans1
    {
        #region prop
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string DBAName { get; set; }
        public string Pcontact { get; set; }
        public string TaxID { get; set; }
        public string SS { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Street { get; set; }
        public bool Own { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Mstreet { get; set; }
        public string Mcity { get; set; }
        public string Mstate { get; set; }
        public string Mzip { get; set; }
        public string Chose1 { get; set; }
        public string DateBE { get; set; }
        public string StateoOI { get; set; }
        public string EmployeesNum { get; set; }
        public string Explains { get; set; }
        public string Chose2 { get; set; }
        public string Acompanies { get; set; }
        public bool Approved { get; set; }
        public string ClientId { get; set; }
        public bool Close { get; set; }

        #endregion
        #region ctor
        public Loans1()
        {
            Id = 0;
            BusinessName = "";
            DBAName = "";
            Pcontact = "";
            TaxID = "";
            Tel = "";
            Mail = "";
            Street = "";
            Own = true;
            City = "";
            State = "";
            Zip = "";
            Mstreet = "";
            Mcity = "";
            Mstate = "";
            Mzip = "";
            Chose1 = "";
            DateBE = "";
            StateoOI = "";
            EmployeesNum = "";
            Explains = "";
            Chose2 = "";
            Acompanies = "";
            Approved = false;
            Close = true;
            ClientId = "0";
        }
        public Loans1(string businessName, string dbaName, string pcontact, string taxID, string ss, string tel, string email, string street, bool own, string city, string state, string zip, string mstreet, string mcity, string mstate, string mzip, string list1, string dateBE, string stateoOI, string employeesNum, string explain, string list2, string acompanies, string clientId)
        {
            Id = 0;
            BusinessName = businessName;
            DBAName = dbaName;
            Pcontact = pcontact;
            TaxID = taxID;
            SS = ss;
            Tel = tel;
            Mail = email;
            Street = street;
            Own = own;
            City = city;
            State = state;
            Zip = zip;
            Mstreet = mstreet;
            Mcity = mcity;
            Mstate = mstate;
            Mzip = mzip;
            Chose1 = list1;
            DateBE = dateBE;
            StateoOI = stateoOI;
            EmployeesNum = employeesNum;
            Explains = explain;
            Chose2 = list2;
            Acompanies = acompanies;
            Approved = false;
            ClientId = clientId;
            Close = false;
        }
        public Loans1(int id, string businessName, string dBAName, string pcontact, string taxID, string sS, string tel, string mail, string street, bool own, string city, string state, string zip, string mstreet, string mcity, string mstate, string mzip, string chose1, string dateBE, string stateoOI, string employeesNum, string explain, string chose2, string acompanies, bool approved, string clientId, bool close)
        {
            Id = id;
            BusinessName = businessName;
            DBAName = dBAName;
            Pcontact = pcontact;
            TaxID = taxID;
            SS = sS;
            Tel = tel;
            Mail = mail;
            Street = street;
            Own = own;
            City = city;
            State = state;
            Zip = zip;
            Mstreet = mstreet;
            Mcity = mcity;
            Mstate = mstate;
            Mzip = mzip;
            Chose1 = chose1;
            DateBE = dateBE;
            StateoOI = stateoOI;
            EmployeesNum = employeesNum;
            Explains = explain;
            Chose2 = chose2;
            Acompanies = acompanies;
            Approved = approved;
            ClientId = clientId;
            Close = close;
        }
        public Loans1(Loans1 l)
        {
            Id = l.Id;
            BusinessName = l.BusinessName;
            DBAName = l.DBAName;
            Pcontact = l.Pcontact;
            TaxID = l.TaxID;
            SS = l.SS;
            Tel = l.Tel ;
            Mail = l.Mail;
            Street = l.Street;
            Own = l.Own;
            City = l.City;
            State = l.State;
            Zip = l.Zip;
            Mstreet = l.Mstreet;
            Mcity = l.Mcity;
            Mstate = l.Mstate;
            Mzip = l.Mzip;
            Chose1 = l.Chose1;
            DateBE = l.DateBE;
            StateoOI = l.StateoOI;
            EmployeesNum = l.EmployeesNum;
            Explains = l.Explains;
            Chose2 = l.Chose2;
            Acompanies = l.Acompanies;
            Approved = l.Approved;
            ClientId = l.ClientId;
            Close = l.Close;
        }
        #endregion
    }
}
