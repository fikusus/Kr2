using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavd2
{
    class Shop
    {
        private List<Product> products = new List<Product>();

        public void Add(Product product)
        {
            if (product != null)
                products.Add(product);
        }


        public void SortByName()
        {
            products.Sort(new ProductNameComparer());
        }
        public void SortByPrice()
        {
            products.Sort(new ProductPriceComparer());
        }

        public void SortByCount()
        {
            products.Sort(new ProductCountComparer());
        }
        public void SortByTerminology()
        {
            products.Sort(new ProductTerminologyComparer());
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Магазин\n");
            foreach (Product item in products)
            {
                stringBuilder.Append(item).Append("\n");
            }
            return stringBuilder.ToString();
        }
    }
}
