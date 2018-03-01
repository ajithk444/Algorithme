using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class MaximumSumIncreasing
    {
        public static int[] nums;
        public static int[] dp;

        public static int GetLargestSum()
        {
            dp[0] = nums[0];
            for(int i=1; i<nums.Length; i++)
            {
                for (int j = i-1; j >= 0; j--)
                {
                    if(nums[j] < nums[i])
                    {
                        dp[i] = dp[j] + nums[i];
                        break;
                    }
                }
                if (dp[i] == 0)
                {
                    dp[i] = nums[i];
                }    
            }

            return dp.Max();
        }

        public static void Start()
        {
            nums = new int[] { 1, 101, 2, 3, 100, 4, 5 };
            dp = new int[nums.Length];
            Console.WriteLine($"Largest sum is {GetLargestSum()}");
        }
    }
}
