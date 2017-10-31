namespace Algorithmne
{
    using System;
    using System.Collections.Generic;

    public class AdjacencyList
    {
        public int V;
        public LinkedList<int>[] adjListArray;
        bool[] visited;

        public AdjacencyList(int v)
        {
            V = v;
            adjListArray = new LinkedList<int>[V];

            for (var i = 0; i < adjListArray.Length; i++)
            {
                adjListArray[i]=new LinkedList<int>();
            }

            visited = new bool[V];
        }

        public void AddEdge(int src, int des)
        {
            adjListArray[src].AddLast(des);
            adjListArray[des].AddLast(src);
        }

        public void DisplayGraphBFS()
        {
            bool[] visited = new bool[V];

            Queue<int> queue = new Queue<int>();
            Console.Write("Please enter the start point : ");
            int start = int.Parse(Console.ReadLine());
            queue.Enqueue(start);
            visited[start] = true;

            while (queue.Count > 0)
            {
                int next = queue.Dequeue();
                Console.Write(next + " ");
                foreach (int i in adjListArray[next])
                {
                    if (visited[i] != true)
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
        }

        public void DisplayGraphDFS(int start)
        {
            Console.Write(start+" ");
            visited[start] = true;

            foreach (int i in adjListArray[start])
            {
                if (visited[i] != true)
                {
                    DisplayGraphDFS(i);
                    visited[i] = true;
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < V; i++)
            {
                foreach (int item in adjListArray[i])
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
