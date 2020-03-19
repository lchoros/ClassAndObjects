using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            string path = "output.txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    sw.WriteLine($"{i + 1} {lines[i]}");
                }
            }
        }
    }
}
