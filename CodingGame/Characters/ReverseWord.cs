using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    class ReverseWord
    {
        public static string ReverseWords(string sentence)
        {
            string result = string.Join(" ", sentence.Split(' ').Select(x => new String(x.Reverse().ToArray())));

            return result;
        }
    }
}
