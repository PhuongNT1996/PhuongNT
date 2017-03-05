using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class HomeProductsModel
    {
        public List<Product> NewProducts { get; set; }
        public List<Product> TrendingProducts { get; set; }
        public List<Product> BestSellerProducts { set; get; }

        public List<Catalogue> Catalogues { set; get; }
    }
}
