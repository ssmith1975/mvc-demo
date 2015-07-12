using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Northwind;
using Northwind.ViewModel;
namespace AcmeBiz.ViewModel
{
    public partial class HomeViewModel
    {
        public List<NorthwindProductsViewModel> FeaturedProductsList { get; set; }
        public List<NorthwindProductsViewModel> NewProductsList { get; set; }
        public List<NorthwindProductsViewModel> TopSellerProductsList { get; set; }

    }
}