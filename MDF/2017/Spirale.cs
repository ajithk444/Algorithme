using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            chars[cX-1, cY] = '#';
            chars[cX-1, cY+1] = '#';
            int lastX = cX - 1;
            int lastY = cY + 1;
            int cpX = lastX;
            int cpY = lastY;

            while (Math.Abs(lastX - cX)<N/2)
            {
                if(chars[lastX, lastY-1]=='#')
                {
                    
                }
                else
                {

                }
            }

            Console.WriteLine(default(int));
            Console.Read();
        }
    }
}
