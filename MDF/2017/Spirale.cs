using System;
namespace MDF._2017
{
    class Spirale
    {
        static int N;
        static char[,] chars;

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            chars = new char[N, N];
            int cX = N / 2;
            int cY = N / 2;
            chars[cX, cY] = '#';
            cY -= 1;
            int[,] ds = {{ 1,0 }, { 0, 1 }, { -1, 0 }, { 0, -1 }};
            int dir = 0;

            if (N > 3)
            {
                for (int i = 2; i <= N; i++)
                {
                    if (dir >= 4) dir %= 4;
                    for (int h = 1; h <= i; h++)
                    {
                        chars[cX, cY] = '#';
                        cX += ds[dir, 0];
                        cY += ds[dir, 1];
                    }
                    dir++;
                }
            }
            else
            {
                chars[cX, cY] = '#';
                chars[cX+1, cY] = '#';
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(chars[i, j] == default(char) ? "=" : "#");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
