using System;
using System.Linq;

namespace HackerRank
{
    internal class Program
    {
        static void Main()
        {
            var testCount = Convert.ToInt32(Console.ReadLine());
            while (testCount-- > 0)
            {
                var rowColumn = Console.ReadLine().Split(' ');
                var gridRowCount = Convert.ToInt32(rowColumn[0]);
                var gridColumnCount = Convert.ToInt32(rowColumn[1]);

                var grid = new int[gridRowCount][];

                for (var i = 0; i < gridRowCount; i++)
                    grid[i] = Console.ReadLine().Select(Convert.ToInt32).ToArray();

                rowColumn = Console.ReadLine().Split(' ');
                var patternRowCount = Convert.ToInt32(rowColumn[0]);
                var patternColumnCount = Convert.ToInt32(rowColumn[1]);

                var pattern = new int[patternRowCount][];

                for (var i = 0; i < patternRowCount; i++)
                    pattern[i] = Console.ReadLine().Select(Convert.ToInt32).ToArray();

                Console.WriteLine(SearchGrid(grid, pattern));
            }
        }

        private static string SearchGrid(int[][] grid, int[][] pattern)
        {

            for (var gR = 0; gR < grid.Length; gR++)
            {
                for (var gC = 0; gC < grid[gR].Length; gC++)
                {
                    if (gR + pattern.Length > grid.Length || gC + pattern[0].Length > grid[0].Length)
                        continue;

                    if(FindPattern(pattern, grid, gR, gC))
                        return "YES";
                }
            }
            return "NO";
        }

        private static bool FindPattern(int[][] pattern, int[][] grid, int gR, int gC)
        {
            var startColumn = gC;
            for (var pR = 0; pR < pattern.Length; pR++, gR++)
            {
                gC = startColumn;
                for (var pC = 0; pC < pattern[pR].Length; pC++, gC++)
                {
                    if (pattern[pR][pC] == grid[gR][gC])
                        continue;

                    return false;
                }
            }

            return true;
        }
    }
}