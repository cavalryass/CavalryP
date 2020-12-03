using Basic.Loan;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToDB.LoansCommand
{
    public class CAccountC
    {
        MySqlConnection con = new MySqlConnection("server=3.84.165.5;user id=root;port=3306;database=Cavalry;Password=cavalry1234;");
        #region Read from DB
        
        public List<CAccount> ListOfCAcc(string loanId)
        {
            List<CAccount> l = new List<CAccount>();
            //find all the caccs their clientId is id

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from CAccount where LoansId=@id", con);
            cmd.Parameters.AddWithValue("@id", loanId);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CAccount c = new CAccount();
                c.Id = Convert.ToInt32(reader["Id"].ToString());
                c.AccountName= reader["AccountName"].ToString();
                c.AccountNum = reader["AccountNum"].ToString();
                c.OriginalCreditor = reader["OriginalCreditor"].ToString();
                c.CompanySold = reader["CompanySold"].ToString();
                c.AccountType = reader["AccountType"].ToString();
                c.DateOpened = reader["DateOpened"].ToString();
                c.AccountStatus = reader["AccountStatus"].ToString();
                c.PaymentStatus = reader["PaymentStatus"].ToString();
                c.StatusUpdated = reader["StatusUpdated"].ToString();
                c.Balance = reader["Balance"].ToString();
                c.BalanceUpdated = reader["BalanceUpdated"].ToString();
                c.CreditLimit = reader["CreditLimit"].ToString();
                c.MonthlyPayment = reader["MonthlyPayment"].ToString();
                c.PastDueAmount = reader["PastDueAmount"].ToString();
                c.HighestBalance = reader["HighestBalance"].ToString();
                c.Terms = reader["Terms"].ToString();
                c.Responsibility = reader["Responsibility"].ToString();
                c.YourStatement = reader["YourStatement"].ToString();
                c.Comments = reader["Comments"].ToString();
                c.Status = reader["Status"].ToString();
                c.LoansId = reader["LoansId"].ToString();
                c.OriginalBalance = reader["OriginalBalance"].ToString();
                l.Add(c);
            }
            con.Close();
            return l;
        }
        public CAccount FindCacc(int Id)
        {
            CAccount c = new CAccount();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from CAccount where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", Id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {                
                c.Id = Convert.ToInt32(reader["Id"].ToString());
                c.AccountName = reader["AccountName"].ToString();
                c.AccountNum = reader["AccountNum"].ToString();
                c.OriginalCreditor = reader["OriginalCreditor"].ToString();
                c.CompanySold = reader["CompanySold"].ToString();
                c.AccountType = reader["AccountType"].ToString();
                c.DateOpened = reader["DateOpened"].ToString();
                c.AccountStatus = reader["AccountStatus"].ToString();
                c.PaymentStatus = reader["PaymentStatus"].ToString();
                c.StatusUpdated = reader["StatusUpdated"].ToString();
                c.Balance = reader["Balance"].ToString();
                c.BalanceUpdated = reader["BalanceUpdated"].ToString();
                c.CreditLimit = reader["CreditLimit"].ToString();
                c.MonthlyPayment = reader["MonthlyPayment"].ToString();
                c.PastDueAmount = reader["PastDueAmount"].ToString();
                c.HighestBalance = reader["HighestBalance"].ToString();
                c.Terms = reader["Terms"].ToString();
                c.Responsibility = reader["Responsibility"].ToString();
                c.YourStatement = reader["YourStatement"].ToString();
                c.Comments = reader["Comments"].ToString();
                c.Status = reader["Status"].ToString();
                c.LoansId = reader["LoansId"].ToString();
                c.OriginalBalance = reader["OriginalBalance"].ToString();
            }
            con.Close();
            return c;
        }
        public int getId()

        {
            int i = 0;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select id from LastId where db=@db", con);
            cmd.Parameters.AddWithValue("@db", "CAccount");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i = Convert.ToInt32(reader["id"].ToString());
            }
            con.Close();
            int id = i + 1;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "UPDATE LastId SET id=@Id WHERE db=@db";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@db", "CAccount");
            cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        #endregion
        #region Write to DB
        public void CreateCAcc(CAccount c)
        {
            //insert to DataBase
            //check if someone already use the database and wait if necessary
            if(c.Id==-1)
                c.Id = getId();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "INSERT INTO CAccount (Id,AccountName,AccountNum,OriginalCreditor,CompanySold,AccountType,DateOpened,AccountStatus,PaymentStatus,StatusUpdated,Balance,BalanceUpdated,CreditLimit,MonthlyPayment,PastDueAmount,HighestBalance,OriginalBalance,Terms,Responsibility,YourStatement,Comments,Status,LoansId) VALUES (@Id,@AccountName,@AccountNum,@OriginalCreditor,@CompanySold,@AccountType,@DateOpened,@AccountStatus,@PaymentStatus,@StatusUpdated,@Balance,@BalanceUpdated,@CreditLimit,@MonthlyPayment,@PastDueAmount,@HighestBalance,@OriginalBalance,@Terms,@Responsibility,@YourStatement,@Comments,@Status,@LoansId)";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", c.Id);
            cmd.Parameters.AddWithValue("@AccountName", c.AccountName);
            cmd.Parameters.AddWithValue("@AccountNum", c.AccountNum);
            cmd.Parameters.AddWithValue("@OriginalCreditor", c.OriginalCreditor);
            cmd.Parameters.AddWithValue("@CompanySold", c.CompanySold);
            cmd.Parameters.AddWithValue("@AccountType", c.AccountType);
            cmd.Parameters.AddWithValue("@DateOpened", c.DateOpened);
            cmd.Parameters.AddWithValue("@AccountStatus", c.AccountStatus);
            cmd.Parameters.AddWithValue("@PaymentStatus", c.PaymentStatus);
            cmd.Parameters.AddWithValue("@StatusUpdated", c.StatusUpdated);
            cmd.Parameters.AddWithValue("@Balance", c.Balance);
            cmd.Parameters.AddWithValue("@BalanceUpdated", c.BalanceUpdated);
            cmd.Parameters.AddWithValue("@CreditLimit", c.CreditLimit);
            cmd.Parameters.AddWithValue("@MonthlyPayment", c.MonthlyPayment);
            cmd.Parameters.AddWithValue("@PastDueAmount", c.PastDueAmount);
            cmd.Parameters.AddWithValue("@HighestBalance", c.HighestBalance);
            cmd.Parameters.AddWithValue("@Terms", c.Terms);
            cmd.Parameters.AddWithValue("@Responsibility", c.Responsibility);
            cmd.Parameters.AddWithValue("@OriginalBalance", c.OriginalBalance);
            cmd.Parameters.AddWithValue("@YourStatement", c.YourStatement);
            cmd.Parameters.AddWithValue("@Comments", c.Comments);
            cmd.Parameters.AddWithValue("@Status", c.Status);
            cmd.Parameters.AddWithValue("@LoansId", c.LoansId);           
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RemoveCAcc(int Id)
        {
            //delete from DataBase
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM CAccount WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateCAcc(CAccount c)
        {
            //change 
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "UPDATE CAccount SET (AccountName=@AccountName,AccountNum=@AccountNum,OriginalCreditor=@OriginalCreditor,CompanySold=@CompanySold,OriginalBalance=@OriginalBalance,AccountType=@AccountType,DateOpened=@DateOpened,AccountStatus=@AccountStatus,PaymentStatus=@PaymentStatus,StatusUpdated=@StatusUpdated,Balance=@Balance,BalanceUpdated=@BalanceUpdated,CreditLimit=@CreditLimit,MonthlyPayment=@MonthlyPayment,PastDueAmount=@PastDueAmount,HighestBalance=@HighestBalance,Terms=@Terms,Responsibility=@Responsibility,YourStatement=@YourStatement,Comments=@Comments,Status=@Status,LoansId=@LoansId) WHERE Id=@Id";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", c.Id);
            cmd.Parameters.AddWithValue("@AccountName", c.AccountName);
            cmd.Parameters.AddWithValue("@AccountNum", c.AccountNum);
            cmd.Parameters.AddWithValue("@OriginalCreditor", c.OriginalCreditor);
            cmd.Parameters.AddWithValue("@CompanySold", c.CompanySold);
            cmd.Parameters.AddWithValue("@AccountType", c.AccountType);
            cmd.Parameters.AddWithValue("@DateOpened", c.DateOpened);
            cmd.Parameters.AddWithValue("@AccountStatus", c.AccountStatus);
            cmd.Parameters.AddWithValue("@PaymentStatus", c.PaymentStatus);
            cmd.Parameters.AddWithValue("@StatusUpdated", c.StatusUpdated);
            cmd.Parameters.AddWithValue("@Balance", c.Balance);
            cmd.Parameters.AddWithValue("@BalanceUpdated", c.BalanceUpdated);
            cmd.Parameters.AddWithValue("@CreditLimit", c.CreditLimit);
            cmd.Parameters.AddWithValue("@MonthlyPayment", c.MonthlyPayment);
            cmd.Parameters.AddWithValue("@PastDueAmount", c.PastDueAmount);
            cmd.Parameters.AddWithValue("@HighestBalance", c.HighestBalance);
            cmd.Parameters.AddWithValue("@Terms", c.Terms);
            cmd.Parameters.AddWithValue("@Responsibility", c.Responsibility);
            cmd.Parameters.AddWithValue("@YourStatement", c.YourStatement);
            cmd.Parameters.AddWithValue("@OriginalBalance", c.OriginalBalance);
            cmd.Parameters.AddWithValue("@Comments", c.Comments);
            cmd.Parameters.AddWithValue("@Status", c.Status);
            cmd.Parameters.AddWithValue("@LoansId", c.LoansId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RemoveAllCAccByLoan(string Id)
        {
            //delete from DataBase
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM CAccount WHERE LoansId = @id", con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
    }
}
