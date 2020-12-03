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
    public class CategoryC
    {
        MySqlConnection con = new MySqlConnection("server=3.84.165.5;user id=root;port=3306;database=Cavalry;Password=cavalry1234;");
        public bool searchIfNewMainC(string name)
        {
            bool ans = true;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from MainCategory";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Name"].ToString() == name)
                    ans = false;

            }
            con.Close();
            return ans;
        }
        public bool searchIfEx(string name,string kind)
        {
            bool ans = false;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Category";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["name"].ToString() == name)
                    if(reader["kind"].ToString() == kind)
                        ans = true;

            }
            con.Close();
            return ans;
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
            cmd.Parameters.AddWithValue("@db", "Category");
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
            cmd.Parameters.AddWithValue("@db", "Category");
            cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public int mgetId()
        {
            int i = 0;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }            
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select id from LastId where db=@db", con);
            cmd.Parameters.AddWithValue("@db", "MainCategory");
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
            cmd.Parameters.AddWithValue("@db", "MainCategory");
            cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public int findMainCId(string name)
        {
            int id = 0;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select id from MainCategory where name=@db", con);
            cmd.Parameters.AddWithValue("@db", name);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["id"].ToString());
            }
            con.Close();
            return id;
        }
        public string findMainCName(int id)
        {
            string name = "";
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from MainCategory where Id=@db", con);
            cmd.Parameters.AddWithValue("@db", id);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader["name"].ToString();
            }
            con.Close();
            return name;
        }
        public void DeleteCategory(int Id)
        {
            while (con.State == ConnectionState.Open)
                System.Threading.Thread.Sleep(500);
            con.Open();
            string query = "DELETE FROM Category WHERE Id=@Id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void InsertCategory(Category c)
        {
            c.id = getId();
            int mid = 0;
            bool newM = false;
            c.id = getId();
            if (searchIfNewMainC(c.mainC))
            {
                mid = mgetId();
                newM = true;
            }
            else
            {
                mid = findMainCId(c.mainC);
            }
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query1 = "";
            MySqlCommand cmd;
            if (newM)
            {
                query1 = "INSERT INTO MainCategory (Id,name) VALUES (@Id,@name)";
                cmd = new MySqlCommand(query1, con);
                cmd.Parameters.AddWithValue("@Id", mid);
                cmd.Parameters.AddWithValue("@name", c.mainC);
                cmd.ExecuteNonQuery();
            }
            query1 = "INSERT INTO Category (Id,name,mainC,kind) VALUES (@Id,@name,@mainC,@kind)";
            cmd = new MySqlCommand(query1, con);

            cmd.Parameters.AddWithValue("@Id", c.id);
            cmd.Parameters.AddWithValue("@name", c.name);
            cmd.Parameters.AddWithValue("@mainC", mid);
            cmd.Parameters.AddWithValue("@kind", c.kind);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Category returnCategory(int id)
        {
            Category c = new Category();
            while (con.State == ConnectionState.Open)
                System.Threading.Thread.Sleep(500);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From Category WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                c.id = Convert.ToInt32(reader[0].ToString());
                c.name = reader[1].ToString();
                c.mainC = reader[2].ToString();
                c.kind = reader[3].ToString();
            }
            con.Close();
            return c;

        }
        public List<string> AllCategories()
        {
            List<string> l = new List<string>();
            while (con.State == ConnectionState.Open)
                System.Threading.Thread.Sleep(500);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Category Order by mainC,name";
            string mainc = "";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (mainc != reader["mainC"].ToString())
                {
                    l.Add("@@@@@@@@"+reader["mainC"].ToString());
                    mainc = reader["mainC"].ToString();
                }
                    l.Add(reader["name"].ToString());
            }
            con.Close();
            List<string> myL = new List<string>();
            foreach(var v in l)
            {
                if (v.Contains("@@@@@@@@"))
                {
                    myL.Add(findMainCName(Convert.ToInt32(v.Substring(8, v.Length - 8))).ToUpper());
                }
                else
                    myL.Add(v);
            }
            return myL;
        }
        public List<string> AllCategoriesByKind(string kind)
        {
            List<string> l = new List<string>();
            while (con.State == ConnectionState.Open)
                System.Threading.Thread.Sleep(500);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Category Order by mainC,name";
            string mainc = "";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                if (mainc != reader["mainC"].ToString())
                {
                    l.Add("@@@@@@@@" + reader["mainC"].ToString());
                    mainc = reader["mainC"].ToString();
                }
                if(reader["kind"].ToString()==kind|| reader["kind"].ToString() =="All")
                    l.Add(reader["name"].ToString());
            }
            con.Close();
            List<string> myL = new List<string>();
            foreach (var v in l)
            {
                if (v.Contains("@@@@@@@@"))
                {
                    string s= findMainCName(Convert.ToInt32(v.Substring(8, v.Length - 8))).ToUpper();
                    if (!s.Contains("NO MAIN CATEGORY")) 
                    myL.Add(s);
                }
                else
                    myL.Add(v);
            }
            return myL;
        }
        public List<string> AllMainC()
        {
            List<string> l = new List<string>();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from MainCategory", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                l.Add(reader["name"].ToString());
            }
            con.Close();
            return l;
        }
        public List<CatWithMain> CategoryList()
        {
            List<CatWithMain> l = new List<CatWithMain>();
            List<Category> littleL = new List<Category>();
            while (con.State == ConnectionState.Open)
                System.Threading.Thread.Sleep(500);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Category ORDER BY mainC";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category c = new Category();
                c.id = Convert.ToInt32(reader["id"].ToString());
                c.name = reader["name"].ToString();
                c.mainC = reader["mainC"].ToString();
                c.kind = reader["kind"].ToString();
                littleL.Add(c);
                
            }
            con.Close();
            foreach(var v in littleL)
            {
                l.Add(new CatWithMain(v.id, v.name, v.mainC, v.kind, findMainCName(Convert.ToInt32(v.mainC))));
            }
            return l;
            //List<Category> l = new List<Category>();
            //while (con.State == ConnectionState.Open)
            //    System.Threading.Thread.Sleep(500);
            //con.Open();
            //MySqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from Category";

            //MySqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Category c = new Category();
            //    c.id = Convert.ToInt32(reader["id"].ToString());
            //    c.name=reader["name"].ToString();
            //    c.mainC = reader["mainC"].ToString();
            //    c.kind = reader["kind"].ToString();
            //    l.Add(c);
            //}
            //con.Close();

            //return l;
        }
        public bool IsSameExist(Category c)
        {
            bool ans = false;
            while (con.State == ConnectionState.Open)
                System.Threading.Thread.Sleep(500);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From Category WHERE name=@name AND mainC=@mainC AND kind=@kind", con);
            cmd.Parameters.AddWithValue("@name", c.name);
            cmd.Parameters.AddWithValue("@mainC", c.mainC);
            cmd.Parameters.AddWithValue("@kind", c.kind);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ans = true;
            }
            return ans;
        }

    }
}