using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

public static class A
{
    public static void Main(string[] args)
    {
        var numbers = new List<int>
        {
            90,109,82,53,66,81,82,106,66,81,82,106
        };

        var letters = numbers.Select(x => (x/2)).ToList();


        for (var i = 0; i > -100; i--)
        {
            foreach (var letter in letters)
            {
                Console.Write((char)((letter + i) + 64));
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.ReadLine();
    }

    public static int FindModInverse(int input)
    {
        return 1;
    }
}