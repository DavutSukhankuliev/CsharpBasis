using System;

namespace Task_2___Linear_algorithms
{
    class Task3
    {
        void Main()
        {
            /*Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3).
             Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости. 
             Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона, где p полупериметр*/
            Console.WriteLine("Введите x1 координату треуголника");
            float x1 = float.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите y1 координату треуголника");
            float y1 = float.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите x2 координату треуголника");
            float x2 = float.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите y2 координату треуголника");
            float y2 = float.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите x3 координату треуголника");
            float x3 = float.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите y3 координату треуголника");
            float y3 = float.Parse(Console.ReadLine() ?? string.Empty);

            double aSide = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double bSide = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double cSide = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double perimeter = aSide + bSide + cSide;
            double square = Math.Sqrt(perimeter * (perimeter - aSide) * (perimeter - bSide) * (perimeter - cSide));

            Console.WriteLine($"perimeter is {perimeter}");
            Console.WriteLine($"square is {square}");
        }
    }
}