using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Controllers
{
    public class DeliveryController : Controller
    {
        // GET: Delivery
        public ActionResult Index()
        {
            ViewBag.TitlePage = "Online Shopping | Delivery";
            ViewBag.Page = "Delivery";
            return View();
        }
    }
}