using System;

namespace Task_5._5___TwoDimArrayOddsZero
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Впишите целочисленное значение N для формирования двумерного массива NxN");
            } while (!int.TryParse(Console.ReadLine(), out n));

            var array = Array2D(n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) 
                    Console.Write($"{array[i, j]} ");
                Console.WriteLine();
            }
        }

        private static int[,] Array2D(int size)
        {
            int[,] newArray = new int[size, size];

            for (int i = 0; i < size; i++) 
                for (int j = 0; j < size; j++) 
                    newArray[i, j] = (i + j) % 2 == 0 ? 1 : 0;

            return newArray;
        }
    }
}