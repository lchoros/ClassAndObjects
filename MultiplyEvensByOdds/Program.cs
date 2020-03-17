using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }

        private static int GetMultipleOfEvensAndOdds(int n)
        {
            int evenSum = 0;
            int oddSum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                if(digit % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
                n /= 10;
            }
            return evenSum * oddSum;
        }
    }
}
