using Basic.ManagerAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToDB.AccountInfo
{
    public class AccountC
    {
        MySqlConnection con = new MySqlConnection("server=3.84.165.5;user id=root;port=3306;database=Cavalry;Password=cavalry1234;");

        #region Write to DB
        public void CreateAcc(Account acc)
        {
            //insert to DB
            //check if someone already use the database and wait if necessary
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "INSERT INTO Account (AccountNum,OwnerMail,Balance,Equity,Debt,SBalance,Sequity,Sdebt,Kind,UserId) VALUES (@AccountNum,@OwnerMail,@Balance,@Equity,@Debt,@SBalance,@Sequity,@Sdebt,@Kind,@UserId)";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@AccountNum", acc.AccountNum);
            cmd.Parameters.AddWithValue("@OwnerMail", acc.OwnerMail);
            cmd.Parameters.AddWithValue("@Balance", acc.Balance);
            cmd.Parameters.AddWithValue("@Equity", acc.Equity);
            cmd.Parameters.AddWithValue("@Debt", acc.Debt);
            cmd.Parameters.AddWithValue("@SBalance", acc.SBalance);
            cmd.Parameters.AddWithValue("@Sequity", acc.Sequity);
            cmd.Parameters.AddWithValue("@Sdebt", acc.Sdebt);
            cmd.Parameters.AddWithValue("@Kind", acc.Kind);
            cmd.Parameters.AddWithValue("@UserId", acc.UserId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RemoveAcc(Account acc)
        {
            string newname = "Deleted Account Number" + acc.AccountNum;
            //delete from DB
           
            AccInfoC inter = new AccInfoC();
            List<AccInfo> l = inter.ListBelongToBank(acc.AccountNum,"01/01/1900",DateTime.Now.ToShortDateString(),"All","All");
            //change all the transference that was from and to this account to be know as outside account 
            foreach (var v in l)
            {
                v.Kind = "Third party";
                
                    if (v.Requestfrom == acc.AccountNum)
                        v.Requestfrom = newname;
                    else
                        v.RequestTo = newname;
                
                inter.UpdateWhenDelete(v);
            }

            //delete the account
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM Account WHERE AccountNum = @id", con);
            cmd.Parameters.AddWithValue("@id", acc.AccountNum);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateAcc(Account acc,string oldNum)
        {
            //change 

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "UPDATE Account SET AccountNum=@newAccountNum,OwnerMail=@OwnerMail,Kind=@Kind,Balance=@Balance,Equity=@Equity,Debt=@Debt,SBalance=@SBalance,Sequity=@Sequity,Sdebt=@Sdebt WHERE AccountNum=@AccountNum";
            MySqlCommand cmd = con.CreateCommand(); 
            cmd.Parameters.AddWithValue("@newAccountNum", acc.AccountNum);
            cmd.Parameters.AddWithValue("@OwnerMail", acc.OwnerMail);
            cmd.Parameters.AddWithValue("@Kind", acc.Kind);
            cmd.Parameters.AddWithValue("@Balance", acc.Balance);
            cmd.Parameters.AddWithValue("@Equity", acc.Equity);
            cmd.Parameters.AddWithValue("@Debt", acc.Debt);
            cmd.Parameters.AddWithValue("@SBalance", acc.SBalance);
            cmd.Parameters.AddWithValue("@Sequity", acc.Sequity);
            cmd.Parameters.AddWithValue("@Sdebt", acc.Sdebt);
            cmd.Parameters.AddWithValue("@AccountNum", oldNum);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
           
        }
        #endregion
        #region Read From DB
        public bool CheckIfExist(string num)
        {
            bool ans = false;
            //search acc
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Account where AccountNum=@id", con);
            cmd.Parameters.AddWithValue("@id", num);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ans = true;
            }
            con.Close();
            return ans;
        }
        public Account FindAcc(string num)
        {
            Account acc = new Account();
            //search acc
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Account where AccountNum=@id", con);
            cmd.Parameters.AddWithValue("@id", num);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                acc.AccountNum = reader["AccountNum"].ToString();
                acc.OwnerMail = reader["OwnerMail"].ToString();
                acc.Balance = reader["Balance"].ToString();
                acc.Equity = reader["Equity"].ToString();
                acc.Debt = reader["Debt"].ToString();
                acc.SBalance = reader["SBalance"].ToString();
                acc.Sequity = reader["Sequity"].ToString();
                acc.Sdebt = reader["Sdebt"].ToString();
                acc.Kind = reader["Kind"].ToString();
                acc.UserId = reader["UserId"].ToString();

            }
            con.Close();
            return acc;
        }
        public List<Account> AccountList()//return list of account
        {
            List<Account> l = new List<Account>();

            //search acc
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Account ", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Account acc = new Account();
                acc.AccountNum = reader["AccountNum"].ToString();
                acc.OwnerMail = reader["OwnerMail"].ToString();
                acc.Balance = reader["Balance"].ToString();
                acc.Equity = reader["Equity"].ToString();
                acc.Debt = reader["Debt"].ToString();
                acc.SBalance = reader["SBalance"].ToString();
                acc.Sequity = reader["Sequity"].ToString();
                acc.Sdebt = reader["Sdebt"].ToString();
                acc.Kind = reader["Kind"].ToString();
                acc.UserId = reader["UserId"].ToString();
                l.Add(acc);
            }
            con.Close();

            return l;
        }
        public List<string> AccountListByKind(bool credit)//return list of account
        {
            List<string> l = new List<string>();

            //search acc
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Account ", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(credit)
                    l.Add(reader["AccountNum"].ToString());
                else
                {
                    if (reader["Kind"].ToString() != "Credit")
                        l.Add(reader["AccountNum"].ToString());
                }
                            
                
            }
            con.Close();
            
            return l;
        }

        #endregion
    }
}
