using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.ViewModel;
using Model.Models;
using Model.DAL;

namespace OnlineShopping.Controllers
{
    public class UpdateAccountController : Controller
    {
        // GET: UpdateAccount
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(FormCollection f)
        {

            string email = f["txtEmail"];
            string fullName = f["txtFullname"];
            string bDate = f["slBirthDay"];
            string bMonth = f["slbirthMonth"];
            string bYear = f["slbirthYear"];
            string gender = f["slGender"];
            string address = f["txtAddress"];
            string s = bYear + "-" + bMonth + "-" + bDate;
            DateTime bd = Convert.ToDateTime(s);
            AccountDAL accountDal = new AccountDAL();
            accountDal.updateAccount(email, fullName, bd, gender, address);

            User_Account u_account = accountDal.getUser(email);
            Session["USER"] = u_account;
            DateTime birthday = (DateTime)u_account.Birthday;
            Session["DATE"] = birthday.Day.ToString();
            Session["MONTH"] = birthday.Month.ToString();
            Session["YEAR"] = birthday.Year.ToString();
            Session["GENDER"] = u_account.Gender;
            ViewBag.Message = "Update Successfully!";
            return View();
        }
    }
}