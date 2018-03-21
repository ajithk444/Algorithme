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
        public static int[,] dp;

        public static bool IsPossible(int sum, int index)
        {
            if (sum == 0 && index == -1) return true;
            if (sum < 0 || index < 0) return false;
            if (dp[sum, index] != 0) return dp[sum, index] == 1 ? true : false;
            if (sum == 0)
            {
                dp[sum, index] = 1;
                return true;
            }

            bool result = IsPossible(sum - nums[index], index - 1) || IsPossible(sum, index - 1);
            dp[sum, index] = result == true ? 1 : 2;
            return result;
        }

        public static void Start()
        {
            nums = new int[] { 5, 3, 14, 7, 8, 4 };
            Console.WriteLine("Please enter a sum : ");
            int sum = int.Parse(Console.ReadLine());
            dp = new int[sum+1, nums.Length];
            Console.WriteLine(IsPossible(sum, nums.Length-1));
            Console.WriteLine();
        }
    }
}
