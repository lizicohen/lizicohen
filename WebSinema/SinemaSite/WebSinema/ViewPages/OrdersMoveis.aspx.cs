using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSinema.DAL;

namespace WebSinema.ViewPages
{
    public partial class OrdersMoveis : Page
    {
        static DbTabels t = DbTabels.GetInstance();
        List<TimeAndPlace> time = t.TimeAndPlace.ToList();
        TimeAndPlace myt;
        Moveis m;
        Users currentUser;
        protected void Page_Load(object sender, EventArgs e)
        {

            //cardDetails.Style.Add("display", "none");
            

            if (!this.IsPostBack)
            {
                try
                {
                     m = (Moveis)Session["moveiSelect"];
                     time = m.TimeAndPlace.Where(i => i.AmountCardsLeft > 0 && i.Date>DateTime.Now).ToList();
                    if (time.Count==0 )
                    {
                        timesMoveis.InnerText = "sorry. the cards finished. try another movei";
                    }
                    else
                    {
                        GridView1.DataSource = time;
                        GridView1.DataBind();
                    }
                }
                catch (Exception)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Moveis not selected. select again!');", true);
                    Response.Redirect("/index.aspx");
                }
            }
           //cardDetails.Style.Add("display", "normal");

            }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Buy")
            {

                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[rowIndex];
                int numCardToBuy;
                int.TryParse((row.FindControl("txtCardToBuy") as TextBox).Text, out numCardToBuy);
                if (numCardToBuy < 1)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('input error. enter number cards to buy!');", true);
                }
                else
                {
                     currentUser = (Users)Session["myUser"];
                    if (currentUser == null)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You are not log in or register yet. go to register');", true);
                    }
                    else
                    {
                        fillOrder(rowIndex, numCardToBuy, currentUser);
                        cardDetails.Style.Add("display", "normal");
                       
                    }
                }





                // ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Name: " + name + "\\nCountry: " + country + "');", true);
            }
        }

        
        private void fillOrder(int row, int numOFCard, Users user)
            {
             m = (Moveis)Session["moveiSelect"];
             time = m.TimeAndPlace.ToList();
             myt = time[row];
            if (myt.AmountCardsLeft < 1)
                Response.Write("<script>alert('Sorry! all cards finished. try another movei!')</script>");
            else
            {
                if (myt.AmountCardsLeft - numOFCard < 0)
                    Response.Write("<script>alert('Sorry! left "+myt.AmountCardsLeft + " cards. change amount!')</script>");
                else
                {

                    Session["MyTime"] = myt;
                    txtmoveiName.InnerText = myt.MovieName;
                    txtDate.InnerText = myt.Date.ToString();
                    txtPlace.InnerText = myt.Place;
                    txtPrice.InnerText = myt.PriceCard.ToString();
                    txtNumCards.InnerText = numOFCard.ToString();
                    txtSum.InnerText = (myt.PriceCard * numOFCard).ToString();
                    txtUser.InnerText = user.UserName;
                    string n = user.NumCard;
                    txtCreditCard.InnerText = "***" + n.Substring(n.Length - 4, 4);
                   
                }
            }

            }

        private void AddOrder()
        {
            try
            {
                m= (Moveis)Session["moveiSelect"];
                myt = (TimeAndPlace)Session["MyTime"];
                currentUser = (Users)Session["myUser"];
                if(myt.AmountCardsLeft<1)
                    Response.Write("<script>alert('Sorry! all cards finished. try another movei!')</script>");
                myt.AmountCardsLeft = myt.AmountCardsLeft - int.Parse(txtNumCards.InnerText);
                Orders o = new Orders();
                o.MoveiID = m.MoveiID;
                o.TimeID = myt.TimeID;
                o.UserID = currentUser.UserID;
                o.DateOrders = DateTime.Now;
                o.AmountCardsIsBuy = int.Parse(txtNumCards.InnerText);
                o.SumPrice = int.Parse(txtNumCards.InnerText) * myt.PriceCard;
                t.Orders.Add(o);
                t.SaveChanges();
                Orders lastOrders = t.Orders.ToList().LastOrDefault();
                int numOrder = lastOrders.OrdersID;
                cardDetails.InnerText = "Your order added successfully.  number of your order is: " + numOrder;
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Order not added. try again')</script>");
            }
        }
        protected void BtnPay_Click(object sender, EventArgs e)
        {
            if (cbAgree.Checked)
                AddOrder();
            else
                Response.Write("<script>alert('Mark to agree for details order!')</script>");

        }

           
    }
}