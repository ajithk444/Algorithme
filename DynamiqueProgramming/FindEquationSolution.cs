using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class FindEquationSolution
    {
        public static int[] coefficients;
        public static int[,] dp;
        public static int[] dpOne;

        // Up-bootom
        public static int GetSolutionsUtil(int sum, int idx)
        {
            if (sum < 0) return 0;
            if (idx == 0) return sum%coefficients[0]==0 ? 1 : 0;
            if (dp[sum, idx] != -1) return dp[sum, idx];
            dp[sum, idx] = GetSolutionsUtil(sum, idx - 1);
            for (int i = 1; i <= sum / coefficients[idx]; i++)
            {
                dp[sum, idx] += GetSolutionsUtil(sum - i * coefficients[idx], idx - 1);
            }

            return dp[sum, idx];
        }

        //Bottom-up
        public static int GetSolutionsUtilBottomUp(int sum)
        {
            dpOne = new int[sum + 1];
            dpOne[0] = 1;
            for (int j = 0; j < coefficients.Length; j++)
            {
                for (int i=coefficients[j]; i <= sum; i++)
                {
                    dpOne[i] += dpOne[i-coefficients[j]];
                }
            }
            return dpOne[sum];
        }

        public static void start(int[] list)
        {
            int sum = list[list.Length-1];
            coefficients = list.Take(list.Length - 1).ToArray();
            dp = new int[sum + 1, list.Length];
            for (int i = 0; i < sum + 1; i++)
            {
                for (int j = 0; j< list.Length; j++)
                {
                    dp[i, j] = -1;
                }
            }
            Console.WriteLine($"Number of the solution : {GetSolutionsUtilBottomUp(sum)}");
        }
    }
}
