using System;
using System.Linq;

namespace DynamiqueProgramming
{
    public class BinominalCoefficient
    {
        // C(n, k) = C(n-1, k) + C(n-1, k-1);
        // Bottom up method
        static int[,] dp;
        public static int GetBinominalCoefficient(int n, int k)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= Math.Min(i, k); j++)
                {
                    if (j == 0 || j == i) dp[i, j] = 1;
                    else dp[i, j] = dp[i - 1, j] + dp[i - 1, j - 1];
                }
            }

            return dp[n, k];
        }

        public static void Test()
        {
            var numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int n = numbers[0];
            int k = numbers[1];
            dp = new int[n + 1, k + 1];

            Console.WriteLine(GetBinominalCoefficient(n, k));
        }
    }
}
