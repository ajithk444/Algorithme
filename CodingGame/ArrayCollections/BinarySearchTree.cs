using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollections
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public void Insert(int value)
        {
            Node newNode = new Node { Value = value };
            Node node = Root;

            if (Root == null)
            {
                Root = newNode;
                return;
            }
            while(true)
            {
                if(value < node.Value)
                {
                    if(node.Left == null)
                    {
                        node.Left = newNode;
                        break;
                    }
                    else
                    {
                        node = node.Left;
                    }
                    
                }
                else
                {
                    if(node.Right == null)
                    {
                        node.Right = newNode;
                        break;
                    }
                    else
                    {
                        node = node.Right;
                    }
                }
            }
        }

        public void DisplayBFS()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);
            while (queue.Count()>0)
            {
                Node child = queue.Dequeue();
                Console.Write(child.Value + " : ");
                if (child.Left != null) queue.Enqueue(child.Left);
                if (child.Right != null) queue.Enqueue(child.Right);
            }
        }

        public void DisplayDFS(Node root)
        {
            Console.Write(root.Value + " : ");
            foreach (var item in GetChildren(root))
            {
                DisplayDFS(item);
            }
        }

        public HashSet<Node> GetChildren(Node parent)
        {
            HashSet<Node> nodes = new HashSet<Node>();
            if (parent.Left != null) nodes.Add(parent.Left);
            if (parent.Right != null) nodes.Add(parent.Right);
            return nodes;
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
