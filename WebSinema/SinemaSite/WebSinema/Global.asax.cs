using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebSinema
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            InitialDB myDBInitializer = new InitialDB();
            myDBInitializer.SetDataBase();


            DAL.DbTabels context = DAL.DbTabels.GetInstance();
        }
    }
}