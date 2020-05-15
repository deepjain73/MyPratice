using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class dimensional
    {
        int[,] array2d = new int[4, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 5, 6 } };
        public void twodimensionalarray()
        {
            Console.WriteLine("2darray:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    Console.Write(array2d[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
        }

        int[,,] number = new int[2, 3, 3] { { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } };

        public void Threedimensional()
        {
            Console.WriteLine("3darray:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {

                        Console.Write(number[i, j, k]);
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }
                //Console.WriteLine(number[3, 1]);

                // Three dimensional Array

                //string[,,] letters = new string[2, 2, 2] { { { "a", "b", "c" }, { "b", "c", "d" } }, { { "c", "d", "e" }, { "f", "g", "h" } } };

            }
        }


    }
}
  

    
