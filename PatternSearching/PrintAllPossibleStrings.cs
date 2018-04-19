using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSearching
{
    public class PrintAllPossibleStrings
    {
        public static int Length;
        public static string Str;
        public static void Start(string str)
        {
            Length = str.Length;
            Str = str;
            Print(str[0].ToString(), 1);
            Print(str[0].ToString() + " ", 1);
        }

        public static void Print(string prefix, int index)
        {
            if (index != Length - 1)
            {
                prefix += Str[index];
                Print(prefix, index + 1);
                prefix += " ";
                Print(prefix, index + 1);
            }
            else
            {
                prefix += Str[index].ToString(); 
                Console.WriteLine(prefix);
            }
        }
    }
}
