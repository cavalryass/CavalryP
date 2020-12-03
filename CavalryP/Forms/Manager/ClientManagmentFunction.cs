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
    public class ClientManagmentFunction
    {
        public List<string> AllClientByPhone()
        {
            ClientC inter = new ClientC();
            return inter.AllClientPN();
        }
        public List<Client> AllClient()
        {
            ClientC inter = new ClientC();
            return inter.AllClients();
        }
        public List<Client> AllClientSearch(string s)
        {
            ClientC inter = new ClientC();
            return inter.AllClientSearch(s);
        }
        public List<Client> ClientsWithLoan()
        {
            ClientC inter = new ClientC();
            return inter.AskLoansClients();
        }
        public void UpdatReqdoc(ReqDocs rd)
        {
            ReqDocsC r = new ReqDocsC();
            r.deleteDB(rd.Id);
            r.insertDB(rd);
        }
        public void AddNewRD(string reqDocs, string clientId)
        {
            ReqDocsC i = new ReqDocsC();
            List<string> l = reqDocs.Split('@').ToList();
            foreach (var v in l)
            {
                if (v != "")
                    i.insertDB(new ReqDocs(clientId, v, ""));
            }
            ClientC inter = new ClientC();
            Client c = inter.FindClient(clientId);
            if (!c.Request)
            {
                c.Request = true;
                inter.UpdateClient(c);
            }
        }
        public List<Docs> UploadDocs(string cid)
        {
            DocsC d = new DocsC();
            return d.findList(cid);
        }
        public Docs findDocById(int id)
        {
            DocsC d = new DocsC();
            return d.findProofdoc(id);
        }
        public Docs findSDoc(string uid)
        {
            DocsC d = new DocsC();
            return d.findSfdoc(uid);
        }
        public List<ReqDocs> listOfReqDocs(string clientId)
        {
            ReqDocsC r = new ReqDocsC();
            return r.ListsOfReqDocs(clientId);
        }
        public void DeleteReqDoc(int id)
        {
            ReqDocsC r = new ReqDocsC();
            r.deleteDB(id);
        }
        public void DeleteDoc(int id)
        {
            DocsC r = new DocsC();
            r.deleteDb(id);
        }
        public void DeleteClient(string id)
        {
            ClientC c = new ClientC();
            c.RemoveClient(c.FindClient(id));
        }
        public void EditClient(Client newC)
        {
            if (newC.Mail == "" || !newC.Mail.Contains("@"))
                throw new Exception("Unavailable Email");
            if(newC.Address==""||newC.City=="")
                throw new Exception("Unavailable Address");
            if (newC.WorkNum == "" )
                throw new Exception("Unavailable Work Phone");
            if (newC.HomeNum == "")
                throw new Exception("Unavailable Home Phone");
            if (newC.MobileNum == "")
                throw new Exception("Unavailable Mobile Phone");
            if (newC.Lname == "" || newC.Fname == "")
                throw new Exception("The Name File Is Missing");
            ClientC c = new ClientC();
            c.UpdateClient(newC);
        }

    }
}
