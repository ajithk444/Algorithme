using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    class ShadowsOfKnight
    {
        public static int X;
        public static int Y;

        public struct SearchArea
        {
            public int x1 { get; set; }
            public int y1 { get; set; }
            public int x2 { get; set; }
            public int y2 { get; set; }

            public void SetValues(int x1, int y1, int x2, int y2)
            {
                this.x1 = x1;
                this.x2 = x2;
                this.y1 = y1;
                this.y2 = y2;
            }

        }

        public static SearchArea searchArea = new SearchArea();

      

        public static void Solution()
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int W = int.Parse(inputs[0])-1; // width of the building.
            int H = int.Parse(inputs[1])-1; // height of the building.
            
            int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
            inputs = Console.ReadLine().Split(' ');
            int X0 = int.Parse(inputs[0]);
            int Y0 = int.Parse(inputs[1]);
            X=X0;
            Y=Y0;

            searchArea.SetValues(0, 0, W, H);

            // game loop
            while (N-->0)
            {
                string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");
                bool final = false;
                switch(bombDir){
                    case "U":
                       searchArea.x1 = X;
                       searchArea.y2 = Y - 1;
                       searchArea.x2 = X; 
                       break;
                    case "R":
                       searchArea.x1 = X + 1;
                       searchArea.y1 = Y;
                       searchArea.y2 = Y;
                       break;
                    case "D":
                       searchArea.x1=X;
                       searchArea.y1 = Y + 1;
                       searchArea.x2 = X;
                       break;
                    case "L":
                       searchArea.y1 = Y;
                       searchArea.x2 = X - 1;
                       searchArea.y2 = Y;
                       break;
                    case "UR":
                       searchArea.x1 = X + 1;
                       searchArea.y2 = Y - 1;
                       break;
                    case "DR":
                       searchArea.x1 = X + 1;
                       searchArea.y1 = Y + 1;
                       break;
                    case "DL":
                       searchArea.x2 = X - 1;
                       searchArea.y1 = Y + 1;
                       break;
                    case "UL":
                       searchArea.x2 = X - 1;
                       searchArea.y2 = Y - 1;
                       break;
                }

                final = SearchAreaCenter();

                if (final) break;
            }
        }

        public static bool SearchAreaCenter()
        {
            if (searchArea.x1 > searchArea.x2 || searchArea.y1>searchArea.y2 )
                return true;
            int midx = (searchArea.x1 + searchArea.x2) / 2;
            int midy = (searchArea.y1 + searchArea.y2) / 2;

            Print(midx, midy);

            return false;
        }


        public static void Print(int x, int y)
        {
            Console.WriteLine("{0} {1}",x, y);
            //Console.WriteLine("Batman jumps to window ({0},{1})", x, y);
            X = x;
            Y = y;
        }
    }
}
