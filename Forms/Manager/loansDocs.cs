using Basic.Loan;
using Basic.ManagerAccess;
using Basic.SoftwareUsers;
using ConnectToDB.LoansCommand;
using ConnectToDB.ManagerAccess;
using ConnectToDB.UsersCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Manager
{
    public class loansDocs
    {
        public List<Client> AllClientWithloan()
        {
            ClientC inter = new ClientC();
            return inter.AskLoansClients();
        }
        public void addNewReqDoc(ReqDocs r)
        {
            ReqDocsC inter = new ReqDocsC();
            inter.insertDB(r);
            ClientC inter1 = new ClientC();
            Client c = inter1.FindClient(r.clientId);
            if (!c.Request)
            {
                c.Request = true;
                inter1.UpdateClient(c);
            }
            inter.insertDB(r);
        }
        public List<Docs> findList(string cId)
        {
            DocsC r = new DocsC();
            return r.findList(cId);             
        }
        public void approveLoan1(Loans1 l)
        {

            ClientC inter = new ClientC();
            Client c = inter.FindClient(l.ClientId);
            c.MiddleProcess = "1app";
            inter.UpdateClient(c);
        }
        public void approveLoan2(Loans2 l)
        {
            ClientC inter = new ClientC();
            Client c = inter.FindClient(l.ClientId);
            c.MiddleProcess = "2app";
            inter.UpdateClient(c);
        }
        
    }
}
