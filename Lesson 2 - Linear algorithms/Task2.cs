using System;

namespace Task_2___Linear_algorithms
{
    class Task2
    {
        void Main()
        {
            /*Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2).
             Стороны прямоугольника параллельны осям координат. Найти периметр и площадь данного прямоугольника.*/
            Console.WriteLine("Введите x1 координату прямоугольника");
            float x1 = float.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите y1 координату прямоугольника");
            float y1 = float.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите x2 координату прямоугольника");
            float x2 = float.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите y2 координату прямоугольника");
            float y2 = float.Parse(Console.ReadLine() ?? string.Empty);

            double aSide = Math.Abs(x2 - x1);
            double bSide = Math.Abs(y2 - y1);
            double perimeter = 2 * (aSide + bSide);
            double square = aSide * bSide;
            
            Console.WriteLine($"Perimeter is {perimeter}");
            Console.WriteLine($"Square is {square}");
        }
    }
}