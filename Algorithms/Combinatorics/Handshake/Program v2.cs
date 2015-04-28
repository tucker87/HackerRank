using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) 
    {
        var t = Convert.ToInt32(Console.ReadLine());
        for (var i = 0; i < t; i++) 
        {
            var n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(n*(n-1)/2);
        }
    }
}