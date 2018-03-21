using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class LongestIncreasingSequence
    {
        public static int[] Longest;

        public static void PrintLongestSequence()
        {
            int[] nums = new int[] { 5, 10, 2, 3, 20, 6, 40, 8 };
            int length = nums.Length;
            int[] Longest = new int[length];
            Longest[0] = 1;
            for (int i = 1; i < length; i++)
            {
                var indexes = nums.Select((value, index) => new { value, index }).Where(e => e.value < nums[i] && e.index < i).Select(e => e.index).ToArray();
                var elements = indexes.Select(s => Longest[s]);
                if (elements.Count() > 0)
                {
                    Longest[i] = elements.Max() + 1;
                }
                else
                {
                    Longest[i] = 1;
                }
            }

            Console.WriteLine($"The longest sequence is : {Longest.Max()}");
        }
    }
}
