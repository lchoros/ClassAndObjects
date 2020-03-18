using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> counter = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!counter.ContainsKey(numbers[i]))
                {
                    counter.Add(numbers[i], 0);
                }
                counter[numbers[i]]++;
            }

            foreach (var num in counter)
            {
                Console.WriteLine("{0} -> {1} times", num.Key, num.Value);
            }
        }
    }
}
