﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming.Simple
{
    public class CountAllPossiblePaths
    {
        public static int[,] dp;

        public static int CountPath(int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == 0 || j == 0)
                    {
                        dp[i, j] = 1;
                    }
                    else{
                        dp[i, j] = dp[i-1, j]+ dp[i, j-1];
                    }
                }
            }

            return dp[m-1, n-1];
        }

        public static void Start(int m, int n)
        {
            dp = new int[m, n];
            Console.WriteLine($"The possible path is equal to : {CountPath(m, n)}");
        }
    }
}
