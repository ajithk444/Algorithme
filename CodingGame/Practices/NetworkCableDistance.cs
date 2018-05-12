﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    class NetworkCableDistance
    {
        public static void Solution()
        {
            int N = int.Parse(Console.ReadLine());
            int[] yArray = new int[N];
            int minX = int.MaxValue;
            int maxX = int.MinValue;
            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int X = int.Parse(inputs[0]);
                if (minX > X) minX = X;
                if (maxX < X) maxX = X;

                int Y = int.Parse(inputs[1]);
                yArray[i] = Y;
            }

            Array.Sort(yArray);
            int yCenter = yArray[yArray.Length / 2];
            Int64 minDistance = 0;

            foreach (int item in yArray)
                minDistance += Math.Abs(item - yCenter);

            minDistance += maxX - minX;
            Console.WriteLine(minDistance);
        }
    }
}