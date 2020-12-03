using Basic.ManagerAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToDB.ManagerAccess
{
    public class ReqDocsC
    {
        MySqlConnection con = new MySqlConnection("server=3.84.165.5;user id=root;port=3306;database=Cavalry;Password=cavalry1234;");
        #region function
        public int getId()
        {
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            int i = 0;            
            MySqlCommand cmd = new MySqlCommand("select id from LastId where db=@db", con);
            cmd.Parameters.AddWithValue("@db", "ReqDoc");
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
            cmd.Parameters.AddWithValue("@db", "ReqDoc");
            cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        #endregion
        public void insertDB(ReqDocs r)
        {
            r.Id = getId();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query1 = "INSERT INTO ReqDocs (Id,clientId,kind,comment) VALUES (@Id,@clientId,@kind,@comment)";
            MySqlCommand cmd = new MySqlCommand(query1, con);
            cmd.Parameters.AddWithValue("@Id", r.Id);
            cmd.Parameters.AddWithValue("@clientId", r.clientId);
            cmd.Parameters.AddWithValue("@kind", r.kind);
            cmd.Parameters.AddWithValue("@comment", r.comment);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int findByUserAndKind(string userId,string kind)
        {
            int i = 0;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select Id from ReqDocs where clientId=@id AND kind=@kind";
            cmd.Parameters.AddWithValue("@id", userId);
            cmd.Parameters.AddWithValue("@kind", kind);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {                
                i = Convert.ToInt32(reader[0].ToString());
            }
            con.Close();
                return i;
        }
        public void deleteDB(int id)
        {
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "DELETE FROM ReqDocs WHERE Id=@Id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<ReqDocs> ListsOfReqDocs(string id)
        {
            List<ReqDocs> l = new List<ReqDocs>();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from ReqDocs where clientId=@id";
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReqDocs rd = new ReqDocs();
                rd.Id = Convert.ToInt32(reader[0].ToString());
                rd.clientId = reader[1].ToString();
                rd.kind = reader[2].ToString();
                rd.comment = reader[3].ToString();
                l.Add(rd);
            }
            con.Close();
            return l;

        }
        public ReqDocs returnReqDoc(int id)
        {
            ReqDocs rd = new ReqDocs();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from ReqDocs where Id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rd.Id = Convert.ToInt32(reader[0].ToString());
                rd.clientId = reader[1].ToString();
                rd.kind = reader[2].ToString();
                rd.comment = reader[3].ToString();
            }
            return rd;
        }
    }
}
