using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CavalryP.MasterForm
{
    public partial class ClientMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GlobalForm/StartPage.aspx");
        }
    }
}