using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSinema.DAL;

namespace WebSinema.ViewPages
{
    public partial class AddMovei : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       // string fileName;
        DbTabels t = DbTabels.GetInstance();
        Moveis newMovies = new Moveis();
        protected void AddMoveis_Click(object sender, EventArgs e)
        {
          
                try
                 {
                //List<Moveis> checkID = t.Moveis.Where((n) => n.MoveiID == int.Parse("1001")).ToList();
                //int b = checkID[0].MoveiID;
                //if (checkID.Count!=0)
                //{   
                    newMovies = new Moveis();
                     if (fileUpload.HasFile)
                     {
                
                    int imgFillLength = fileUpload.PostedFile.ContentLength;
                    byte[] imgArr = new byte[imgFillLength];
                    HttpPostedFile poster = fileUpload.PostedFile;
                    poster.InputStream.Read(imgArr, 0, imgFillLength);
                    newMovies.MoveiImage = imgArr;
             
                // fileName = Path.GetFileName(fileUpload.PostedFile.FileName);
                //fileUpload.PostedFile.SaveAs(Server.MapPath("~/Img/") + fileName);
                //Response.Redirect(Request.Url.AbsoluteUri());
            }
              
                    newMovies.MoveiID = int.Parse(txtMuveiID.Text.Trim());
                    newMovies.MoveiName = txtMuviName.Text.Trim();
                    newMovies.MovieDirector = txtDirect.Text.Trim();
                    newMovies.RatingAvg = 0;
                    newMovies.Janer = txtJaner.Text.Trim();
                    newMovies.Description = txtDescription.Text.Trim();
                    List<Moveis> query = t.Moveis.Where((m) => m.MoveiID == newMovies.MoveiID).ToList();
                    if (query.Count > 0)
                    {
                        Response.Write("<script>alert('error! moveiID already exist ')</script>");
                    }
                    else
                    {
                        try
                        {
                            t.Moveis.Add(newMovies);
                            t.SaveChanges();
                            Response.Write("<script>alert('the movei added!')</script>");
                        }
                        catch (Exception ex)
                        {
                            Response.Write("<script>alert('Error! " + ex.Message + "')</script>");
                        }
                    }
               
                //}
                //else
                //    Response.Write("<script>alert('Error! ID already exsist. try another')</script>");
            }
              
            catch (Exception m)
            {
                Response.Write("<script>alert('error! " + m.Message + " ')</script>");
            }
        }
        protected void AddTime_Click(object sender, EventArgs e)
        {
            try
            {

                int check = int.Parse(txtIdMuvei.Text.Trim());
                Moveis moveis = t.Moveis.Where(l => l.MoveiID == check).FirstOrDefault();
                if (moveis != null)
                {
                    TimeAndPlace time = new TimeAndPlace();
                    time.MoveiID = int.Parse(txtIdMuvei.Text.Trim());
                    time.Place = txtPlace.Text.Trim();
                    time.Region = txtRegion.Text.Trim();
                    time.PriceCard = int.Parse(txtPrice.Text.Trim());
                    time.AmountCardsToSell = int.Parse(txtNumsell.Text.Trim());
                    time.AmountCardsLeft = time.AmountCardsToSell;
                    string txtTime1 = txtDate.Text + " " + txtHour.Text;

                    DateTime txtTime2 = DateTime.ParseExact(txtTime1, "MM/dd/yyyy HH:mm", null);

                    //DateTime txtTime= DateTime.ParseExact("02/28/2019 16:35", "MM/dd/yyyy HH:mm", null);
                    time.Date = txtTime2;
                    time.MovieName = moveis.MoveiName;
                    TimeSpan diff = time.Date - DateTime.Now;
                    if (diff.Days > 0)
                    {

                        try
                        {
                            t.TimeAndPlace.Add(time);
                            t.SaveChanges();
                            Response.Write("<script>alert('the Time and place added!')</script>");
                        }

                        catch (Exception ex)
                        {
                            Response.Write("<script>alert(ex.Message)</script>");
                        }
                    }
                    else
                        Response.Write("<script>alert('error! time over!')</script>");
                }
                else
                    Response.Write("<script>alert('error! Moveis ID not exsist')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' repair the date to 2 digit for mounth and day')</script>"); 
            }
        }
       
    }
}
