using Graph.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Other
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph = {{0, 1, 0, 1},
                {1, 0, 1, 1},
                {0, 1, 0, 1},
                {1, 1, 1, 0},
            };

            AdjacencyMatrix am = new AdjacencyMatrix(graph);
            MColoring.Solve(am, 3);

            Console.WriteLine(BiPartiteGraph.IsGraphBipartite(am));
            Console.Read();
        }
    }
}
