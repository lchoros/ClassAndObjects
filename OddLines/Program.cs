using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines("input.txt").Where((x,i)=> i % 2 == 1).ToArray();
            File.WriteAllLines("output.txt", data);
        }
    }
}
