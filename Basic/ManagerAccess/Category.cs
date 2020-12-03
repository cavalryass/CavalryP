using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.ManagerAccess
{
    public class  MainCategory
    {
        public int Id { get; set; }
        public string name { get; set; }

        public MainCategory()
        {
            Id = 0;
            this.name = "";
        }
        public MainCategory(int id, string name)
        {
            Id = id;
            this.name = name;
        }
    }
    public class Category
    {
        #region prop
        public int id { get; set; }
        public string name { get; set; }
        public string mainC { get; set; }
        public string kind { get; set; }
        #endregion
        #region ctor
        public Category()
        {
            this.id = 0;
            this.name = "";
            this.mainC = "0";
            this.kind = "";
        }
        public Category(string name, string mainC, string kind)
        {
            this.id = 0;
            this.name = name;
            this.mainC = mainC;
            this.kind = kind;
        }
        public Category(int id, string name, string mainC, string kind)
        {
            this.id = id;
            this.name = name;
            this.mainC = mainC;
            this.kind = kind;
        }
        #endregion
    }
}
