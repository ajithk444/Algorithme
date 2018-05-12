using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeJam
{
    public class RoundingError
    {
        public class Info
        {
            public int Index;
            public int Value;
        }
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int[][] Ns = new int[t][];
            int[][] numss = new int[t][];

            for (int i = 0; i < t; i++)
            {
                Ns[i] = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
                numss[i] = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
            }

            for (int i = 0; i < t; i++)
            {
                int N = Ns[i][0];
                int L = Ns[i][1];
                int[] nums = numss[i];
                List<Info> infos = new List<Info>();
                int left = N - nums.Sum();
                int result = 0;
                double full = 100.0;

                for (int m = 0; m < nums.Length; m++)
                {
                    infos.Add(new Info());
                    infos[m].Index=m;
                    double r = (double)(nums[m]) / N * full;
                    if (isAdd(r))
                    {
                        infos[m].Value++;
                    }
                }

                int temp = 1;
                for (int h = 1; h <= N; h++)
                {
                    double r = (double)(h) / N * full;
                    if (!isAdd(r))
                    {
                        temp=h;
                        break;
                    }
                }

                var list = infos.OrderBy(s => s.Value).ToList();
               
                for (int m = 0; m < list.Count; m++)
                {
                    if (list[m].Value < temp && left >= list[m].Value)
                    {
                        double r = (double)(nums[list[m].Index] + list[m].Value) / N * full;
                        result += (int)Math.Round(r, MidpointRounding.AwayFromZero);
                        left -= list[m].Value;
                    }
                    else if(list[m].Value > temp && left>0)
                    {
                        if (left >= temp)
                        {
                            double r = (double)(temp) / N * full;
                            result += (int)Math.Round(r, MidpointRounding.AwayFromZero);
                            left -= temp;
                            m--;
                        }
                        else
                        {
                            double r = (double)(left) / N * full;
                            result += (int)Math.Round(r, MidpointRounding.AwayFromZero);
                            left=0;
                        }
                    }
                    else
                    {
                        double r = (double)(nums[list[m].Index]) / N * full;
                        result += (int)Math.Round(r, MidpointRounding.AwayFromZero);
                    }
                }

                while (left > 0)
                {
                    if (left >= temp)
                    {
                        double r = (double)(temp) / N * full;
                        result += (int)Math.Round(r, MidpointRounding.AwayFromZero);
                        left -= temp;
                    }
                    else
                    {
                        double r = (double)(left) / N * full;
                        result += (int)Math.Round(r, MidpointRounding.AwayFromZero);
                        left = 0;
                    }
                }

                Output(i + 1, result);
            }
           
        }

        public static bool isAdd(double num) {
            return Math.Round(num, MidpointRounding.AwayFromZero) == Math.Floor(num);
        }


        public static void Output(int caseNum, int result)
        {
            Console.Write("Case #" + caseNum + ": "+result);
 
            Console.WriteLine();
        }
    }
}
