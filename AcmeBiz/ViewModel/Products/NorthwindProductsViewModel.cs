using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Northwind;
using Northwind.Custom;
using System.ComponentModel.DataAnnotations;


namespace Northwind.ViewModel
{
     public partial class NorthwindProductsViewModel
    {

         public int ProductID { get; set; }
         public string ProductName { get; set; }
         public int SupplierID { get; set; }
         public int CategoryID { get; set; }
         public Category Category { get; set; }
         public string QuantityPerUnity { get; set; }
         [DisplayFormat(DataFormatString = "{0:$#.##}")]
         public decimal UnitPrice { get; set; }
         public short UnitsInStock { get; set; }
         public short UnitOnOrder { get; set; }
         public short ReorderLevel { get; set; }
         public bool Discontinued { get; set; }
         

         public List<NorthwindProductsViewModel> ProductList { get; set; }

    }
}