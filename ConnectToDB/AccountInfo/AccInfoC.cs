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
    public class AccInfoC
    {
       MySqlConnection con = new MySqlConnection("server=3.84.165.5;user id=root;port=3306;database=Cavalry;Password=cavalry1234;");
       
       #region Read from DB
        public int getID()
        {
            int i = 0;
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }            
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select id from LastId where db=@db", con);
            cmd.Parameters.AddWithValue("@db", "AccInfo");
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
            cmd.Parameters.AddWithValue("@db", "AccInfo");
            cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public AccInfo FindAccInfo(int id)
        {
            AccInfo c = new AccInfo();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from AccInfo where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                c.Id = Convert.ToInt32(reader["Id"].ToString());
                c.Date = reader["Date"].ToString();
                c.RequestTo = reader["RequestTo"].ToString();
                c.Requestfrom = reader["Requestfrom"].ToString();
                c.Kind = reader["Kind"].ToString();
                c.Comment = reader["Comment"].ToString();
                c.Amount = reader["Amount"].ToString();
                c.UserId = reader["UserId"].ToString();
                c.Category = reader["Category"].ToString();
                c.CheckNum = reader["CheckNum"].ToString();
                c.BankName = reader["BankName"].ToString();
                c.InvoiceNum = reader["InvoiceNum"].ToString();
                c.Enterb = Convert.ToBoolean(Convert.ToInt32(reader["Enterb"].ToString()));

            }
            con.Close();
            return c;
        }
        public List<AccInfo> ListBelongToBank(string bankNum, string Dfrom, string Dto, string category, string f_twhom)
        {
            
            List<AccInfo> l = new List<AccInfo>();

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from AccInfo", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {                
                AccInfo c = new AccInfo();
                c.Date = reader["Date"].ToString();
                c.RequestTo = reader["RequestTo"].ToString();
                c.Requestfrom = reader["Requestfrom"].ToString();
                c.Category = reader["Category"].ToString();

                if (Convert.ToDateTime(c.Date) >= Convert.ToDateTime(Dfrom) && Convert.ToDateTime(c.Date) <= Convert.ToDateTime(Dto))
                { 
                    if(c.Category==category||category=="All")
                    {
                        if(c.Requestfrom==bankNum||c.RequestTo==bankNum)
                        {
                            if(f_twhom=="All"|| c.Requestfrom == f_twhom || c.RequestTo == f_twhom)
                            {
                                c.Id = Convert.ToInt32(reader["Id"].ToString());
                                c.Kind = reader["Kind"].ToString();
                                c.Comment = reader["Comment"].ToString();
                                c.Amount = reader["Amount"].ToString();
                                c.UserId = reader["UserId"].ToString();
                                c.CheckNum = reader["CheckNum"].ToString();
                                c.BankName = reader["BankName"].ToString();
                                c.InvoiceNum = reader["InvoiceNum"].ToString();
                                c.Enterb = Convert.ToBoolean(Convert.ToInt32(reader["Enterb"].ToString()));
                                l.Add(c);
                            }
                        }
                    }
                }                
                   
                
            }
            con.Close();

            return l;
        }
        public List<AccInfo> ListBelongToCategory(string Dfrom, string Dto, string category)
        {

            List<AccInfo> l = new List<AccInfo>();

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from AccInfo", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AccInfo c = new AccInfo();
                c.Date = reader["Date"].ToString();
                c.Category = reader["Category"].ToString();

                if (Convert.ToDateTime(c.Date) >= Convert.ToDateTime(Dfrom) && Convert.ToDateTime(c.Date) <= Convert.ToDateTime(Dto))
                {
                    if (c.Category == category)
                    {
                        c.Id = Convert.ToInt32(reader["Id"].ToString());

                        c.RequestTo = reader["RequestTo"].ToString();
                        c.Requestfrom = reader["Requestfrom"].ToString();
                        c.Kind = reader["Kind"].ToString();
                        c.Comment = reader["Comment"].ToString();
                        c.Amount = reader["Amount"].ToString();
                        c.UserId = reader["UserId"].ToString();
                        c.CheckNum = reader["CheckNum"].ToString();
                        c.BankName = reader["BankName"].ToString();
                        c.InvoiceNum = reader["InvoiceNum"].ToString();
                        c.Enterb = Convert.ToBoolean(Convert.ToInt32(reader["Enterb"].ToString()));
                        l.Add(c);

                    }
                }


            }
            con.Close();

            return l;
        }

        public List<AccInfo> FilterAccInfo(string date,string kind,string from,string to,string amount,string enterToBank)
        {
            List<AccInfo> l = new List<AccInfo>();

            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from AccInfo ", con);          
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AccInfo c = new AccInfo();
                c.Date = reader["Date"].ToString();
                c.RequestTo = reader["RequestTo"].ToString();
                c.Requestfrom = reader["Requestfrom"].ToString();
                c.Kind = reader["Kind"].ToString();
                c.Enterb = Convert.ToBoolean(Convert.ToInt32(reader["Enterb"].ToString()));
                c.Amount = reader["Amount"].ToString();
                if (c.Date == date || date == "") 
                {
                    if(c.Kind==kind||kind=="All")
                    {
                        if (c.Requestfrom == from || from == "All")
                        {
                            if (c.RequestTo == to || to == "All")
                            {
                                if (amount == "" || Convert.ToDouble(c.Amount) == Convert.ToDouble(amount))
                                {
                                    if (Convert.ToBoolean(c.Enterb).ToString() == enterToBank || enterToBank == "All")
                                    {
                                        c.Id = Convert.ToInt32(reader["Id"].ToString());
                                        c.Comment = reader["Comment"].ToString();
                                        c.UserId = reader["UserId"].ToString();
                                        c.Category = reader["Category"].ToString();
                                        c.CheckNum = reader["CheckNum"].ToString();
                                        c.BankName = reader["BankName"].ToString();
                                        c.InvoiceNum = reader["InvoiceNum"].ToString();
                                        l.Add(c);
                                    }
                                }
                            }
                        }
                    }
                
                }

                c.Id = Convert.ToInt32(reader["Id"].ToString());
                c.Comment = reader["Comment"].ToString();               
                c.UserId = reader["UserId"].ToString();
                c.Category = reader["Category"].ToString();
                c.CheckNum = reader["CheckNum"].ToString();
                c.BankName = reader["BankName"].ToString();
                c.InvoiceNum = reader["InvoiceNum"].ToString();
                l.Add(c);
            }
            con.Close();

            return l;
        }
        #endregion
        #region Write to DB
        public void AddAccInfo(AccInfo info)
        {
            if (info.Kind == "Regular")
            {
                Regular(info);
            }
            if (info.Kind == "Income")
            {
                Income(info);
            }
            if (info.Kind == "Expenses")
            {
                Expenses(info);
            }
            if (info.Kind == "Third party")
            {
                Thirdparty(info);
            }
            //add to DB
            info.Id = getID();
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            string query = "INSERT INTO AccInfo (Id,Kind,Date,Requestfrom,RequestTo,Comment,Amount,UserId,Category,CheckNum,BankName,InvoiceNum,Enterb) VALUES (@Id,@Kind,@Date,@Requestfrom,@RequestTo,@Comment,@Amount,@UserId,@Category,@CheckNum,@BankName,@InvoiceNum,@Enterb)";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", info.Id);
            cmd.Parameters.AddWithValue("@Kind", info.Kind);
            cmd.Parameters.AddWithValue("@Date", info.Date);
            cmd.Parameters.AddWithValue("@Requestfrom", info.Requestfrom);
            cmd.Parameters.AddWithValue("@RequestTo", info.RequestTo);
            cmd.Parameters.AddWithValue("@Comment", info.Comment);
            cmd.Parameters.AddWithValue("@Amount", info.Amount);
            cmd.Parameters.AddWithValue("@UserId", info.UserId);
            cmd.Parameters.AddWithValue("@Category", info.Category);
            cmd.Parameters.AddWithValue("@CheckNum", info.CheckNum);
            cmd.Parameters.AddWithValue("@BankName", info.BankName);
            cmd.Parameters.AddWithValue("@InvoiceNum", info.InvoiceNum);
            cmd.Parameters.AddWithValue("@Enterb", info.Enterb);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RemoveAccInfo(int id)
        {
            AccInfoC inter = new AccInfoC();
            AccInfo info = new AccInfo();
            info = inter.FindAccInfo(id);
            info.Amount = -1 * Convert.ToDouble(info.Amount) + "";
            if (info.Kind == "Regular")
            {
                Regular(info);
            }
            if (info.Kind == "Income")
            {
                Income(info);
            }
            if (info.Kind == "Expenses")
            {
                Expenses(info);
            }
            if (info.Kind == "Third party")
            {
                Thirdparty(info);
            }
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM AccInfo WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateAccInfo(AccInfo i)
        {
            RemoveAccInfo(i.Id);
            AddAccInfo(i);
        }
        public void UpdateWhenDelete(AccInfo i)
        {
            while (con.State == ConnectionState.Open)
            {
                System.Threading.Thread.Sleep(500);
            }
            con.Open();

            string query = "UPDATE AccInfo SET Kind=@kind,Requestfrom=@from,RequestTo=@to WHERE Id=@Id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", i.Id);
            cmd.Parameters.AddWithValue("@kind", i.Kind);
            cmd.Parameters.AddWithValue("@from", i.Requestfrom);
            cmd.Parameters.AddWithValue("@to", i.RequestTo);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region function       
        public void Regular(AccInfo info)
        {
            AccountC acc = new AccountC();
            Account acc1 = acc.FindAcc(info.Requestfrom);
            Account acc2 = acc.FindAcc(info.RequestTo);
            bool needDebt = true;
            if (acc1.Kind.Contains("Company") && acc2.Kind.Contains("Company"))// there is not debts betweebn company accounts
            {
                needDebt = false;
            }
            bool creditKind = false;
            if (acc2.Kind == "Credit")
                creditKind = true;
            #region From
            string s = info.Amount;
            double am = Convert.ToDouble(s);
            double eq = Convert.ToDouble(acc1.Equity);
            double ba = Convert.ToDouble(acc1.Balance);
            double deb = Convert.ToDouble(acc1.Debt);
            double seq = Convert.ToDouble(acc1.Sequity);
            double sba = Convert.ToDouble(acc1.SBalance);
            double sdeb = Convert.ToDouble(acc1.Sdebt);
            seq -= am;
            sba -= am;
            if (needDebt)
                sdeb += am;
            if (info.Enterb)
            {
                eq -= am;
                ba -= am;
                if (needDebt)
                    deb += am;
            }
            acc1.Equity = eq.ToString();
            acc1.Balance = ba.ToString();
            acc1.Debt = deb.ToString();
            acc1.Sequity = seq.ToString();
            acc1.SBalance = sba.ToString();
            acc1.Sdebt = sdeb.ToString();
            #endregion
            #region To
            eq = Convert.ToDouble(acc2.Equity);
            ba = Convert.ToDouble(acc2.Balance);
            deb = Convert.ToDouble(acc2.Debt);
            seq = Convert.ToDouble(acc2.Sequity);
            sba = Convert.ToDouble(acc2.SBalance);
            sdeb = Convert.ToDouble(acc2.Sdebt);
            if (!creditKind)
            {
                seq += am;
                sba += am;
                if (needDebt)
                    sdeb -= am;
                if (info.Enterb)
                {
                    eq += am;
                    ba += am;
                    if (needDebt)
                        deb -= am;
                }
            }
            else
            {
                sba += am;
                if (info.Enterb)
                    ba += am;
            }
            acc2.Equity = eq.ToString();
            acc2.Balance = ba.ToString();
            acc2.Debt = deb.ToString();
            acc2.Sequity = seq.ToString();
            acc2.SBalance = sba.ToString();
            acc2.Sdebt = sdeb.ToString();
            #endregion
            acc.UpdateAcc(acc1,acc1.AccountNum);
            acc.UpdateAcc(acc2, acc2.AccountNum);
        }
        public void Income(AccInfo info)
        {
            AccountC acc = new AccountC();
            Account acc1 = acc.FindAcc(info.RequestTo);
            double am = Convert.ToDouble(info.Amount);
            double eq = Convert.ToDouble(acc1.Equity);
            double ba = Convert.ToDouble(acc1.Balance);
            double deb = Convert.ToDouble(acc1.Debt);
            double seq = Convert.ToDouble(acc1.Sequity);
            double sba = Convert.ToDouble(acc1.SBalance);
            double sdeb = Convert.ToDouble(acc1.Sdebt);
            seq += am;
            sba += am;
            if (info.Enterb)
            {
                eq += am;
                ba += am;
            }
            acc1.Equity = eq.ToString();
            acc1.Balance = ba.ToString();
            acc1.Debt = deb.ToString();
            acc1.Sequity = seq.ToString();
            acc1.SBalance = sba.ToString();
            acc1.Sdebt = sdeb.ToString();
            acc.UpdateAcc(acc1,acc1.AccountNum);
        }
        public void Expenses(AccInfo info)
        {
            AccountC acc = new AccountC();
            Account acc1 = acc.FindAcc(info.Requestfrom);
            double am = Convert.ToDouble(info.Amount);
            double eq = Convert.ToDouble(acc1.Equity);
            double ba = Convert.ToDouble(acc1.Balance);
            double deb = Convert.ToDouble(acc1.Debt);
            double seq = Convert.ToDouble(acc1.Sequity);
            double sba = Convert.ToDouble(acc1.SBalance);
            double sdeb = Convert.ToDouble(acc1.Sdebt);
            bool creditKind = false;
            if (acc1.Kind == "Credit")
                creditKind = true;
            if (!creditKind)
            {
                seq -= am;
                sba -= am;
                if (info.Enterb)
                {
                    eq -= am;
                    ba -= am;
                }
            }
            else
                ba -= am;
            
            acc1.Equity = eq.ToString();
            acc1.Balance = ba.ToString();
            acc1.Debt = deb.ToString();
            acc1.Sequity = seq.ToString();
            acc1.SBalance = sba.ToString();
            acc1.Sdebt = sdeb.ToString();
            acc.UpdateAcc(acc1,acc1.AccountNum);

        }
        public void Thirdparty(AccInfo info)
        {
            AccountC acc = new AccountC();
            Account acc1 = acc.FindAcc(info.Requestfrom);
            Account acc2 = acc.FindAcc(info.RequestTo);
            if (acc1.AccountNum != "0")
            {
                double am = Convert.ToDouble(info.Amount);
                double eq = Convert.ToDouble(acc1.Equity);
                double ba = Convert.ToDouble(acc1.Balance);
                double deb = Convert.ToDouble(acc1.Debt);
                double seq = Convert.ToDouble(acc1.Sequity);
                double sba = Convert.ToDouble(acc1.SBalance);
                double sdeb = Convert.ToDouble(acc1.Sdebt);
                seq -= am;
                if (info.Enterb)
                    eq -= am;
                acc1.Equity = eq.ToString();
                acc1.Balance = ba.ToString();
                acc1.Debt = deb.ToString();
                acc1.Sequity = seq.ToString();
                acc1.SBalance = sba.ToString();
                acc1.Sdebt = sdeb.ToString();
                acc.UpdateAcc(acc1,acc1.AccountNum);

            }
            else
            {
                double am = Convert.ToDouble(info.Amount);
                double eq = Convert.ToDouble(acc2.Equity);
                double ba = Convert.ToDouble(acc2.Balance);
                double deb = Convert.ToDouble(acc2.Debt);
                double seq = Convert.ToDouble(acc2.Sequity);
                double sba = Convert.ToDouble(acc2.SBalance);
                double sdeb = Convert.ToDouble(acc2.Sdebt);

                seq += am;
                if (info.Enterb)
                {
                    eq += am;
                }
                acc1.Equity = eq.ToString();
                acc1.Balance = ba.ToString();
                acc1.Debt = deb.ToString();
                acc1.Sequity = seq.ToString();
                acc1.SBalance = sba.ToString();
                acc1.Sdebt = sdeb.ToString();
                acc.UpdateAcc(acc1,acc1.AccountNum);
            }
        }

        #endregion
    }
}
