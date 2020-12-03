using Basic.Loan;
using Basic.SoftwareUsers;
using ConnectToDB.UsersCommand;
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
    public class Loans1C
    {
        MySqlConnection con = new MySqlConnection("server=3.84.165.5;user id=root;port=3306;database=Cavalry;Password=cavalry1234;");
        #region Write to DB
        public void CreateLoan1(Loans1 l)
        {
            l.Id = getId();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "INSERT INTO Loans1 (Id,BusinessName,DBAName,Pcontact,TaxID,SS,Tel,Mail,Street,Own,City,State,Zip,Mstreet,Mcity,Mstate,Mzip,Chose1,DateBE,StateoOI,EmployeesNum,Explains,Chose2,Acompanies,Approved,ClientId,Close) VALUES (@Id,@BusinessName,@DBAName,@Pcontact,@TaxID,@SS,@Tel,@Mail,@Street,@Own,@City,@State,@Zip,@Mstreet,@Mcity,@Mstate,@Mzip,@Chose1,@DateBE,@StateoOI,@EmployeesNum,@Explain,@Chose2,@Acompanies,@Approved,@ClientId,@Close)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", l.Id);
            cmd.Parameters.AddWithValue("@BusinessName", l.BusinessName);
            cmd.Parameters.AddWithValue("@DBAName", l.DBAName);
            cmd.Parameters.AddWithValue("@Pcontact", l.Pcontact);
            cmd.Parameters.AddWithValue("@TaxID", l.TaxID);
            cmd.Parameters.AddWithValue("@SS", l.SS);
            cmd.Parameters.AddWithValue("@Tel", l.Tel);
            cmd.Parameters.AddWithValue("@Mail", l.Mail);
            cmd.Parameters.AddWithValue("@Street", l.Street);
            cmd.Parameters.AddWithValue("@Own", l.Own);
            cmd.Parameters.AddWithValue("@City", l.City);
            cmd.Parameters.AddWithValue("@State", l.State);
            cmd.Parameters.AddWithValue("@Zip", l.Zip);
            cmd.Parameters.AddWithValue("@Mstreet", l.Mstreet);
            cmd.Parameters.AddWithValue("@Mcity", l.Mcity);
            cmd.Parameters.AddWithValue("@Mstate", l.Mstate);
            cmd.Parameters.AddWithValue("@Mzip", l.Mzip);
            cmd.Parameters.AddWithValue("@Chose1", l.Chose1);
            cmd.Parameters.AddWithValue("@DateBE", l.DateBE);
            cmd.Parameters.AddWithValue("@StateoOI", l.StateoOI);
            cmd.Parameters.AddWithValue("@EmployeesNum", l.EmployeesNum);
            cmd.Parameters.AddWithValue("@Explain", l.Explains);
            cmd.Parameters.AddWithValue("@Chose2", l.Chose2);
            cmd.Parameters.AddWithValue("@Acompanies", l.Acompanies);
            cmd.Parameters.AddWithValue("@Approved", l.Approved);
            cmd.Parameters.AddWithValue("@ClientId", l.ClientId);
            cmd.Parameters.AddWithValue("@Close",Convert.ToInt32(l.Close));
            cmd.ExecuteNonQuery();
            con.Close();
            ClientC inter = new ClientC();
            Client c = inter.FindClient(l.ClientId);
            c.MiddleProcess = "1";
            inter.UpdateClient(c);

        }
        public void RemoveLoan1(int Id)
        {
            //delete from DataBase
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Loans1 WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateLoan1(Loans1 l)
        {
            //change 
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "UPDATE Loans1 SET BusinessName=@BusinessName,DBAName=@DBAName,Pcontact=@Pcontact,TaxID=@TaxID,SS=@SS,Tel=@Tel,Mail=@Mail,Street=@Street,Own=@Own,City=@City,State=@State,Zip=@Zip,Mstreet=@Mstreet,Mcity=@Mcity,Mstate=@Mstate,Mzip=@Mzip,Chose1=@Chose1,DateBE=@DateBE,StateoOI=@StateoOI,EmployeesNum=@EmployeesNum,Explains=@Explain,Chose2=@Chose2,Acompanies=@Acompanies,Approved=@Approved,ClientId=@ClientId,Close=@Close WHERE Id=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", l.Id);
            cmd.Parameters.AddWithValue("@BusinessName", l.BusinessName);
            cmd.Parameters.AddWithValue("@DBAName", l.DBAName);
            cmd.Parameters.AddWithValue("@Pcontact", l.Pcontact);
            cmd.Parameters.AddWithValue("@TaxID", l.TaxID);
            cmd.Parameters.AddWithValue("@SS", l.SS);
            cmd.Parameters.AddWithValue("@Tel", l.Tel);
            cmd.Parameters.AddWithValue("@Mail", l.Mail);
            cmd.Parameters.AddWithValue("@Street", l.Street);
            cmd.Parameters.AddWithValue("@Own", l.Own);
            cmd.Parameters.AddWithValue("@City", l.City);
            cmd.Parameters.AddWithValue("@State", l.State);
            cmd.Parameters.AddWithValue("@Zip", l.Zip);
            cmd.Parameters.AddWithValue("@Mstreet", l.Mstreet);
            cmd.Parameters.AddWithValue("@Mcity", l.Mcity);
            cmd.Parameters.AddWithValue("@Mstate", l.Mstate);
            cmd.Parameters.AddWithValue("@Mzip", l.Mzip);
            cmd.Parameters.AddWithValue("@Chose1", l.Chose1);
            cmd.Parameters.AddWithValue("@DateBE", l.DateBE);
            cmd.Parameters.AddWithValue("@StateoOI", l.StateoOI);
            cmd.Parameters.AddWithValue("@EmployeesNum", l.EmployeesNum);
            cmd.Parameters.AddWithValue("@Explain", l.Explains);
            cmd.Parameters.AddWithValue("@Chose2", l.Chose2);
            cmd.Parameters.AddWithValue("@Acompanies", l.Acompanies);
            cmd.Parameters.AddWithValue("@Approved", l.Approved);
            cmd.Parameters.AddWithValue("@ClientId", l.ClientId);
            cmd.Parameters.AddWithValue("@Close", Convert.ToInt32(l.Close));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Read from DB
        public int getId()
        {
            int i = 0;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }           
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select id from LastId where db=@db", con);
            cmd.Parameters.AddWithValue("@db", "Loans1");
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
            cmd.Parameters.AddWithValue("@db", "Loan1");
            cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }        
        public Loans1 FindLoan1(string id)
        {
            Loans1 l = new Loans1();
            //search
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Loans1 where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                l.Id = int.Parse(id);
                l.BusinessName = reader["BusinessName"].ToString();
                l.DBAName = reader["DBAName"].ToString();
                l.Pcontact = reader["Pcontact"].ToString();
                l.TaxID = reader["TaxID"].ToString();
                l.SS = reader["SS"].ToString();
                l.Tel = reader["Tel"].ToString();
                l.Street = reader["Street"].ToString();
                l.Own = Convert.ToBoolean(int.Parse(reader["Own"].ToString()));
                l.City = reader["City"].ToString();
                l.State = reader["State"].ToString();
                l.Zip = reader["Zip"].ToString();
                l.Mstreet = reader["Mstreet"].ToString();
                l.Mcity = reader["Mcity"].ToString();
                l.Mstate = reader["Mstate"].ToString();
                l.Mzip = reader["Mzip"].ToString();
                l.Chose1 = reader["Chose1"].ToString();
                l.DateBE = reader["DateBE"].ToString();
                l.StateoOI = reader["StateoOI"].ToString();
                l.EmployeesNum = reader["EmployeesNum"].ToString();
                l.Explains = reader["Explains"].ToString();
                l.Chose2 = reader["Chose2"].ToString();
                l.Acompanies = reader["Acompanies"].ToString();
                l.Approved = Convert.ToBoolean(int.Parse(reader["Approved"].ToString()));
                l.ClientId = reader["ClientId"].ToString();
                l.Close = Convert.ToBoolean(int.Parse(reader["Close"].ToString()));
            }
            con.Close();
            return l;
        }
        public Loans1 FindLoan1ByClient(string Cid)
        {
            Loans1 l = new Loans1();
            l.Id = -1;
            //search
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Loans1 where ClientId=@id AND Close=@close", con);
            cmd.Parameters.AddWithValue("@id", Cid);
            cmd.Parameters.AddWithValue("@close", Convert.ToInt32(false));
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                l.Id = int.Parse(reader["id"].ToString());
                l.BusinessName = reader["BusinessName"].ToString();
                l.DBAName = reader["DBAName"].ToString();
                l.Pcontact = reader["Pcontact"].ToString();
                l.TaxID = reader["TaxID"].ToString();
                l.SS = reader["SS"].ToString();
                l.Tel = reader["Tel"].ToString();
                l.Mail = reader["Mail"].ToString();
                l.Street = reader["Street"].ToString();
                l.Own = Convert.ToBoolean(int.Parse(reader["Own"].ToString()));
                l.City = reader["City"].ToString();
                l.State = reader["State"].ToString();
                l.Zip = reader["Zip"].ToString();
                l.Mstreet = reader["Mstreet"].ToString();
                l.Mcity = reader["Mcity"].ToString();
                l.Mstate = reader["Mstate"].ToString();
                l.Mzip = reader["Mzip"].ToString();
                l.Chose1 = reader["Chose1"].ToString();
                l.DateBE = reader["DateBE"].ToString();
                l.StateoOI = reader["StateoOI"].ToString();
                l.EmployeesNum = reader["EmployeesNum"].ToString();
                l.Explains = reader["Explains"].ToString();
                l.Chose2 = reader["Chose2"].ToString();
                l.Acompanies = reader["Acompanies"].ToString();
                l.Approved = Convert.ToBoolean(int.Parse(reader["Approved"].ToString()));
                l.ClientId = reader["ClientId"].ToString();
                l.Close = Convert.ToBoolean(int.Parse(reader["Close"].ToString()));
            }
            con.Close();
            return l;
        }
        public List<Loans1> AllOpenLoans1()

        {
            List<Loans1> myL = new List<Loans1>();
            //search
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Loans1 where Close=@close", con);            
            cmd.Parameters.AddWithValue("@close", Convert.ToInt32(false));
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Loans1 l = new Loans1();
                l.Id = int.Parse(reader["id"].ToString());
                l.BusinessName = reader["BusinessName"].ToString();
                l.DBAName = reader["DBAName"].ToString();
                l.Pcontact = reader["Pcontact"].ToString();
                l.TaxID = reader["TaxID"].ToString();
                l.SS = reader["SS"].ToString();
                l.Tel = reader["Tel"].ToString();
                l.Street = reader["Street"].ToString();
                l.Own = Convert.ToBoolean(int.Parse(reader["Own"].ToString()));
                l.City = reader["City"].ToString();
                l.State = reader["State"].ToString();
                l.Zip = reader["Zip"].ToString();
                l.Mstreet = reader["Mstreet"].ToString();
                l.Mcity = reader["Mcity"].ToString();
                l.Mstate = reader["Mstate"].ToString();
                l.Mzip = reader["Mzip"].ToString();
                l.Chose1 = reader["Chose1"].ToString();
                l.DateBE = reader["DateBE"].ToString();
                l.StateoOI = reader["StateoOI"].ToString();
                l.EmployeesNum = reader["EmployeesNum"].ToString();
                l.Explains = reader["Explains"].ToString();
                l.Chose2 = reader["Chose2"].ToString();
                l.Acompanies = reader["Acompanies"].ToString();
                l.Approved = Convert.ToBoolean(int.Parse(reader["Approved"].ToString()));
                l.ClientId = reader["ClientId"].ToString();
                l.Close = Convert.ToBoolean(int.Parse(reader["Close"].ToString()));
                myL.Add(l);
            }
            con.Close();
            return myL;
        }
        #endregion

    }
}
