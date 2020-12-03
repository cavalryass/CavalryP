using Basic.Loan;
using Basic.ManagerAccess;
using ConnectToDB.LoansCommand;
using ConnectToDB.ManagerAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Forms.ClientForms.Loans
{
    public class UploadDocdfunction
    {
        public List<string> reqDocsDD(string clientId)
        {
            List<string> l = new List<string>();
            List<ReqDocs> l1 = reqDocs(clientId);
            foreach (var v in l1)
            {
                l.Add(v.kind);
            }
            return l;
        }
        public List<ReqDocs> reqDocs(string clientId)
        {
            ReqDocsC r = new ReqDocsC();
            return r.ListsOfReqDocs(clientId);
        }
        public string comment(string cid, string kind)
        {
            List<ReqDocs> l1 = reqDocs(cid);
            foreach (var v in l1)
            {
                if (v.kind == kind)
                    return v.comment;
            }
            return "";
        }
        public void deleteReqDoc(string cid,string kind)
        {
            ReqDocsC r = new ReqDocsC();
            r.deleteDB(r.findByUserAndKind(cid, kind));
        }
        public void createDoc(string cid,string filename,string contentType,string kind, FileUpload FileUpload1)
        {
            if (filename == "")
                throw new Exception("The File Name Is Empty ");
            if (contentType == "")
                throw new Exception("The Content Type Name Is Empty ");
            if (kind == "")
                throw new Exception("The Kind Name Is Empty ");
          
            DocsC d = new DocsC();
            using (Stream fs = FileUpload1.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);                   
                    d.insertDb(new Docs(cid, filename, contentType, bytes,kind));
                    deleteReqDoc(cid,kind);
                }
            }
            
        }
    }
}
