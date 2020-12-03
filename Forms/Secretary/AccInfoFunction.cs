using Basic.ManagerAccess;
using ConnectToDB.AccountInfo;
using ConnectToDB.ManagerAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Secretary
{
    public class AccInfoFunction
    {
        AccountC i = new AccountC();
        public List<string> FromSource(string kind)
        {
            if (kind == "Expenses")
                return i.AccountListByKind(true);
            return i.AccountListByKind(false);
        }
        public List<string> FromWhenChoose(string choice)
        {
            List<string> l = new List<string>();
            foreach (var v in i.AccountListByKind(true))
                if (v != choice)
                    l.Add(v);
            return l;
        }
        public List<string> ToWhenChoose(string choice)
        {
            List<string> l = new List<string>();
            foreach (var v in i.AccountListByKind(false))
                if (v != choice)
                    l.Add(v);
            return l;
        }
        public List<string> ToSource(string kind)
        {
            return i.AccountListByKind(false);
        }
        public List<string> CategorySource(string kind)
        {
            CategoryC c = new CategoryC();
            return c.AllCategoriesByKind(kind);
        }
        public void AddButton(AccInfo acc)
        {
            try
            {
                Convert.ToDouble(acc.Amount);
            }
            catch
            {
                throw new Exception("The Amount Isn't Available");
            }
            try
            {
                if (Convert.ToDateTime(acc.Date) > DateTime.Now)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("The Date Isn't Available");
            }
            //if (acc.InvoiceNum == "")
              //  throw new Exception("The Invoice Isn't Available");
            AccInfoC infoC = new AccInfoC();
            infoC.AddAccInfo(acc);
        }
        public void UpdateButton(AccInfo acc)
        {
            try
            {
                Convert.ToDouble(acc.Amount);
            }
            catch
            {
                throw new Exception("The Amount Isn't Available");
            }
            try
            {
                if (Convert.ToDateTime(acc.Date) > DateTime.Now)
                    throw new Exception();
            }
            catch
            {
                throw new Exception("The Date Isn't Available");
            }
            if (acc.InvoiceNum == "")
                throw new Exception("The Invoice Isn't Available");
            AccInfoC infoC = new AccInfoC();            
            infoC.UpdateAccInfo(acc);
        }
        public void DeleteButton(int id)
        {
            AccInfoC infoC = new AccInfoC();
            infoC.RemoveAccInfo(id);
        }
        public List<AccInfo> SearchInfo(string date,string from,string to,string amount,string enterTB)
        {
            try
            {
                if (date != "")
                    Convert.ToDateTime(date);
            }
            catch
            {
                throw new Exception("The Date Isn't Available");
            }
            try
            {
                if (amount != "")
                    Convert.ToDouble(amount);
            }
            catch
            {
                throw new Exception("The Amount Isn't Available");
            }
            AccInfoC infoC = new AccInfoC();
            return infoC.FilterAccInfo(date,"All", from, to, amount, enterTB);
        }
    }
}
