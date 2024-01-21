namespace Lesson_4___Loop_algorithms
{
    /*Задачи на использование операторов цикла с предусловием.
     Осуществить ввод необходимых данных, выполнить реализацию алгоритма с использованием операторов цикла while, 
     обеспечить вывод полученных результатов. Использование других операторов цикла недопустимо.*/
    
    /*Ввести положительные числа A, B, C.
     На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений). 
     Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.*/
    
    internal class Task3
    {
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
        public int MaxSquaresInRectangle(int width, int height)
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
        public int MaxSquaresInRectangle(int width, int height, int squareSide)
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