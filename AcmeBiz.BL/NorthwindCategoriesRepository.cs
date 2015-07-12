using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind;

namespace AcmeBiz.BL
{
    public partial class NorthwindCategoriesRepository
    {
        static public List<Category> GetCategories()
        {
            List<Category> categories;

            using (var ctx = new NorthwindEntities())
            {
                var q = from category in ctx.Categories
                        select category;

                categories = q.ToList<Category>();
            }

            return categories;

        } // end GetCategories

        
    }
}
