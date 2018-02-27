using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class AssemblyLine
    {
        public static int[,] costs;
        public static int[,] extra;
        public static int[,] mincosts;

        public static void start()
        {
            InitialVaraibles();

            mincosts[0, 0] = costs[0, 0];
            mincosts[1, 0] = costs[1, 0];
            mincosts[0, 1] = costs[0, 1] + costs[0, 0];
            mincosts[1, 1] = costs[1, 1] + costs[1, 0];

            int len = costs.GetLength(1);
            for (int i = 2; i < len - 1; i++)
            {
                mincosts[0, i] = Math.Min(costs[0, i]+mincosts[0, i-1], costs[0, i]+mincosts[1, i-1]+extra[1, i]);
                mincosts[1, i] = Math.Min(costs[1, i] + mincosts[1, i - 1], costs[1, i] + mincosts[0, i - 1] + extra[0, i]);
            }

            Console.WriteLine($"The minimum time is {Math.Min(mincosts[0, len-2]+ costs[0, len-1], mincosts[1, len - 2] + costs[1, len - 1])}");
        }

        public static void InitialVaraibles()
        {
            costs = new int[2, 7]
            {
                { 5, 7, 6, 3, 9, 5, 4 },
                { 4, 3, 9, 2, 7, 1, 8 }
            };

            mincosts = new int[2, 6];

            extra = new int[2, 6]
            {
                { 0, 1, 3, 4, 2, 1 },
                { 0, 1, 1, 1, 2, 4 }
            };

        }
    }
}
