using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavd2
{
    class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public double Count { get; set; }
        public DateTime Terminology { get; set; }

        public Product(string name, double price, double count, DateTime terminology)
        {
            Name = name ?? "Product";
            Price = price;
            Count = count;
            Terminology = terminology;
        }

        public override string ToString()
        {
            return Name + " цена:" + Price + " количество на складе:" + Count + " срок годности до " + Terminology.ToString("MM/dd/yyyy");
        }
    }
}
