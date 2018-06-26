using Maths.Geometric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polygon area
            double[] x = { 1, 3, 3, 1 };
            double[] y = { 2, 5, -5, -3};

            Console.WriteLine(Polygon.GetPolygonArea(x, y, x.Count()));

            Console.Read();
        }
    }
}
