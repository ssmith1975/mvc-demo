using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Custom
{
    public partial class ProductCategory:Product
    {
        //Product Product { get; set; }
        public byte[] Picture { get; set; }
    }
}
