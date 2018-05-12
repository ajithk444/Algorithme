using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class ASCIIArt
    {
        public static void Solution()
        {

            int L = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            string T = Console.ReadLine();

            string[][] asciiArt = new string[H][];
            int numChars = 0;

            for (int i = 0; i < H; i++)
            {
                string ROW = Console.ReadLine();
                if (i == 0)
                    numChars = (int)Math.Ceiling(((double)ROW.Length / L));

                string[] temp = new string[numChars];
                for (int j = 0; j < numChars; j++)
                    temp[j] = ROW.Substring(j * L, L);

                asciiArt[i] = temp;
            }

            string upperT = T.ToUpper();
            int baseNum = Convert.ToInt16('A');

            int index = numChars - 1;
            StringBuilder[] strs = new StringBuilder[H];
            for (int i = 0; i < H; i++)
                strs[i] = new StringBuilder();

            foreach (char c in upperT.ToCharArray())
            {
                index = (int)c - baseNum;

                if (index < 0 || index > numChars - 1)
                    index = numChars - 1;

                for (int i = 0; i < H; i++)
                {
                    strs[i].Append(asciiArt[i][index]);
                }
            }

            foreach (var item in strs)
            {
                Console.WriteLine(item.ToString());
            }
        }


    }
}
