using System;

namespace Task_4._3___Max_squares_fit_in_rectangle
{
    /*Задачи на использование операторов цикла с предусловием.
     Осуществить ввод необходимых данных, выполнить реализацию алгоритма с использованием операторов цикла while,
     обеспечить вывод полученных результатов. Использование других операторов цикла недопустимо.*/
    
    /*Ввести положительные числа A, B, C.
     На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений).
     Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите A длину прямоугольника:");
            int.TryParse(Console.ReadLine(), out var a);
            Console.WriteLine("Введите B высоту прямоугольника:");
            int.TryParse(Console.ReadLine(), out var b);
            Console.WriteLine("Введите C длину квадрта:");
            int.TryParse(Console.ReadLine(), out var c);

            var result = $"Максимальное количество квадратов в прямоугольнике = {MaxSquaresInRectangle(a, b)}" +
                     $"\r\nМаксимальное количество квадратов с длиной сторон {c} = {MaxSquaresInRectangle(a, b, c)}";

            Console.WriteLine(result);
        }
        
        private static int FindGCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        /// <summary>
        /// Finds maximum possible integer number of squares that can fit into rectangle
        /// </summary>
        /// <param name="width">Length of the rectangle</param>
        /// <param name="height">Height of the rectangle</param>
        /// <returns><see cref="int"/> of squares that can fit rectangle</returns>
        private static int MaxSquaresInRectangle(int width, int height)
        {
            var gcd = FindGCD(width, height);
            var result = 0;
            var i = 0;
            var j = 0;

            while (i < width)
            {
                j = 0;
                while (j < height)
                {
                    result++;
                    j += gcd;
                }
                i += gcd;
            }

            return result;
        }

        /// <summary>
        /// Finds maximum possible integer number of squares with provided length that can fit into rectangle
        /// </summary>
        /// <param name="width">Length of the rectangle</param>
        /// <param name="height">Height of the rectangle</param>
        /// <param name="squareSide">Length of the square</param>
        /// <returns><see cref="int"/> of squares with the length of <paramref name="squareSide"/> that can fit rectangle</returns>
        private static int MaxSquaresInRectangle(int width, int height, int squareSide)
        {
            var result = 0;
            
            while (width >= squareSide && height >= squareSide)
            {
                result++;
                width -= squareSide;
                height -= squareSide;
            }

            return result;
        }
    }
}