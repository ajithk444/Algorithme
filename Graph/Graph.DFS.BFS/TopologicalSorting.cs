using System.Linq;
using Graph.Base;

namespace Algorithmne
{
    using System;
    using System.Collections.Generic;

    public class TopologicalSorting
    {
        public AdjacencyList AdjList { get; set; }
        public Stack<int> Stack { get; set; }

        public TopologicalSorting(AdjacencyList adjList)
        {
            AdjList = adjList;
            Stack = new Stack<int>();
        }

        public void TopologicalSortingUtil(int i)
        {
            AdjList.Visited[i] = true;

            foreach (int s in AdjList.AdjListArray[i])
            {
                if (!AdjList.Visited[s])
                {
                    TopologicalSortingUtil(s);
                }
            }

            Stack.Push(i);
        }

        public void StartTopologicalSorting()
        {
            for (int i = 0; i < AdjList.V; i++)
            {
                if (!AdjList.Visited[i])
                {
                    TopologicalSortingUtil(i);
                }
            }

            foreach (int i in Stack)
            {
                Console.Write(i + " => ");
            }
        }
    }
}
