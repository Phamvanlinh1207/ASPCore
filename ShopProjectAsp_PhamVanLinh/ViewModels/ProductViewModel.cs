using ShopProjectAsp_PhamVanLinh.Data;
using ShopProjectAsp_PhamVanLinh.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace ShopProjectAsp_PhamVanLinh.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
