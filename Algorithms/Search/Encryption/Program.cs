using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
public class Solution
{
    private static void Main(String[] args)
    {
        var message = Console.ReadLine();
        var length = message.Length;
        var min = (int)Math.Floor(Math.Sqrt(length));
        var max = (int)Math.Ceiling(Math.Sqrt(length));

        var rows = 0;
        var columns = 0;

        while (rows == 0)
        {
            if (min*max >= length)
            {
                rows = min;
                columns = max;
            }
            min++;
        }

        var grid = new string[rows];
        var offset = 0;
        var inset = 0;
        for (var i = 0; i < grid.Length; i++)
        {
            while (offset + columns - inset > message.Length)
                inset++;

            grid[i] = message.Substring(offset, columns - inset);
            offset += columns;
        }

        var output = "";
        for (var c = 0; c < columns; c++)
        {
            for (var r = 0; r < rows; r++)
            {
                try
                {
                    output += grid[r][c];
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            output += " ";
        }

        Console.WriteLine(output);
        Console.ReadLine();
    }
}