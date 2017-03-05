using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        OnlineShoppingEntities db = new OnlineShoppingEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost] 
        public ActionResult Login(FormCollection f)
        {
            string username = f["txtUsername"];
            string password = f["txtPassword"];
            User_Account account = db.User_Account.SingleOrDefault(s => s.Email == username && s.Password == password);
            if (account  == null)
            {
                ViewBag.Message = "Username or password ko dung";
                
            }
            else
            {
                Session["User"] = account;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}