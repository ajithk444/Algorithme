using System;
using System.Linq;

namespace BitOperation
{
    /*
        Input: arr[] = {12, 1, 12, 3, 12, 1, 1, 2, 3, 3}
        Given an array where every element occurs three times, except one element which occurs only once.
    */
    public class FindElementOnce
    {
        public const int SIZE = 32;

        public static void DisplayWithMethod1(int[] nums, int times)
        {
            int result = 0;
            int sum;
            for (int i = 0; i < SIZE; i++)
            {
                sum = 0;
                int temp = 1 << i;
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((nums[j] & temp) != 0) ++sum;
                }
                if (sum % 3 != 0) result = result | temp;
            }
            Console.WriteLine("The single element is " + result);
        }

        public static void DisplayWithMethod2(int[] nums, int time)
        {
            Console.WriteLine("The single element is " + (nums.Distinct().Sum() * time - nums.Sum()) / (time - 1));
        }
    }
}
