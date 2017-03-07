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
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ProductDetails(string productIDStr)
        {
            int id = 1;
            if(int.TryParse(productIDStr, out id))
            {
                id = int.Parse(productIDStr);
            }

            ProductDAL productDal = new ProductDAL();
            Product product = productDal.getProductById(id);
            CatalogueDAL catalogueDal = new CatalogueDAL();
            Catalogue catalogue = catalogueDal.getCatalogueById(product.Catalogue_ID);
            catalogueDal.getAllProductsByCatalogue(catalogue);
            List<Catalogue> catalogues = catalogueDal.getAllCatalogues();
            
            ProductDetailsModel productDetails = new ProductDetailsModel
            {
                ProductCatalogue = catalogue,
                ProductDetails = product,
                Catalogues = catalogues,                
            };
            
            return View(productDetails);  
        }
    }
}