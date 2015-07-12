using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Northwind;
using Northwind.ViewModel;
using AcmeBiz.BL;

namespace AcmeBiz.ViewModel
{
    public partial class ViewModelFactory
    {
        public List<NorthwindProductsViewModel> GetNorthwindProductsViewModel()
        {

            var products = NorthwindProductsRepository.GetProducts();

            List<NorthwindProductsViewModel> viewModel = new List<NorthwindProductsViewModel>();

            viewModel = (from product in products
                         select new NorthwindProductsViewModel()
                         {
                             ProductID = product.ProductID,
                             ProductName = product.ProductName,
                             UnitPrice = (decimal)product.UnitPrice,

                             Category = product.Category,
                             CategoryID = (int)product.CategoryID
                         }).ToList<NorthwindProductsViewModel>();

            return viewModel;
        } // end GetNorthwindProductsViewModel


        public List<NorthwindProductsViewModel> GetNorthwindFeaturedProductsViewModel()
        {

            var products = NorthwindProductsRepository.GetFeaturedProducts();

            List<NorthwindProductsViewModel> viewModel = new List<NorthwindProductsViewModel>();

            viewModel = (from product in products
                         select new NorthwindProductsViewModel()
                         {
                             ProductID = product.ProductID,
                             ProductName = product.ProductName,
                             UnitPrice = (decimal)product.UnitPrice,

                             Category = product.Category,
                             CategoryID = (int)product.CategoryID
                         }).ToList<NorthwindProductsViewModel>();

            return viewModel;
        } // end GetNorthwindFeaturedProductsViewModel

        public List<NorthwindProductsViewModel> GetNorthwindNewProductsViewModel()
        {

            var products = NorthwindProductsRepository.GetNewProducts();

            List<NorthwindProductsViewModel> viewModel = new List<NorthwindProductsViewModel>();

            viewModel = (from product in products
                         select new NorthwindProductsViewModel()
                         {
                             ProductID = product.ProductID,
                             ProductName = product.ProductName,
                             UnitPrice = (decimal)product.UnitPrice,
                             Category = product.Category,                           
                             CategoryID = (int)product.CategoryID
                         }).ToList<NorthwindProductsViewModel>();

            return viewModel;
        } // end GetNorthwindNewProductsViewModel


        public List<NorthwindProductsViewModel> GetNorthwindTopSellerProductsViewModel()
        {

            var products = NorthwindProductsRepository.GetTopSellerProducts();

            List<NorthwindProductsViewModel> viewModel = new List<NorthwindProductsViewModel>();

            viewModel = (from product in products
                         select new NorthwindProductsViewModel()
                         {
                             ProductID = product.ProductID,
                             ProductName = product.ProductName,
                             UnitPrice = (decimal)product.UnitPrice,

                             Category = product.Category,
                             CategoryID = (int)product.CategoryID
                         }).ToList<NorthwindProductsViewModel>();

            return viewModel;
        } // GetNorthwindTopSellerProductsViewModel 


    } // end class
}