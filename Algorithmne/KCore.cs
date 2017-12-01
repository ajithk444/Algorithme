using System;
using System.Linq;

namespace Algorithmne
{
    public class KCore
    {
        public AdjacencyList AdjList { get; set; }

        public KCore(AdjacencyList adjList)
        {
            AdjList = adjList;
        }

        public void DFSUtil(int start, int k)
        {
            AdjList.Visited[start] = true;
            int childrenNum = AdjList.AdjListArray[start].Count;

            for (int i = 0; i < childrenNum; i++)
            {
                if (childrenNum < k)
                {
                    int item = AdjList.AdjListArray[start].First.Value;
                    AdjList.AdjListArray[start].Remove(item);
                    AdjList.AdjListArray[item].Remove(start);
                    DFSUtil(item, k);
                }
                else
                {
                    int child = AdjList.AdjListArray[start].ElementAt(i);
                    if (AdjList.Visited[child] == false)
                    {
                        DFSUtil(child, k);
                    }
                }
              
            }
        }

        public void Print(int k)
        {
            int v = AdjList.V;
            int startPoint = 0;
            bool hasKeyCore = false;

            for (int i = 0; i < v; i++)
            {
                if (AdjList.AdjListArray[i].Count < k)
                {
                    startPoint = i;
                    break;
                }
            }

            DFSUtil(startPoint, k);

            hasKeyCore = AdjList.AdjListArray.Any(s => s.Count >= k);

            if (hasKeyCore)
            {
                for (int i = 0; i < AdjList.AdjListArray.Length; i++)
                {
                    if (AdjList.AdjListArray[i].Count >= k)
                    {
                        Console.Write(i + " => ");
                        foreach (int m in AdjList.AdjListArray[i])
                        {
                            Console.Write(m + " => ");
                        }
                    }
                }
               
            }
            else
            {
                Console.WriteLine("Doesn't have "+ k + "Core Graph");
            }
        }
    }
}
