using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var t = Convert.ToInt32(Console.ReadLine());

        while (t > 0)
        {
            var words = Console.ReadLine();
            if (words.Length%2 != 0)
                Console.WriteLine(-1);
            else
            {
                var wordLength = words.Length/2;
                var wordA = words.Take(wordLength).ToArray();
                var wordB = words.Skip(wordLength).Take(wordLength).ToArray();

                var lettersA = new int[26];
                var lettersB = new int[26];

                foreach (var letter in wordA)
                    lettersA[letter - 'a']++;

                foreach (var letter in wordB)
                    lettersB[letter - 'a']++;

                var total = lettersA.Select((t1, i) => Math.Abs(t1 - lettersB[i])).Sum();
                Console.WriteLine(total/2);
            }
            t--;
        }
    }
}