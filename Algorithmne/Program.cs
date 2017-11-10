using System;
using System.Collections.Generic;

namespace Algorithmne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adjacency Matrix
            //AdjacencyMatrix.Generate();
            //AdjacencyMatrix.Print();

            //Adjacency List
            //BFS Display
            //AdjacencyList adjacencyList = new AdjacencyList(5);
            //adjacencyList.AddEdge(0, 1);
            //adjacencyList.AddEdge(0, 4);
            //adjacencyList.AddEdge(1, 2);
            //adjacencyList.AddEdge(1, 3);
            //adjacencyList.AddEdge(1, 4);
            //adjacencyList.AddEdge(2, 3);
            //adjacencyList.AddEdge(3, 4);

            ////adjacencyList.Print();
            ////adjacencyList.DisplayGraphBFS();
            //Console.Write("Please enter the start point for DFS : ");
            //int start = int.Parse(Console.ReadLine());
            //adjacencyList.DisplayGraphDFS(start);

            //TopologicalSorting
            //TopologicalSorting adjacencyList = new TopologicalSorting(6);
            //adjacencyList.AddEdge(5, 2);
            //adjacencyList.AddEdge(5, 0);
            //adjacencyList.AddEdge(4, 0);
            //adjacencyList.AddEdge(4, 1);
            //adjacencyList.AddEdge(2, 3);
            //adjacencyList.AddEdge(3, 1);

            //adjacencyList.StartTopologicalSorting();

            //Longest Path
            LongestPath adjacencyList = new LongestPath(6);
            adjacencyList.AddEdge(0, 1, 5);
            adjacencyList.AddEdge(0, 2, 3);
            adjacencyList.AddEdge(1, 3, 6);
            adjacencyList.AddEdge(1, 2, 2);
            adjacencyList.AddEdge(2, 4, 4);
            adjacencyList.AddEdge(2, 5, 2);
            adjacencyList.AddEdge(2, 3, 7);
            adjacencyList.AddEdge(3, 5, 1);
            adjacencyList.AddEdge(3, 4, -1);
            adjacencyList.AddEdge(4, 5, -2);

            //adjacencyList.CalculateLongestPathWithTopologicalOrder(1);
            adjacencyList.CalculateLongestPathWithRecursiveWay(1);


            Console.Read();

        }
    }
}
