using System;
using System.Linq;
using input = System.Console;

namespace CodeJam.Model
{
    public class CostumeChange
    {
        public static int T;
        public static int N;
        public static int[][] Nums;

        public static void Start()
        {
#if true
            System.IO.StreamReader input = new System.IO.StreamReader(@"test\CostumeChange.txt");
#endif

            T = Convert.ToInt32(input.ReadLine());

            for (int i = 0; i < T; i++)
            {
                N = int.Parse(input.ReadLine());
                Nums = new int[N][];
                for (int j = 0; j < N; j++)
                {
                    Nums[j] = input.ReadLine().Split(' ').Select(int.Parse).ToArray();
                }

                Solve();
            }

            //Console.Read();
        }

        public static void Solve()
        {
            int[,] Rs = new int[N, 2*N+1];
            int[,] Cs = new int[N, 2 * N + 1];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Rs[i, Nums[i][j]]++;
                    Cs[j, Nums[i][j]]++;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Rs[i, Nums[i][j]]++;
                    Cs[j, Nums[i][j]]++;
                }
            }
        }

        public static void Output(int caseNum, string result)
        {
            Console.Write("Case #" + caseNum + ": " + result);
            Console.WriteLine();
        }
    }
}
