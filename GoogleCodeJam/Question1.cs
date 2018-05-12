using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeJam
{
    public class Question2
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int[][] Ns = new int[t][];
            int[][] numss = new int[t][];

            for (int i = 0; i < t; i++)
            {
                Ns[i] = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
                numss[i] = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
            }

            for (int i = 0; i < t; i++)
            {
                int N = Ns[i][0];
                int L = Ns[i][1];
                int[] nums = numss[i];
                

                //Output(i + 1, result);
            }
           
        }

        public static void Output(int caseNum, int result)
        {
            Console.Write("Case #" + caseNum + ": "+result);
 
            Console.WriteLine();
        }
    }
}
