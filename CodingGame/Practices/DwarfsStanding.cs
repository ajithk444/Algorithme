using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    public class DwarfsStanding
    {
        public static void Solution()
        {
            Graph graph = new Graph();
            int n = int.Parse(Console.ReadLine()); // the number of relationships of influence
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int x = int.Parse(inputs[0]); // a relationship of influence between two people (x influences y)
                int y = int.Parse(inputs[1]);
            }

            
        }
    }

    public class Graph
    {
        private HashSet<int> _startNodes;
        //private Dictionary

        public Graph()
        {
            _startNodes = new HashSet<int>();
        }
    }

    public class Node
    {
        public int StartNum { get; set; }
        public int ToNum { get; set; }

        public Node(int start, int to)
        {
            this.StartNum = start;
            this.ToNum = to;
        }
    }
}
