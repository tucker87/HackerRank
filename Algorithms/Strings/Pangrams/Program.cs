using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        var letters = new int[26];
        var sentence = Console.ReadLine().Replace(" ","").ToLower();
        foreach (char c in sentence){
            letters[c-97]++;
        }
        if(letters.Min() == 0)
            Console.Write("not ");
        
        Console.WriteLine("pangram");
    }
}