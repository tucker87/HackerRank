using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
public class Solution
{
    private static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var balls = new List<long>();
        while (n > 0)
        {
            balls.Add(Convert.ToInt64(Console.ReadLine()));
            n--;
        }

        Console.WriteLine("{0:F1}", (double)balls.Sum() / 2);
        Console.ReadLine();
    }
}