using System;

namespace Task_2._3___Find_P_and_S_of_Triangle
{
    /*Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3).
             Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости.
             Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона, где p полупериметр*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            // TODO: loops
                    
            Console.WriteLine("Введите x1 координату треуголника");
            float.TryParse(Console.ReadLine(), out var x1);
            Console.WriteLine("Введите y1 координату треуголника");
            float.TryParse(Console.ReadLine(), out var y1);
            Console.WriteLine("Введите x2 координату треуголника");
            float.TryParse(Console.ReadLine(), out var x2);
            Console.WriteLine("Введите y2 координату треуголника");
            float.TryParse(Console.ReadLine(), out var y2);
            Console.WriteLine("Введите x3 координату треуголника");
            float.TryParse(Console.ReadLine(), out var x3);
            Console.WriteLine("Введите y3 координату треуголника");
            float.TryParse(Console.ReadLine(), out var y3);

            GetPerimeterAndSquareTriangleCoord(x1, y1, x2, y2, x3, y3, out var perimeter, out var square);
            Console.WriteLine($"Периметр треугольника с координатами ({x1};{y1}),({x2};{y2}) и ({x3};{y3}) равен {perimeter} ед." +
                              $"\r\nПлощадь треугольника с координатами ({x1};{y1}),({x2};{y2}) и ({x3};{y3}) равна {square} кв.ед.");
        }
        
        private static void GetPerimeterAndSquareTriangleCoord(float x1, float y1, float x2, float y2, float x3, float y3, out double perimeter, out double square)
        {
            var aSide = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            var bSide = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            var cSide = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            perimeter = aSide + bSide + cSide;
            square = Math.Sqrt(perimeter * (perimeter - aSide) * (perimeter - bSide) * (perimeter - cSide));
        }
    }
}