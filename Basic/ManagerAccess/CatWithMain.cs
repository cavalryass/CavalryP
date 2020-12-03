using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.ManagerAccess
{
    public class CatWithMain
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mainC { get; set; }
        public string kind { get; set; }
        public string nameOfMainc { get; set; }

        public CatWithMain(int id, string name, string mainC, string kind, string nameOfMainc)
        {
            this.id = id;
            this.name = name;
            this.mainC = mainC;
            this.kind = kind;
            this.nameOfMainc = nameOfMainc;
        }
    }
}
