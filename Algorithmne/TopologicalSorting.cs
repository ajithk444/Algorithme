namespace Algorithmne
{
    using System;
    using System.Collections.Generic;

    public class TopologicalSorting
    {
        public int V;
        public LinkedList<int>[] adjListArray;
        bool[] visited;

        public TopologicalSorting(int v)
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
        }

        public void TopologicalSortingUtil(int i, Stack<int> stack)
        {
            if (visited[i] == false)
            {
                visited[i] = true;

                foreach (int s in adjListArray[i])
                {
                    TopologicalSortingUtil(s, stack);
                }

                stack.Push(i);
            }
        }

        public void StartTopologicalSorting()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < V; i++)
            {
                if (!visited[i])
                {
                    TopologicalSortingUtil(i, stack);
                }
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop()+" ");
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
