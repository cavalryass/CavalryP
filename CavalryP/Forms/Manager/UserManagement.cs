using Basic.SoftwareUsers;
using ConnectToDB.UsersCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Manager
{
    class UserManagement
    {
        public List<User> UnknownUsers()
        {
            UserC inter = new UserC();
            return inter.UnknownUsers();
        }
        public void ChangeUserStatus(User u,string status)
        {
            if(status!="Client")//all kind of status
            u.Status = status;
            UserC inter = new UserC();
            inter.UpdateUser(u);

        }
        
    }
}
