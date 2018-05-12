using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    public class Link
    {
        private int x;
        private int y;

        public Link(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print(){
            Console.WriteLine(x+" "+y);
        }

        public override bool Equals(Object obj)
        {
            Link other = obj as Link;
            if (other != null)
            {
                return (other.x == this.x && other.y == this.y) || (other.y == this.x && other.x == this.y);
            }

            return false;
        }

        public override int GetHashCode()
        {
             return base.GetHashCode();
        }

    }


    class SkynetRevolution
    {
   
        public static bool BlockLink(int node, int[] gateways, List<Link> lists){
            foreach (int gateway in gateways)
            {
                int index = lists.IndexOf(new Link(node, gateway));
                if(index!=-1){
                    lists[index].Print();
                    lists.RemoveAt(index);
                    return true;
                }
            }

            return false;
        }
      

        public static void Solution()
        {

            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]); // the total number of nodes in the level, including the gateways
            int L = int.Parse(inputs[1]); // the number of links
            int E = int.Parse(inputs[2]); // the number of exit gateways

            List<Link> links=new List<Link>();
            int[] gateways=new int[E];


            for (int i = 0; i < L; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int N1 = int.Parse(inputs[0]); // N1 and N2 defines a link between these nodes
                int N2 = int.Parse(inputs[1]);
                links.Add(new Link(N1, N2));
            }
            for (int i = 0; i < E; i++)
            {
                int EI = int.Parse(Console.ReadLine()); // the index of a gateway node
                gateways[i]=EI;
            }

            // game loop
            while (true)
            {
                int SI = int.Parse(Console.ReadLine()); // The index of the node on which the Skynet agent is positioned this turn

                if (!BlockLink(SI, gateways, links))
                {
                    links[0].Print();
                    links.RemoveAt(0);
                }

            }
        }
    }
}
