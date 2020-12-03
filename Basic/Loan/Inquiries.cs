using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Loan
{
    public class Inquiries
    {
        #region prop
        public int Id { get; set; }
        public string NameOfBank { get; set; }
        public string InquiryDate { get; set; }
        public string RemovalDate { get; set; }
        public string BusinessType { get; set; }
        public string ContactInformation { get; set; }
        public string LoansId { get; set; }

        #endregion
        #region ctor
        public Inquiries()
        {

            Id = -1;
            NameOfBank = "";
            InquiryDate = "";
            RemovalDate = "";
            BusinessType = "";
            ContactInformation = "";
            LoansId = "0";
        }
        public Inquiries(string nameOfBank, string inquiryDate, string removalDate, string businessType, string contactInformation, string loansId)
        {
            Id = -1;
            NameOfBank = nameOfBank;
            InquiryDate = inquiryDate;
            RemovalDate = removalDate;
            BusinessType = businessType;
            ContactInformation = contactInformation;
            LoansId = loansId;
        }
        public Inquiries(int id, string nameOfBank, string inquiryDate, string removalDate, string businessType, string contactInformation, string loansId)
        {
            Id = id;
            NameOfBank = nameOfBank;
            InquiryDate = inquiryDate;
            RemovalDate = removalDate;
            BusinessType = businessType;
            ContactInformation = contactInformation;
            LoansId = loansId;
        }
        public Inquiries(Inquiries inq)
        {
            Id = inq.Id;
            NameOfBank = inq.NameOfBank;
            InquiryDate = inq.InquiryDate;
            RemovalDate = inq.RemovalDate;
            BusinessType = inq.BusinessType;
            ContactInformation = inq.ContactInformation;
            LoansId = inq.LoansId;
        }
        #endregion
    }
}
