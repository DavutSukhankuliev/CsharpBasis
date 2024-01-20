using System;

namespace Task_2___Linear_algorithms
{
    internal class Task3
    {
        public static void GetPerimeterAndSquareTriangleCoord(float x1, float y1, float x2, float y2, float x3, float y3, out double perimeter, out double square)
        {
            /*Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3).
             Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости. 
             Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона, где p полупериметр*/

            var aSide = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            var bSide = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            var cSide = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            perimeter = aSide + bSide + cSide;
            square = Math.Sqrt(perimeter * (perimeter - aSide) * (perimeter - bSide) * (perimeter - cSide));
        }
    }
}