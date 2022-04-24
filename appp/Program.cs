using System;
using System.Threading;

namespace appi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            byte maxElement = 1;
            byte numberOfLines = 10;
            byte numberOfColumns = 10;
            byte[,] num = new byte[numberOfLines, numberOfColumns];
            for (byte i = 0; i < num.GetLength(0); i++)
            {
                for (byte j = 0; j < num.GetLength(1); j++)
                {
                    num[i, j] = (byte)rand.Next(10, 100);
                    Console.Write($"{num[i,j]} ");
                    if(maxElement < num[i, j])
                    {
                        maxElement = num[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nНаибольший элемент массива = {maxElement}\n");

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    if (num[i,j] == maxElement)
                    {
                        num[i, j] = 0;
                    }
                    Console.Write($"{num[i,j]} ");
                }
                Console.WriteLine();
            }
         
        }
    }
}
