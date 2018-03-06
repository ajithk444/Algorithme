using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class CatalanNumber
    {
        public static long[] dp;

        //Dynamique programming
        public static long CatalanDp(int n)
        {
            if (n == 0 || n == 1) return 1;
            if (dp[n] != 0) return dp[n];
            long result = 0;
            for (int i = 0; i <n; i++)
            {
                result += CatalanDp(i)*CatalanDp(n - 1 - i);
            }
            return dp[n] = result;
        }

        //Binomial Coefficient
        //Catalan value = C(2n, n)/n+1
        public static long CatalanBc(int n)
        {
           return BinominalCoefficient(2 * n, n) / (n+1);
        }

        public static long BinominalCoefficient(int n, int k)
        {
            if (n - k < k) k = n - k;
            int res = 1;
            for (int i = 0; i < k; i++)
            {
                res *= n - i;
                res /= i + 1;
            }
            return res;
        }

        public static void Start(int n)
        {
            dp = new long[n+1];
            Console.WriteLine($"result is {CatalanBc(n)}");
        }
    }
}
