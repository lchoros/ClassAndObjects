using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split(' ');
            var pattern = "";
            var regex = new Regex(pattern);

            foreach (var number in phoneNumbers)
            {
                if(regex.IsMatch(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
