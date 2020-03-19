using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
            var wordsToCount = File.ReadAllText("words.txt").Split(' ').Distinct();

            foreach (var word in wordsToCount)
            {
                wordsCount.Add(word, 0);
            }

            string[] words = File.ReadAllText("text.txt").Split(new char[] { '-', '?', '.', ',', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            wordsCount = wordsCount.OrderByDescending(m => m.Value).ToDictionary(m => m.Key, m=> m.Value);

            List<string> result = new List<string>();

            //foreach (var item in wordsCount)
            //{
            //    File.AppendAllText("output.txt", $"{item.Key} - {item.Value}{Environment.NewLine}");
            //    result.Add($"{item.Key} - {item.Value}");
            //}

            File.WriteAllText("output.txt", string.Join(Environment.NewLine, wordsCount.Select(x => x.Key + " - " + x.Value).ToArray()));
        }
    }
}
