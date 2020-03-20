using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //char letter = (char)('a' + num);
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        for (int k = 0; k < num; k++)
            //        {
            //            Console.WriteLine("{0}{1}{2}", (char)('a' + i), (char)('a' + j), (char)('a' + k));
            //        }
            //    }
            //}
            var letter = (char)('a' + num);
            for (char i = 'a'; i < letter; i++)
            {
                for (char j = 'a'; j < letter; j++)
                {
                    for (char k = 'a'; k < letter; k++)
                    {
                        Console.WriteLine("{0}{1}{2}",  i,  j,  k);
                    }
                }
            }
        }
    }
}
