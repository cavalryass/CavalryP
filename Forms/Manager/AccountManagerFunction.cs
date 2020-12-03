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
    public class AccountManagerFunction
    {
        AccountC inter = new AccountC();
        #region function
        Account fillEmptyFileds(Account fullA, Account acc)
        {
            if (acc.AccountNum == "")
                acc.AccountNum = fullA.AccountNum;
            if (acc.Balance == "")
                acc.Balance = fullA.Balance;
            if (acc.Equity == "")
                acc.Equity = fullA.Equity;
            if (acc.Debt == "")
                acc.Debt = fullA.Debt;
            if (acc.SBalance == "")
                acc.SBalance = fullA.SBalance;
            if (acc.Sequity == "")
                acc.Sequity = fullA.Sequity;
            if (acc.Sdebt == "")
                acc.Sdebt = fullA.Sdebt;
            if (acc.OwnerMail == "")
                acc.OwnerMail = fullA.OwnerMail;
            if (acc.Kind == "")
                acc.Kind = fullA.Kind;
            if (acc.UserId == "")
                acc.UserId = fullA.UserId;


            return acc;
        }
        #endregion
        public void AddAccount(Account acc)
        {
            if (acc.AccountNum == "" || inter.CheckIfExist(acc.AccountNum))
                throw new Exception("The Account Number Isn't Available");
            try
            {
                Convert.ToDouble(acc.Equity);
            }
            catch
            {
                throw new Exception("The Equity Isn't Available");
            }
            inter.CreateAcc(acc);

        }
        public void UpdateAccount(Account acc,string oldNum)
        {
            if (acc.AccountNum == "" || inter.CheckIfExist(acc.AccountNum))
                throw new Exception("The Account Number Isn't Available");
            
            fillEmptyFileds(inter.FindAcc(oldNum), acc);
            inter.UpdateAcc(acc,oldNum);
        }
        public void DeleteAccount(string accNum)
        {
            inter.RemoveAcc(FindAccount(accNum));
        }
        public Account FindAccount(string AccNum)
        {
            return inter.FindAcc(AccNum);
        }
        public List<Account> AllAccounts()
        {
            return inter.AccountList();
        }
        public List<AccInfo> SearchAccInfo(string bankNum,string dfrom, string dto,string category, string t_fWhom)
        {
            try
            {
                if (dfrom == "")
                    dfrom = new DateTime(1900, 01, 01).ToShortDateString();
                Convert.ToDateTime(dfrom);
            }
            catch
            {
                throw new Exception("Unavailable From Date");
            }
            try
            {
                if (dto == "")
                    dto = DateTime.Now.ToShortDateString();
                Convert.ToDateTime(dto);
            }
            catch
            {
                throw new Exception("Unavailable To Date");
            }

            AccInfoC infoC = new AccInfoC();
            return infoC.ListBelongToBank(bankNum, dfrom, dto, category, t_fWhom);
        }
        public List<string> F_WSource()
        {
            List<string> l = new List<string>();
            foreach (var v in inter.AccountList())
                l.Add(v.AccountNum);
            l.Add("Other");
            l.Add("All");
            return l;

        }
        public List<string> CategorySource()
        {
            CategoryC cat = new CategoryC();
            List<string> l= cat.AllCategories();
            l.Add("All");
            return l;
        }
    }
}
