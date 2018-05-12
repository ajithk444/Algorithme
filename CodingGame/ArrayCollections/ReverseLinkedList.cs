using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollections
{
    public static class ReverseLinkedList
    {
        public static LinkedList<int> ReverseLInkedList(LinkedList<int> linkedList)
        {
            LinkedList<int> result = new LinkedList<int>();
            var lastNode = linkedList.Last;
            while (lastNode.Previous != null)
            {
                result.AddLast(lastNode.Value);
                lastNode = lastNode.Previous;
            }
            result.AddLast(lastNode.Value);
            return result;
        }

        public static void Display(this LinkedList<int> linkedList)
        {
            foreach(var item in linkedList.AsEnumerable())
            {
                Console.WriteLine(item);
            }
        }

        public static void Display(this LinkedList<string> linkedList)
        {
            foreach (var item in linkedList.AsEnumerable())
            {
                Console.WriteLine(item);
            }
        }
    }
}
