using Model.DAL;
using Model.Models;
using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(FormCollection f)
        {
            string searchValue = f["txtSearchValue"];
            if (searchValue.Equals("Search"))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ProductDAL productDal = new ProductDAL();
                List<Product> productList = productDal.searchProduct(searchValue);
                if(productList == null)
                {
                    return RedirectToAction("Index", "Home");
                }else
                {
                    Session["SVALUE"] = searchValue;
                    return View(productList);
                }
            }   

        }
    }
}