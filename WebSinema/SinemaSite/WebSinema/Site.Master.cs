using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSinema
{
    public partial class Site : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Users current = (Users)Session["myUser"];
                if (current.ToString() != null)
                    loginNav.InnerText = string.Format("welcome {0}!", current.UserName);
            }
            catch { }
        }
    }
}