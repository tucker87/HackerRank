using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var firstStone = Console.ReadLine().ToCharArray();
        var stones = new char[n-1][];
        for (var i = 0; i < n-1; i++)
            stones[i] = Console.ReadLine().ToCharArray();

        var gemStones = new HashSet<char>();
        foreach (var baseGem in firstStone.Where(baseGem => stones.All(stone => stone.Contains(baseGem))))
            gemStones.Add(baseGem);

        Console.WriteLine(gemStones.Count);
    }
}