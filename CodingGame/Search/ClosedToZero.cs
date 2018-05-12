using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class ClosedToZero
    {
        public static double ClosestToZero(double[] ts)
        {
            if (ts == null) return 0;

            double result = 0;
            double distance = double.MaxValue;
            foreach (double d in ts)
            {
                if (Math.Abs(d) < distance)
                {
                   
                    result = d;
                    distance = Math.Abs(d);
                }

                else if (Math.Abs(d) == distance && d > 0)
                {
                    result = d;
                }

            }

            return result;

        }
    }
}
