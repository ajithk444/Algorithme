using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternSearching
{
    public class SuffixArray
    {
        public static void Start(string str)
        {
            List<Tuple<int, string>> suffixes = new List<Tuple<int, string>>(); 
            for (int i = 0; i < str.Length; i++)
            {
                suffixes.Add(new Tuple<int, string>(i, str.Substring(i)));
            }

            int[] suffixArray = suffixes.OrderBy(s => s.Item2).Select(x => x.Item1).ToArray();
            foreach (var item in suffixArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
