using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class MinimumCostFillWeight
    {
        public static int[] nums;
        public static int weight;
        public static int[,] dp;
        public const int MAXNUM = int.MaxValue;

        // Top bottom
        public static int GetMinUtil(int weight, int idx)
        {
            if (weight < 0 || idx < 0) return MAXNUM;
            if (nums[idx] == -1) return MAXNUM;
            if (weight == 0) return 0;
            if (dp[weight, idx] != -1) return dp[weight, idx];

            if(GetMinUtil(weight-idx-1, idx) != MAXNUM){
                return dp[weight, idx] = Math.Min(nums[idx] + GetMinUtil(weight-idx-1, idx), GetMinUtil(weight, idx - 1));
            }
            return dp[weight, idx] = GetMinUtil(weight, idx - 1);
            
        }

        // bottom top
        public static int GetMinBottomUp(int weight, int idx)
        {
            List<int> vweight = new List<int>();

            for (int i = 0; i <= idx; i++)
            {
                if(nums[i]!=-1){
                    vweight.Add(i+1);
                }
            }

            int n=vweight.Count();
            int[,] vdp = new int[n,weight+1];

            for (int m = 0; m < n; m++)
            {
                for (int h = 0; h < weight+1; h++)
                {
                    if (h == 0)
                    {
                        vdp[m, h] = 0;
                    }else if (m == 0 && h% vweight[m]==0)
                    {
                        vdp[m, h] = h / vweight[m] * nums[vweight[m]-1];
                    }
                    else
                    {
                        vdp[m, h] = int.MaxValue;
                    }
                }
            }

            for(int i=1; i<n; i++){
                for (int j = 1; j <= weight; j++)
                {
                    if (vweight[i] > j)
                    {
                        vdp[i, j] = vdp[i - 1, j];
                    }
                    else
                    {
                        if(vdp[i, j - vweight[i]] != int.MaxValue)
                        {
                            vdp[i, j] = Math.Min(vdp[i - 1, j], vdp[i, j - vweight[i]] + nums[vweight[i] - 1]);
                        }
                    }
                }
            }

            return vdp[n-1, weight];
        }

        public static void Start(int[] weights)
        {
            nums = weights;
            weight = weights.Count();
            dp = new int[weight+1, weight];
            for (int i = 0; i < weight+1; i++)
            {
                for (int j = 0; j < weight; j++)
                {
                    dp[i, j] = -1;
                }
            }

            // int minCost = GetMinUtil(weight, nums.Count()-1);
            int minCost = GetMinBottomUp(weight, nums.Count()-1);

            if(minCost < MAXNUM)
            {
                Console.WriteLine($"The minimun cost is : {minCost}");
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
