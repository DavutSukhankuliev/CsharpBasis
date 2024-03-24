using System;

namespace Lesson_12._1___CircleClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Задайте параметры окружности");
            Console.Write("Радиус = ");
            double.TryParse(Console.ReadLine(), out double radius);
            Console.WriteLine();
            Console.Write("Коордианта x0 = ");
            double.TryParse(Console.ReadLine(), out double x0);
            Console.WriteLine();
            Console.Write("Коордианта y0 = ");
            double.TryParse(Console.ReadLine(), out double y0);
            Console.WriteLine();

            Console.WriteLine($"Длина окружности с радиусом {radius}: {CircleExtension.CalculateCircumference(radius)}");
            Console.WriteLine($"Площадь окружности с радиусом {radius}: {CircleExtension.CalculateArea(radius)}");
            
            Console.WriteLine("Задайте точку, которую предпологается проверить на принадлежность вышеописанной окружности");
            Console.Write("Координата x = ");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine();
            Console.Write("Координата y = ");
            double.TryParse(Console.ReadLine(), out double y);
            Console.WriteLine();

            Console.WriteLine($"Точка ({x}; {y}) {(CircleExtension.IsPointInside(x,y,x0,y0,radius) ? "принадлежит" : "не принадлежит")} окружности");
            Console.ReadKey();
        }
    }
}