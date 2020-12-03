using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Loan
{
    public class Loans2
    {
        #region prop
        public string Id { get; set; }
        public string OpenCC { get; set; }
        public string OpenRC { get; set; }
        public string OpenRELoans { get; set; }
        public string OpenILoans { get; set; }
        public string TotalOpenAcc { get; set; }
        public string AcceverLate { get; set; }
        public string CollectionAcc { get; set; }
        public string AvgAccAge { get; set; }
        public string OldestAcc { get; set; }
        public string CRDebt { get; set; }
        public string REDebt { get; set; }
        public string ILDebt { get; set; }
        public string CollectionDebt { get; set; }
        public string TDebt { get; set; }
        public string PublicRecords { get; set; }
        public string Experian { get; set; }
        public string Equifax { get; set; }
        public string TransUnio { get; set; }
        public string Fico2 { get; set; }
        public string Fico3 { get; set; }
        public string Fico8 { get; set; }
        public string Comment { get; set; }
        public string ClientId { get; set; }
        public bool Source { get; set; }
        public bool Close { get; set; }
        public List<CAccount> CAccList { get; set; }
        public List<Inquiries> InqList { get; set; }


        #endregion
        #region ctor
        public Loans2()
        {
            Id = "0";
            OpenCC = "0";
            OpenRC = "0";
            OpenRELoans = "0";
            OpenILoans = "0";
            TotalOpenAcc = "0";
            AcceverLate = "0";
            CollectionAcc = "0";
            AvgAccAge = " / ";
            OldestAcc = " / ";
            CRDebt = "0";
            REDebt = "0";
            ILDebt = "0";
            CollectionDebt = "0";
            TDebt = "0";
            PublicRecords = "0";
            Experian = "0";
            Fico2 = "0";
            Fico3 = "0";
            Fico8 = "0";
            Equifax = "0";
            TransUnio = "0";
            Comment = "@@@@@";
            ClientId = "0";
            Close = false;
            Source = false;
            CAccList = new List<CAccount>();
            InqList = new List<Inquiries>();           
        }      
        public Loans2(string openCC, string openRC, string openRELoans, string openILoans, string totalOpenAcc, string acceverLate, string collectionAcc, string avgAccAge, string oldestAcc, string cRDebt, string rEDebt, string iLDebt, string collectionDebt, string tDebt, string publicRecords, string experian, string equifax, string transUnio,string fico2, string fico3, string fico8, string clientId, bool source)
        {
            this.Id = "0";
            OpenCC = openCC;
            OpenRC = openRC;
            OpenRELoans = openRELoans;
            OpenILoans = openILoans;
            TotalOpenAcc = totalOpenAcc;
            Source = source;
            AcceverLate = acceverLate;
            CollectionAcc = collectionAcc;
            AvgAccAge = avgAccAge;
            OldestAcc = oldestAcc;
            CRDebt = cRDebt;
            REDebt = rEDebt;
            ILDebt = iLDebt;
            CollectionDebt = collectionDebt;
            TDebt = tDebt;
            PublicRecords = publicRecords;
            Experian = experian;
            Equifax = equifax;
            TransUnio = transUnio;
            Comment = "";
            Fico2 = fico2;
            Fico3 = fico3;
            Fico8=fico8;
            ClientId = clientId;
            CAccList = new List<CAccount>();
            InqList = new List<Inquiries>();
            Close = false;

        }
        public Loans2(string id, string openCC, string openRC, string openRELoans, string openILoans, string totalOpenAcc, string acceverLate, string collectionAcc, string avgAccAge, string oldestAcc, string cRDebt, string rEDebt, string iLDebt, string collectionDebt, string tDebt, string publicRecords, string experian, string equifax, string transUnio, string fico2, string fico3, string fico8, string comment, string clientId, bool source, bool close, List<CAccount> cAccList, List<Inquiries> inqList)
        {
            Id = id;
            OpenCC = openCC;
            OpenRC = openRC;
            OpenRELoans = openRELoans;
            OpenILoans = openILoans;
            TotalOpenAcc = totalOpenAcc;
            AcceverLate = acceverLate;
            CollectionAcc = collectionAcc;
            AvgAccAge = avgAccAge;
            OldestAcc = oldestAcc;
            CRDebt = cRDebt;
            REDebt = rEDebt;
            ILDebt = iLDebt;
            CollectionDebt = collectionDebt;
            TDebt = tDebt;
            PublicRecords = publicRecords;
            Experian = experian;
            Equifax = equifax;
            TransUnio = transUnio;
            Fico2 = fico2;
            Fico3 = fico3;
            Fico8 = fico8;
            Comment = comment;
            ClientId = clientId;
            Source = source;
            Close = close;
            CAccList = cAccList;
            InqList = inqList;
        }
        public Loans2(Loans2 l)
        {
            Source = l.Source;
            Id = l.Id;
            OpenCC = l.OpenCC;
            OpenRELoans = l.OpenRELoans;
            OpenRC = l.OpenRC;
            OpenILoans = l.OpenILoans;
            TotalOpenAcc = l.TotalOpenAcc;
            AcceverLate = l.AcceverLate;
            CollectionAcc = l.CollectionAcc;
            AvgAccAge = l.AvgAccAge;
            OldestAcc = l.OldestAcc;
            CRDebt = l.CRDebt;
            REDebt = l.REDebt;
            ILDebt = l.ILDebt;
            CollectionDebt = l.CollectionDebt;
            TDebt = l.TDebt;
            PublicRecords = l.PublicRecords;
            Experian = l.Experian ;
            Equifax = l.Equifax;
            TransUnio = l.TransUnio;
            Fico2 = l.Fico2;
            Fico3 = l.Fico3;
            Fico8 = l.Fico8;
            Comment = l.Comment;
            ClientId = l.ClientId;
            Close = l.Close;
            CAccList = l.CAccList;
            InqList = l.InqList;

        }
        #endregion
    }
}
