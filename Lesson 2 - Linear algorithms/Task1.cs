using System;

namespace Lesson_2___Linear_algorithms
{
    internal class Task1
    {
        public static void GetRadiusAndSquare(double length, out double radius, out double square)
        {
            /*Обязательная задача*. Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью.*/
            radius = length / (2 * Math.PI);
            square = Math.PI * Math.Pow(radius, 2);
        }
    }
}