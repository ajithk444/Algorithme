using System;
using System.Linq;

namespace GoogleCodeJam
{
    public class Question3
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int[] D = new int[t];
            string[] P = new string[t];

            for (int i = 0; i < t; i++)
            {
                var strs = Console.ReadLine().Split(' ');
                D[i] = Convert.ToInt32(strs[0]);
                P[i] = strs[1];
            }

            for (int i = 0; i < t; i++)
            {

            }
            Console.Read();
        }

        public static void Output(int caseNum, int result, bool isPossible)
        {
            Console.Write("Case #" + caseNum + ": ");
            if (isPossible)
            {
                Console.Write(result);
            }
            else
            {
                Console.Write("IMPOSSIBLE");
            }
            Console.WriteLine();
        }
    }
}
