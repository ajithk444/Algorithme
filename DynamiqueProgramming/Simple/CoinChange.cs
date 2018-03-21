using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class CoinChange
    {
        public static int sum;
        public static int[] elements;
        public static int[,] dp;

        public static int Count(int m, int total)
        {
            if (m < 0 || total < 0) return 0;
            if (dp[m, total] != -1) return dp[m, total];
            if (total == 0) return dp[m, 0] = 1;

            return dp[m, total] = Count(m, total - elements[m]) + Count(m - 1, total);
        }

        public static void Start()
        {
            Console.WriteLine("Please enter the value of sum : ");
            sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the values of the elements : ");
            elements = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            dp = new int[elements.Length, sum+1];
            for(int i = 0; i< elements.Length; i++)
            {
                for (int j = 0; j < sum + 1; j++)
                {
                    dp[i, j] = -1;
                }
            }
            Console.WriteLine("The number of solution is : " + Count(elements.Length-1, sum));
        }
    }
}
