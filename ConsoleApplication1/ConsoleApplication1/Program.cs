using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] lenght = new int[n, n];
            print(lenght);
        }

        static void DrawT(int[,] length)
        {
            int row = length.GetLength(0);
            int column = length.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    length[0, j] = 1;
                    if (j == row / 2 - 1 && i != 0)
                    {
                        length[i, j] = 1;
                    }
                    else
                    {
                        length[i, j] = 0;
                    }
                }
            }

        }
        static void print(int[,] lenght)
        {
            DrawT(lenght);
            for (int i = 0; i < lenght.GetLength(0); i++)
            {
                for (int j = 0; j < lenght.GetLength(1); j++)
                {
                    if (lenght[i, j] == 1)
                    {
                        Console.Write("T");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
