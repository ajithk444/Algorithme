using System;
using System.Collections.Generic;
using Graph.Base;

namespace Algorithmne
{
    public class TransitiveClosureGraph
    {
        public AdjacencyList AdjList { get; set; }
        public Stack<int> Stack { get; set; }
        public int[,] AdjMatrix { get; set; }

        public TransitiveClosureGraph(AdjacencyList adjList)
        {
            AdjList = adjList;
            Stack = new Stack<int>();
            AdjMatrix = new int[AdjList.V, AdjList.V];
        }

        public void DFSsearching(int i, int row)
        {
            AdjMatrix[row, i] = 1;

            foreach (int s in AdjList.AdjListArray[i])
            {
                if (AdjMatrix[row, s] == 0)
                {
                    DFSsearching(s, row);
                }
            }
        }

        public void PrintTransitiveMatrix()
        {
            for (int i = 0; i < AdjList.V; i++)
            {
                DFSsearching(i, i);
            }

            for (int i = 0; i < AdjMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < AdjMatrix.GetLength(1); j++)
                {
                    Console.Write(AdjMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
