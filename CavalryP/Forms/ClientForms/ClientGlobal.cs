using Basic.SoftwareUsers;
using ConnectToDB.UsersCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.ClientForms
{
    public class ClientGlobal
    {
        public Client FindClient(string Id)//find the information for client that you can fill
        {
            ClientC inter = new ClientC();
            return inter.FindClient(Id);
        }
        public void UpdateClient(Client c)
        {
            ClientC inter = new ClientC();
            inter.UpdateClient(c);
        }
    }
}
