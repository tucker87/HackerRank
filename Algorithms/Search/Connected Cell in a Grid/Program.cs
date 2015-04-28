using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
public class Solution
{
    public static bool[][] Grid { get; set; }
    public static int Height { get; set; }
    public static int Width { get; set; }

    private static void Main(String[] args)
    {
        Height = Convert.ToInt32(Console.ReadLine());
        Width = Convert.ToInt32(Console.ReadLine());

        Grid = new bool[Height][];

        for (var i = 0; i < Height; i++)
            Grid[i] = new bool[Width];

        var currentHeight = Height;
        while (currentHeight > 0)
        {
            var row = Console.ReadLine().Trim().Split(' ').Select(x => x == "1");
            
            foreach (var b in row.Select((x, i) => new { Value = x, Index = i }))
                Grid[Height - currentHeight][b.Index] = b.Value;

            currentHeight--;
        }

        var biggestRegion = 0;
        foreach (var row in Grid.Select((r, i) => new {Value = r, Index = i}))
            foreach (var column in row.Value.Select((c,i) => new {Value = c, Index = i}))
            {
                if (!column.Value) continue;

                var currentRegion = SearchRegion(row.Index, column.Index);

                if (currentRegion > biggestRegion)
                    biggestRegion = currentRegion;
            }

        Console.WriteLine(biggestRegion);
        Console.ReadLine();
    }

    private static int SearchRegion(int r, int c, bool[][] visited = null)
    {
        if (visited == null)
        {
           visited = new bool[Height][];

           for (var i = 0; i < Height; i++)
               visited[i] = new bool[Width];

            visited[r][c] = true;
        }
        else if (visited[r][c])
            return 0;
        else
            visited[r][c] = true;

        var biggestRegion = 0;

        foreach (var direction in Directions)
        {
            var newR = r + direction.Value.R;
            var newC = c + direction.Value.C;

            if (newR >= Height || newR < 0) continue;
            if (newC >= Width || newC < 0) continue;
            if (!Grid[newR][newC]) continue;

            biggestRegion += SearchRegion(newR, newC, visited);
        }

        return 1 + biggestRegion;
    }

    private static Dictionary<string, Coordinates> Directions
    {
        get
        {
            return new Dictionary<string, Coordinates>
            {
                {"Up", new Coordinates {R = -1}},
                {"Down", new Coordinates {R = 1}},
                {"Left", new Coordinates {C = -1}},
                {"Right", new Coordinates {C = 1}},

                {"UpLeft", new Coordinates {R = -1, C = -1}},
                {"UpRight", new Coordinates {R = -1, C = 1}},
                {"DownLeft", new Coordinates {R = 1, C = -1}},
                {"DownRight", new Coordinates {R = 1, C = 1}}
            };
        }
    }

    class Coordinates
    {
        public int R;
        public int C;
    }
}