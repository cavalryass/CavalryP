using Basic.SoftwareUsers;
using ConnectToDB.LoansCommand;
using ConnectToDB.UsersCommand;
using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using ConnectToDB.ManagerAccess;

namespace ConnectToDB
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryC c = new CategoryC();
            foreach (var v in c.CategoryList())
                Console.WriteLine(v.id);
        }
    }
}