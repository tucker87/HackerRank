using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        var t = Convert.ToInt32(Console.ReadLine());
        for (var c = 0; c < t; c++) 
        {
            Console.ReadLine();
            var a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToArray();
            long positiveSum = long.MinValue;
            long currentSum = 0;
            long bestSum = 0;
            var currentStartIndex = -1;
            var bestStartIndex = 0;
            var bestEndIndex = 0;
            for (var i = 0; i < a.Length; i++)
            {
                var num = a[i];
                if (num > 0) 
                {
                    if (positiveSum < 1)
                        positiveSum = 0;
                       
                    positiveSum += num;
                }
                else    
                {
                    if(positiveSum < 1)
                        if(num > positiveSum)
                            positiveSum = num;
                }
                
                
                var val = currentSum + a[i];
                if (val > 0) 
                {
                    if (currentSum == 0)
                        currentStartIndex = i;
                    
                    currentSum = val;
                } 
                else
                    currentSum = 0;
                
                if (currentSum > bestSum) 
                {
                    bestSum = currentSum;
                    bestStartIndex = currentStartIndex;
                    bestEndIndex = i;
                }
                    
                
            }
            var bestSegment = new long[bestEndIndex + 1 - bestStartIndex];
            Array.Copy(a, bestStartIndex, bestSegment, 0, bestEndIndex + 1 - bestStartIndex);
            Console.WriteLine(bestSegment.Sum() + " " + positiveSum);
        }
    }
}