using Basic.SoftwareUsers;
using ConnectToDB.UsersCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.ClientForms
{
    public class ClientFirsTimeFunction
    {
        public User userInformation(string uid)
        {
            UserC c = new UserC();
            return c.FindUser(uid);
        }
        public void CreateClient(Client c)
        {
            if (c.Mail == "")
                throw new Exception("The Mail Field Is Empty");
            if (c.Lname == "")
                throw new Exception("The Last Name Field I s Empty");
            if (c.Fname == "")
                throw new Exception("The First Name Field Is Empty");
            if (c.Address == "")
                throw new Exception("The Address Field Is Empty");
            if (c.Suite == "")
                throw new Exception("The Suite Field Is Empty");
            if (c.City == "")
                throw new Exception("The City Field Is Empty");
            if (c.Zip == "")
                throw new Exception("The Zip Field Is Empty");
            if (c.MobileNum == ""&&c.HomeNum==""&&c.WorkNum=="")
                throw new Exception("One Of The Phone Numbers Fields Must Be Full");
            UserC u = new UserC();
            u.UpdateUser(new User(c.Mail, "", c.Fname, c.Lname, c.MobileNum));
            ClientC clientC = new ClientC();
            clientC.CreateClient(c);
        }
        public string findStateByZip(int zip)
        {
            string state = "";
            if (zip >= 35000 && zip <= 36999)
            {
                state = "AL";
            }
            else 
            if (zip >= 99500 && zip <= 99999)
            {
                state = "AK";
            }
            else 
            if (zip >= 85000 && zip <= 86999)
            {                
                state = "AZ";
            }
            else 
            if (zip >= 71600 && zip <= 72999)
            {
                state = "AR";
            }
            else 
            if (zip >= 90000 && zip <= 96699)
            {
                state = "CA";
            }
            else 
            if (zip >= 80000 && zip <= 81999)
            {
                state = "CO";
            }
            else 
            if (zip >= 6000 && zip <= 6999)
            {
                state = "CT";
            }
            else 
            if (zip >= 19700 && zip <= 19999)
            {                
                state = "DE";
            }
            else 
            if (zip >= 32000 && zip <= 34999)
            {                
                state = "FL";
            }
            else
            if (zip >= 30000 && zip <= 31999)
            {
                state = "GA";
            }
            else 
            if (zip >= 96700 && zip <= 96999)
            {
                state = "HI";
            }
            else 
            if (zip >= 83200 && zip <= 83999)
            {
                state ="ID";
            }
            else 
            if (zip >= 60000 && zip <= 62999)
            {              
                state = "IL";
            }
            else 
            if (zip >= 46000 && zip <= 47999)
            {
                state = "IN";
            }
            else 
            if (zip >= 50000 && zip <= 52999)
            {                
                state = "IA";
            }
            else 
            if (zip >= 66000 && zip <= 67999)
            {
                state = "KS";
            }
            else 
            if (zip >= 40000 && zip <= 42999)
            {
                state = "KY";
            }
            else 
            if (zip >= 70000 && zip <= 71599)
            {
                state = "LA";
            }
            else 
            if (zip >= 3900 && zip <= 4999)
            {
                state = "ME";                
            }
            else 
            if (zip >= 20600 && zip <= 21999)
            {
                state = "MD";
            }
            else 
            if (zip >= 1000 && zip <= 2799)
            {
                state = "MA";
            }
            else 
            if (zip >= 48000 && zip <= 49999)
            {
                state = "MI";
            }
            else 
            if (zip >= 55000 && zip <= 56999)
            {
                state = "MN";
            }
            else 
            if (zip >= 38600 && zip <= 39999)
            {
                state = "MS";
            }
            else 
            if (zip >= 63000 && zip <= 65999)
            {
                state = "MO";
            }
            else 
            if (zip >= 59000 && zip <= 59999)
            {
                state = "MT";                
            }
            else 
            if (zip >= 27000 && zip <= 28999)
            {
                state = "NC";
            }
            else if (zip >= 58000 && zip <= 58999)
            {
                state = "ND";
            }
            else 
            if (zip >= 68000 && zip <= 69999)
            {
                state = "NE";
            }
            else 
            if (zip >= 88900 && zip<= 89999)
            {
                state = "NV";
            }
            else 
            if (zip >= 3000 && zip <= 3899)
            {
                state = "NH";
            }
            else 
            if (zip >= 7000 && zip <= 8999)
            {
                state = "NJ";
            }
            else 
            if (zip >= 87000 && zip <= 88499)
            {
                state = "NM";
            }
            else 
            if (zip >= 10000 && zip <= 14999)
            {
                state = "NY";
            }
            else if (zip >= 43000 && zip <= 45999)
            {
                state = "OH";
            }
            else 
            if (zip >= 73000 && zip <= 74999)
            {
                state = "OK";
            }
            else 
            if (zip >= 97000 && zip <= 97999)
            {
                state = "OR";
            }
            else 
            if (zip >= 15000 && zip <= 19699)
            {
                state = "PA";
            }
            else 
            if (zip >= 300 && zip <= 999)
            {
                state = "PR";
            }
            else 
            if (zip >= 2800 && zip <= 2999)
            {
                state = "RI";
            }
            else 
            if (zip >= 29000 && zip <= 29999)
            {
                state = "SC";
            }
            else 
            if (zip >= 57000 && zip <= 57999)
            {
                state = "SD";
            }
            else 
            if (zip >= 37000 && zip <= 38599)
            {
                state = "TN";
            }
            else 
            if ((zip >= 75000 && zip <= 79999) || (zip >= 88500 && zip <= 88599))
            {
                state = "TX";
            }
            else 
            if (zip >= 84000 && zip <= 84999)
            {
                state = "UT";
            }
            else 
            if (zip >= 5000 && zip <= 5999)
            {
                state = "VT";
            }
            else 
            if (zip >= 22000 && zip <= 24699)
            {
                state = "VA";
            }
            else 
            if (zip >= 20000 && zip <= 20599)
            {
                state = "DC";
            }
            else 
            if (zip >= 98000 && zip <= 99499)
            {
                state = "WA";
            }
            else 
            if (zip >= 24700 && zip <= 26999)
            {
                state = "WV";
            }
            else 
            if (zip >= 53000 && zip <= 54999)
            {
                state = "WI";
            }
            else 
            if (zip >= 82000 && zip <= 83199)
            {
                state = "WY";
            }
            else
            {
                throw new Exception();
            }

            return state;
        }
    }
}
