namespace Maths.Geometric
{
    using System;

    public class LPI
    {
        public static bool IsTwoLineIntersect(Point p1, Point p2, Point q1, Point q2)
        {
            if ((OTP.Orientation(p1, p2, q1) != OTP.Orientation(p1, p2, q2)) && (OTP.Orientation(q1, q2, p1) != OTP.Orientation(q1, q2, p2)))
                return true;

            var rangeX1 = new Range<double>(p1.X, p2.X);
            var rangeX2 = new Range<double>(q1.X, q2.X);
            var rangeY1 = new Range<double>(p1.Y, p2.Y);
            var rangeY2 = new Range<double>(q1.Y, q2.Y);

            if (OTP.Orientation(p1, p2, q1)==0 && OTP.Orientation(p1, p2, q2)==0 && rangeX1.IsOverlapped(rangeX2) && rangeY1.IsOverlapped(rangeY2))
            {
                return true;
            }

            return false;
        }

        public static bool IsPointInLine(Point l1, Point l2, Point p)
        {
            if (OTP.Orientation(l1, l2, p) == 0 && p.X >= Math.Min(l1.X, l2.X) && p.X <= Math.Max(l1.X, l2.X) && p.Y>= Math.Min(l1.Y, l2.Y) && p.Y<=Math.Max(l1.Y, l2.Y))
            {
                return true;
            }

            return false;
        }
    }
}
