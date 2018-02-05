using System;
using System.Linq;

namespace DynamiqueProgramming
{
    public class LargestSumContiguousSubArray
    {
        public static int[] Nums;
        public static int[] Sums;

        public static int GetLargestSumUtil()
        {
            int counter = 0;
            int maxSum = Nums[0];

            while (counter < Nums.Length)
            {
                if (Nums[counter] > 0) {
                    maxSum = Math.Max(maxSum, GetGreatestLastElementsSum(counter));
                }
                counter++;
            }
            return maxSum;
        }

        public static int GetGreatestLastElementsSum(int counter)
        {
            if (Sums[counter] != int.MinValue) return Sums[counter];
            if (counter == 0) return Nums[0];
            if (Sums[counter-1] < 0) return Sums[counter] = Nums[counter];
            return Sums[counter] = Sums[counter - 1] + Nums[counter];
        }

        public static void GetLargestSum()
        {
            string nums = Console.ReadLine();
            Nums = nums.Split(' ').Select(s => int.Parse(s)).ToArray();

            Sums = new int[Nums.Length];
            for (int i = 0; i < Nums.Length; i++)
            {
                Sums[i] = int.MinValue;
            }

            Console.WriteLine("The list is :");
            foreach (int item in Nums)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("The largest sum is " + GetLargestSumUtil());
        }
    }
}
