using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollections
{
    public class MergeTwoSortedLInkedList
    {
        public static LinkedList<int> MergeSortedLinkedListSolutionOne(LinkedList<int> listOne, LinkedList<int> listTwo)
        {
            LinkedList<int> mergedList = new LinkedList<int>();
            var itemListTwo = listTwo.First;
            var itemListOne = listOne.First;

            while (itemListOne != null || itemListTwo != null)
            {
                if (itemListOne == null)
                {
                    mergedList.AddLast(itemListTwo.Value);
                    itemListTwo = itemListTwo.Next;
                    continue;
                }

                if (itemListTwo == null)
                {
                    mergedList.AddLast(itemListOne.Value);
                    itemListOne = itemListOne.Next;
                    continue;
                }

                if (itemListOne.Value < itemListTwo.Value)
                {
                    mergedList.AddLast(itemListOne.Value);
                    itemListOne = itemListOne.Next;
                }
                else
                {
                    mergedList.AddLast(itemListTwo.Value);
                    itemListTwo = itemListTwo.Next;
                }
            }

            return mergedList;
        }

        public static LinkedList<int> MergeSortedLinkedListSolutionTwo(LinkedList<int> listOne, LinkedList<int> listTwo)
        {
            return new LinkedList<int>(listOne.Union(listTwo).OrderBy(x => x));
        }

        public static LinkedList<string> MergeSortedLinkedListSolutionTwo(LinkedList<string> listOne, LinkedList<string> listTwo)
        {
            return new LinkedList<string>(listOne.Union(listTwo).OrderBy(x => x));
        }

        
    }
}
