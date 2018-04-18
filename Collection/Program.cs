using Collection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Priority Queue Test
            PriorityQueue<Employee> priorityQueue = new PriorityQueue<Employee>();
            priorityQueue.Enqueue(new Employee("Litao", 100));
            priorityQueue.Enqueue(new Employee("JingLi", 12));
            priorityQueue.Enqueue(new Employee("Leonard", 8));
            priorityQueue.Enqueue(new Employee("Shen", 3));
            priorityQueue.Enqueue(new Employee("Vincent", 13));
            priorityQueue.Enqueue(new Employee("Xinlong", 11));
            Console.WriteLine(priorityQueue);
            priorityQueue.Dequeue();
            Console.WriteLine(priorityQueue);
            priorityQueue.Enqueue(new Employee("Huangshen", 2));
            Console.WriteLine(priorityQueue);
            Console.Read();
        }
    }
}
