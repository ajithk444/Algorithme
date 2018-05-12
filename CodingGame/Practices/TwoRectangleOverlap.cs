using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class TwoRectangleOverlap
    {
        //Judge if two rectangle is overlapped or not in x-ray and y ray

        public static bool IsOverlap(double x1, double y1, double x2, double y2, double n)
        {
            bool IsOverLapX = (x1 >= x2 && x1 <= x2 + n) || (x2 >= x1 && x2 <= x1 + n);

            bool IsOverlapY = (y1 >= y2 && y1 <= y2 + n) || (y2 >= y1 && y2 <= y1 + n);

            return IsOverLapX && IsOverlapY;
        }
    }
}
