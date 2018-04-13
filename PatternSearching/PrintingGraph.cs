namespace PatternSearching
{
    // C# code to wish happY Women's DaY
    using System;

    public class PrintingGraph
    {
        public static void Start()
        {
            // Initializing size of design
            int n = 5;

            // Loop to print Circle
            // (Upper part of design)
            // Outer loop to
            // control height of
            // design
            for (int i = 0; i <= 2 * n; i++)
            {
                // Inner loop to control
                // width
                for (int j = 0; j <= 2 * n; j++)
                {

                    // computing distance of
                    // each point from center
                    float center_dist =(float)Math.Sqrt((i - n) *(i - n) + (j - n) * (j - n));

                    if (center_dist > n - 0.5&& center_dist < n + 0.5)
                        Console.Write("$");
                    else
                        Console.Write(" ");
                }

                // Printing HappY Women's DaY
                if (i == n)
                {
                    Console.Write(" " + "HappY Women's DaY");
                }
                    
                Console.WriteLine();
            }

            // Loop to print lower part
            // Outer loop to control
            // height
            for (int i = 0; i <= n; i++)
            {
                // Positioning pattern
                // Loop for Printing
                // horizontal line
                if (i == (n / 2) + 1)
                {
                    for (int j = 0; j <= 2 * n; j++)
                        if (j >= (n - n / 2) && j <= (n + n / 2))
                            Console.Write("$");
                        else
                            Console.Write(" ");
                }
                else
                {
                    for (int j = 0; j <= 2 * n; j++)
                    {
                        if (j == n)
                            Console.Write("$");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
