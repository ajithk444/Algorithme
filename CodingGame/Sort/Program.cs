using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {5,4,6,25,14,36,39,25,74,69,32,12,6,69,32,27,99};

            /**********QuickSort*************/
            Stopwatch watch = new Stopwatch();
            watch.Start();

            QuickSort.QuickSortArray(numbers, 0, numbers.Length-1);

            watch.Stop();
            Console.WriteLine("The time elapsed : " + watch.ElapsedMilliseconds);
            printArray(numbers);

            Console.Read();
        }

        static void printArray(int[] numbers)
        {
            foreach(int number in numbers){
                Console.Write(number+" ");
            }
        }
    }
}
