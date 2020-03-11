using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            var randomizer = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var position = randomizer.Next(0, words.Count);
                var oldWord = words[i];
                words[i] = words[position];
                words[position] = oldWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
