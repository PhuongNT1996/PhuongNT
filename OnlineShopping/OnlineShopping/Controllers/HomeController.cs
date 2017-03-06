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
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.TitlePage = "Online Shopping | Home";
            ViewBag.Page = "Home";

            HomeProductsModel homeProduct = new HomeProductsModel();
            ProductDAL productDal = new ProductDAL();

            List<Product> products = productDal.getTopNewProduct();           
            homeProduct.NewProducts = products;

            products = productDal.getTopTrending();
            homeProduct.TrendingProducts = products;

            products = productDal.getTopBestSeller();
            homeProduct.BestSellerProducts = products;

            CatalogueDAL catalogueDal = new CatalogueDAL();
            List<Catalogue> catalogues = catalogueDal.getAllCatalogues();
            homeProduct.Catalogues = catalogues;

            return View(homeProduct);
        }

        public ActionResult NewProduct()
        {
            ViewBag.TitlePage = "Online Shopping | Home";
            ViewBag.Page = "Home";

            HomeProductsModel homeProduct = new HomeProductsModel();
            ProductDAL productDal = new ProductDAL();

            List<Product> products = productDal.getAllNewProduct();

            return View(products);
        }

        public ActionResult BestSeller()
        {
            ViewBag.TitlePage = "Online Shopping | Home";
            ViewBag.Page = "Home";

            HomeProductsModel homeProduct = new HomeProductsModel();
            ProductDAL productDal = new ProductDAL();

            List<Product> products = productDal.getAllBestSeller();

            return View(products);
        }

        public ActionResult Trending()
        {
            ViewBag.TitlePage = "Online Shopping | Home";
            ViewBag.Page = "Home";

            HomeProductsModel homeProduct = new HomeProductsModel();
            ProductDAL productDal = new ProductDAL();

            List<Product> products = productDal.getAllTrending();

            return View(products);
        }

        public ActionResult Catalogue(string IDStr)
        {
            int ID = 1;
            if (int.TryParse(IDStr, out ID))
            {
                ID = int.Parse(IDStr);
            }
            CatalogueDAL catalogueDal = new CatalogueDAL();
            Catalogue catalogue = catalogueDal.getCatalogueById(ID);

            catalogueDal.getAllProductsByCatalogue(catalogue);
            return View(catalogue);
        }
    }
}