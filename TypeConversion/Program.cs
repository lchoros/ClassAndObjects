using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var capacity = 4 + 8 + 12;

            int courses = n / capacity;

            if(n % capacity != 0)
            {
                courses += 1;
            }
            var courses2 = (int)Math.Ceiling((double)n / capacity);
            Console.WriteLine(courses);
            Console.WriteLine(courses2);
        }
    }
}
