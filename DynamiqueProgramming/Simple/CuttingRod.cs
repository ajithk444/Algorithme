using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class CuttingRod
    {
        public static int[] rods;
        public static int[] dp;

        public static int GetMaxPriceUtil(int length)
        {
            if (length == 1) return rods[0];
            if (dp[length] != 0) return dp[length];

            int max = rods[length-1];
            for (int i = 0; i < length-1; i++)
            {
                max = Math.Max(max, rods[i] + GetMaxPriceUtil(length - 1 - i));
            }
            return dp[length] = max;
        }

        public static void Start()
        {
            rods = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 };
            dp = new int[rods.Length+1];
            Console.WriteLine("The maximun price is : " + GetMaxPriceUtil(rods.Length));
        }
    }
}
