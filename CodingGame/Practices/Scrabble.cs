using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    public class Scrabble
    {
        public struct Word
        {
            public string Str;
            public int Position;
            public Word(string str, int position)
            {
                Str = str;
                Position = position;
            }
        }

        public static void Solution()
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<char, List<Word>> dictionary = new Dictionary<char, List<Word>>();
            Dictionary<char, int> points = new Dictionary<char, int>();
            points.Add('e', 1);
            points.Add('a', 1);
            points.Add('i', 1);
            points.Add('o', 1);
            points.Add('n', 1);
            points.Add('r', 1);
            points.Add('t', 1);
            points.Add('l', 1);
            points.Add('s', 1);
            points.Add('u', 1);
            points.Add('d', 2);
            points.Add('g', 2);
            points.Add('b', 3);
            points.Add('c', 3);
            points.Add('m', 3);
            points.Add('p', 3);
            points.Add('f', 4);
            points.Add('h', 4);
            points.Add('v', 4);
            points.Add('w', 4);
            points.Add('y', 4);
            points.Add('k', 5);
            points.Add('j', 8);
            points.Add('x', 8);
            points.Add('q', 10);
            points.Add('z', 10);

            for (int i = 0; i < N; i++)
            {
                string W = Console.ReadLine();
                if (dictionary.ContainsKey(W[0]))
                    dictionary[W[0]].Add(new Word(W, N));
                else
                    dictionary.Add(W[0], new List<Word>() { new Word(W, N) });

            }
            string LETTERS = Console.ReadLine();
            char[] chars = LETTERS.ToCharArray();

            int score1 = 0;
            string result1 = "";

            int score2 = 0;
            string result2 = "";
            List<Word> strs;
            int currentPosition = int.MaxValue;
            bool isDistinct = false;


            foreach (char c in LETTERS)
            {
                if (dictionary.ContainsKey(c))
                {
                    strs = dictionary[c];
                    foreach (Word str in strs)
                    {
                        isDistinct = false;
                        char[] tempchars = str.Str.ToCharArray();

                        if (!tempchars.Except(chars).Any())
                        {
                            if (tempchars.Distinct().Count() == tempchars.Count())
                                isDistinct = true;

                            int scoreTemp = GetScore(tempchars, points);

                            if (isDistinct && (scoreTemp > score1 || (scoreTemp == score1 && str.Position < currentPosition)))
                            {
                                score1 = scoreTemp;
                                result1 = str.Str;
                                currentPosition = str.Position;
                            }

                            if (!isDistinct && (scoreTemp > score2 || (scoreTemp == score2 && str.Position < currentPosition)))
                            {
                                score2 = scoreTemp;
                                result2 = str.Str;
                                currentPosition = str.Position;
                            }
                        }
                    }

                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(result1 != "" ? result1 : result2);
        }

        public static int GetScore(char[] chars, Dictionary<char, int> points)
        {
            int sum = 0;
            foreach (char c in chars)
                sum += points[c];
            return sum;
        }
    }
}
