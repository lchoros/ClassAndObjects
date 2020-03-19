using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileOneNumbers = File.ReadAllLines("input1.txt");
            string[] fileTwoNumbers = File.ReadAllLines("input2.txt");

            List<string> result = new List<string>();

            result.AddRange(fileOneNumbers);
            result.AddRange(fileTwoNumbers);
            //File.WriteAllLines("output.txt", result.OrderBy(m => int.Parse(m)).Select(x => x.ToString()).ToArray());
            File.WriteAllText("output.txt", string.Join(Environment.NewLine, result.OrderBy(x => int.Parse(x))));
            //var firstFile = File.ReadAllLines("input1.txt");
            //var secondFile = File.ReadAllLines("input2.txt");

            //File.WriteAllText("result.txt", string.Empty);

            //for (int i = 0; i < firstFile.Length; i++)
            //{
            //    File.AppendAllText("result.txt", firstFile[i] + Environment.NewLine + secondFile[i] + Environment.NewLine);
            //}

        }
    }
}
