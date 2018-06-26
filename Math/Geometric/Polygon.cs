using System;

namespace Maths.Geometric
{
    public class Polygon
    {
        /// <summary>
        /// We can compute area of a polygon using Shoelace formula.
        /// </summary>
        public static double GetPolygonArea(double[] X, double[] Y, int n)
        {

            // Initialze area
            double area = 0.0;

            // Calculate value of shoelace formula
            int j = n-1;

            for (int i = 0; i < n; i++)
            {
                area += (X[j] + X[i]) * (Y[j] - Y[i]);

                // j is previous vertex to i
                j = i;
            }

            // Return absolute value
            return Math.Abs(area/2);
        }
    }
}
