using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiqueProgramming
{
    public class MaxiumSubSquareMatrix
    {
        public static void GetMaximunSquareMatrix()
        {
            int[,] matrix = new int[4, 5]
            {
                { 1,0,1,0,0 },
                { 1,0,1,1,0 },
                { 1,0,1,1,0 },
                { 1,0,0,1,0 },
            };

            int[,] calculatedMatrix = new int[4, 5];

            int maxSize = 0;
            int maxX = 0;
            int maxY = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 || j == 0) {
                        calculatedMatrix[i, j] = matrix[i, j];
                    }
                    else
                    {
                        if (matrix[i, j] == 1)
                        {
                            calculatedMatrix[i, j] = Math.Min(calculatedMatrix[i - 1, j-1], Math.Min(calculatedMatrix[i - 1, j], calculatedMatrix[i, j - 1]))+1;
                        }else
                        {
                            calculatedMatrix[i, j] = 0;
                        }
                    } 

                    if(calculatedMatrix[i,j] > maxSize)
                    {
                        maxSize = calculatedMatrix[i, j];
                        maxX = i;
                        maxY = j;
                    }
                }
            }

            Console.WriteLine($"The maximun size of the square matrix is : {maxSize}");
            Console.WriteLine($"The the right most index is : {maxX},{maxY}");
        }
    }
}
