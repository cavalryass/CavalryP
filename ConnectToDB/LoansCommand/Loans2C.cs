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
    public class Loans2C
    {
        MySqlConnection con = new MySqlConnection("server=3.84.165.5;user id=root;port=3306;database=Cavalry;Password=cavalry1234;");
        #region Write to DB
        public void CreateLoan2(Loans2 l)
        {
            Loans1C c = new Loans1C();
            l.Id = c.FindLoan1ByClient(l.ClientId).Id.ToString();
            InquiriesC inq = new InquiriesC();
            foreach (var v in l.InqList)
            {
                v.LoansId = l.Id;
                inq.CreateInq(v);
            }
            CAccountC cacc = new CAccountC();
            foreach (var v in l.CAccList)
                cacc.CreateCAcc(v);
            
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            
            string query = "INSERT INTO Loans2 (Id,OpenCC,OpenRC,OpenRELoans,OpenILoans,TotalOpenAcc,AcceverLate,CollectionAcc,AvgAccAge,OldestAcc,CRDebt,REDebt,ILDebt,CollectionDebt,TDebt,PublicRecords,Experian,Equifax,TransUnio,Fico2,Fico3,Fico8,Comment,ClientId,Close,Source) VALUES (@Id,@OpenCC,@OpenRC,@OpenRELoans,@OpenILoans,@TotalOpenAcc,@AcceverLate,@CollectionAcc,@AvgAccAge,@OldestAcc,@CRDebt,@REDebt,@ILDebt,@CollectionDebt,@TDebt,@PublicRecords,@Experian,@Equifax,@TransUnio,@Fico2,@Fico3,@Fico8,@Comment,@ClientId,@Close,@Source)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", l.Id);
            cmd.Parameters.AddWithValue("@OpenCC", l.OpenCC);
            cmd.Parameters.AddWithValue("@OpenRC", l.OpenRC);
            cmd.Parameters.AddWithValue("@OpenRELoans", l.OpenRELoans);
            cmd.Parameters.AddWithValue("@OpenILoans", l.OpenILoans);
            cmd.Parameters.AddWithValue("@TotalOpenAcc", l.TotalOpenAcc);
            cmd.Parameters.AddWithValue("@AcceverLate", l.AcceverLate);
            cmd.Parameters.AddWithValue("@CollectionAcc", l.CollectionAcc);
            cmd.Parameters.AddWithValue("@AvgAccAge", l.AvgAccAge);
            cmd.Parameters.AddWithValue("@OldestAcc", l.OldestAcc);
            cmd.Parameters.AddWithValue("@CRDebt", l.CRDebt);
            cmd.Parameters.AddWithValue("@REDebt", l.REDebt);
            cmd.Parameters.AddWithValue("@ILDebt", l.ILDebt);
            cmd.Parameters.AddWithValue("@CollectionDebt", l.CollectionDebt);
            cmd.Parameters.AddWithValue("@TDebt", l.TDebt);
            cmd.Parameters.AddWithValue("@PublicRecords", l.PublicRecords);
            cmd.Parameters.AddWithValue("@Experian", l.Experian);
            cmd.Parameters.AddWithValue("@Equifax", l.Equifax);
            cmd.Parameters.AddWithValue("@Comment", l.Comment);
            cmd.Parameters.AddWithValue("@TransUnio", l.TransUnio);
            cmd.Parameters.AddWithValue("@Fico2", l.Fico2);
            cmd.Parameters.AddWithValue("@Fico3", l.Fico3);
            cmd.Parameters.AddWithValue("@Fico8", l.Fico8);
            cmd.Parameters.AddWithValue("@ClientId", l.ClientId);
            cmd.Parameters.AddWithValue("@Close", Convert.ToInt32(l.Close).ToString());
            cmd.Parameters.AddWithValue("@Source", Convert.ToInt32(l.Source).ToString());

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RemoveLoan2(string Id)
        {
            InquiriesC inq = new InquiriesC();
            inq.RemoveAllInqByLoan(Id);
            CAccountC cacc = new CAccountC();
            cacc.RemoveAllCAccByLoan(Id);
            //delete from DataBase
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Loans2 WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateLoan2(Loans2 l)
        {
            InquiriesC inq = new InquiriesC();
            inq.RemoveAllInqByLoan(l.Id.ToString());
            CAccountC cacc = new CAccountC();
            cacc.RemoveAllCAccByLoan(l.Id.ToString());            
            foreach (var v in l.InqList)
                inq.CreateInq(v);
            foreach (var v in l.CAccList)
                cacc.CreateCAcc(v);

            //change 
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "UPDATE Loans2 SET OpenCC=@OpenCC,Source=@Source,OpenRC=@OpenRC,OpenRELoans=@OpenRELoans,OpenILoans=@OpenILoans,TotalOpenAcc=@TotalOpenAcc,AcceverLate=@AcceverLate,CollectionAcc=@CollectionAcc,AvgAccAge=@AvgAccAge,OldestAcc=@OldestAcc,CRDebt=@CRDebt,REDebt=@REDebt,ILDebt=@ILDebt,CollectionDebt=@CollectionDebt,TDebt=@TDebt,PublicRecords=@PublicRecords,Experian=@Experian,Equifax=@Equifax,TransUnio=@TransUnio,Fico2=@Fico2,Fico3=@Fico3,Fico8=@Fico8,Comment=@Comment,ClientId=@ClientId,Close=@Close WHERE Id=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", l.Id);
            cmd.Parameters.AddWithValue("@OpenCC", l.OpenCC);
            cmd.Parameters.AddWithValue("@OpenRC", l.OpenRC);
            cmd.Parameters.AddWithValue("@OpenRELoans", l.OpenRELoans);
            cmd.Parameters.AddWithValue("@OpenILoans", l.OpenILoans);
            cmd.Parameters.AddWithValue("@TotalOpenAcc", l.TotalOpenAcc);
            cmd.Parameters.AddWithValue("@AcceverLate", l.AcceverLate);
            cmd.Parameters.AddWithValue("@CollectionAcc", l.CollectionAcc);
            cmd.Parameters.AddWithValue("@AvgAccAge", l.AvgAccAge);
            cmd.Parameters.AddWithValue("@OldestAcc", l.OldestAcc);
            cmd.Parameters.AddWithValue("@CRDebt", l.CRDebt);
            cmd.Parameters.AddWithValue("@REDebt", l.REDebt);
            cmd.Parameters.AddWithValue("@ILDebt", l.ILDebt);
            cmd.Parameters.AddWithValue("@CollectionDebt", l.CollectionDebt);
            cmd.Parameters.AddWithValue("@TDebt", l.TDebt);
            cmd.Parameters.AddWithValue("@PublicRecords", l.PublicRecords);
            cmd.Parameters.AddWithValue("@Experian", l.Experian);
            cmd.Parameters.AddWithValue("@Equifax", l.Equifax);
            cmd.Parameters.AddWithValue("@Comment", l.Comment);
            cmd.Parameters.AddWithValue("@TransUnio", l.TransUnio);
            cmd.Parameters.AddWithValue("@ClientId", l.ClientId);
            cmd.Parameters.AddWithValue("@Fico2", l.Fico2);
            cmd.Parameters.AddWithValue("@Fico3", l.Fico3);
            cmd.Parameters.AddWithValue("@Fico8", l.Fico8);
            cmd.Parameters.AddWithValue("@Close", Convert.ToInt32(l.Close).ToString());
            cmd.Parameters.AddWithValue("@Source", Convert.ToInt32(l.Source).ToString());
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Read from DB        
        public Loans2 FindLoan2(string id)
        {
            Loans2 l = new Loans2();
            //search
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Loans2 where Id=@id ", con);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                l.Id = id;
                l.OpenCC =reader["OpenCC"].ToString();
                l.OpenRC = reader["OpenRC"].ToString();
                l.OpenILoans = reader["OpenILoans"].ToString();
                l.TotalOpenAcc = reader["TotalOpenAcc"].ToString();
                l.AcceverLate = reader["AcceverLate"].ToString();
                l.CollectionAcc = reader["CollectionAcc"].ToString();
                l.AvgAccAge = reader["AvgAccAge"].ToString();
                l.OldestAcc = reader["OldestAcc"].ToString();
                l.CRDebt = reader["CRDebt"].ToString();
                l.REDebt = reader["REDebt"].ToString();
                l.ILDebt = reader["ILDebt"].ToString();
                l.CollectionDebt = reader["CollectionDebt"].ToString();
                l.TDebt = reader["TDebt"].ToString();
                l.PublicRecords = reader["PublicRecords"].ToString();
                l.Experian =reader["Experian"].ToString();
                l.Equifax =reader["Equifax"].ToString();
                l.TransUnio =reader["TransUnio"].ToString();
                l.Comment = reader["Comment"].ToString();
                l.ClientId = reader["ClientId"].ToString();
                l.Close = Convert.ToBoolean(Convert.ToInt32(reader["Close"].ToString()));
                l.Fico2= reader["Fico2"].ToString();
                l.Fico3 = reader["Fico3"].ToString();
                l.Fico8 = reader["Fico8"].ToString();
                l.Source = Convert.ToBoolean(Convert.ToInt32(reader["Source"].ToString()));
            }
            con.Close();
            InquiriesC inq = new InquiriesC();
            l.InqList = inq.ListOfInq(l.Id);
            CAccountC cacc = new CAccountC();
            l.CAccList = cacc.ListOfCAcc(l.Id);
            return l;
        }        
        public Loans2 FindLoan2ByClient(string Cid)
        {
            Loans2 l = new Loans2();
            //search
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Loans2 " , con);            
            // where ClientId=@id cmd.Parameters.AddWithValue("@close", Convert.ToInt32(false));
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                l.Close = Convert.ToBoolean(Convert.ToInt32(reader["Close"].ToString()));
                l.ClientId = reader["ClientId"].ToString();
                if (l.ClientId == Cid)
                    if (!l.Close)
                    {
                        l.Id = reader["id"].ToString();
                        l.OpenCC = reader["OpenCC"].ToString();
                        l.OpenRC = reader["OpenRC"].ToString();
                        l.OpenRELoans= reader["OpenRELoans"].ToString();
                        l.OpenILoans = reader["OpenILoans"].ToString();
                        l.TotalOpenAcc = reader["TotalOpenAcc"].ToString();
                        l.AcceverLate = reader["AcceverLate"].ToString();
                        l.CollectionAcc = reader["CollectionAcc"].ToString();
                        l.AvgAccAge = reader["AvgAccAge"].ToString();
                        l.OldestAcc = reader["OldestAcc"].ToString();
                        l.CRDebt = reader["CRDebt"].ToString();
                        l.REDebt = reader["REDebt"].ToString();
                        l.ILDebt = reader["ILDebt"].ToString();
                        l.CollectionDebt = reader["CollectionDebt"].ToString();
                        l.TDebt = reader["TDebt"].ToString();
                        l.PublicRecords = reader["PublicRecords"].ToString();
                        l.Experian = reader["Experian"].ToString();
                        l.Equifax = reader["Equifax"].ToString();
                        l.TransUnio = reader["TransUnio"].ToString();
                        l.Fico2 = reader["Fico2"].ToString();
                        l.Fico3 = reader["Fico3"].ToString();
                        l.Fico8 = reader["Fico8"].ToString();
                        l.Comment = reader["Comment"].ToString();
                        l.Source = Convert.ToBoolean(Convert.ToInt32(reader["Source"].ToString()));                    
                    }
            }
            con.Close();
            InquiriesC inq = new InquiriesC();
            l.InqList = inq.ListOfInq(l.Id);
            CAccountC cacc = new CAccountC();
            l.CAccList = cacc.ListOfCAcc(l.Id);
            return l;
        }
        public List<Loans2> AllOpenLoans2()

        {
            List<Loans2> myL = new List<Loans2>();
            //search
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Loans2 where Close=@close", con);
            cmd.Parameters.AddWithValue("@close", Convert.ToInt32(false));
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Loans2 l = new Loans2();
                l.Id = reader["id"].ToString();
                l.OpenCC = reader["OpenCC"].ToString();
                l.OpenRC = reader["OpenRC"].ToString();
                l.OpenILoans = reader["OpenILoans"].ToString();
                l.TotalOpenAcc = reader["TotalOpenAcc"].ToString();
                l.AcceverLate = reader["AcceverLate"].ToString();
                l.CollectionAcc = reader["CollectionAcc"].ToString();
                l.AvgAccAge = reader["AvgAccAge"].ToString();
                l.OldestAcc = reader["OldestAcc"].ToString();
                l.CRDebt = reader["CRDebt"].ToString();
                l.REDebt = reader["REDebt"].ToString();
                l.ILDebt = reader["ILDebt"].ToString();
                l.CollectionDebt = reader["CollectionDebt"].ToString();
                l.TDebt = reader["TDebt"].ToString();
                l.PublicRecords = reader["PublicRecords"].ToString();
                l.Experian = reader["Experian"].ToString();
                l.Equifax = reader["Equifax"].ToString();
                l.TransUnio = reader["TransUnio"].ToString();
                l.Fico2 = reader["Fico2"].ToString();
                l.Fico3 = reader["Fico3"].ToString();
                l.Fico8 = reader["Fico8"].ToString();
                l.Comment = reader["Comment"].ToString();
                l.ClientId = reader["ClientId"].ToString();
                l.Close = Convert.ToBoolean(Convert.ToInt32(reader["Close"].ToString()));
                l.Source = Convert.ToBoolean(Convert.ToInt32(reader["Source"].ToString()));
                myL.Add(l);
            }
            con.Close();
            return myL;
        }
        public bool checkIfExist(string cliebntId)
        {
            bool ans = false;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Loans2", con);
             MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(reader["ClientId"].ToString()==cliebntId&&reader["Close"].ToString()==Convert.ToInt32(false).ToString())
                ans = true;
            }
            con.Close();
            return ans;
        }
    }
}
#endregion