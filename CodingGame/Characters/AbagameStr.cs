using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    class AbagameStr
    {
        //Test two if two string contain the same characters

        //Solution one
        public static bool SameStr1(string s1, string s2)
        {
            if (s1 == null || s2 == null) return false;

            char[] chars1 = s1.ToCharArray();
            char[] chars2 = s2.ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            return new String(chars1) == new String(chars2);
        }

        //Solution two
        public static bool SameStr2(string s1, string s2)
        {
            if (s1 == null || s2 == null) return false;
            if (s1.Length != s2.Length) return false;

            char[] chars1 = s1.ToCharArray();
            char[] chars2 = s2.ToCharArray();

            Dictionary<char, int> dic1 = chars1.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            Dictionary<char, int> dic2 = chars1.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

            foreach (KeyValuePair<char, int> kvp in dic1)
            {
                if (!dic2.ContainsKey(kvp.Key) || dic2[kvp.Key] != kvp.Value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
