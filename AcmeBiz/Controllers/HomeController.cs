using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcmeBiz.BL;
using AcmeBiz.ViewModel;
using Northwind.ViewModel;
//using AcmeBiz.Controllers;

namespace AcmeBiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            HomeViewModel viewModel = ViewModelFactory.GetInstance.GetHomeViewModel();
            return View(viewModel);
        } // end Index

    }
}
