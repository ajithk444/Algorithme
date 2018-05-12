using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sort
{
    class QuickSort
    {
        public static void QuickSortArray(int[] numbers,int start, int end)
        {
      
            if (start < end)
            {
                int pivot = numbers[end];
                int pindex = start;
                int swap;
                for (int i = start; i < end; i++)
                {
                    if (numbers[i] < pivot)
                    {
                        if (i != pindex)
                        {
                            swap = numbers[pindex];
                            numbers[pindex] = numbers[i];
                            numbers[i] = swap;
                        }
                        pindex++;
                    }
                }
                if (end != pindex)
                {
                    numbers[end] = numbers[pindex];
                    numbers[pindex] = pivot;
                }
                
                QuickSortArray(numbers, start, pindex - 1);
                QuickSortArray(numbers, pindex+1, end);
            }
    

            /*
            // Deuxième solution
           if (start < end)
           {
               int pivot = numbers[end];
               int position = -1;
               int swap;
               for (int i = start, j = end - 1; i <= j; )
               {
                   if (numbers[i] >= pivot && numbers[j] < pivot)
                   {
                       swap = numbers[i];
                       numbers[i]=numbers[j];
                       numbers[j] = swap;
                       position = j;
                   }
                   else if (numbers[i] <= pivot && numbers[j] > pivot)
                   {
                
                   }
                   else if (numbers[i] >= pivot && numbers[j] > pivot)
                   {
                 
                   }
                   else(numbers[i] <= pivot && numbers[j] < pivot)
                   {
                     
                   }
                  
               }
               if (position != -1)
               {
                   swap = numbers[position];
                   numbers[position] = pivot;
                   numbers[end] = swap;
               }
               else
               {
                   position = end;
               }
               QuickSortArray(numbers, start, position - 1);
               QuickSortArray(numbers, position + 1, end);
           }
             */
           


        }
    }
}
