using System;
using System.Linq;
using input = System.Console;

namespace CodeJam.Model
{
    public class NumsLinesNums
    {
        public static int T;
        public static int N;
        public static int[][] Nums;

        public static void Start()
        {
#if false
            System.IO.StreamReader input = new System.IO.StreamReader(@"test\test.txt");
#endif

            T = Convert.ToInt32(input.ReadLine());

            for (int i = 0; i < T; i++)
            {
                N = int.Parse(input.ReadLine());
                Nums = new int[N][];

                for (int h = 0; h < N; h++)
                {
                    Nums[h] = input.ReadLine().Split(' ').Select(int.Parse).ToArray();
                }

                Solve();
            }

            //Console.Read();
        }

        public static void Solve()
        {

        }

        public static void Output(int caseNum, string result)
        {
            Console.Write("Case #" + caseNum + ": " + result);
            Console.WriteLine();
        }
    }
}
