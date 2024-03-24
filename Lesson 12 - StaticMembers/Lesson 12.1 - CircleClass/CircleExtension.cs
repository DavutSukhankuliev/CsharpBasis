using System;

namespace Lesson_12._1___CircleClass
{
    public static class CircleExtension
    {
        public static double CalculateCircumference(double radius)
        {
            if (radius < 0)
            {
                radius = -radius;
                Console.WriteLine("Метод обработал отрицательный радиус и использовал радиус в модуле");
            }
            
            return 2 * Math.PI * radius;
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static bool IsPointInside(double x, double y, double x0, double y0, double radius)
        {
            if (radius < 0)
            {
                radius = -radius;
                Console.WriteLine("Метод обработал отрицательный радиус и использовал радиус в модуле");
            }
            
            double distance = Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2));
            
            return distance <= radius;
        }
    }
}