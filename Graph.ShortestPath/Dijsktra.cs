using System;
using System.Collections.Generic;
using Graph.Base;

namespace Graph.ShortestPath
{
    public class Dijsktra
    {
        public int[,] Graph { get; set; }
        public int V { get; set; }
        public bool[] Visited { get; set; }
        public int[] Parents { get; set; }
        public HashSet<int> TreeLeafNodes { get; set; }

        public AdjacencyListEdgeWeight AdjList { get; set; }

        public Dijsktra(int[,] graph)
        {
            Graph = graph;
            V = Graph.GetLength(0);
            Visited = new bool[V];
            Parents = new int[V];
            TreeLeafNodes = new HashSet<int>();
        }

        public Dijsktra(AdjacencyListEdgeWeight adjList)
        {
            AdjList = adjList;
        }

        public void CalculateUntil(int src, int[] weights)
        {
            Visited[src] = true;
            TreeLeafNodes.Remove(src);

            for (int i = 0; i < V; i++)
            {
                if (Visited[i] == false && Graph[src, i] > 0)
                {
                    TreeLeafNodes.Add(i);
                    if (weights[i] > weights[src] + Graph[src, i])
                    {
                        weights[i] = weights[src] + Graph[src, i];
                        Parents[i] = src;
                    }
                }
            }

            int minNodeValue = int.MaxValue;
            int index = -1;

            foreach (int treeLeafNode in TreeLeafNodes)
            {
                if (weights[treeLeafNode] < minNodeValue)
                {
                    minNodeValue = weights[treeLeafNode];
                    index = treeLeafNode;
                }
            }

            if (index != -1)
            {
                CalculateUntil(index, weights);
            }
        }

        public void CalculateUntilWithAdjList(int src, int[] weights)
        {
            Visited[src] = true;
            TreeLeafNodes.Remove(src);

            foreach (Node node in AdjList.AdjListArray[src])
            {
                if (Visited[node.Des] == false)
                {
                    TreeLeafNodes.Add(node.Des);
                    if (weights[node.Des] > weights[src] + node.Weight)
                    {
                        weights[node.Des] = weights[src] + node.Weight;
                        Parents[node.Des] = src;
                    }
                }
            }

            int minNodeValue = int.MaxValue;
            int index = -1;

            foreach (int treeLeafNode in TreeLeafNodes)
            {
                if (weights[treeLeafNode] < minNodeValue)
                {
                    minNodeValue = weights[treeLeafNode];
                    index = treeLeafNode;
                }
            }

            if (index != -1)
            {
                CalculateUntil(index, weights);
            }
        }

        public void CalculateShortestPath(int src)
        {
            int[] weights = new int[V];
            for (int i = 0; i < V; i++)
            {
                if (i == src)
                {
                    weights[i] = 0;
                }
                else
                {
                    weights[i] = int.MaxValue;
                }
            }
            TreeLeafNodes.Add(src);
            Parents[src] = src;
            CalculateUntil(src, weights);

            PrintShortestPathForEveryNode(src, weights, Parents);
        }

        private void PrintShortestPathForEveryNode(int src, int[] weights, int[] parents)
        {
            Stack<int> path = new Stack<int>();
            for (int i = 0; i < weights.Length; i++)
            {
                Console.WriteLine($"Node {i}, shortest weight {weights[i]}");
                int p = i;
                path.Push(p);
                do
                {
                    path.Push(parents[p]);
                    p = parents[p];
                } while (p != src);

                while (path.Count>0)
                {
                    Console.Write(path.Pop() + " => ");
                }
                Console.WriteLine();
            }
        }


        public void CalculateShortestPathWithAdjList(int src)
        {
            int[] weights = new int[V];
            for (int i = 0; i < V; i++)
            {
                if (i == src)
                {
                    weights[i] = 0;
                }
                else
                {
                    weights[i] = int.MaxValue;
                }
            }

            TreeLeafNodes.Add(src);
            Parents[src] = src;
            CalculateUntilWithAdjList(src, weights);

            PrintShortestPathForEveryNode(src, weights, Parents);
        }
    }
}
