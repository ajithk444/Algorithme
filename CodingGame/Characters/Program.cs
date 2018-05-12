using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    class Program
    {
        static void Main(string[] args)
        {
           
           /********Character check***********/
            Console.WriteLine("The first result is {0}", CheckBrackets.CheckBracketsValid("([()])"));
            Console.WriteLine("The second result is {0}", CheckBrackets.CheckBracketsValid("(([)])"));
            Console.WriteLine("The third result is {0}", CheckBrackets.CheckBracketsValid("(((])[))"));
            Console.WriteLine("The forth result is {0}", CheckBrackets.CheckBracketsValid("((([])[]))"));
            Console.WriteLine("The forth result is {0}", CheckBrackets.CheckBracketsValid("[((([])[]))]"));
            

            /*********Reverse all the words of a sentence***********/
            //Console.WriteLine(ReverseWords("Hello World"));


            /******************Palindrome test***************/
            //Console.WriteLine(Palindrome.IsPalindrome("DSddddSD"));

            /******************Abagame test***************/
            /*
            string str1 = "WonderfulSDKFffddsssWonderful";
            string str2 = "ulonfFffddsssWderSDKWonderful";

            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine(AbagameStr.SameStr2(str1, str2));
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            */

            /*************ASCII Art******************/
            //CodingGame.ASCIIArt.ASCIIArtMethod();

            Console.Read();
        }



        public static void CharacterTransfer(){
            string sentence = Console.ReadLine();
            if (sentence.Length > 1 && sentence.Length < 1000)
            {
                sentence.ToCharArray();

                string r = "";
                char[] chars = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

                foreach (char c in sentence)
                {
                    if (chars.Contains(c))
                    {
                        r += c.ToString() + "p" + c.ToString();
                    }
                    else
                        r += c.ToString();
                }
                Console.WriteLine(r);
            }
        }

        public static void CordinatesOutput(){
          int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
            int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
            string[][] data=new string[height][];
            for (int i = 0; i < height; i++)
            {
                string line = Console.ReadLine(); // width characters, each either 0 or .
                data[i] = line.Split();
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    string center, right, bottom;
                    center = data[i][j] == "." ? "-1 -1" : data[i][j];
                    right = (j == width - 1) ? ".": (data[i][j+1]=="." ? "-1 -1" : i+" "+(j+1));
                    bottom =  (i == height - 1) ? ".":(data[i+1][j]=="." ? "-1 -1" : i+1+" "+j);
                    Console.WriteLine(center+" "+right+" "+bottom);
                }
            }

        }
    }
}
