using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class ChoiceOfArea
    {
        public static Tuple<int, int> start;
        public static Tuple<int, int> X;
        public static Tuple<int, int> Y;
        public static Tuple<int, int> Z;
        public static Dictionary<Tuple<int, int, int>, int> maxSteps = new Dictionary<Tuple<int, int, int>, int>();

        public static int GetMaxUtil(int x, int y, int current)
        {
            if (x < 0 || y < 0) return 0;
            var step = new Tuple<int, int, int>(x, y, current);
            if (maxSteps.ContainsKey(step)) return maxSteps[step];
            switch (current)
            {
                case 1:
                    return maxSteps[step] = Math.Max(1 + GetMaxUtil(x + Y.Item1, y + Y.Item2, 2), 1 + GetMaxUtil(x + Z.Item1, y + Z.Item2, 3));
                case 2:
                    return maxSteps[step] = Math.Max(1 + GetMaxUtil(x + X.Item1, y + X.Item2, 1), 1 + GetMaxUtil(x + Z.Item1, y + Z.Item2, 3));
                default:
                    return maxSteps[step] = Math.Max(1 + GetMaxUtil(x + X.Item1, y + X.Item2, 1), 1 + GetMaxUtil(x + Y.Item1, y + Y.Item2, 2));
            }
        }

        public static int GetMax(int x, int y)
        {
            var step = new Tuple<int, int>(x, y);
            return Math.Max(GetMaxUtil(x + X.Item1, y + X.Item2, 1), Math.Max(GetMaxUtil(x + Y.Item1, y + Y.Item2, 2), GetMaxUtil(x + Z.Item1, y + Z.Item2, 3)));
        }

        public static void Start(int[] nums)
        {
            X = new Tuple<int, int>(nums[2], nums[3]);
            Y = new Tuple<int, int>(nums[4], nums[5]);
            Z = new Tuple<int, int>(nums[6], nums[7]);
            Console.WriteLine(GetMax(nums[0], nums[1]));
        }
    }
}
