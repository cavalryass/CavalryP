using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.ManagerAccess
{
    public class Account
    {
        #region propties
        public string AccountNum { get; set; }//primary key
        public string OwnerMail { get; set; }
        public string Balance { get; set; }
        public string Equity { get; set; }
        public string Debt { get; set; }
        public string SBalance { get; set; }
        public string Sequity { get; set; }
        public string Sdebt { get; set; }
        public string Kind { get; set; }
        public string UserId { get; set; }

        #endregion
        #region ctor
        public Account()
        {
            AccountNum = "";
            OwnerMail = "";
            Balance = "";
            Equity = "";
            Debt = "";
            SBalance = "";
            Sequity = "";
            Sdebt = "";
            Kind = "";
            UserId = "";
        }
        public Account(string accountNum, string ownerMail, string balance, string equity, string debt, string sBalance, string sequity, string sdebt, string kind, string userId)
        {
            AccountNum = accountNum;
            OwnerMail = ownerMail;
            Balance = balance;
            Equity = equity;
            Debt = debt;
            SBalance = sBalance;
            Sequity = sequity;
            Sdebt = sdebt;
            Kind = kind;
            UserId = userId;
        }
        public Account(Account acc)
        {
            AccountNum = acc.AccountNum;
            OwnerMail = acc.OwnerMail;
            Balance = acc.Balance;
            Equity = acc.Equity;
            Debt = acc.Debt;
            SBalance = acc.SBalance;
            Sequity = acc.Sequity;
            Sdebt = acc.Sdebt;
            Kind = acc.Kind;
            UserId = acc.UserId;
        }

        #endregion
    }
}
