using System;

namespace Task_2___Linear_algorithms
{
    internal class Task2
    {
        public static void GetPerimeterAndSquareRectangleCoord(float x1, float y1, float x2, float y2, out double perimeter, out double square)
        {
            /*Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2).
             Стороны прямоугольника параллельны осям координат. Найти периметр и площадь данного прямоугольника.*/

            double aSide = Math.Abs(x2 - x1);
            double bSide = Math.Abs(y2 - y1);
            perimeter = 2 * (aSide + bSide);
            square = aSide * bSide;
        }
    }
}