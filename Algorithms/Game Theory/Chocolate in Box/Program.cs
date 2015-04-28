using System;
using System.Linq;

// ReSharper disable once CheckNamespace
public class Solution
{
    private static void Main(String[] args)
    {
        Console.ReadLine();
        var set = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToArray();
        
        var answer = set.Aggregate((current, number) => current ^ number);

        var answersCount = set.Count(number => (answer ^ number) < number);

        Console.WriteLine(answersCount);
    }
}