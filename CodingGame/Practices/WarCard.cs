using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class WarCard
    {
        public static int Convert(string str)
        {
            int result = 0;

            str = str.Substring(0, str.Length - 1);

            switch (str)
            {
                case "J":
                    result = 11;
                    break;
                case "Q":
                    result = 12;
                    break;
                case "K":
                    result = 13;
                    break;
                case "A":
                    result = 14;
                    break;
                default:
                    result = int.Parse(str);
                    break;
            }

            return result;
        }

        public static int num = 0;
        static Queue<int> player1 = new Queue<int>();
        static Queue<int> player2 = new Queue<int>();
        static Queue<int> stock1 = new Queue<int>();
        static Queue<int> stock2 = new Queue<int>();

        public static void Solution()
        {
            //string[] strs1 = new string[] { "6H", "7H", "6C", "QS", "7S", "8D", "6D", "5S", "6S", "QH", "4D", "3S", "7C", "3C", "4S", "5H", "QD", "5C", "3H", "3D", "8C", "4H", "4C", "QC", "5D", "7D" };
            //string[] strs2 = new string[] { "JH", "AH", "KD", "AD", "9C", "2D", "2H", "JC", "10C", "KC", "10D", "JS", "JD", "9D", "9S", "KS", "AS", "KH", "10S", "8S", "2S", "10H", "8H", "AC", "2C", "9H" };
            //string[] strs1 = new string[] { "8C", "KD", "AH", "QH", "2S" };
            //string[] strs2 = new string[] { "8D", "2D", "3H", "4D", "3S" };

            /*
            foreach (string str in strs1)
                player1.Enqueue(Convert(str));

            foreach (string str in strs2)
                player2.Enqueue(Convert(str));
             */

            int n = int.Parse(Console.ReadLine()); // the number of cards for player 1
            for (int i = 0; i < n; i++)
            {
                string cardp1 = Console.ReadLine(); // the n cards of player 1
                player1.Enqueue(Convert(cardp1));
            }
            int m = int.Parse(Console.ReadLine()); // the number of cards for player 2
            for (int i = 0; i < m; i++)
            {
                string cardp2 = Console.ReadLine(); // the m cards of player 2
                player2.Enqueue(Convert(cardp2));
            }




            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            while (player1.Count != 0 && player2.Count != 0)
            {
                /*
                if (num < 35)
                {
                    Console.WriteLine("The turn is : " + num);
                    foreach (int i in player1)
                        Console.Write(i + " ");

                    Console.WriteLine();

                    foreach (int i in player2)
                        Console.Write(i + " ");

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }*/


                if (!Fight())
                {
                    if (!War())
                    {
                        return;
                    }
                }
            }

            if (player1.Count == 0)
            {
                Console.WriteLine("2 " + num);
            }


            if (player2.Count == 0)
            {
                Console.WriteLine("1 " + num);
            }

        }

        public static void PutStockCard(Queue<int> player, Queue<int> s)
        {
            while (s.Count != 0)
            {
                player.Enqueue(s.Dequeue());
            }
        }

        public static bool Fight()
        {
            int value1 = player1.Dequeue();
            stock1.Enqueue(value1);
            int value2 = player2.Dequeue();
            stock2.Enqueue(value2);

            if (value1 > value2)
            {
                num++;
                PutStockCard(player1, stock1);
                PutStockCard(player1, stock2);
            }
            else if (value1 < value2)
            {
                num++;
                PutStockCard(player2, stock1);
                PutStockCard(player2, stock2);
            }
            else
            {
                return false;
            }

            return true;
        }

        public static bool War()
        {
            if (player1.Count <= 3 || player2.Count <= 3)
            {
                Console.WriteLine("PAT");
                return false;
            }

            for (int i = 0; i < 3; i++)
            {
                stock1.Enqueue(player1.Dequeue());
                stock2.Enqueue(player2.Dequeue());
            }

            return true;
        }
    }
}
