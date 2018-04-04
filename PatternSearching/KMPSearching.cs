using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSearching
{
    public class KMPSearching
    {
        public static int[] lps;

        public static void CalculateLps(string pattern)
        {
            int len = 0;
            char[] chars = pattern.ToCharArray();
            lps = new int[chars.Length];

            for (int i = 1; i < chars.Length; )
            {
                if(chars[i] == chars[len])
                {
                    lps[i] = len + 1;
                    len++;
                    i++;
                }
                else if(chars[i] != chars[len] && len>0)
                {
                    len = lps[len - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }

        public static void Start(string pattern, string text)
        {
            CalculateLps(pattern);
            Console.Write("LPS array is : ");
            foreach (int item in lps)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            int j = 0;

            for (int i = 0; i < text.Length;)
            {
                if(text[i] == pattern[j])
                {
                    i++;
                    j++;

                    if(j == lps.Length)
                    {
                        Console.Write($"{i-j} : ");
                        j = lps[j - 1];
                    }

                }else
                {
                    if (j > 0)
                    {
                        j = lps[j - 1];
                    }else
                    {
                        i++;
                    }
                }
            }
        }
    }
}
