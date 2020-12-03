using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.ManagerAccess
{
    public class ReqDocs
    {
        public int Id { get; set; }
        public string clientId { get; set; }
        public string kind { get; set; }
        public string comment { get; set; }
        public ReqDocs()
        {
            Id = 0;
            this.clientId = "";
            this.kind = "";
            this.comment = "";
        }
        public ReqDocs(string clientId, string kind, string comment)
        {
            Id = 0;
            this.clientId = clientId;
            this.kind = kind;
            this.comment = comment;
        }

        public ReqDocs(int id, string clientId, string kind, string comment)
        {
            Id = id;
            this.clientId = clientId;
            this.kind = kind;
            this.comment = comment;
        }
    }
}
