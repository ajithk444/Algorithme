using Maths.Geometric;
using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polygon area
            //double[] x = { 1, 3, 3, 1 };
            //double[] y = { 2, 5, -5, -3};

            //Console.WriteLine(Polygon.GetPolygonArea(x, y, x.Count()));

            //Point p1 = new Point(0, 0);
            //Point p2 = new Point(4, 4);
            //Point p3 = new Point(-5, -5);

            //int o = OrientationTreePoints.Orientation(p1, p2, p3);
            //Console.WriteLine(o);

            Point p1 = new Point(0, 0);
            Point p2 = new Point(4, 4);
            Point q1 = new Point(-1, 1);
            Point q2 = new Point(1,0.3);

            Console.WriteLine(TLI.IsIntersect(p1, p2, q1, q2));

            Console.Read();
        }
    }
}
