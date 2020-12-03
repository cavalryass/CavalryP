using Basic.ManagerAccess;
using ConnectToDB.AccountInfo;
using ConnectToDB.ManagerAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Manager
{
    public class AccountAndInfo
    {
        #region AccInfo
 
        public List<string> fromDD()//all the from account
        {
            List<string> l = new List<string>();
            AccountC inter = new AccountC();
            List<Account> c = inter.AccountList();
            foreach (var v in c)
                l.Add(v.AccountNum);
            return l;
        }
        public List<string> toDD()//all the to account
        {
            List<string> l = new List<string>();
            AccountC inter = new AccountC();
            List<Account> c = inter.AccountList();
            foreach (var v in c)
                if (v.Kind != "Credit")
                    l.Add(v.AccountNum);
            return l;
        }
        public List<string> categoryDD()//all categories
        {
            CategoryC inter = new CategoryC();
            return inter.AllCategories();
        }
        public void AddNewAccInfo(AccInfo acc)//create new information of transfernce
        {
            try
            {
                if (Convert.ToInt32(acc.Amount) < 0)
                    throw new Exception("Unavailable Amount");
            }
            catch
            {
                throw new Exception("Unavailable Amount");
            }
            try
            {
                if (Convert.ToDateTime(acc.Date) > DateTime.Now)
                    throw new Exception("Unavailable Date");
            }
            catch
            {
                throw new Exception("Unavailable Date");
            }
            AccInfoC inter = new AccInfoC();
            try
            {
                inter.AddAccInfo(acc);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<AccInfo> SearchListOfAccInfo(string date, string kind, string from, string to, string amount, string enterB)//return the list of information filtered by the following fields
        {
            try
            {
                bool dFlag = false;
                bool aFlag = false;
                if (date == "")
                {
                    date = DateTime.Now.ToString();
                    dFlag = true;
                }
                if (Convert.ToDateTime(date) > DateTime.Now)
                    throw new Exception("Not Available Date");
                if (from == "")
                    throw new Exception("The From Field Is Empty");
                if (to == "")
                    throw new Exception("The To Field Is Empty");
                if (amount == "")
                {
                    aFlag = true;
                    amount = "3";
                }
                if (double.Parse(amount) < 0)
                    throw new Exception("Unavailable Amount");
                if (dFlag)
                    date = "";
                if (aFlag)
                    amount = "";
                AccInfoC inter = new AccInfoC();
                return inter.FilterAccInfo(date, kind, from, to, amount, enterB);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public AccInfo SelectAccInfo(int Id)//show the accInfo
        {
            AccInfoC inter = new AccInfoC();
            return inter.FindAccInfo(Id);
        }
        public void DeleteAccInfo(int Id)
        {
            AccInfoC inter = new AccInfoC();
            inter.RemoveAccInfo(Id);
        }
        public void UpdateAccInfo(AccInfo i)
        {
            AccInfoC inter = new AccInfoC();
            inter.UpdateAccInfo(i);
        }
        #endregion
        #region Account
        public void CreateAccount(Account acc)
        {
            try
            {
                AccountC inter = new AccountC();
                acc.Balance = "0";
                acc.Equity = "0";
                acc.Debt = "0";
                acc.SBalance = "0";
                acc.Sequity = "0";
                acc.Sdebt = "0";
                inter.CreateAcc(acc);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void RemoveAccount(Account acc)
        {
            try
            {
                AccountC inter = new AccountC();
                inter.RemoveAcc(acc);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void UpdateAccount(Account acc,string oldAcc)
        {
            try
            {
                AccountC inter = new AccountC();
                inter.UpdateAcc(acc,oldAcc);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Account> AccountList()
        {
            AccountC c = new AccountC();
            return c.AccountList();
        }
        public List<AccInfo> AccountsAIDetails(string accNum,string Dfrom,string Dto,string category,string f_twhom)
        {
            AccInfoC c = new AccInfoC();
            if(Dfrom=="")
                Dfrom="01/01/1900";
            if (Dto == "")
                Dto = DateTime.Now.ToShortDateString();
            try
            {
                if (Convert.ToDateTime(Dfrom) > DateTime.Now)
                    throw new Exception();
                if (Convert.ToDateTime(Dto) > DateTime.Now)
                    throw new Exception();

            }
            catch
            {
                throw new Exception("Unavailable Date");
            }
            return c.ListBelongToBank(accNum, Dfrom, Dto, category, f_twhom);
             
        }
      #endregion
    }
}
