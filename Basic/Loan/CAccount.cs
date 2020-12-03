using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Loan
{
    public class CAccount
    {
        #region prop
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNum { get; set; }
        public string OriginalCreditor { get; set; }
        public string CompanySold { get; set; }
        public string AccountType { get; set; }
        public string DateOpened { get; set; }
        public string AccountStatus { get; set; }
        public string PaymentStatus { get; set; }
        public string StatusUpdated { get; set; }
        public string OriginalBalance { get; set; }
        public string Balance { get; set; }
        public string BalanceUpdated { get; set; }
        public string CreditLimit { get; set; }
        public string MonthlyPayment { get; set; }
        public string PastDueAmount { get; set; }
        public string HighestBalance { get; set; }
        public string Terms { get; set; }
        public string Responsibility { get; set; }
        public string YourStatement { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }
        public string LoansId { get; set; }

        #endregion
        #region ctor
        public CAccount()
        {
            Id = -1;
            AccountName = "";
            AccountNum = "";
            OriginalCreditor = "";
            CompanySold = "";
            DateOpened = "";
            AccountStatus = "";
            PaymentStatus = "";
            StatusUpdated = "";
            Balance = "";
            BalanceUpdated = "";
            CreditLimit = "";
            MonthlyPayment = "";
            PastDueAmount = "";
            HighestBalance = "";
            Terms = "";
            Responsibility = "";
            YourStatement = "";
            Comments = "";
            Status = "";
            LoansId = "0";
            OriginalBalance = "";
        }
        public CAccount(string accountName, string accountNum, string originalCreditor, string companySold, string accountType, string dateOpened, string accountStatus, string paymentStatus, string statusUpdated, string balance, string balanceUpdated, string creditLimit, string monthlyPayment, string pastDueAmount, string highestBalance, string originalBalance, string terms, string responsibility, string yourStatement, string comments, string status, string loansId)
        {
            Id =-1;
            AccountName = accountName;
            AccountNum = accountNum;
            OriginalCreditor = originalCreditor;
            CompanySold = companySold;
            AccountType = accountType;
            DateOpened = dateOpened;
            AccountStatus = accountStatus;
            PaymentStatus = paymentStatus;
            StatusUpdated = statusUpdated;
            Balance = balance;
            BalanceUpdated = balanceUpdated;
            CreditLimit = creditLimit;
            MonthlyPayment = monthlyPayment;
            PastDueAmount = pastDueAmount;
            HighestBalance = highestBalance;
            Terms = terms;
            Responsibility = responsibility;
            YourStatement = yourStatement;
            Comments = comments;
            Status = status;
            LoansId = loansId;
            OriginalBalance = originalBalance;
        }
        public CAccount(int id, string accountName, string accountNum, string originalCreditor, string companySold, string accountType, string dateOpened, string accountStatus, string paymentStatus, string statusUpdated, string balance, string balanceUpdated, string creditLimit, string monthlyPayment, string pastDueAmount, string highestBalance, string originalBalance, string terms, string responsibility, string yourStatement, string comments, string status, string loansId)
        {
            Id = id;
            AccountName = accountName;
            AccountNum = accountNum;
            OriginalCreditor = originalCreditor;
            CompanySold = companySold;
            AccountType = accountType;
            DateOpened = dateOpened;
            AccountStatus = accountStatus;
            PaymentStatus = paymentStatus;
            StatusUpdated = statusUpdated;
            Balance = balance;
            BalanceUpdated = balanceUpdated;
            CreditLimit = creditLimit;
            MonthlyPayment = monthlyPayment;
            PastDueAmount = pastDueAmount;
            HighestBalance = highestBalance;
            Terms = terms;
            Responsibility = responsibility;
            YourStatement = yourStatement;
            Comments = comments;
            Status = status;
            LoansId = loansId;
            OriginalBalance = originalBalance;
        }
        public CAccount(CAccount c)
        {
            Id = c.Id;
            AccountName = c.AccountName;
            AccountNum = c.AccountNum;
            OriginalCreditor = c.OriginalCreditor;
            CompanySold = c.CompanySold;
            AccountType = c.AccountType;
            DateOpened = c.DateOpened;
            AccountStatus = c.AccountStatus;
            PaymentStatus = c.PaymentStatus;
            StatusUpdated = c.StatusUpdated;
            Balance = c.Balance;
            BalanceUpdated = c.BalanceUpdated;
            CreditLimit = c.CreditLimit;
            MonthlyPayment = c.MonthlyPayment;
            PastDueAmount = c.PastDueAmount;
            HighestBalance = c.HighestBalance;
            Terms = c.Terms;
            Responsibility = c.Responsibility;
            YourStatement = c.YourStatement;
            Comments = c.Comments;
            Status = c.Status;
            LoansId = c.LoansId;
            OriginalBalance = c.OriginalBalance;
        }

        #endregion

    }
}
