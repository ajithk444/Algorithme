using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class BinarySearch
    {
        public static bool Exists(int[] ints, int k){
            int start, end, middle;
            start=0;
            end=ints.Length-1;
           
            while(start<=end){
                middle = (start + end) / 2;
                if(k==ints[middle]) return true;
                if (k < ints[middle]) {
                    end = middle-1;
                }
                if (k > ints[middle])
                {
                    start = middle+1;
                }
            }
            return false;
        }

        
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            int start, end, middle;
            start = 0;
            end = sortedArray.Length - 1;
            middle = 0;
            while (start<end)
            {
                middle = (start + end) / 2;
                if (sortedArray[middle] < lessThan){
                     start = middle + 1;
                }else{
                    end = middle - 1;
                }
            }

            if (sortedArray[start] < lessThan) start += 1;

            return start;
        }

       
    }
}
