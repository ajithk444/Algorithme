using System;

namespace DynamiqueProgramming
{
    public class MinOperationConvertionStrings
    {
        public static char[] char1;
        public static char[] char2;
        public static int[,] dp;

        public static int GetMin(int m, int n)
        {
            if (n < 0) return 0;
            if (m < 0) return n+1;
            if(char1[m] == char2[n])
            {
                return GetMin(m - 1, n - 1);
            }else
            {
                return 1 + GetMinValue(GetMin(m, n-1), GetMin(m-1, n-1), GetMin(m-1, n));
            }
        }

        public static int GetMinValue(int n1, int n2, int n3)
        {
            return n1 > n2 ? (n2 > n3 ? n3 : n2) : (n1 > n3 ? n3 : n1);
        }

        public static void Start(string str1, string str2)
        {
            char1 = str1.ToCharArray();
            char2 = str2.ToCharArray();

            dp = new int[char1.Length, char2.Length];

            for (int i = 0; i < char1.Length; i++)
            {
                for (int j = 0; j < char2.Length; j++)
                {
                    dp[i, j] = -1;
                }
            }
            Console.WriteLine("The minium operation is : " + GetMin(char1.Length-1, char2.Length-1));
        }
    }
}
