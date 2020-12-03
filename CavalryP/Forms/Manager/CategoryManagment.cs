using Basic.ManagerAccess;
using ConnectToDB.AccountInfo;
using ConnectToDB.ManagerAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Manager
{
    public class CategoryManagment
    {
        public bool CheckIfAlreadyExist(Category c)
        {
            CategoryC inter = new CategoryC();
            return inter.IsSameExist(c);
        }
        public void CreateCategory(Category c)
        {
            if(c.name=="")
                throw new Exception("The Category Name Is Empty");
            if (c.mainC == "")
                throw new Exception("The Main Category Is Empty");       
            
            CategoryC inter = new CategoryC();
            if (inter.searchIfEx(c.name, c.kind))
                throw new Exception("This Category Already Exist");
            inter.InsertCategory(c);
            
        }
        public void DeleteCategory(int Id)
        {
            CategoryC inter = new CategoryC();
            inter.DeleteCategory(Id);
        }
        public void UpdateCategory(Category c)
        {
            CategoryC inter = new CategoryC();
            inter.DeleteCategory(c.id);
            inter.InsertCategory(c);
        }
        public List<string> MainCatSource()
        {
            CategoryC i = new CategoryC();
            List<string> l = i.AllMainC();
            l.Add("New");
            return l;
        }
        public List<CatWithMain> CategoryList()
        {
            CategoryC inter = new CategoryC();
            return inter.CategoryList();
        }
        public Category ReturnCategory(int Id)
        {
            CategoryC inter = new CategoryC();
            return inter.returnCategory(Id);
        }
        public List<AccInfo> CategoryAIDetails(string Dfrom, string Dto, string category)
        {
            AccInfoC c = new AccInfoC();
            if (Dfrom == "")
                Dfrom = "01/01/1900";
            if (Dto == "")
                Dto = DateTime.Now.ToShortDateString();
            try
            {
                if (Convert.ToDateTime(Dfrom) > DateTime.Now)
                    throw new Exception();
                if (Convert.ToDateTime(Dto) > DateTime.Now)
                    throw new Exception();

            }
            catch
            {
                throw new Exception("Unavailable Date");
            }
            return c.ListBelongToCategory(Dfrom, Dto,findCategoryName(category));
        }
       string findCategoryName(string cid)
        {
            CategoryC c = new CategoryC();
            return c.returnCategory(Convert.ToInt32(cid)).name;
        }
       public string findMainCatName(string cid)
        {
            CategoryC c = new CategoryC();
            return c.findMainCName(Convert.ToInt32(cid));
        }
    }
}
