using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;
using WebSinema.DAL;

namespace WebSinema
{
    public partial class index : Page
    {

        DbTabels t;
        List<Moveis> ms, allMoveis;
        protected void Page_Load(object sender, EventArgs e)
        {

           
            FillCart();
            ReadCookie();
          //  txtSearch.Text = "";
        }
       
        private void ReadCookie()
        {
            try
            {
                string user = Request.Cookies.GetKey(0);
                string pass = Request.Cookies[user].Value;
            }
            catch (Exception) { }
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string moveiSearch = txtSearch.Text.Trim();
            if (moveiSearch !="")
            {
                t = DbTabels.GetInstance();
                Moveis selected = t.Moveis.Where(m => m.MoveiName == moveiSearch).FirstOrDefault();
                if (ms != null)
                {
                    FillDetails(selected);
                }

            }
                
        }
        private void GetDetails()
        {
            string nameMovei = txtSearch.Text;
        }
        static List<Moveis> selectedMovei = new List<Moveis>();
        private void FillCart()
        {
             t = DbTabels.GetInstance();
             ms = t.Moveis.ToList();
            allMoveis = t.Moveis.ToList();
            GvAll.DataSource = allMoveis;
            GvAll.DataBind();

            //List<Moveis> v = ms.OrderBy(m => m.RatingAvg).Reverse().ToList();
            //List<Moveis> three = v;
            var three = (from item
                         in ms
                         orderby item.RatingAvg descending
                         select item).ToList();
            for (int i = 0; i < three.Count; i++)
            {
                selectedMovei.Add(three[i]);
            }

            lblR3_1.InnerText = three[0].RatingAvg.ToString();
            lblJ3_1.InnerText = three[0].Janer;
            lblN3_1.InnerText = three[0].MoveiName;
            try
            {
                lblI3_1.InnerHtml = "<img src=\"data:image/jpeg;base64," + Convert.ToBase64String(three[0].MoveiImage) + " \"  class='img-fluid w-100  card-img ' style='width: 6rem; height: 7rem;' > ";
            }
            catch (Exception)
            {
                lblI3_1.InnerHtml = " ";
            }
            

            lblR3_2.InnerText = three[1].RatingAvg.ToString();
            lblJ3_2.InnerText = three[1].Janer;
            lblN3_2.InnerText = three[1].MoveiName;
            try
            {
                lblI3_2.InnerHtml = "<img src=\"data:image/jpeg;base64," + Convert.ToBase64String(three[1].MoveiImage) + " \"  class='img-fluid w-100 card-img  ' style='width: 6rem; height: 7rem;'>";
            }
            catch (Exception)
            {
                lblI3_2.InnerHtml = " ";
            }

            lblR3_3.InnerText = three[2].RatingAvg.ToString();
            lblJ3_3.InnerText = three[2].Janer;
            lblN3_3.InnerText = three[2].MoveiName;
            try
            {
                lblI3_3.InnerHtml = "<img src=\"data:image/jpeg;base64," + Convert.ToBase64String(three[2].MoveiImage) + " \"  class='img-fluid w-100  card-img '  style='width: 6rem; height: 7rem;'>";
            }
            catch (Exception)
            {
                lblI3_3.InnerHtml = " ";
            }
        }

        protected void getDetails1_Click(object sender, EventArgs e)
        {
            FillDetails(selectedMovei[0]);
        }
        protected void getDetails2_Click(object sender, EventArgs e)
        {
            FillDetails(selectedMovei[1]);
        }
        protected void getDetails3_Click(object sender, EventArgs e)
        {
            FillDetails(selectedMovei[2]);
        }
        //"data:image/jpeg;base64," + Convert.ToBase64String(moveis.MoveiImage);
        List<Feedback> lstFeedback;
       
        protected void FillDetails(Moveis moveis) {
           
            Session["moveiSelect"] = moveis;
            try
            {
                imgDetails.InnerHtml = "<img src=\"data:image/jpeg;base64," + Convert.ToBase64String(moveis.MoveiImage) + " \"  class='img-fluid w-50  card-img  ' style='width: 14rem; height: 14rem;'>";
            }
            catch (Exception)
            {
                imgDetails.InnerHtml = " ";
            }
            try
            {
                moveiName.InnerText = moveis.MoveiName;
                moveiDirect.InnerText = moveis.MovieDirector;
                janer.InnerText = moveis.Janer;
                description.InnerText = moveis.Description;
                rating.InnerText = moveis.RatingAvg.ToString();

                try
                {
                    lstFeedback = moveis.Feedback.ToList();
                }
                catch (Exception) { }
                gvFeedback.DataSource = lstFeedback;
                gvFeedback.DataBind();
            }
            catch (Exception) { }
        }
        protected void FillGridView_Click(object sender, EventArgs e)
        {
            Moveis select = (Moveis)Session["moveiSelect"];
            lstFeedback = select.Feedback.ToList();
            gvFeedback.DataSource = lstFeedback;
            gvFeedback.DataBind();
            //moveiName.InnerText = lstFeedback.ToList().ToString();
        }

        //protected void Button3_Click(object sender, EventArgs e)
        //{
        //    Moveis select = (Moveis)Session["moveiSelect"];
        //    lstFeedback = select.Feedback.ToList();
        //    gvFeedback.DataSource = lstFeedback;
        //    gvFeedback.DataBind();


        //}

        //protected void BtnShowFeedback2_Click(object sender, EventArgs e)
        //{
        //    Moveis select = (Moveis)Session["moveiSelect"];
        //    lstFeedback = select.Feedback.ToList();

        //    gvFeedback.DataSource = lstFeedback;
        //    gvFeedback.DataBind();

        //}
       // protected void BtnAddFeedback_Click(object sender, EventArgs e) { }
        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var isCan = Session["myUser"] != null ? true : false;
                if (isCan)
                {
                    Moveis current = (Moveis)Session["moveiSelect"];
                    Feedback f = new Feedback();

                    
                    List<Feedback> lstFeedback = current.Feedback.ToList();

                    f.MoveiID = current.MoveiID;
                    f.FeedbackText = txtFeedback.Text;
                    f.Rating = decimal.Parse(txtRating.Text);
                    DbTabels t = DbTabels.GetInstance();
                    t.FeedBack.Add(f);
                    t.SaveChanges();
                    try
                    {
                        var lstRating = (from r
                                      in lstFeedback
                                         select r.Rating).ToList();
                        lstRating.Add(f.Rating);
                        decimal avg = (decimal)lstRating.Average();
                        Moveis movei = t.Moveis.Where((c) => c.MoveiID == current.MoveiID).First();
                        movei.RatingAvg = avg;
                        t.SaveChanges();
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('you are not permetion to add feadback. you are register before');", true);
                    
                }
            }
            catch (Exception ex) { }
        }
        protected void SelectedRow(object sender, EventArgs e)
        {
            
            GridViewRow row = GvAll.SelectedRow;

           
            var x = "You selected " + row.Cells[2].Text + ".";
        }
      
          protected void BtnShowTimes_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ViewPages/OrdersMoveis.aspx");
        }
        //public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        //{
        //    MemoryStream m = new MemoryStream(byteArrayIn);
        //    System.Drawing.Image img = System.Drawing.Image.FromStream(m);
        //    img.Save(Response.OutputStream, ImageFormat.Gif);
        //    return img;
        //}
    }
}