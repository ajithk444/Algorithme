using System;
using System.Collections.Generic;
using System.Linq;
using input = System.Console;

namespace CodeJam.Model
{
    public class ModelNumsLinesNums
    {
        public static void Start()
        {
#if false
            System.IO.StreamReader input = new System.IO.StreamReader(@"test\test.txt");
#endif

            int t = Convert.ToInt32(input.ReadLine());
            int[][] Ns = new int[t][];
            int[][][] nums = new int[t][][];

            for (int i = 0; i < t; i++)
            {
                Ns[i] = input.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int N = Ns[i][0];
                nums[i] = new int[N][];
                for (int h = 0; h < N; h++)
                {
                    nums[i][h] = input.ReadLine().Split(' ').Select(int.Parse).ToArray();
                }
            }

            for (int i = 0; i < t; i++)
            {
                //code
            }

            //Console.Read();
        }

        public static bool Solve(int[] Ns, char[][] strs)
        {
            int R = Ns[0];
            int C = Ns[1];


            return true;
        }

        public static void Output(int caseNum, string result)
        {
            Console.Write("Case #" + caseNum + ": " + result);

            Console.WriteLine();
        }
    }
}
