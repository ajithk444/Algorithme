﻿using System;

namespace Maths.Geometric
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// 3D rotation matrix
        /// </summary>
        /// <param name="pointToRotate"></param>
        /// <param name="centerPoint"></param>
        /// <param name="dir">The ratation direction, 0 is Z axis, 1 is x axis, 2 is y axis </param>
        /// <param name="angleInDegrees"></param>
        /// <returns>3D point after rotation</returns>
        public static Point3D RotatePoint3D(Point3D pointToRotate, Point3D centerPoint, int dir, double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);
            double x = pointToRotate.X - centerPoint.X;
            double y = pointToRotate.Y - centerPoint.Y;
            double z = pointToRotate.Z - centerPoint.Z;
            double x1, y1, z1;

            if (dir == 0)
            {
                x1 = cosTheta * x -sinTheta * y + centerPoint.X;
                y1 = sinTheta * x + cosTheta * y + centerPoint.Y;
                z1 = pointToRotate.Z + centerPoint.Z;
            }else if (dir == 1)
            {
                y1 = cosTheta * y - sinTheta * z + centerPoint.Y;
                z1 = sinTheta * y + cosTheta * z + centerPoint.Z;
                x1 = pointToRotate.X + centerPoint.X;
            }
            else
            {
                z1 = cosTheta * z - sinTheta * x + centerPoint.Z;
                x1 = sinTheta * z + cosTheta * x + centerPoint.X;
                y1 = pointToRotate.Z + centerPoint.Z;
            }

            return new Point3D(x1, y1, z1);
        }

        public override string ToString()
        {
            return this.X+" "+this.Y+" "+this.Z;
        }
    }
}
