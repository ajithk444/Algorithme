using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class SubsetSum
    {
        public static int[] nums;
        public static bool[] areUsed;
        public static int[] dp;

        public static bool IsPossible(int sum, int level)
        {
            if (sum < 0) return false;
            if (sum == 0) return true;
            if (dp[sum] != 0) return dp[sum] == 1 ? false : true;
            for (int i = 0; i < nums.Length; i++)
            {
                if(level == 0)
                {
                    Reset();
                }

                if(areUsed[i] == false)
                {
                    areUsed[i] = true;
                    if (IsPossible(sum - nums[i], level + 1))
                    {
                        dp[sum] = 2;
                        return true;
                    }
                }
            }
            dp[sum] = 1;
            return false;
        }

        public static void Reset()
        {
            for (int i = 0; i < areUsed.Length; i++)
            {
                areUsed[i] = false;
            }
        }

        public static void Start()
        {
            nums = new int[] { 5, 3, 14, 7, 8, 4, 12, 7 };
            areUsed = new bool[nums.Length];
            Console.WriteLine("Please enter a sum : ");
            int sum = int.Parse(Console.ReadLine());
            dp = new int[sum+1];
            Console.WriteLine(IsPossible(sum, 0));
            Console.WriteLine();
        }
    }
}
