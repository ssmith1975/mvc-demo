using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind.ViewModel;

namespace AcmeBiz.ViewModel
{
    public partial class ViewModelFactory
    {
        public HomeViewModel GetHomeViewModel () {

            HomeViewModel viewModel = new HomeViewModel()
            {
                FeaturedProductsList = GetNorthwindFeaturedProductsViewModel(),
                NewProductsList = GetNorthwindNewProductsViewModel(),
                TopSellerProductsList = GetNorthwindTopSellerProductsViewModel()               
            };

            return viewModel;

        } // end GetHomeViewModel

    } // end class
}