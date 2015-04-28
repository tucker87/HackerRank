using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) 
    {
        var length = Convert.ToInt64(Console.ReadLine());
        var items = Console.ReadLine().Split(' ').ToArray();
        var count = new long[100];
        for (var i = 0; i < length; i++)
            count[Convert.ToInt64(items[i])]++;
            
        Console.WriteLine(String.Join(" ", count));
    }
}