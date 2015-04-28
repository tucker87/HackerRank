using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) 
    {
        var m = 1234567;
        var t = Convert.ToInt32(Console.ReadLine());
        for (var i=0; i<t; i++) {
            var n = Convert.ToInt32(Console.ReadLine());
            var ni = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToArray();
            decimal total = 1;
            foreach (long town in ni) {
                total = (total%m * town%m);
            }
            Console.WriteLine(total%1234567);
        }
    }
}