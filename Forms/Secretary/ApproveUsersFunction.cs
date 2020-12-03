using Basic.SoftwareUsers;
using ConnectToDB.UsersCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Secretary
{
    public class ApproveUsersFunction
    {
        public List<User> UnknownUsers()
        {
            UserC inter = new UserC();
            return inter.UnknownUsers();
        }
        public void UpdateUserStatus(User u)
        {
            UserC inter = new UserC();
            inter.UpdateUser(u);

        }
    }
}
