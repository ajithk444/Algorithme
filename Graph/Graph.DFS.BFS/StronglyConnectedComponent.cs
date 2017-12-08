using System;
using System.Collections.Generic;

namespace Algorithmne
{
    public class StronglyConnectedComponent
    {
        public AdjacencyList AdjList { get; set; }
        public AdjacencyList ReverseAdjList { get; set; }
        public Stack<int> Stack { get; set; }

        public StronglyConnectedComponent(AdjacencyList adjList)
        {
            AdjList = adjList;
            Stack = new Stack<int>();
        }

        public void DFSsearching(int i)
        {
            AdjList.Visited[i] = true;

            foreach (int s in AdjList.AdjListArray[i])
            {
                if (AdjList.Visited[s] == false)
                {
                    DFSsearching(s);
                }
            }

            Stack.Push(i);
        }

        public void DFSPrint(int i)
        {
            ReverseAdjList.Visited[i] = true;

            foreach (int s in ReverseAdjList.AdjListArray[i])
            {
                if (ReverseAdjList.Visited[s] == false)
                    DFSPrint(s);
            }


            Console.Write(i + " ");
        }

        public void PrintSCC()
        {
            // DFS over the adjacencyList$
            for (int i = 0; i < AdjList.V; i++)
            {
                if (AdjList.Visited[i] == false)
                {
                    DFSsearching(i);
                }
            }

           ReverseAdjList = GetTransposeGraph();

            while(Stack.Count > 0)
            {
               int i = Stack.Pop();
               if (ReverseAdjList.Visited[i] == false)
               {
                   DFSPrint(i);
                   Console.Write(" :: ");
                }
                
            }
        }

        private AdjacencyList GetTransposeGraph()
        {
            AdjacencyList reversGraph = new AdjacencyList(AdjList.V);

            for (int i = 0; i < AdjList.V; i++)
            {
                foreach (int des in AdjList.AdjListArray[i])
                {
                    reversGraph.AdjListArray[des].AddLast(i);
                }
            }

            return reversGraph;
        }
    }
}
