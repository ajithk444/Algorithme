namespace Graph.Base
{
    using System;

    public class AdjacencyMatrix
    {
        public static int[,] AdacencyMatrix;
        public int N { get; set; }
        public int E { get; set; }
        public bool IsDirected { get; set; }

        public AdjacencyMatrix(int n, bool isDirected = false)
        {
            N = n;
            E = 0;
            AdacencyMatrix = new int[N, N];
            IsDirected = isDirected;
        }

        public void AddEdge(int src, int des, bool isDirected = false)
        {
            AdacencyMatrix[src, des] = 1;
            if (!IsDirected)
            {
                AdacencyMatrix[des, src] = 1;
            }
            ++E;
        }

        public void Print()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(AdacencyMatrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
