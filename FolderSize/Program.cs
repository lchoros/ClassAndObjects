using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = Directory.GetFiles("TestFolder");

            long size = 0l;
            foreach (var file in folder)
            {
                size += new FileInfo(file).Length;
            }
            File.WriteAllText("output.txt", ConvertBytesToMegabytes(size).ToString());
        }

        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }
    }
}
