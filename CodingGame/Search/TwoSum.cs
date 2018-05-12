using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class TwoSum
    {
        //Write a function that, given a list and a target sum, returns zero-based indices of any two distinct elements whose sum is equal to the target sum. If there are no such elements, the function should return null.
        //For example, FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12) should return a Tuple<int, int> containing any of the following pairs of indices:

        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {

            var hs = new HashSet<int>();
            for (int i = 0; i < list.Count; i++)
            {
                hs.Add(list[i]);
            }

            for (int i = 0; i < hs.Count; i++)
            {
                //HashSet is the most performance collection
                var diff = sum - list[i];
                if (hs.Contains(diff))
                {
                    var index = list.IndexOf(diff);
                    return new Tuple<int, int>(i, index);
                }
            }

            return null;

        }
    }
}
