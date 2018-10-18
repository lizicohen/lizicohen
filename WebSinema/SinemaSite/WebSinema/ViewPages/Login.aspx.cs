using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSinema.DAL;

namespace WebSinema.ViewPages
{
    public partial class Login : Page
    {
        string userName;
        string pass;
     

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                ReadCokie();
               if(userName!=null && pass!=null)
                    checkUser(userName, pass);

                
            }
            catch { }
           

        }
            protected void LogIn_Click(object sender, EventArgs e)
            {
               
            userName = txtLogUser.Text;
            pass = txtLogPass.Text;
            checkUser(userName, pass);
           
            }
            private void CreatCookie()
            {
                HttpCookie newCookie = new HttpCookie(userName, pass);
                newCookie.Expires = DateTime.Today.AddYears(2);
                Response.Cookies.Add(newCookie);
            }
            //in index page
           
            private void ReadCokie()
            {
                userName = Request.Cookies.GetKey(0);
                pass = Request.Cookies[userName].Value;
               
            }
            
        private void checkUser(string userName, string pass)
        {
            DbTabels t = DbTabels.GetInstance();
            var currentUser = t.Users.FirstOrDefault(u => u.UserName == userName && u.Password == pass);
            if (currentUser != null)
            {
                Session["myUser"] = currentUser;
                if (cbRememberMe.Checked)
                {
                    CreatCookie();

                }
                Response.Redirect("/index.aspx");
            }
            else
            {

                if (IsPostBack)
                {
                    errMsg.Style.Add("display", "normal");
                   // Response.Write("<script>alert('Error!  the user Name or password is not correct! ')</script>");
                }
            }
        }
        }
    }
    
