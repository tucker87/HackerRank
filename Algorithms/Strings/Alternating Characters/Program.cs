using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        var t = Convert.ToInt32(Console.ReadLine());
        for(var i = 0; i < t; i++)
        {
            var s = Console.ReadLine().ToArray();
            var currentValue = s[0] == 'A';
            var count = 0;
            for(var c = 1; c<s.Length; c++)
                if (s[c] == 'A' == currentValue)
                    count++;
                else
                    currentValue = !currentValue;
            Console.WriteLine(count);
        }
    }
}