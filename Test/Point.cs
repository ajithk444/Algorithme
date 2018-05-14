using System;

public class Point2D
{
    public int X;
    public int Y;

    public Point2D()
    {
    }

    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }


    public int DistanceInf(Point2D other)
    {
        return Math.Max(Math.Abs(this.X - other.X), Math.Abs(this.Y - other.Y));
    }
}