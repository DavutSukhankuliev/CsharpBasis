using System;

namespace Task_2._2___Find_P_and_S_of_Rectangle
{
    /*Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2).
             Стороны прямоугольника параллельны осям координат. Найти периметр и площадь данного прямоугольника.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            // TODO: loops and isRectangle condition
                    
            Console.WriteLine("Введите x1 координату прямоугольника");
            float.TryParse(Console.ReadLine(), out var x1);
            Console.WriteLine("Введите y1 координату прямоугольника");
            float.TryParse(Console.ReadLine(), out var y1);
            Console.WriteLine("Введите x2 координату прямоугольника");
            float.TryParse(Console.ReadLine(), out var x2);
            Console.WriteLine("Введите y2 координату прямоугольника");
            float.TryParse(Console.ReadLine(), out var y2);

            GetPerimeterAndSquareRectangleCoord(x1, y1, x2, y2, out var perimeter, out var square);
            Console.WriteLine($"Периметр прямоугольника с координатами ({x1};{y1}) и ({x2};{y2}) равен {perimeter} ед." +
                              $"\r\nПлощадь прямоугольника с координатами ({x1};{y1}) и ({x2};{y2}) равна {square} кв.ед.");
        }

        private static void GetPerimeterAndSquareRectangleCoord(float x1, float y1, float x2, float y2, out double perimeter, out double square)
        {
            double aSide = Math.Abs(x2 - x1);
            double bSide = Math.Abs(y2 - y1);
            perimeter = 2 * (aSide + bSide);
            square = aSide * bSide;
        }
    }
}