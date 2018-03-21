using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming.Simple
{
    public class FindMaximumLengthSnake
    {
        public static int[,] nums;
        public static int[,] dp;

        public static void Start(int[,] arr)
        {
            nums = arr;
            dp = new int[arr.GetLength(0), arr.GetLength(1)];
            int max = 0;
            int[] maxPoint = new int[2];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if(i>0 || j > 0)
                    {
                        if (j > 0 && IsAddNum(nums[i, j - 1], nums[i, j]))
                        {
                            dp[i, j] = Math.Max(dp[i, j - 1] + 1, dp[i, j]);
                        }

                        if (i > 0 && IsAddNum(nums[i - 1, j], nums[i, j]))
                        {
                            dp[i, j] = Math.Max(dp[i - 1, j] + 1, dp[i, j]);
                        }
                    }

                    if (dp[i, j] == 0) dp[i, j] = 1;

                    if (dp[i, j] > max)
                    {
                        max = dp[i, j];
                        maxPoint[0] = i;
                        maxPoint[1] = j;
                    }
                }
            }

            Stack<int> stack = new Stack<int>();

            int m = maxPoint[0];
            int n = maxPoint[1];

            while (max>0)
            {
                stack.Push(nums[m, n]);
                max--;
                if(n > 0 && dp[m, n - 1] == max)
                {
                    n--;
                }
                else if(m> 0 && dp[m-1, n] == max)
                {
                    m--;
                }
            }

            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
        }

        public static bool IsAddNum(int x, int y)
        {
            return Math.Abs(x - y) == 1 ? true : false;
        }
    }
}
