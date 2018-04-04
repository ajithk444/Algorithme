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
            KMPSearching.Start("AABFAAAAB", "AAAABFAAAABEFMFAABFAAAAB");

            Console.Read();
        }
    }
}
