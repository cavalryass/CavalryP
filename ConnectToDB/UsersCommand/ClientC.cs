using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basic.SoftwareUsers;
using MySql.Data.MySqlClient;

namespace ConnectToDB.UsersCommand
{
    public class ClientC
    {
        MySqlConnection con = new MySqlConnection("server=3.84.165.5;user id=root;port=3306;database=Cavalry;Password=cavalry1234;");
        #region Write to DB
        public void CreateClient(Client c)
        {
            //insert to DB
            //check if someone already use the database and wait if necessary
            UserC u = new UserC();
            c.Id = u.FindUserByMail(c.Mail).Id;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "INSERT INTO Client (Id,Mail,Fname,Lname,CompanyName,Address,Suite,City,State,Zip,WorkNum,HomeNum,MobileNum,Fax,SalesRep,Memo,MiddleProcess,Request) VALUES (@Id,@Mail,@Fname,@Lname,@CompanyName,@Address,@Suite,@City,@State,@Zip,@WorkNum,@HomeNum,@MobileNum,@Fax,@SalesRep,@Memo,@MiddleProcess,@Request)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", c.Id);
            cmd.Parameters.AddWithValue("@Mail", c.Mail);
            cmd.Parameters.AddWithValue("@Fname", c.Fname);
            cmd.Parameters.AddWithValue("@Lname", c.Lname);
            cmd.Parameters.AddWithValue("@CompanyName", c.CompanyName);
            cmd.Parameters.AddWithValue("@Address", c.Address);
            cmd.Parameters.AddWithValue("@Suite", c.Suite);
            cmd.Parameters.AddWithValue("@City", c.City);
            cmd.Parameters.AddWithValue("@State", c.State);
            cmd.Parameters.AddWithValue("@Zip", c.Zip);
            cmd.Parameters.AddWithValue("@WorkNum", c.WorkNum);
            cmd.Parameters.AddWithValue("@HomeNum", c.HomeNum);
            cmd.Parameters.AddWithValue("@MobileNum", c.MobileNum);
            cmd.Parameters.AddWithValue("@Fax", c.Fax);
            cmd.Parameters.AddWithValue("@SalesRep", c.SalesRep);
            cmd.Parameters.AddWithValue("@Memo", c.Memo);
            cmd.Parameters.AddWithValue("@MiddleProcess", c.MiddleProcess);
            cmd.Parameters.AddWithValue("@Request", c.Request);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RemoveClient(Client c)
        {
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            //change the clientId in every class to be a little information of the erase client
            #region Delete open loans
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Loans1 WHERE ClientId = @id AND Close=@close", con);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@close", Convert.ToInt32(false));
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("DELETE FROM Loans2 WHERE ClientId = @id AND Close=@close", con);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@close", Convert.ToInt32(false));
            cmd.ExecuteNonQuery();
            #endregion
            #region change loans           
            string eraseData = c.Mail + " " + c.MobileNum + " " + c.Fname + " " + c.Lname;
            string query = "UPDATE Loans1 SET ClientId=@ClientId WHERE ClientId=@id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ClientId", eraseData);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.ExecuteNonQuery();
            //delete from DB
            query = "UPDATE Loans2 SET ClientId=@ClientId WHERE ClientId=@id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ClientId", eraseData);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.ExecuteNonQuery();
            #endregion
            #region Remove ProofDoc
            cmd = new MySqlCommand("DELETE FROM Docs WHERE ClientId = @id", con);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.ExecuteNonQuery();
            #endregion
            cmd = new MySqlCommand("DELETE FROM Client WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateClient(Client c)
        {
            Client c1 = FindClient(c.Id);
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "UPDATE Client SET Mail=@Mail,Fname=@Fname,Lname=@Lname,CompanyName=@CompanyName,Address=@Address,Suite=@Suite,City=@City,State=@State,Zip=@Zip,WorkNum=@WorkNum,HomeNum=@HomeNum,MobileNum=@MobileNum,Fax=@Fax,SalesRep=@SalesRep,Memo=@Memo,MiddleProcess=@MiddleProcess,Request=@Request WHERE Id=@Id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", c.Id);
            cmd.Parameters.AddWithValue("@Mail", c.Mail);
            cmd.Parameters.AddWithValue("@Fname", c.Fname);
            cmd.Parameters.AddWithValue("@Lname", c.Lname);
            cmd.Parameters.AddWithValue("@CompanyName", c.CompanyName);
            cmd.Parameters.AddWithValue("@Address", c.Address);
            cmd.Parameters.AddWithValue("@Suite", c.Suite);
            cmd.Parameters.AddWithValue("@City", c.City);
            cmd.Parameters.AddWithValue("@State", c.State);
            cmd.Parameters.AddWithValue("@Zip", c.Zip);
            cmd.Parameters.AddWithValue("@WorkNum", c.WorkNum);
            cmd.Parameters.AddWithValue("@HomeNum", c.HomeNum);
            cmd.Parameters.AddWithValue("@MobileNum", c.MobileNum);
            cmd.Parameters.AddWithValue("@Fax", c.Fax);
            cmd.Parameters.AddWithValue("@SalesRep", c.SalesRep);
            cmd.Parameters.AddWithValue("@Memo", c.Memo);
            cmd.Parameters.AddWithValue("@MiddleProcess", c.MiddleProcess);
            cmd.Parameters.AddWithValue("@Request", c.Request);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Read from DB
        public int FindClientId(string mail)
        {
            int id =0;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select Id from User where Mail=@mail", con);
            cmd.Parameters.AddWithValue("@mail", mail);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader["Id"].ToString());
            }

                return id;
        }
        public Client FindClient(string id)
        {
            Client c = new Client();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Client where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                c.Id = id;
                c.Mail = reader["Mail"].ToString();
                c.Fname = reader["Fname"].ToString();
                c.Lname = reader["Lname"].ToString();
                c.CompanyName = reader["CompanyName"].ToString();
                c.Address = reader["Address"].ToString();
                c.Suite = reader["Suite"].ToString();
                c.City = reader["City"].ToString();
                c.State = reader["State"].ToString();
                c.Zip = reader["Zip"].ToString();
                c.WorkNum = reader["WorkNum"].ToString();
                c.HomeNum = reader["HomeNum"].ToString();
                c.MobileNum = reader["MobileNum"].ToString();
                c.SalesRep = reader["SalesRep"].ToString();
                c.Fax = reader["Fax"].ToString();
                c.Memo = reader["Memo"].ToString();
                c.MiddleProcess = reader["MiddleProcess"].ToString();
                c.Request = Convert.ToBoolean(Convert.ToInt32(reader["Request"].ToString()));


            }
            con.Close();
            return c;
        }
        public bool CheckFirstTime(string id)
        {
            bool ans = true;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Client where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ans = false;

            }
            con.Close();
            return ans;
        }
        public List<Client> AskLoansClients()
        {
            List<Client> l = new List<Client>();
            //all the clients that their middleprocess!=""

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Client where NOT MiddleProcess=@MiddleProcess", con);
            cmd.Parameters.AddWithValue("@MiddleProcess", "");
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Client c = new Client();
                c.Id = reader["Id"].ToString();
                c.Mail = reader["Mail"].ToString();
                c.Fname = reader["Fname"].ToString();
                c.Lname = reader["Lname"].ToString();
                c.CompanyName = reader["CompanyName"].ToString();
                c.Address = reader["Address"].ToString();
                c.Suite = reader["Suite"].ToString();
                c.City = reader["City"].ToString();
                c.State = reader["State"].ToString();
                c.Zip = reader["Zip"].ToString();
                c.WorkNum = reader["WorkNum"].ToString();
                c.HomeNum = reader["HomeNum"].ToString();
                c.MobileNum = reader["MobileNum"].ToString();
                c.SalesRep = reader["SalesRep"].ToString();
                c.Fax = reader["Fax"].ToString();
                c.Memo = reader["Memo"].ToString();
                c.MiddleProcess = reader["MiddleProcess"].ToString();
                c.Request = Convert.ToBoolean(Convert.ToInt32(reader["Request"].ToString()));
                l.Add(c);

            }
            con.Close();
            return l;
        }
        public List<string> AllClientPN()
        {
            List<string> l = new List<string>();
            //all the clients that their middleprocess!=""

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Client", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                l.Add(reader["MobileNum"].ToString());
            }
            con.Close();
            return l;
        }
    
        public List<Client> AllClients()
        {
            List<Client> l = new List<Client>();
            //all the clients that their middleprocess!=""

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Client", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Client c = new Client();
                c.Id = reader["Id"].ToString();
                c.Mail = reader["Mail"].ToString();
                c.Fname = reader["Fname"].ToString();
                c.Lname = reader["Lname"].ToString();
                c.CompanyName = reader["CompanyName"].ToString();
                c.Address = reader["Address"].ToString();
                c.Suite = reader["Suite"].ToString();
                c.City = reader["City"].ToString();
                c.State = reader["State"].ToString();
                c.Zip = reader["Zip"].ToString();
                c.WorkNum = reader["WorkNum"].ToString();
                c.HomeNum = reader["HomeNum"].ToString();
                c.MobileNum = reader["MobileNum"].ToString();
                c.SalesRep = reader["SalesRep"].ToString();
                c.Fax = reader["Fax"].ToString();
                c.Memo = reader["Memo"].ToString();
                c.MiddleProcess = reader["MiddleProcess"].ToString();
                c.Request = Convert.ToBoolean(Convert.ToInt32(reader["Request"].ToString()));
                l.Add(c);

            }
            con.Close();
            return l;
        }
        public List<Client> AllClientSearch(string s)
        {
            //check the search element
            string s1 = "";
            string s2 = "";
            string s3 = "";
            string s4 = "";
            int i = 0;
            if (s.Split(' ').Length == 4)
            {
                i = 4;
                s1 = s.Split(' ')[0].ToUpper();
                s2 = s.Split(' ')[1].ToUpper();
                s3 = s.Split(' ')[3].ToUpper();
                try
                {
                    s4 = s.Split(' ')[4].ToUpper();
                }
                catch
                {
                    s4 = "";
                }
                if (s4 == "")
                    i--;

                if (s3 == "")
                {
                    s3 = s4;
                    i--;
                }
                if (s2 == "")
                {
                    s2 = s3;
                    s3 = s4;
                    i--;
                }
            }
            else
            {
                if (s.Split(' ').Length == 3)
                {
                    s1 = s.Split(' ')[0].ToUpper();
                    s2 = s.Split(' ')[1].ToUpper();
                    try
                    {
                        s3 = s.Split(' ')[3].ToUpper();
                    }
                    catch
                    {
                        s3 = "";
                    }
                    i = 3;


                    if (s3 == "")
                    {
                        i--;
                    }
                    if (s2 == "")
                    {
                        s2 = s3;
                        i--;
                    }

                }
                else
                {
                    if (s.Split(' ').Length == 2)
                    {
                        i = 2;
                        s1 = s.Split(' ')[0].ToUpper();
                        try
                        {
                            s2 = s.Split(' ')[1].ToUpper();
                        }
                        catch
                        {
                            s2 = "";
                        }
                        if (s2 == "")
                            i--;
                    }
                    else
                    {
                        i = 1;
                        s1 = s.ToUpper();
                    }
                }
            }
            List<Client> l = new List<Client>();
            //all the clients that their middleprocess!=""

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Client", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            bool enteragain = true;
            while (reader.Read())
            {
                
                bool flag = false;
                Client c = new Client();
                c.MobileNum = reader["MobileNum"].ToString();
                string mobNum = c.MobileNum.Replace("(", "").Replace(")", "").Replace("-", "");
                c.Fname = reader["Fname"].ToString();
                c.Lname = reader["Lname"].ToString();
                c.Mail = reader["Mail"].ToString();
                if (mobNum == s1 || mobNum == s2 || mobNum == s3|| mobNum == s4)
                {
                    l.Clear();                    
                    c.Id = reader["Id"].ToString();
                    
                    c.CompanyName = reader["CompanyName"].ToString();
                    c.Address = reader["Address"].ToString();
                    c.Suite = reader["Suite"].ToString();
                    c.City = reader["City"].ToString();
                    c.State = reader["State"].ToString();
                    c.Zip = reader["Zip"].ToString();
                    c.WorkNum = reader["WorkNum"].ToString();
                    c.HomeNum = reader["HomeNum"].ToString();

                    c.SalesRep = reader["SalesRep"].ToString();
                    c.Fax = reader["Fax"].ToString();
                    c.Memo = reader["Memo"].ToString();
                    c.MiddleProcess = reader["MiddleProcess"].ToString();
                    c.Request = Convert.ToBoolean(Convert.ToInt32(reader["Request"].ToString()));
                    l.Add(c);
                    enteragain = false;
                }
                if (c.Mail == s1 || c.Mail == s2 || c.Mail == s3 || c.Mail == s4)
                {
                    l.Clear();
                    c.Id = reader["Id"].ToString();

                    c.CompanyName = reader["CompanyName"].ToString();
                    c.Address = reader["Address"].ToString();
                    c.Suite = reader["Suite"].ToString();
                    c.City = reader["City"].ToString();
                    c.State = reader["State"].ToString();
                    c.Zip = reader["Zip"].ToString();
                    c.WorkNum = reader["WorkNum"].ToString();
                    c.HomeNum = reader["HomeNum"].ToString();

                    c.SalesRep = reader["SalesRep"].ToString();
                    c.Fax = reader["Fax"].ToString();
                    c.Memo = reader["Memo"].ToString();
                    c.MiddleProcess = reader["MiddleProcess"].ToString();
                    c.Request = Convert.ToBoolean(Convert.ToInt32(reader["Request"].ToString()));
                    l.Add(c);
                    enteragain = false;
                }

                if (i == 1)
                {
                    if ((s2 != "" && c.Fname.ToUpper().Contains(s2)) || (s3 != "" && c.Fname.ToUpper().Contains(s3)) || c.Fname.ToUpper().Contains(s1) ||s4!=""&& c.Fname.ToUpper().Contains(s4))
                    {
                        flag = true;
                    }
                    if ((s2 != "" && mobNum.ToUpper().Contains(s2)) || (s3 != "" && mobNum.ToUpper().Contains(s3)) || mobNum.ToUpper().Contains(s1)||(s4 != "" && mobNum.ToUpper().Contains(s4)) )
                    {
                        flag = true;
                    }
                    if ((s2 != "" && c.Lname.ToUpper().Contains(s2)) || (s3 != "" && c.Lname.ToUpper().Contains(s3)) || c.Lname.ToUpper().Contains(s1) ||(s4!=""&& c.Lname.ToUpper().Contains(s1)))
                    {
                        flag = true;
                    }
                    if ((s2 != "" && c.Mail.ToUpper().Contains(s2)) || (s3 != "" && c.Mail.ToUpper().Contains(s3)) || c.Mail.ToUpper().Contains(s1) || (s4 != "" && c.Mail.ToUpper().Contains(s1)))
                    {
                        flag = true;
                    }
                }
                if (i == 2)
                {
                    bool onealreadyt = false;
                    if ((s2 != "" && c.Fname.ToUpper().Contains(s2)) || (s3 != "" && c.Fname.ToUpper().Contains(s3)) || c.Fname.ToUpper().Contains(s1)||(s4!=""&& c.Fname.ToUpper().Contains(s4)))
                    {
                        onealreadyt = true;
                    }
                    if ((s2 != "" && mobNum.ToUpper().Contains(s2)) || (s3 != "" && mobNum.ToUpper().Contains(s3)) || mobNum.ToUpper().Contains(s1) || (s4 != "" && mobNum.ToUpper().Contains(s4)))
                    {
                        if (onealreadyt)
                            flag = true;
                        else
                            onealreadyt = true;
                    }
                    if ((s2 != "" && c.Lname.ToUpper().Contains(s2)) || (s3 != "" && c.Lname.ToUpper().Contains(s3)) || c.Lname.ToUpper().Contains(s1)||(s4!=""&& c.Lname.ToUpper().Contains(s4)))
                    {
                        if(onealreadyt)
                            flag = true;
                    }
                    if ((s2 != "" && c.Mail.ToUpper().Contains(s2)) || (s3 != "" && c.Mail.ToUpper().Contains(s3)) || c.Mail.ToUpper().Contains(s1) || (s4 != "" && c.Mail.ToUpper().Contains(s4)))
                    {
                        if (onealreadyt)
                            flag = true;
                    }


                }
                if (i == 3)
                {
                    bool onealreadyt = false;
                    bool talreadyt = false;
                    if ((s2 != "" && c.Fname.ToUpper().Contains(s2)) || (s3 != "" && c.Fname.ToUpper().Contains(s3)) || c.Fname.ToUpper().Contains(s1) || (s4 != "" && c.Fname.ToUpper().Contains(s4)))
                    {
                        onealreadyt = true;
                    }
                    if ((s2 != "" && mobNum.ToUpper().Contains(s2)) || (s3 != "" && mobNum.ToUpper().Contains(s3)) || mobNum.ToUpper().Contains(s1) || (s4 != "" && mobNum.ToUpper().Contains(s4)))
                    {
                        if (onealreadyt)
                            talreadyt = true;
                        else
                            onealreadyt = true;
                    }
                    if ((s2 != "" && c.Lname.ToUpper().Contains(s2)) || (s3 != "" && c.Lname.ToUpper().Contains(s3)) || c.Lname.ToUpper().Contains(s1) || (s4 != "" && c.Lname.ToUpper().Contains(s4)))
                    {
                        if (talreadyt)
                            flag = true;
                        else
                        if (onealreadyt)
                            talreadyt = true;
                        else
                            onealreadyt = true;
                    }
                    if ((s2 != "" && c.Mail.ToUpper().Contains(s2)) || (s3 != "" && c.Mail.ToUpper().Contains(s3)) || c.Mail.ToUpper().Contains(s1) || (s4 != "" && c.Mail.ToUpper().Contains(s4)))
                    {
                        if (talreadyt)
                            flag = true;
                    }


                }
                if (i == 4)
                {
                    if ((s2 != "" && c.Fname.ToUpper().Contains(s2)) || (s3 != "" && c.Fname.ToUpper().Contains(s3)) || c.Fname.ToUpper().Contains(s1) || (s4 != "" && c.Fname.ToUpper().Contains(s4)))
                    {

                        if ((s2 != "" && mobNum.ToUpper().Contains(s2)) || (s3 != "" && mobNum.ToUpper().Contains(s3)) || mobNum.ToUpper().Contains(s1) || (s4 != "" && mobNum.ToUpper().Contains(s4)))
                        {
                            if ((s2 != "" && c.Lname.ToUpper().Contains(s2)) || (s3 != "" && c.Lname.ToUpper().Contains(s3)) || c.Lname.ToUpper().Contains(s1) || (s4 != "" && c.Lname.ToUpper().Contains(s4)))
                            {
                            if((s2 != "" && c.Mail.ToUpper().Contains(s2)) || (s3 != "" && c.Mail.ToUpper().Contains(s3)) || c.Mail.ToUpper().Contains(s1)||(s4!=""&&c.Mail.ToUpper().Contains(s4)))
                                flag = true;
                            }
                        }
                    }

                }
                if (flag&&enteragain)
                {
                    c.Id = reader["Id"].ToString();
                    c.Mail = reader["Mail"].ToString();
                    c.CompanyName = reader["CompanyName"].ToString();
                    c.Address = reader["Address"].ToString();
                    c.Suite = reader["Suite"].ToString();
                    c.City = reader["City"].ToString();
                    c.State = reader["State"].ToString();
                    c.Zip = reader["Zip"].ToString();
                    c.WorkNum = reader["WorkNum"].ToString();
                    c.HomeNum = reader["HomeNum"].ToString();

                    c.SalesRep = reader["SalesRep"].ToString();
                    c.Fax = reader["Fax"].ToString();
                    c.Memo = reader["Memo"].ToString();
                    c.MiddleProcess = reader["MiddleProcess"].ToString();
                    c.Request = Convert.ToBoolean(Convert.ToInt32(reader["Request"].ToString()));
                    l.Add(c);
                }

            }
            con.Close();
            return l;
        }
        public bool FindIfClientHasLoan(string clientId)
        {
            bool ans = false;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select MiddleProcess from Client where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", clientId);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string s = reader["MiddleProcess"].ToString();
                if (s!="")
                    ans = true;
            }
            con.Close();
            return ans;
        }
        #endregion

    }
}
