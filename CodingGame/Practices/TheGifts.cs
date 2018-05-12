using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    class TheGifts
    {
        public static void Solution()
        {
            int N = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            int average = C / N;
            int rest = C;
            List<int> budgets=new List<int>();
            List<int> results=new List<int>();

            for (int i = 0; i < N; i++)
            {
                int B = int.Parse(Console.ReadLine());
                if(B<=average){
                     results.Add(B);
                     rest-=B;
                }else{
                    budgets.Add(B);
                }
            }

            while(rest>0 && budgets.Count>0){
                N = budgets.Count;
                average = rest / N;
                for (int i = N-1; i >=0; i--)
                {
                    if (budgets[i] <= average)
                    {
                        results.Add(budgets[i]);
                        rest -= budgets[i];
                        budgets.RemoveAt(i);
                    }
                }
                if (budgets.Count == N)
                {
                    budgets.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        rest -= average;
                        results.Add(average);
                    }
                    N = results.Count-1;
                    while(rest>0){
                        rest--;
                        results[N--] += 1;
                    }
      
                }
            }

            if(rest>0)
                Console.WriteLine("IMPOSSIBLE");
            else
            {
                results.Sort();
                foreach (int i in results)
                    Console.WriteLine(i);
            }

        }

        
    }
}
