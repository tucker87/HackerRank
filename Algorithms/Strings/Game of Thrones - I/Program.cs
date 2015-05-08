using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var input = Console.ReadLine();
        var letters = new int[26];
        foreach (var c in input)
            letters[c - 97]++;
        
        Console.WriteLine(letters.Where(x => x%2 != 0).Count() <= 1 ? "YES" : "NO");
    }
}