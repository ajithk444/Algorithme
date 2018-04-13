using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternSearching
{
    public class AnagramSubstring
    {
        public static void Start(string pattern, string str)
        {
            Dictionary<char, int> result = pattern.ToCharArray().GroupBy(s => s).ToDictionary(d => d.Key, d => d.Count());
            Dictionary<char, int> pointResult = new Dictionary<char, int>(result);
            var keys = new List<char>(pointResult.Keys);
            ClearDic(pointResult, keys);

            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (pointResult.ContainsKey(str[i]))
                {
                    j++;
                    pointResult[str[i]]++;
                    if (j == pattern.Length)
                    {
                        if (!result.Except(pointResult).Any())
                        {
                            Console.Write((i-j+1) + " ");
                            j = 0;
                        }
                        else
                        {
                            pointResult[str[i - j + 1]]--;
                            j--;
                        }
                    }
                }
                else
                {
                    j = 0;
                    ClearDic(pointResult, keys);
                }
            }
        }

        public static void ClearDic(Dictionary<char, int> dic, List<char> keys)
        {
            
            foreach(var key in keys)
            {
                dic[key]= 0;
            }
        }
    }
}
