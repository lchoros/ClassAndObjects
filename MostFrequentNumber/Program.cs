using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();

            Dictionary<int, int> frequentCounter = new Dictionary<int, int>();

            foreach (var num in numbers)
            {
                if (!frequentCounter.ContainsKey(num))
                {
                    frequentCounter.Add(num, 0);
                }
                frequentCounter[num]++;
            }
            File.WriteAllText("output.txt", frequentCounter.OrderByDescending(m => m.Value).FirstOrDefault().Key.ToString());
        }
    }
}
