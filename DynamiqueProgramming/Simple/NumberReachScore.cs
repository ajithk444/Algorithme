using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class NumberReachScore
    {
        public static int[] dp;
        public static int[,] dp1;
        public static int[] nums = new int[3] { 3, 5, 10 };

        public static int ComputeNumOrder(int n)
        {
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 3];
                if (i >= 5)
                {
                    dp[i] += dp[i - 5];
                }
                if (i >= 10)
                {
                    dp[i] += dp[i - 10];
                }
            }
            return dp[n];
        }

        // Bottom Up
        public static int ComputeNoOrder(int n)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums[i]; j <= n; j++)
                {
                    dp[j] += dp[j - nums[i]];
                }
            }
           
            return dp[n];
        }

        // Up bottom
        public static int ComputeNoOrder(int n, int index)
        {
            if (index < 0 || n < 0) return 0;
            if (n == 0) return 1;
            if (dp1[n, index] != -1) return dp1[n, index];

            return dp1[n, index] = ComputeNoOrder(n - nums[index], index) + ComputeNoOrder(n, index - 1);
        }

        public static void Start(int n)
        {
            dp = new int[n+1];
            dp[0] = 1;
            
            Console.WriteLine($"The total way (bottom-up) is {ComputeNoOrder(20)}");

            dp1 = new int[n+1, nums.Length];
            for (int i = 0; i < dp1.GetLength(0); i++)
            {
                for (int j = 0; j < dp1.GetLength(1); j++)
                {
                    dp1[i, j] = -1;
                }
            }

            Console.WriteLine($"The total way (up-bottom) is {ComputeNoOrder(20, 2)}");
        }
    }
}
