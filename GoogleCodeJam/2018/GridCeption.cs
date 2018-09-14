using System;
using System.Collections.Generic;
using System.Linq;
using input = System.Console;

namespace CodeJam.Model
{
    public class GridCeption
    {
        public static int T;
        public static int[] Ns;
        public static int R;
        public static int C;
        public static char[][] Cs;
        public static int[,] ConnectedA;
        public static int Max;

        public static void Main()
        {
#if true
            System.IO.StreamReader input = new System.IO.StreamReader(@"test\GridCeption.txt");
#endif

            T = Convert.ToInt32(input.ReadLine());
            Ns = new int[T];

            for (int i = 0; i < T; i++)
            {
                Ns = input.ReadLine().Split(' ').Select(int.Parse).ToArray();
                R = Ns[0];
                C = Ns[1];
                Cs = new char[R][];
                for (int h = 0; h < R; h++)
                {
                    Cs[h] = input.ReadLine().ToCharArray();
                }

                Solve();
                Output(i + 1, Max);
            }

            Console.Read();
        }

        public static void Solve()
        {
            ConnectedA = new int[R, C];
            Max = 0;

            List<int> patterns = new List<int>();

            int[] xMove = { -1, -1, 0, 0 };
            int[] yMove = { -1, 0, -1, 0 };

            for (int i = 0; i <R ; i++)
            {
                for (int j = 0; j <C; j++)
                {
                    int t = 0;

                    for (int m = 0; m < 4; m++)
                    {
                        if (i+xMove[m] >= 0 && j+yMove[m] >= 0 && Cs[i + xMove[m]][j + yMove[m]] == 'B')
                        {
                            t += (int)Math.Pow(2, m);
                        }
                    }

                    patterns.Add(t);
                }
            }

           var ps = patterns.Distinct().ToList();

            foreach(int m in ps)
            {
                for (int i = 0; i <= R; i++)
                {
                    for (int j = 0; j <= C; j++)
                    {
                        for (int n = 0; n < 4; n++)
                        {
                            char color = ((m >> n) & 1) == 1 ? 'B' : 'W';
                            switch (n)
                            {
                                case 0:
                                    SetValue(0, 0, i, j, color);
                                    break;
                                case 1:
                                    SetValue(0, j, i, C, color);
                                    break;
                                case 2:
                                    SetValue(i, 0, R, j, color);
                                    break;
                                case 3:
                                    SetValue(i, j, R, C, color);
                                    break;
                            } 
                        }

                        GetLargestConnectedComponent();
                    }
                }
            }
        }

        public static void SetValue(int x0, int y0, int x1, int y1, char color)
        {
            for (int i = x0; i < x1; i++)
            {
                for (int j = y0; j < y1; j++)
                {
                    if (Cs[i][j] == color)
                    {
                        ConnectedA[i, j] = 1;
                    }
                    else
                    {
                        ConnectedA[i, j] = 0;
                    }
                }
            }
        }

        public static void GetLargestConnectedComponent()
        {
            bool[,] IsVisited = new bool[R, C];

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (!IsVisited[i, j])
                    {
                        int num = Search(i, j, IsVisited);
                        if (num > Max)
                        {
                            Max = num;
                        }
                    }
                }
            }
        }

        public static int Search(int i, int j, bool[,] isVisited)
        {
            if (i < 0 || i >= R || j < 0 || j >= C) return 0;

            if (!isVisited[i, j] && ConnectedA[i, j] == 1)
            {
                isVisited[i, j] = true;
                int[] xMove = { 1, -1, 0, 0 };
                int[] yMove = { 0, 0, 1, -1 };

                int c = 1;
                for (int u = 0; u < 4; u++)
                {
                    c += Search(i + xMove[u], j + yMove[u], isVisited);
                }
                return c;
            }

            return 0;
        }

        public static void Output(int caseNum, int result)
        {
            Console.Write("Case #" + caseNum + ": " + result);
            Console.WriteLine();
        }
    }
}
