using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind;
using Northwind.ViewModel;
using AcmeBiz.BL;

namespace AcmeBiz.ViewModel
{
    public partial class ViewModelFactory
    {
        private static ViewModelFactory Instance = null;

        private ViewModelFactory() { }

        public static ViewModelFactory GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new ViewModelFactory();
                }
                return Instance;
            }
        }



    }
}