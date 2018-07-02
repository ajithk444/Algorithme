using Maths.Geometric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    class Program
    {
        static void Main(string[] args)
        {
            var ps = new Point[] { new Point(-1, 1), new Point(0, 0), new Point(1, 1), new Point(2, 2), new Point(3, 3), new Point(3, 1) };
            Console.WriteLine(MaximunPointsInOneLine.GetMax(ps));

            Console.Read();
        }
    }
}
