using System;
using System.Linq;
using input = System.Console;

namespace CodeJam.Model
{
    public class NumsLinesChars
    {
        public static int T;
        public static int[] Ns;
        public static char[][] Cs;

        public static void Start()
        {
#if false
            System.IO.StreamReader input = new System.IO.StreamReader(@"test\test.txt");
#endif

            T = Convert.ToInt32(input.ReadLine());
            Ns = new int[T];

            for (int i = 0; i < T; i++)
            {
                Ns = input.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int N = Ns[0];
                Cs = new char[N][];
                for (int h = 0; h < N; h++)
                {
                    Cs[h] = input.ReadLine().ToCharArray();
                }

                Solve();
            }

            Console.Read();
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
