﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactProductOfRealNumbers
{
    class Program
    {
        public static void Main()
        {
            int inputNums = int.Parse(Console.ReadLine());

            decimal sum = decimal.Parse(Console.ReadLine());

            for (int i = 0; i < inputNums - 1; i++)
            {
                decimal curentNum = decimal.Parse(Console.ReadLine());
                sum = sum * curentNum;
            }

            Console.WriteLine(sum);
        }
    }
}
