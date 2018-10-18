using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSinema.DAL;

namespace WebSinema.ViewPages
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            Users newUser = new Users();
            newUser.UserName = txtNewUserName.Text.Trim();
            newUser.Password = txtNewPassword.Text.Trim();
            newUser.IsAdmin = false;
            newUser.Email = txtnewEmail.Text.Trim();
            newUser.Phone = txtNewTel.Text.Trim();
            newUser.FirstName = txtNewfnPay.Text.Trim();
            newUser.LastName = txtNewlnPay.Text.Trim();
            newUser.ExpirtyDate = DateTime.Parse(txtNewExpirty.Text);
            int x = int.Parse(imagecart.SelectedValue);
            newUser.CreditCard = (CreditCompany)x;

            newUser.OwnerId = txtNewIdWoner.Text.Trim();
            newUser.NumCard = txtNewNumCard.Text.Trim();
            newUser.Cvv = txtCvv.Text.Trim();
            DbTabels t = DbTabels.GetInstance();
            try
            {
                t.Users.Add(newUser);
                t.SaveChanges();
                Response.Write("<script>alert('The new user added!');</script>");
                Response.Redirect("/Login.aspx");
            }
            catch(Exception )
            {
                Response.Write("<script>alert('Error');</script>");
            }
           
        }

    }
}
