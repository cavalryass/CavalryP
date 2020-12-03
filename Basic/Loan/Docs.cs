using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Loan
{
    public class Docs
    {
        #region prop
        public int Id { get; set; }
        public string clientId { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
        public string Request { get; set; }
       
        #endregion
        #region ctor
        public Docs()
        {
            Id = 0;
            clientId = "";
            Name = "";
            ContentType = "";
            Data = null;
            Request = "";
        }
        public Docs(string clientId, string name, string contentType, byte[] data, string request)
        {          
            Id = 0;
            this.clientId = clientId;
            Name = name;
            ContentType = contentType;
            Data = data;
            Request = request;
        }
        #endregion
    }
}
