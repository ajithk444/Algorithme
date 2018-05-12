using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class BinaryTreeSearch
    {
        public static void BinaryTreeSearchMethod(){
            Node small = new Node();
            small.value = 10;
            small.Left = new Node();
            small.Left.value = 5;
            small.Left.Left = new Node();
            small.Left.Left.value = 1;
            small.Right = new Node();
            small.Right.value = 6;
            small.Right.Right = new Node();
            small.Right.Right.value = 121;

            Console.WriteLine("The search result : {0}", small.Find(121));
            Console.WriteLine("The search result : {0}", small.Find(100));
        }

    }

    class Node
    {
        public Node Left, Right;
        public int value;

        public bool Find(int value)
        {
            if (this.value == value) return true;
            if(this.Left!=null && this.Left.Find(value)==true){
                return true;
            }
            if (this.Right != null && this.Right.Find(value) == true)
            {
                return true;
            }
            return false; 
        }
    }
}
