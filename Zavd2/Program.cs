using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavd2
{
    class Program
    {
        delegate void SortingProduct();
        enum SortingType
        {
            ByName,
            ByPrice,
            ByCount,
            ByTerminology
        }

        static void Main(string[] args)
        {
            Dictionary<SortingType, SortingProduct> sortingDictinary = new Dictionary<SortingType, SortingProduct>();
            Shop shop = new Shop();   
            sortingDictinary.Add(SortingType.ByName, shop.SortByName);
            sortingDictinary.Add(SortingType.ByPrice, shop.SortByPrice);
            sortingDictinary.Add(SortingType.ByCount, shop.SortByCount);
            sortingDictinary.Add(SortingType.ByTerminology, shop.SortByTerminology);

            shop.Add(new Product("Сало", 142, 5, new DateTime(2020, 5, 25)));
            shop.Add(new Product("Вареники", 60, 12, new DateTime(2020, 5, 20)));
            shop.Add(new Product("Сосиски", 42, 10, new DateTime(2020, 6, 12)));
            shop.Add(new Product("Шпроты", 31, 3, new DateTime(2021, 5, 25)));
            shop.Add(new Product("Зубная паста", 68, 50, new DateTime(2022, 3, 25)));
            shop.Add(new Product("Лосось", 250, 1, new DateTime(2020, 4, 20)));

            foreach (SortingType sorting in Enum.GetValues(typeof(SortingType)))
            {
                Console.WriteLine(sorting.ToString());
                sortingDictinary[sorting]();
                Console.WriteLine(shop);
            }

            Console.ReadKey();
        }
    }
}
