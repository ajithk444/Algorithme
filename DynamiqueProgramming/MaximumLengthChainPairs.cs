using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class MaximumLengthChainPairs
    {
        public static List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
        public static int[] dp;

        public static int GetMaxLength(int index, int limit)
        {
            dp[0] = 1;
            for (int i = 1; i < pairs.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if(pairs[i].Item1 > pairs[j].Item2)
                    {
                        dp[i] = Math.Max(dp[j] + 1, dp[i]);
                    }

                    if (dp[i] == 0) dp[i] = 1;
                }
            }
            return dp.Max();
        }

        public static void Start()
        {
            pairs.Add(new Tuple<int, int>(5, 24));
            pairs.Add(new Tuple<int, int>(39, 60));
            pairs.Add(new Tuple<int, int>(15, 28));
            pairs.Add(new Tuple<int, int>(27, 40));
            pairs.Add(new Tuple<int, int>(50, 90));
            int len = pairs.Count;
            dp = new int[len];

            pairs = pairs.OrderBy(s => s.Item1).ToList();

            Console.WriteLine($"The maximum length is {GetMaxLength(len-1, pairs[len-1].Item1)}");
        }
    }
}
