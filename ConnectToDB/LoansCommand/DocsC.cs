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
    public class DocsC
    {
        MySqlConnection con = new MySqlConnection("server=3.84.165.5;user id=root;port=3306;database=Cavalry;Password=cavalry1234;");
        public int getId()
        {
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            int i = 0;
            MySqlCommand cmd = new MySqlCommand("select id from LastId where db=@db", con);
            cmd.Parameters.AddWithValue("@db", "Docs");
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
            cmd.Parameters.AddWithValue("@db", "Docs");
            cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public void insertDb(Docs p)
        {
            p.Id = getId();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "insert into Docs values (@id,@clientId,@Name, @ContentType, @Data,@Request)";
            MySqlCommand cmd = new MySqlCommand(query);

            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.Parameters.AddWithValue("@clientId", p.clientId);
            cmd.Parameters.AddWithValue("@Name", p.Name);
            cmd.Parameters.AddWithValue("@ContentType", p.ContentType);
            cmd.Parameters.AddWithValue("@Data", p.Data);
            cmd.Parameters.AddWithValue("@Request", p.Request);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void deleteDb(int id)
        {
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Docs WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Docs findProofdoc(int id)
        {
            Docs p = new Docs();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                cmd.CommandText = "select Name, Data, ContentType,Request from Docs where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Connection = con;
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    p.Data = (byte[])sdr["Data"];
                    p.ContentType = sdr["ContentType"].ToString();
                    p.Name = sdr["Name"].ToString();
                    p.Request = sdr["Request"].ToString();
                }
                con.Close();
            }
            return p;
        }
        public Docs findSfdoc(string uid)
        {
            Docs p = new Docs();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                while (con.State == ConnectionState.Open)
                {
                    System.Threading.Thread.Sleep(500);
                }
                con.Open();
                cmd.CommandText = "select * from Docs where clientId=@cid AND Request=@Request";
               
                cmd.Parameters.AddWithValue("@cid", uid);
                cmd.Parameters.AddWithValue("@Request", "Source Loan 2");                
                cmd.Connection = con;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    p.Data = (byte[])reader["Data"];
                    p.ContentType = reader["ContentType"].ToString();
                    p.Name = reader["Name"].ToString();
                    p.Request = reader["Request"].ToString();
                }
                con.Close();
            }
            return p;
        }
        public List<Docs> findList(string mail)
        {
            List<Docs> l = new List<Docs>();
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Docs where clientId=@clientmail", con);
            cmd.Parameters.AddWithValue("@clientmail", mail);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Docs p = new Docs();
                p.Id = Convert.ToInt32(reader["Id"].ToString());
                p.clientId = reader["clientId"].ToString();
                p.Name = reader["Name"].ToString();
                p.ContentType = reader["ContentType"].ToString();
                p.Data = (byte[])reader["Data"];
                p.Request = reader["Request"].ToString();
                l.Add(p);
            }

            con.Close();
            return l;
        }
    }
}
