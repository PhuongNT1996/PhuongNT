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
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult ViewCart()
        {
            return View();
        }



        public ActionResult Add(FormCollection f)
        {
            Dictionary<Product, int> myCart = new Dictionary<Product, int>();

            if (Session["CART"] != null)
            {
                myCart = (Dictionary<Product, int>)Session["CART"];
            }
            string s_quantity = f["myNumber"];
            Int32 quantity = Convert.ToInt32(s_quantity);

            Product pro_detail = (Product)Session["PRO_DETAIL"];

            if (myCart.Count == 0)
            {
                myCart.Add(pro_detail, quantity);
            }
            else
            {
                List<Product> proList_dic = new List<Product>(myCart.Keys);
                for (int i = 0; i < proList_dic.Count; i++)
                {
                    if (pro_detail.Product_ID.Equals(proList_dic[i].Product_ID))
                    {
                        myCart[proList_dic[i]] += quantity;
                        Session["CART"] = myCart;
                        return View();
                    }
                }
                myCart.Add(pro_detail, quantity);
            }
            Session["CART"] = myCart;
            return View();
        }

      

    }
}