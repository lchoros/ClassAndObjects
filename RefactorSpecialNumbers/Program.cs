using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            bool isSpecialNumber = false;
            int sum = 0;
            int currentNumber = 0;
            for (int index = 1; index <= endNum; index++)
            {
                currentNumber = index;
                while (index > 0)
                {
                    sum += index % 10;
                    index /=  10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{index} -> {isSpecialNumber}");
                sum = 0;
                index = currentNumber;
            }
        }
    }
}
