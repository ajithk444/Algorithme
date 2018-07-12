using Maths.Geometric;
using System;
using System.Globalization;
using System.Linq;

namespace GoogleCodeJam
{
    public class CubicUFO
    {
        public static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            double[] Area = new double[t];

            for (int i = 0; i < t; i++)
            {
                Area[i] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            var A = new Point3D(0.5, -0.5, 0.5);
            var B = new Point3D(-0.5, -0.5, -0.5);
            var C = new Point3D(-0.5, 0.5, 0.5);
            var centerP = new Point3D(0, 0, 0);
            double aZrotationMax = Math.Sqrt(2);
            Point3D[] result;

            for (int i = 0; i < t; i++)
            {
                double ar = Area[i];
                Point3D A1, B1, C1;

                if (ar <= aZrotationMax)
                {
                    double degree =Math.PI/4 - Math.Acos(ar / Math.Sqrt(2));
                    A1 = Point3D.RotatePoint3D(A, centerP, 0, degree);
                    B1 = Point3D.RotatePoint3D(B, centerP, 0, degree);
                    C1 = Point3D.RotatePoint3D(C, centerP, 0, degree);
                    result = new Point3D[] {
                         GetMidPoint(A1,B1),
                         GetMidPoint(A1,C1),
                         GetMidPoint(B1,C1),
                    };
                }
                else
                {
                    double degreeZ = Math.PI / 4;

                    A1 = Point3D.RotatePoint3D(A, centerP, 0, degreeZ);
                    B1 = Point3D.RotatePoint3D(B, centerP, 0, degreeZ);
                    C1 = Point3D.RotatePoint3D(C, centerP, 0, degreeZ);

                    double degreeX = 0;
                    double dMin = 0;
                    double dMax = Math.PI / 4;
                    double caX = GetPolygonAreaRotationByAngle(centerP, A1, B1, C1, dMin);
                    double caXMax = GetPolygonAreaRotationByAngle(centerP, A1, B1, C1, dMax);
                    if(caXMax == ar)
                    {
                        degreeX = dMax;
                    }
                    else
                    {
                        while (ar != caX)
                        {
                            degreeX = (dMin + dMax) / 2;
                            caX = GetPolygonAreaRotationByAngle(centerP, A1, B1, C1, degreeX);
                            if (caX < ar)
                            {
                                dMin = degreeX;
                            }
                            else
                            {
                                dMax = degreeX;
                            }
                        }
                    }

                    Point3D A2, B2, C2;
                    A2 = Point3D.RotatePoint3D(A1, centerP, 1, degreeX);
                    B2 = Point3D.RotatePoint3D(B1, centerP, 1, degreeX);
                    C2 = Point3D.RotatePoint3D(C1, centerP, 1, degreeX);
                    result = new Point3D[] {
                         GetMidPoint(A2,B2),
                         GetMidPoint(A2,C2),
                         GetMidPoint(B2,C2),
                    };
                }

                Output(i + 1, result);
            }
            Console.Read();
        }

        private static Point3D GetMidPoint(Point3D A, Point3D B)
        {
            return new Point3D((A.X+B.X)/2, (A.Y+B.Y)/2, (A.Z+B.Z)/2, 8, true);
        }

        private static double GetPolygonAreaRotationByAngle(Point3D centerP, Point3D A1, Point3D B1, Point3D C1, double degree)
        {
            Point3D A2, B2, C2;

            A2 = Point3D.RotatePoint3D(A1, centerP, 1, degree);
            B2 = Point3D.RotatePoint3D(B1, centerP, 1, degree);
            C2 = Point3D.RotatePoint3D(C1, centerP, 1, degree);

            double[] ax = new double[] { A2.X, B2.X, C2.X };
            double[] az = new double[] { A2.Z, B2.Z, C2.Z };
            double area = Math.Round(2 * Polygon.GetPolygonArea(ax, az, 3), 6, MidpointRounding.AwayFromZero);
            return area;
        }

        public static void Output(int caseNum, Point3D[] ps)
        {
            Console.WriteLine("Case #" + caseNum + ": ");
            foreach (var p in ps)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public static double GetPolygonArea(double[] X, double[] Y, int n)
        {

            // Initialze area
            double area = 0.0;

            // Calculate value of shoelace formula
            int j = n - 1;

            for (int i = 0; i < n; i++)
            {
                area += (X[j] + X[i]) * (Y[j] - Y[i]);

                // j is previous vertex to i
                j = i;
            }

            // Return absolute value
            return Math.Abs(area / 2);
        }
    }
}
