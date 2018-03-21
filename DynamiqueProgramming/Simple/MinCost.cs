using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class MinCost
    {
        public static int[,] mincosts = new int[4, 4];
        public static int[,] costs = new int[4, 4]
            {
                { 1, 2, 3, 1 },
                { 4, 8, 2, 3 },
                { 1, 5, 3, 4 },
                { 2, 1, 3, 6 },
            };

        public static int CalculateMinCostsUtil(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return mincosts[x, y] = costs[0, 0];
            }
            if (mincosts[x, y] != 0) return mincosts[x, y];
           
            if(x == 0)
            {
                return mincosts[x, y] = CalculateMinCostsUtil(x, y - 1) + costs[x, y];
            }
            if (y == 0)
            {
                return mincosts[x, 0] = CalculateMinCostsUtil(x -1, y) + costs[x, y];
            }

            return mincosts[x, y] = Math.Min(CalculateMinCostsUtil(x - 1, y - 1), Math.Min(CalculateMinCostsUtil(x - 1, y), CalculateMinCostsUtil(x, y-1))) + costs[x, y];
        }

        public static void GetMinCost()
        {
            Console.WriteLine("Please enter the start point");
            int[] endpoint = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("The min cost is : " + CalculateMinCostsUtil(endpoint[0], endpoint[1]));
        }
    }
}
