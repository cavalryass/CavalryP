using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.ManagerAccess
{
    public class AccInfo
    {
        #region propities
        public int Id { get; set; }
        public string Kind { get; set; }
        public string Date { get; set; }
        public string Requestfrom { get; set; }
        public string RequestTo { get; set; }
        public string Comment { get; set; }
        public string Amount { get; set; }
        public string UserId { get; set; }
        public string Category { get; set; }
        public string CheckNum { get; set; }
        public string BankName { get; set; }
        public string InvoiceNum { get; set; }
        public bool Enterb { get; set; }
        #endregion
        #region ctor
        public AccInfo()
        {
            Id = 0;
            Kind = "";
            Date = "";
            Requestfrom = "";
            RequestTo = "";
            Comment = "";
            Amount = "";
            UserId = "0";
            Category = "";
            CheckNum = "";
            BankName = "";
            InvoiceNum = "";
            Enterb = false;
        }
        public AccInfo(string kind, string date, string requestfrom, string requestTo, string comment, string amount, string userId, string category, string checkNum, string bankName, string invoiceNum, bool enterb)
        {
            Id = 0;
            Kind = kind;
            Date = date;
            Requestfrom = requestfrom;
            RequestTo = requestTo;
            Comment = comment;
            Amount = amount;
            UserId = userId;
            Category = category;
            CheckNum = checkNum;
            BankName = bankName;
            InvoiceNum = invoiceNum;
            Enterb = enterb;
        }
        public AccInfo(int id, string kind, string date, string requestfrom, string requestTo, string comment, string amount, string userId, string category, string checkNum, string bankName, string invoiceNum, bool enterb)
        {
            Id = id;
            Kind = kind;
            Date = date;
            Requestfrom = requestfrom;
            RequestTo = requestTo;
            Comment = comment;
            Amount = amount;
            UserId = userId;
            Category = category;
            CheckNum = checkNum;
            BankName = bankName;
            InvoiceNum = invoiceNum;
            Enterb = enterb;
        }
        public AccInfo(AccInfo i)
        {
            Id = i.Id;
            Kind = i.Kind;
            Date = i.Date;
            Requestfrom = i.Requestfrom;
            RequestTo = i.RequestTo;
            Comment = i.Comment;
            Amount = i.Amount;
            UserId = i.UserId;
            Category = i.Category;
            CheckNum = i.CheckNum;
            BankName = i.BankName;
            InvoiceNum = i.InvoiceNum;
            Enterb = i.Enterb;
        }

        #endregion
    }
}
