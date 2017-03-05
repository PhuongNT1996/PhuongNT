using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            ViewBag.TitlePage = "Online Shopping | News";
            ViewBag.Page = "News";
            return View();
        }
    }
}