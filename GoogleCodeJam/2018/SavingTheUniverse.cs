using System;
using System.Linq;

namespace GoogleCodeJam
{
    public class SavingTheUniverse
    {
        public static void Start()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int[] D = new int[t];
            string[] P = new string[t];

            for (int i = 0; i < t; i++)
            {
                var strs = Console.ReadLine().Split(' ');
                D[i] = Convert.ToInt32(strs[0]);
                P[i] = strs[1];
            }

            for (int i = 0; i < t; i++)
            {
                string str = P[i].TrimEnd('C');
                int[] nums = new int[str.Length];
                for (int j = 0, h=0; j < str.Length; j++)
                {
                    if (str[j] == 'C')
                    {
                        h++;
                    }
                    else
                    {
                        nums[h]++;
                    }
                }

                int minSum = nums.Sum();
                if(D[i] < minSum)
                {
                    Output(i + 1, 0, false);
                }
                else
                {
                    int step = 0;
                    int curIndex = nums.LastOrDefault(s => s!=0);
                    int sum = (int)nums.Select((s, index) => s * Math.Pow(2, index)).Sum();
                    while (sum > D[i])
                    {
                        if (nums[curIndex] != 0)
                        {
                            nums[curIndex]--;
                            nums[curIndex-1]++;
                            sum =sum - (int)Math.Pow(2, curIndex) + (int)Math.Pow(2, curIndex-1);
                            step++;
                        }
                        else
                        {
                            curIndex--;
                        }
                    }

                    Output(i + 1, step, true);
                }
            }
        }

        public static void Output(int caseNum, int result, bool isPossible)
        {
            Console.Write("Case #" + caseNum + ": ");
            if (isPossible)
            {
                Console.Write(result);
            }
            else
            {
                Console.Write("IMPOSSIBLE");
            }
            Console.WriteLine();
        }
    }
}
