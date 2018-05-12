using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class Program 
    {
        public static void Main()
        {
            /****************Binary Search Test*********************/
            /*
            int[] ints = new int[] { -1, 2, 4, 6, 10, 12, 18, 30, 37 };
            Console.WriteLine("The result is {0}", BinarySearch.Exists(ints, -2));
             * /

            /****************Binary Tree Search Test*********************/
            //BinaryTreeSearch.BinaryTreeSearchMethod();

            /******Search the number of numbers less than the specified value*******/
            int[] ints = new int[] { 1,6,10,10,11,13,15 };
            ints = new int[] { 1, 3, 5, 7 };
            Console.WriteLine("The result is : "+BinarySearch.CountNumbers(ints, 4));
            
            Console.Read();
        }
    }
}
