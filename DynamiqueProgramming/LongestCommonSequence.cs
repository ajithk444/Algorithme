using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamiqueProgramming
{
    public class LongestCommonSequence
    {
        public static void GetLCS(string str1, string str2)
        {
            char[] xChars = str1.ToCharArray();
            char[] yChars = str2.ToCharArray();

            int xLength = xChars.Length + 1;
            int yLength = yChars.Length + 1;

            int[,] matrix = new int[xLength, yLength];
            for (int i = 1; i < xLength; i++)
            {
                for (int j = 1; j < yLength; j++)
                {
                    if(xChars[i-1] == yChars[j - 1])
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + 1;
                    }else
                    {
                        matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
                    }
                }
            }

            Console.WriteLine("The longest length of sequence is : " + matrix[xLength-1, yLength-1]);

            List<char> chars = new List<char>();

            int m = xLength-1;
            int n = yLength-1;

            while (m > 0 && n > 0)
            {
                if (matrix[m, n] == 0) break;

                if (matrix[m, n] != matrix[m - 1, n - 1])
                {
                    chars.Add(xChars[m-1]);
                }

                m--;
                n--;
            }

            chars.Reverse();

            Console.WriteLine("The result of the string is : "+ new string(chars.ToArray()));
        }
    }
}
