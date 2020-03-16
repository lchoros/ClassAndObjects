using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPorudtcs = int.Parse(Console.ReadLine());
            var products = ReadProducts(numberOfPorudtcs);
            var customers = ReadCustomers(products);
            PrintOutput(customers);
        }

        public static void PrintOutput(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
                foreach (var item in customer.ShopList)
                {
                    Console.WriteLine("--{0} - {1}", item.Key, item.Value);
                }
                Console.WriteLine("Bill: {0:F2}", customer.Bill);
            }
            Console.WriteLine("Total bill: {0:F2}", customers.Sum(m => m.Bill));
        }

        public static Dictionary<string, decimal> ReadProducts(int numberOfProducts)
        {
            var products = new Dictionary<string, decimal>();
            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] productArgs = Console.ReadLine().Split('-');
                string productName = productArgs[0];
                decimal price = decimal.Parse(productArgs[1]);
                if(!products.ContainsKey(productName))
                {
                    products.Add(productName, price);
                }
                else
                {
                    products[productName] = price;
                }
            }
            return products;
        }

        public static List<Customer> ReadCustomers(Dictionary<string, decimal> products)
        {
            string command = Console.ReadLine();
            var customers = new List<Customer>();
            while (command != "end of clients")
            {
                string[] customerArgs = command.Split(new char[] { '-', ',' });
                string productName = customerArgs[1];
                if(products.ContainsKey(productName))
                {
                    string customerName = customerArgs[0];
                    int quantity = int.Parse(customerArgs[2]);
                    var customer = new Customer
                    {
                        Name = customerName,
                        ShopList = new Dictionary<string, int>(),
                        Bill = 0
                    };

                    if (!customer.ShopList.ContainsKey(productName))
                    {
                        customer.ShopList.Add(productName, quantity);
                    }
                    else
                    {
                        customer.ShopList[productName] += quantity;
                    }
                    customer.Bill += products[productName] * quantity;
                    customers.Add(customer);
                }
                command = Console.ReadLine();
            }
            customers = customers.OrderBy(m => m.Name).ToList();
            return customers;
        }
    }
}
