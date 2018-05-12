using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class TelephoneNumber
    {

        public static void Solution()
        {
            int N = int.Parse(Console.ReadLine());

            Tree tree = new Tree(-1);

            Tree point;

            for (int i = 0; i < N; i++)
            {
                string telephone = Console.ReadLine();
                char[] temp = telephone.ToCharArray();
                point = tree;
                foreach (char c in temp)
                {
                    Tree childNode = new Tree(Convert.ToInt16(c));
                    point = point.addChild(childNode);
                }
            }

            int result = 0;

            result += GetNumChild(tree);


            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // The number of elements (referencing a number) stored in the structure.
            Console.WriteLine(result);
        }

        public static int GetNumChild(Tree tree)
        {
            int result = tree.GetChildren().Count;
            foreach (Tree subTree in tree.GetChildren())
                result += GetNumChild(subTree);
            return result;
        }


        public class Tree
        {
            public int Number { get; private set; }

            private HashSet<Tree> children = new HashSet<Tree>();

            public Tree(int number)
            {
                Number = number;
            }

            public Tree addChild(Tree node)
            {
                if (!children.Contains(node))
                    children.Add(node);
                else
                    node = children.First(t => t.Number == node.Number);

                return node;
            }

            public HashSet<Tree> GetChildren()
            {
                return children;
            }

            public override bool Equals(object obj)
            {
                Tree other = obj as Tree;
                if (other != null)
                    return other.Number == this.Number;
                return false;
            }

            public override int GetHashCode()
            {
                return Number.GetHashCode();
            }
        }
    }
}
