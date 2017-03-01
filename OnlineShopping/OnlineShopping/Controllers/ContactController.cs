using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.TitlePage = "Online Shopping | Contact";
            ViewBag.Page = "Contact";
            return View();
        }
    }
}