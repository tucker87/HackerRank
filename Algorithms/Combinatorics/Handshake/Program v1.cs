using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) 
    {
        var t = Convert.ToInt32(Console.ReadLine());
        for (var i = 0; i < t; i++) 
        {
            long total = 0;
            var n = Convert.ToInt64(Console.ReadLine());
            total = ShakeHands(1, n);
            Console.WriteLine(total);
        }
    }
    static long ShakeHands(long person, long max){
        if (person + 1 > max) return 0;
        return max - person + ShakeHands(person + 1, max);
    }
}