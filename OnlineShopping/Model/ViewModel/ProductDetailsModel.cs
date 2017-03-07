using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class ProductDetailsModel
    {
        public Product ProductDetails { get; set; }
        
        public Catalogue ProductCatalogue { set; get; }

        public List<Catalogue> Catalogues { set; get; }
    }
}
