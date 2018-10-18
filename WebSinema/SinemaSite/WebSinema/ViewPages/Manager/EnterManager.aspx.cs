using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSinema.DAL;

namespace WebSinema.ViewPages
{
    public partial class EnterManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            Users newUser = new Users();
            newUser.UserName = txtNewUserName.Text;
            newUser.Password = txtNewPassword.Text;
            if (rbPermition.SelectedValue == "Manager")
                newUser.IsAdmin = true;
            else newUser.IsAdmin = false;
            newUser.Email = txtnewEmail.Text;
            newUser.Phone = txtNewTel.Text;
            newUser.FirstName = txtNewfnPay.Text;
            newUser.LastName = txtNewlnPay.Text;
            newUser.ExpirtyDate = DateTime.Parse(txtNewExpirty.Text);
            int x = int.Parse(imagecart.SelectedValue);
            newUser.CreditCard = (CreditCompany)x;

            newUser.OwnerId = txtNewIdWoner.Text;
            newUser.NumCard = txtNewNumCard.Text;
            newUser.Cvv = txtCvv.Text;
            DbTabels t = DbTabels.GetInstance();
            try
            {
                t.Users.Add(newUser);
                t.SaveChanges();
                Response.Write("<script>alert('The new user added!');</script>");
                Response.Redirect("../Login.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error');</script>");
            }

        }

    }
}