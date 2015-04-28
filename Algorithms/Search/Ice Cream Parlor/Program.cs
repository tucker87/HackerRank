using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
public class Solution
{
    private static void Main(String[] args)
    {
        var t = Convert.ToInt32(Console.ReadLine());

        while (t > 0)
        {
            var m = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            var costs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();

            var found = false;
            for (var a = 0; a < costs.Count; a++)
            {
                for (var b = a + 1; b < costs.Count; b++)
                {
                    if (costs[a] + costs[b] == m)
                    {
                        found = true;
                        Console.WriteLine("{0} {1}", a + 1, b + 1);
                        break;
                    }
                }
                if (found) break;
            }
            t--;
        }
       
        Console.WriteLine();
        Console.ReadLine();
    } 
}