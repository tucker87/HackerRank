using System;

class Solution
{
    static void Main(String[] args)
    {
        var t = Convert.ToInt32(Console.ReadLine());

        while (t > 0)
        {
            var word = Console.ReadLine().ToCharArray();

            var funny = true;
            for (var i = 1; i < word.Length; i++)
            {
                if (Math.Abs(word[i] - word[i-1]) != Math.Abs(word[word.Length-1-i] - word[word.Length-i]))
                {
                    funny = false;
                    break;
                }
            }
            Console.WriteLine(funny ? "Funny" : "Not Funny");
            t--;
        }
        
    }
}