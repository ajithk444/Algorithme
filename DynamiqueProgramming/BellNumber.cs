using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class BellNumber
    {
        // S(n+1, k) = S(n, k-1) + k*S(n, k)
        public static void Start(int n)
        {
            int[,] nums = new int[n+1,n+1];
            nums[1, 1] = 1;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    nums[i, j] = nums[i-1,j - 1] + j * nums[i - 1, j];
                }
            }
            int sum=0;
            for (int i = 1; i <= n; i++)
            {
                sum += nums[n, i];
            }
            Console.WriteLine($"The result is : {sum}");
        }
    }
}
