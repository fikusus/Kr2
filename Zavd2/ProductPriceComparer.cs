using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavd2
{
    class ProductPriceComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x.Price > y.Price)
                return 1;
            else if (x.Price < y.Price)
                return -1;
            else
                return 0;
        }
    }
}
