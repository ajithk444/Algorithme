namespace Graph.Base
{
    using System;
    using System.Collections.Generic;

    public struct Node
    {
        public int Des { get; set; }
        public int Weight { get; set; }
    }

    public class AdjacencyListEdgeWeight
    {
        public int V { get; set; }
        public LinkedList<Node>[] AdjListArray { get; set; }
        public bool[] Visited { get; set; }
        public bool IsDirected { get; set; }

        public AdjacencyListEdgeWeight(int v, bool isDirected = false)
        {
            V = v;
            AdjListArray = new LinkedList<Node>[V];

            for (var i = 0; i < AdjListArray.Length; i++)
            {
                AdjListArray[i]=new LinkedList<Node>();
            }

            Visited = new bool[V];
            IsDirected = isDirected;
        }

        public void Reset()
        {
            for (var i = 0; i < Visited.Length; i++)
            {
                Visited[i] = false;
            }
        }

        public void AddEdge(int src, int des, int weight)
        {
            AdjListArray[src].AddLast(new Node{Des = des, Weight = weight});
            if (!IsDirected)
            {
                AdjListArray[des].AddLast(new Node {Des = src, Weight = weight});
            }
        }
    }
}
