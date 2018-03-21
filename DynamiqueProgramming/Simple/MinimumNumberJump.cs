using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class MinimumNumberJump
    {
        public static int[] steps = new int[] { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 };
        public static int[] dp = new int[steps.Length];

        public static int GetMinimumUntil(int start, int end)
        {
            if (start >= end) return 0;
            if (dp[start] != -1) return dp[start];

            int min = int.MaxValue;
            for(int i=1; i<= steps[start]; i++)
            {
                min = Math.Min(min, 1+GetMinimumUntil(start + i, end));
            }
            return dp[start] = min;
        }

        public static void Start()
        {
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = -1;
            }
            Console.WriteLine($"The minimum steps is : {GetMinimumUntil(0, steps.Length-1)}");
        }
    }
}
