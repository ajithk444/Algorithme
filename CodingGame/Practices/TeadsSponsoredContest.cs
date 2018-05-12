using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    class TeadsSponsoredContest
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine()); // the number of adjacency relations
            int[][] relations = new int[n][];

            Dictionary<int, List<int>> tree = new Dictionary<int, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int xi = int.Parse(inputs[0]); // the ID of a person which is adjacent to yi
                int yi = int.Parse(inputs[1]); // the ID of a person which is adjacent to xi

                if (tree.ContainsKey(xi))
                    tree[xi].Add(yi);
                else
                    tree.Add(xi, new List<int>());

                if (tree.ContainsKey(yi))
                    tree[yi].Add(xi);
                else
                    tree.Add(yi, new List<int>());
            }

            int depth = 0;

            while (tree != null)
            {
                depth++;
                DeleteChildNode(tree);
            }

            Console.WriteLine(depth);
        }

        public static void DeleteChildNode(Dictionary<int, List<int>> tree)
        {
            List<int> keys = tree.Keys.ToList();


            foreach (KeyValuePair<int, List<int>> kvp in tree)
            {
                if (kvp.Value.Count == 1) tree.Remove(kvp.Key);
            }
        }


    }
}
