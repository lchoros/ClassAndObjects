using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSales = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();
            for (int i = 0; i < numberOfSales; i++)
            {
                var sale = ReadSale();
                if (!salesByTown.ContainsKey(sale.Town))
                {
                    salesByTown.Add(sale.Town, 0);
                }
                salesByTown[sale.Town] += sale.Price * sale.Quantity;
            }
            foreach (var s in salesByTown)
            {
                Console.WriteLine("{0} -> {1:f2}", s.Key, s.Value);
            }
        }

        public static Sale ReadSale()
        {
            string[] saleDetails = Console.ReadLine().Split(' ');
            var sale = new Sale
            {
                Town = saleDetails[0],
                Product = saleDetails[1],
                Price = decimal.Parse(saleDetails[2]),
                Quantity = decimal.Parse(saleDetails[3])
            };

            return sale;
        }
    }
}
