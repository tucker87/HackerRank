using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var input1 = Console.ReadLine().ToCharArray();
        var input2 = Console.ReadLine().ToCharArray();
        
        var a = new int[26];
        var b = new int[26];

        foreach (var letter in input1)
            a[letter - 'a']++;

        foreach (var letter in input2)
            b[letter - 'a']++;

        var total = a.Select((t, i) => Math.Abs(t - b[i])).Sum();

        Console.WriteLine(total);
    }
}