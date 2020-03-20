using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceAllTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var pattern = @"<a.*href=(""|')(.*)\1>(.*?)<\/a>";

            while (!inputLine.Equals("end"))
            {

                var reg = new Regex(pattern);
                var matches = reg.Matches(inputLine);
                var matche = matches;
                inputLine = reg.Replace(inputLine, @"[URL href=""$2""]$3[/URL]");

                Console.WriteLine(inputLine);

                inputLine = Console.ReadLine();
            }
        }
    }
}
