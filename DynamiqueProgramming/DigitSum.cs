using System;
using System.Collections.Generic;

namespace DynamiqueProgramming
{
    public class DigitSum
    {
        public static List<int> MaxValueByIndex = new List<int>();

        public static long[,,] dp = new long[19, 2, 171];

        public static long GetDigitSumUntil(int index, int tight, int sum)
        {
            if (index <= -1) return sum;
            if (dp[index, tight, sum] != -1) return dp[index, tight, sum];
            long result = 0;

            int upperLimit = tight == 0 ? 9 : MaxValueByIndex[index];

            for (int i = 0; i <= upperLimit; i++)
            {
                int newTight = (tight == 1 && i == upperLimit) ? 1 : 0;
                result += GetDigitSumUntil(index - 1, newTight, sum + i);
            }

            return dp[index, tight, sum] = result;
        }

        public static void CalculateIndexValues(long value)
        {
            MaxValueByIndex.Clear();
            do
            {
                MaxValueByIndex.Add((int)value % 10);
                value /= 10;
            } while (value > 0);

        }

        public static void Start()
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 171; k++)
                    {
                        dp[i, j, k] = -1;
                    }
                }
            }
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());
            CalculateIndexValues(end);
            long resultEnd = GetDigitSumUntil(MaxValueByIndex.Count - 1, 1, 0);
            CalculateIndexValues(start - 1);
            long resultStart = GetDigitSumUntil(MaxValueByIndex.Count - 1, 1, 0);

            Console.WriteLine(resultEnd - resultStart);

            Console.ReadLine();
        }
    }
}
