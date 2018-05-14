
//***************************************************************
//*
//*
//* SOLUTION BY seb_delmas
//*
//*
//******************************************************************
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solver01
{
    class Program
    {
        static string[][] strs;
        static int[][] ints;
        static int startX, startY;

        static void Main(string[] args)
        {
            var input = new List<string>();
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                input.Add(line);
            }

            int H = int.Parse(input[0]);
            int L = int.Parse(input[1]);
            strs = new string[H][];
            for (int i = 0; i < H; i++)
            {
                strs[i] = new string[L];
            }
            
            ints = new int[H][];
            for (int i = 0; i < H; i++)
            {
                ints[i] = new int[L];
            }

            //ConvertArray();

            for (int i = 0; i < H; i++)
            {
                strs[i] = input[i + 2].ToCharArray().Select(s => s.ToString()).ToArray();
            }
            int result = 0;
            for (int i = 0; i < strs.Count(); i++)
            {
                for (int j = 0; j < strs[i].Count(); j++)
                {
                    if (strs[i][j] == "x")
                    {
                        startX = i;
                        startY = j;
                    }
                }
            }

            result += GetNumCase(startX, startY);
            Console.WriteLine(result);

            Console.Read();
        }

        public static int GetNumCase(int x, int y)
        {
            if (strs[x][y] == "v") return 0;
            if (strs[x][y] == "*")
            {
                strs[x][y] = "v";
                return 0;
            }
            int total = 1;
            strs[x][y] = "v";
            
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    if (x < 0 || y < 0 || x > strs.Count() - 1 || y > strs.Count() - 1) continue;
                    if (strs[i][j] != "v")
                    {
                        total += GetNumCase(i, j);
                    }
                }
            }
            return total;
        }

        //public static int GetNumCase(int x, int y)
        //{
        //    if (ints[x][y] == -1) return 0;
        //    if (ints[x][y] == 1)
        //    {
        //        ints[x][y] = -1;
        //        return 1;
        //    }
        //    int total = 1;
        //    ints[x][y] = -1;

        //    for (int i = x; i < x + 3; i++)
        //    {
        //        for (int j = y; j < y + 3; j++)
        //        {
        //            if (x < 0 || y < 0 || x > strs.Count() - 1 || y > strs.Count() - 1) continue;
        //            if (ints[i][j] != -1)
        //            {
        //                total += GetNumCase(i, j);
        //            }
        //        }
        //    }
        //    return total;
        //}

        //public static void ConvertArray()
        //{
        //    for (int i = 0; i < strs.Count(); i++)
        //    {
        //        for (int j = 0; j < strs[i].Count(); j++)
        //        {
        //            if (strs[i][j] == "x")
        //            {
        //                startX = i;
        //                startY = j;
        //            }

        //            ints[i][j] = GetNum(i, j);
        //        }
        //    }
        //}

        //public static int GetNum(int x, int y)
        //{
        //    for (int i = x; i < x + 3; i++)
        //    {
        //        for (int j = y; j < y + 3; j++)
        //        {
        //            if (x < 0 || y < 0 || x > strs.Count() - 1 || y > strs.Count() - 1) continue;
        //            if (i != x + 1 || j != y + 1)
        //            {
        //                return 1;
        //            }
        //        }
        //    }
        //    return 0;
        //}
    }
}

