using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["User"] = null;
            ViewBag.TitlePage = "Online Shopping | Home";
            ViewBag.Page = "Home";
            return View();
        }

    }
}