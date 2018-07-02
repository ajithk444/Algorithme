namespace Geometric
{
    using System.Linq;
    using Maths.Geometric;
    using System.Collections.Generic;
    using System;

    public class MaximunPointsInOneLine
    {
        public const double INF = double.MaxValue;

        public static int GetMax(Point[] ps)
        {
            Dictionary<double, HashSet<int>> dicP = new Dictionary<double, HashSet<int>>();

            HashSet<int> vPs = new HashSet<int>();

            int num = ps.Length;
            for (int i = 0; i < num; i++)
            {
                for (int j = i+1; j < num; j++)
                {
                    if(ps[j].X - ps[i].X == 0){
                        if (!vPs.Contains(i)) vPs.Add(i);
                        if (!vPs.Contains(j)) vPs.Add(j);
                    }
                    else{
                        double slop = (ps[j].Y - ps[i].Y) / (ps[j].X - ps[i].X);
                        if (dicP.ContainsKey(slop))
                        {
                            if (!dicP[slop].Contains(i)) dicP[slop].Add(i);
                            if (!dicP[slop].Contains(j)) dicP[slop].Add(j);
                        }
                        else
                        {
                            dicP.Add(slop, new HashSet<int>{i, j});
                        }
                       
                    }
                }
            }

            return Math.Max(dicP.Max(d => d.Value.Count), vPs.Count);
        }
    }
}
