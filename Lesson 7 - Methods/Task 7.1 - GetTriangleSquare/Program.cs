using System;

namespace Task_7._1___GetTriangleSquare
{
    /*Обязательная задача*. Два треугольника заданы длинами своих сторон.
     Определить, площадь какого из них больше 
     (создать метод для вычисления  площади  треугольника по длинам его сторон).  
     Для решения задачи можно использовать формулу Герона */
    
    internal class Program
    {
        private static double CalculateTriangleSquare(double a, double b, double c)
        {
            double halfPerimeter = CalculatePerimeter(a, b, c) / 2;

            var square = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            
            return square;
        }
        
        private static double CalculatePerimeter(params double[] sides)
        {
            double s = 0;
            
            foreach (var side in sides)
            {
                s += side;
            }

            return s;
        }
        
        public static void Main(string[] args)
        {
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{CalculateTriangleSquare(a, b, c)}");
            Console.ReadKey();
        }
    }
}