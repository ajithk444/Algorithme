using System;
using System.Collections.Generic;

namespace DynamiqueProgramming
{
    //Simple solution
    public class UglyNumSolution1
    {
        public static HashSet<int> UglyNums = new HashSet<int>() { 1, 2, 3, 4, 5};

        public static void Print(int index)
        {
            if (index <= 5)
            {
                Console.WriteLine(index);
                return;
            }
            int counter = 5;
            for (int i = 6; i <= int.MaxValue; i++)
            {
                if((i % 2 == 0 && UglyNums.Contains(i / 2)) || (i % 3 == 0 && UglyNums.Contains(i / 3)) || (i % 5 == 0 && UglyNums.Contains(i / 5)))
                {
                    UglyNums.Add(i);
                    ++counter;
                    if (counter == index)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
        }
    }

    //Optimized solution
    public class UglyNumSolution2
    {
        public static int[] UglyNums;

        public static void Print(int index)
        {
            UglyNums = new int[index];

            UglyNums[0] = 1;
            int index1 = 0, index2 = 0, index3 = 0;

            int newUglyNums1 = UglyNums[index1] * 2;
            int newUglyNums2 = UglyNums[index2] * 3;
            int newUglyNums3 = UglyNums[index3] * 5;
            int i = 1;
            while(i < index)
            {
                int newUglyNum = Math.Min(newUglyNums1, Math.Min(newUglyNums2, newUglyNums3));
                if (UglyNums[i - 1] != newUglyNum)
                {
                    UglyNums[i++] = newUglyNum;
                }

                if (newUglyNums1 == newUglyNum)
                {
                    newUglyNums1 = UglyNums[++index1] * 2;
                }
                else if (newUglyNums2 == newUglyNum)
                {
                    newUglyNums2 = UglyNums[++index2] * 3;
                }
                else
                {
                    newUglyNums3 = UglyNums[++index3] * 5;
                }
            }

            Console.WriteLine(UglyNums[index-1]);
        }
    }
}
