using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            //KMPSearching.Start("AABFAAAAB", "AAAABFAAAABEFMFAABFAAAAB");

            //SuffixArray.Start("banana");

            //AnagramSubstring.Start("AABAABFAA", "AAAABFAAAABEFMFAABFAAAAB");

            //PrintingGraph.Start();

            PrintAllPossibleStrings.Start("ABC");

            Console.Read();
        }
    }
}
