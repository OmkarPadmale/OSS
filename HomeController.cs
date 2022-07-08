using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//this is cmnt from omkar padmale
namespace TFLWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int currentVisitCount = int.Parse(this.HttpContext.Session["visits"].ToString());

            this.HttpContext.Session["visits"] = currentVisitCount + 1;
                
            return View();
        }


        public ActionResult Aboutus()
        {
            int currentVisitCount = int.Parse(this.HttpContext.Session["visits"].ToString());
            this.HttpContext.Session["visits"] = currentVisitCount + 1;
            return View();
        }
    }
}
