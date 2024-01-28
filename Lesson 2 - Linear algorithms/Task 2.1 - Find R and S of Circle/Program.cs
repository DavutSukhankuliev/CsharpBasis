using System;

namespace Task_2._1___Find_R_and_S_of_Circle
{
    /*Обязательная задача*. Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            double length;
            do
            {
                Console.WriteLine("Введите длину окружности L. Длина окружности должна быть положительной:");
                double.TryParse(Console.ReadLine(), out length);
            } while (length < 0);
            
            GetRadiusAndSquare(length, out var radius, out var square);
            Console.WriteLine($"Радиус окружности с длинной {length} равен {radius} ед." +
                              $"\r\nПлощадь окружности с длинной {length} равна {square} кв.ед.");
        }

        private static void GetRadiusAndSquare(double length, out double radius, out double square)
        {
            radius = length / (2 * Math.PI);
            square = Math.PI * Math.Pow(radius, 2);
        }
    }
}