using System;
using Graph.Base;

namespace Graph.Cycle
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Detected the cycle in the directed graph
            //Graph 1.0.2
            //AdjacencyList adjacencyList = new AdjacencyList(7, true);
            //adjacencyList.AddEdge(0, 1);
            //adjacencyList.AddEdge(1, 2);
            //adjacencyList.AddEdge(2, 0);
            //adjacencyList.AddEdge(2, 3);
            //adjacencyList.AddEdge(2, 6);
            //adjacencyList.AddEdge(3, 4);
            //adjacencyList.AddEdge(4, 5);
            //adjacencyList.AddEdge(5, 3);

            //CycleDirectedGraph cycleDirectedGraph = new CycleDirectedGraph(adjacencyList);
            ////cycleDirectedGraph.DetectCycle();
            //cycleDirectedGraph.DetectCycleWithColor();

            //Detected the cycle in the Undirected graph
            //Graph 1.0.4
            //AdjacencyList adjacencyList = new AdjacencyList(6);
            //adjacencyList.AddEdge(0, 1);
            //adjacencyList.AddEdge(0, 3);
            //adjacencyList.AddEdge(0, 4);
            //adjacencyList.AddEdge(0, 5);
            //adjacencyList.AddEdge(1, 2);
            //adjacencyList.AddEdge(4, 5);

            //CycleUnDirectedGraph cycleInDirectedGraph = new CycleUnDirectedGraph(adjacencyList);
            //cycleInDirectedGraph.DetectCycle();

            //Detected the cycle in the UnDirected graph
            //Graph 1.0.4
            GraphVertexEdge graph = new GraphVertexEdge(6);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 3);
            graph.AddEdge(0, 4);
            graph.AddEdge(0, 5);
            graph.AddEdge(1, 2);
            graph.AddEdge(4, 5);
            CycleUnDirectedGraphFindUnion findUnionGraph = new CycleUnDirectedGraphFindUnion(graph);
            findUnionGraph.DetectCycle();

            Console.Read();
        }
    }
}
