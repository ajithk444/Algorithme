using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class LongestCommonSubstring
    {
        public static char[] chars1;
        public static char[] chars2;
        public static int[,,] dp;

        public static int GetLongestLength(int idx1, int idx2, int isConsecutive)
        {
            if (idx1 < 0 || idx2 < 0) return 0;
            if (dp[idx1, idx2, isConsecutive] != -1) return dp[idx1, idx2, isConsecutive];

            if (isConsecutive == 1)
            {
                return dp[idx1, idx2, isConsecutive] = chars1[idx1] == chars2[idx2] ? 1 + GetLongestLength(idx1 - 1, idx2-1, 1) : 0;
            }
            else
            {
                int longest = Math.Max(GetLongestLength(idx1 - 1, idx2, 0), GetLongestLength(idx1, idx2 - 1, 0));
                if (chars1[idx1] != chars2[idx2])
                {
                    return dp[idx1, idx2, isConsecutive] = longest;
                }

                return dp[idx1, idx2, isConsecutive] = Math.Max(longest, 1 + GetLongestLength(idx1-1, idx2-1, 1));
            }
        }

        public static void GetLCSubstring(string str1, string str2)
        {
            char[] xChars = str1.ToCharArray();
            char[] yChars = str2.ToCharArray();

            int xLength = xChars.Length + 1;
            int yLength = yChars.Length + 1;

            int[,] matrix = new int[yLength, xLength];
            for (int i = 1; i < yLength; i++)
            {
                for (int j = 1; j < xLength; j++)
                {
                    if (xChars[j - 1] == yChars[i - 1])
                    {
                        if(i==1 || j == 1)
                        {
                            matrix[i, j] = 1;
                        }else
                        {
                            if (xChars[j - 2] == yChars[i - 2])
                            {
                                matrix[i, j] = matrix[i - 1, j - 1] + 1;
                            }else
                            {
                                matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
                            }
                        }
                    }
                    else
                    {
                        matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
                    }
                }
            }

            Console.WriteLine("The longest length of substring is : " + matrix[yLength - 1, xLength - 1]);
            Console.WriteLine("The matrix is like this : ");
            for (int i = 0; i < yLength; i++)
            {
                for (int j = 0; j < xLength; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            List<char> chars = new List<char>();

            int m = yLength - 1;
            int n = xLength - 1;

            bool isLastChar = true;

            while (m > 0 && n > 0)
            {
                if (matrix[m, n] == 0) break;

                if (isLastChar)
                {
                    if (matrix[m, n] == matrix[m - 1, n])
                    {
                        m--;
                    }
                    else if (matrix[m, n] == matrix[m, n - 1])
                    {
                        n--;
                    }
                    else
                    {
                        chars.Add(xChars[n - 1]);
                        m--;
                        n--;
                        isLastChar = false;
                    }
                }else
                {
                    if (matrix[m, n]+1 == matrix[m+1, n+1])
                    {
                        chars.Add(xChars[n - 1]);
                        m--;
                        n--;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            chars.Reverse();

            Console.WriteLine("The result of the string is : " + new string(chars.ToArray()));
        }

        public static void Start(string str1, string str2)
        {
            chars1 = str1.ToCharArray();
            chars2 = str2.ToCharArray();
            dp = new int[chars1.Length, chars2.Length, 2];
            for (int i = 0; i < chars1.Length; i++)
            {
                for (int j = 0; j < chars2.Length; j++)
                {
                    for (int h = 0; h < 2; h++)
                    {
                        dp[i, j, h] = -1;
                    }
                }
            }

            Console.WriteLine($"The longest substring is {GetLongestLength(chars1.Length - 1, chars2.Length - 1, 0)}");
        }
    }
}
