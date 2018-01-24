namespace BitOperation
{
    using System;
    using System.Collections.Generic;
    public class BitMaskingCaps
    {
        static int MOD = 1000000007;

        static List<int>[] capList = new List<int>[101];

        static int[][] dp = new int[1025][];

        static int allmask;

        static int countWaysUtil(int mask, int i)
        {
            if (mask == allmask) return 1;

            if (i > 100) return 0;

            if (dp[mask][i] != -1) return dp[mask][i];

            int ways = countWaysUtil(mask, i + 1);

            foreach (int person in capList[i])
            {
                if ((mask & (1 << person)) == 0)
                {
                    ways += countWaysUtil(mask | (1 << person), i + 1);
                }
            }

            return dp[mask][i] = ways % MOD;
        }

        //   Reads n lines from standard input for current test case
        static void countWays(int n)
        {
            //  ----------- READ INPUT --------------------------
            string str;
            string[] split;
            int x;
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                split = str.Split(' ');
                //   while there are words in the split[]
                for (int j = 0; j < split.Length; j++)
                {
                    //   add the ith person in the list of cap if with id x
                    x = int.Parse(split[j]);
                    capList[x].Add(i);
                }
            }

            //  ----------------------------------------------------
            //   All mask is used to check of all persons
            //   are included or not, set all n bits as 1
            allmask = ((1 << n) - 1);

            //   Initialize all entries in dp as -1
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[101];
                for (int j = 0; j < 101; j++)
                {
                    dp[i][j] = -1;
                }
            }

            //   Call recursive function count ways
            Console.WriteLine(countWaysUtil(0, 1));
        }

        public static void Test()
        {
            int n;

            for (int i = 0; i < capList.Length; i++)
            {
                capList[i] = new List<int>();
            }

            n = int.Parse(Console.ReadLine());
            countWays(n);
        }
    }
}
