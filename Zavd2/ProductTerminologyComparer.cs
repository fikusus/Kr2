using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavd2
{
    class ProductTerminologyComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x.Terminology > y.Terminology)
                return 1;
            else if (x.Terminology < y.Terminology)
                return -1;
            else
                return 0;
        }
    }
}
