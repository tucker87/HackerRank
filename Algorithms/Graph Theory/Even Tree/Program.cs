using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static bool[] visit = new bool[105];
        static List<int>[] tree = new List<int>[105];
        private static int _ans;

        private static void Main(string[] args)
        {
            for (var i = 0; i < tree.Count(); i++)
                tree[i] = new List<int>();

            var m = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).First();

            for (var i = 0; i < m - 1; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                var a = input[0];
                var b = input[1];
                //Console.WriteLine(a + " " + b);
                tree[a].Add(b);
                tree[b].Add(a);
            }

            Dfs(1);
            Console.WriteLine(_ans);
        }

        static int Dfs(int node)
        {
            visit[node] = true;
            var numVertex = 0;
            for (var i = 0; i < tree[node].Count; i++)
            {
                if (!visit[tree[node][i]])
                {
                    var numNodes = Dfs(tree[node][i]);
                    if (numNodes % 2 == 0)
                        _ans++;
                    else
                        numVertex += numNodes;
                }
            }
            return numVertex + 1;
        }
    }