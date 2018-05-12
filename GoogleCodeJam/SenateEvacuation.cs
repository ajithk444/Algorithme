using System;
using System.Collections.Generic;
using System.Linq;

namespace GoogleCodeJam
{
    //mark
    public class Party
    {
        public char C { get; set; }
        public int Num { get; set; }
        public Party(char c, int num)
        {
            C = c;
            Num = num;
        }
    }

    class SenateEvacuation
    {
        static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int[] Ns = new int[t];
            int[][] numss = new int[t][];

            for (int i = 0; i < t; i++)
            {
                Ns[i] = Convert.ToInt32(Console.ReadLine());
                numss[i] = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
            }

            for (int i = 0; i < t; i++)
            {
                int N = Ns[i];
                int[] nums = numss[i];
                List<Party> infos = new List<Party>();
                for (int j = 0; j < N; j++)
                {
                    infos.Add(new Party((char)(j+65), nums[j]));
                }
                infos = infos.OrderByDescending(info => info.Num).ToList();
                bool[] areEmpties = new bool[N];
                List<Char> solution = new List<Char>();
                while(areEmpties.Any(s => s == false))
                {
                    for (int h = 0; h < N; h++)
                    {
                        while (areEmpties[h] == false)
                        {
                            if (infos[h].Num == 0)
                            {
                                areEmpties[h] = true;
                                h = 0;
                                break;
                            }else if (h == N - 1 && infos[h].Num <= infos[h - 1].Num)
                            {
                                h = 0;
                            }
                            else if (h == 0 && infos[h].Num >= infos[h + 1].Num)
                            {
                                solution.Add(infos[h].C);
                                infos[h].Num--;
                            }
                            else if (h > 0 && infos[h].Num > infos[h - 1].Num)
                            {
                                solution.Add(infos[h].C);
                                infos[h].Num--;
                            }else if (h<N-1 && infos[h].Num < infos[h + 1].Num)
                            {
                                h++;
                            }
                            else
                            {
                                h = 0;
                            }
                        }
                    }
                }

                Console.Write("Case #"+ (i+1) +": ");

                for (int m = 0; m < solution.Count; m++)
                {
                    Console.Write(solution[m]);
                    if (m % 2 == 1) Console.Write(' ');
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
