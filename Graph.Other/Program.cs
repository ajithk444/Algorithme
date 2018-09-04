﻿using Graph.Base;
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
            //int[,] graph = {{0, 1, 0, 1},
            //    {1, 0, 1, 1},
            //    {0, 1, 0, 1},
            //    {1, 1, 1, 0},
            //};

            //AdjacencyMatrix am = new AdjacencyMatrix(graph);
            //MColoring.Solve(am, 3);

            //Console.WriteLine(BiPartiteGraph.IsGraphBipartite(am));

            int[,] graph = { 
                              {0, 16, 13, 0, 0, 0},
                              {0, 0, 10, 12, 0, 0},
                              {0, 4, 0, 0, 14, 0},
                              {0, 0, 9, 0, 0, 20},
                              {0, 0, 0, 7, 0, 4},
                              {0, 0, 0, 0, 0, 0}
                      };

            Console.WriteLine(FordFulkersonMaximumFlow.GetMaximunFlow(graph, 0, 5));


            Console.Read();
        }
    }
}
