using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            string pattern = @"[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+$";
            var reg = new Regex(pattern);
            foreach (var name in names)
            {
                if (reg.IsMatch(name.Trim()))
                {
                    Console.WriteLine(name.Trim());
                }
            }
        }
    }
}
