using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var t = Convert.ToInt32(Console.ReadLine());

        while (t > 0)
        {
            var a = Console.ReadLine().ToList();
            var b = Console.ReadLine().ToList();

            var lettersA = new int[26];
            var lettersB = new int[26];

            foreach (var letter in a)
                lettersA[letter - 'a']++;

            foreach (var letter in b)
                lettersB[letter - 'a']++;

            Console.WriteLine(lettersA.Where((t1, i) => t1 > 0 && lettersB[i] > 0).Any() ? "YES" : "NO");
        }
    }
}