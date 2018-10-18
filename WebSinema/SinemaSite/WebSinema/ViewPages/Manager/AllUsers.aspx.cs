using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSinema.DAL;

namespace WebSinema.ViewPages
{
    public partial class AllUsers : System.Web.UI.Page
    {
        DbTabels t = DbTabels.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Users> listUsers = t.Users.ToList();
            GVUsers.DataSource = listUsers;

            GVUsers.DataBind();

        }
    }
}