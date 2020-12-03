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
    public class InquiriesC
    {

        MySqlConnection con = new MySqlConnection("server=3.84.165.5;user id=root;port=3306;database=Cavalry;Password=cavalry1234;");
        #region Write to DB
        public void CreateInq(Inquiries i)
        {
            if(i.Id==-1)
                i.Id = getId();
                            
            //insert to DB
            //check if someone already use the database and wait if necessary
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "INSERT INTO Inquiries (Id,NameOfBank,InquiryDate,RemovalDate,BusinessType,ContactInformation,LoansId) VALUES (@Id,@NameOfBank,@InquiryDate,@RemovalDate,@BusinessType,@ContactInformation,@LoansId)";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", i.Id);
            cmd.Parameters.AddWithValue("@NameOfBank", i.NameOfBank);
            cmd.Parameters.AddWithValue("@InquiryDate", i.InquiryDate);
            cmd.Parameters.AddWithValue("@RemovalDate", i.RemovalDate);
            cmd.Parameters.AddWithValue("@BusinessType", i.BusinessType);
            cmd.Parameters.AddWithValue("@ContactInformation", i.ContactInformation);
            cmd.Parameters.AddWithValue("@LoansId", i.LoansId);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RemoveInq(int Id)
        {
            //delete from DataBase
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM Inquiries WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateInq(Inquiries i)
        {
            //change 
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "UPDATE Inquiries SET NameOfBank=@NameOfBank,InquiryDate=@InquiryDate,RemovalDate=@RemovalDate,BusinessType=@BusinessType,ContactInformation=@ContactInformation,LoansId=@LoansId WHERE Id=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", i.Id);
            cmd.Parameters.AddWithValue("@NameOfBank", i.NameOfBank);
            cmd.Parameters.AddWithValue("@InquiryDate", i.InquiryDate);
            cmd.Parameters.AddWithValue("@RemovalDate", i.RemovalDate);
            cmd.Parameters.AddWithValue("@BusinessType", i.BusinessType);
            cmd.Parameters.AddWithValue("@ContactInformation", i.ContactInformation);
            cmd.Parameters.AddWithValue("@LoansId", i.LoansId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RemoveAllInqByLoan(string lId)
        {
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM Inquiries WHERE LoansId = @id", con);
            cmd.Parameters.AddWithValue("@id", lId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Read from DB
        public int getId()

        {
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            int i = 0;
            
            MySqlCommand cmd = new MySqlCommand("select id from LastId where db=@db", con);
            cmd.Parameters.AddWithValue("@db", "Inquiries");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i = Convert.ToInt32(reader["id"].ToString());
            }
            con.Close();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            int id = i + 1;
            string query = "UPDATE LastId SET id=@Id WHERE db=@db";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@db", "Inquiries");
            cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public List<Inquiries> ListOfInq(string loanId)
        {
            List<Inquiries> l = new List<Inquiries>();

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Inquiries where LoansId=@id", con);
            cmd.Parameters.AddWithValue("@id", loanId);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Inquiries inq = new Inquiries();
                inq.Id = Convert.ToInt32(reader["Id"].ToString());
                inq.NameOfBank = reader["NameOfBank"].ToString();
                inq.InquiryDate = reader["InquiryDate"].ToString();
                inq.RemovalDate= reader["RemovalDate"].ToString();
                inq.BusinessType = reader["BusinessType"].ToString();
                inq.ContactInformation = reader["ContactInformation"].ToString();
                inq.LoansId = reader["LoansId"].ToString();
                l.Add(inq);
            }
            con.Close();
            return l;
        }
        public Inquiries FindInq(int Id)
        {
            Inquiries inq = new Inquiries();

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            MySqlCommand cmd = new MySqlCommand("select * from Inquiries where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", Id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                inq.Id = Convert.ToInt32(reader["Id"].ToString());
                inq.NameOfBank = reader["NameOfBank"].ToString();
                inq.InquiryDate = reader["InquiryDate"].ToString();
                inq.RemovalDate = reader["RemovalDate"].ToString();
                inq.BusinessType = reader["BusinessType"].ToString();
                inq.ContactInformation = reader["ContactInformation"].ToString();
                inq.LoansId = reader["LoansId"].ToString();
            }
            return inq;
        }
        #endregion
    }
}
