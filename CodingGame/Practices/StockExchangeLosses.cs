using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    class StockExchangeLosses
    {
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            int[] points = new int[n];
            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                int v = int.Parse(inputs[i]);
                points[i] = v;
            }

            int maxLoss = 0;
            int lastPeekIndex = 0;

            for (int i = 1; i < n; i++)
            {
                int margin = points[i] - points[lastPeekIndex];
                if (margin < 0 && margin < maxLoss)
                {
                    maxLoss = margin;
                }
                else if (margin > 0)
                {
                    lastPeekIndex = i;
                }

            }


            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(maxLoss);
        }
    }
}
