using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectGame.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult get()
        {
            return View();
        }
        public ActionResult post()
        {
            return View();
        }
        public ActionResult put()
        {
            return View();
        }
      
        public ActionResult getRex()
        {
        
            return new FilePathResult("~/Views/Pages/getRex.html", "text/html");
        }
    }
}