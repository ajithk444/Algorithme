using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class CountEvenLengthBinaryWithSameSum
    {
        //S(n) = Cn0* Cn0 + ...+ Cnn* Cnn
        //Cnk = Cn(k-1)*(n-k+1)/k

        public static int[] dp;
        public static void Start(int n)
        {
            dp = new int[n+1];
            dp[0] = 1;

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                dp[i] = dp[i - 1] * (n + 1 - i) / i;
                result += dp[i]*dp[i];
            }

            Console.WriteLine($"The number of the solution is {result}");
        }
    }
}
