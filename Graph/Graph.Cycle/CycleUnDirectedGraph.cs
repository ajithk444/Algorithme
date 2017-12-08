using System;
using System.ComponentModel;
using Graph.Base;

namespace Graph.Cycle
{
    public class CycleUnDirectedGraph
    {
        public AdjacencyList AdjList { get; set; }

        public CycleUnDirectedGraph(AdjacencyList adjList)
        {
            AdjList = adjList;
        }

        public void DetectCycle()
        {
            if (HasCycle())
            {
                Console.WriteLine("There is a cyle");
            }
            else
            {
                Console.WriteLine("No cycle");
            }
            
        }

        public bool HasCycle()
        {
            int v = AdjList.V;
            bool[] inStack = new bool[v];

            for (int i = 0; i < v; i++)
            {
                if (!AdjList.Visited[i] && DFSUtil(i, i, inStack))
                {
                    return true;
                }

            }
            return false;
        }

        private bool DFSUtil(int i, int parent, bool[] inStack)
        {
            AdjList.Visited[i] = true;
            inStack[i] = true;

            foreach (int child in AdjList.AdjListArray[i])
            {
                if (child!=parent && inStack[child])
                {
                    return true;
                }

                if (!AdjList.Visited[child] && DFSUtil(child, i, inStack))
                {
                    return true;
                }
            }

            inStack[i] = false;
            return false;
        }
    }
}
