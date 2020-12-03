using Basic.SoftwareUsers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToDB.UsersCommand
{
    public class UserC
    {

        MySqlConnection con = new MySqlConnection("server=3.84.165.5;user id=root;port=3306;database=Cavalry;Password=cavalry1234;");
        //local DB
        static List<User> users = new List<User>();
        #region Write
        public void CreateUser(User u)
        {
           
            //insert to DB
            //check if someone already use the database and wait if necessary
             u.Id = getID();
            while(con.State==ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "INSERT INTO User (Id,Mail,Password,Fname,Lname,MobileNum,Status) VALUES (@Id,@mail,@password,@fname,@lname,@mobilenum,@status)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", u.Id);
            cmd.Parameters.AddWithValue("@mail", u.Mail);
            cmd.Parameters.AddWithValue("@password",u.Password);
            cmd.Parameters.AddWithValue("@fname", u.Fname);
            cmd.Parameters.AddWithValue("@lname", u.Lname);
            cmd.Parameters.AddWithValue("@mobilenum", u.MobileNum);
            cmd.Parameters.AddWithValue("@status", u.Status);
         
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void RemoveUser(User u)
        {
           
            //delete from DB
            //check if someone already use the database and wait if necessary
            if(u.Status=="Client")
            {
                ClientC c = new ClientC();
                c.RemoveClient(c.FindClient(u.Id.ToString()));
            }
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM User WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", u.Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateUser(User u)
        {
            //if there are emty field fill them and than do the changes
            User u1 = FindUser(u.Id);
            if (u.Mail == "")
                u.Mail = u1.Mail;
            if (u.Fname == "")
                u.Fname = u1.Fname;
            if (u.Lname == "")
                u.Lname = u1.Lname;
            if (u.Password == "")
                u.Password = u1.Password;
            if (u.MobileNum == "")
                u.MobileNum = u1.MobileNum;
            if (u.Status == "")
                u.Status = u1.Status;
            //change
            
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "UPDATE User SET Mail=@mail,Password=@password,Fname=@fname,Lname=@lname,MobileNum=@mobilenum,Status=@status WHERE Id=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@mail",u.Mail);
            cmd.Parameters.AddWithValue("@password", u.Password);
            cmd.Parameters.AddWithValue("@fname", u.Fname);
            cmd.Parameters.AddWithValue("@lname", u.Lname);
            cmd.Parameters.AddWithValue("@mobilenum", u.MobileNum);
            cmd.Parameters.AddWithValue("@status",u.Status);
            cmd.Parameters.AddWithValue("@id", u.Id);
            cmd.ExecuteNonQuery();
            con.Close();
           
            foreach (var v in users)
                if (v.Id == u.Id)
                {
                    users.Remove(v);
                    break;
                }
            users.Add(u);
        }

        #endregion
        #region Read
        public string FindNeedEmail(string kind,string uid)
        {
            string email = "";
            if (kind == "Manager")
                email = "cavalryassociatesmailbox@gmail.com";

            return email;
        }
        public string getID()
        {
            int i = 0;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select id from LastId where db=@db", con);
            cmd.Parameters.AddWithValue("@db", "User");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i = Convert.ToInt32(reader["id"].ToString());
            }
            int id = i + 1;
            con.Close();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "UPDATE LastId SET id=@Id WHERE db=@db";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@db", "User");
            cmd.ExecuteNonQuery();
            con.Close();
            return i.ToString();
        }
        public User FindUser(string Id)
        {
            User u = new User();
             //find
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from User where Id=@id", con);
            cmd.Parameters.AddWithValue("@id",Id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u.Id = Id;
                u.Fname = reader["Fname"].ToString();
                u.Lname= reader["Lname"].ToString();
                u.Password = reader["Password"].ToString();
                u.Mail = reader["Mail"].ToString();
                u.Status = reader["Status"].ToString();
                u.MobileNum = reader["MobileNum"].ToString();
            }
            con.Close();
            
            return u;
        }
        public User FindUserByMail(string mail)
        {

            User u = new User();
            //find
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from User where Mail=@mail", con);
            cmd.Parameters.AddWithValue("@mail",mail);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u.Id = reader["Id"].ToString(); 
                u.Fname = reader["Fname"].ToString();
                u.Lname= reader["Lname"].ToString();
                u.Password = reader["Password"].ToString();
                u.Mail = reader["Mail"].ToString();
                u.Status = reader["Status"].ToString();
                u.MobileNum = reader["MobileNum"].ToString();
            }
            con.Close();
            
            return u;
        }
        public bool CheckIfExist(string mail)
        {
            bool ans = false;
            //check if one of the user already have the mail

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select Mail from User where Mail=@mail", con);
            cmd.Parameters.AddWithValue("@mail", mail);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ans = true;
            }
            con.Close();

            return ans;
        }
        public List<User> UnknownUsers()
        {
            List<User> l = new List<User>();
            //return all the user that the user status =="Unknown"
           
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from User where Status=@status", con);
            cmd.Parameters.AddWithValue("@status", "Unknown");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User u = new User();
                u.Id = reader["Id"].ToString();
                u.Fname = reader["Fname"].ToString();
                u.Lname = reader["Lname"].ToString();
                u.Password = reader["Password"].ToString();
                u.Mail = reader["Mail"].ToString();
                u.Status = reader["Status"].ToString();
                u.MobileNum = reader["MobileNum"].ToString();
                l.Add(u); 
            }
            con.Close();
           
            foreach (var v in users)
                if (v.Status == "Unknown")
                    l.Add(v);
            return l;
        }
        #endregion


    }
}
