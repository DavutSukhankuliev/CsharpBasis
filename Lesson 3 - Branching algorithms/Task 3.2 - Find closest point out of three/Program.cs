using System;

namespace Task_3._2___Find_closest_point_out_of_three
{
    /*На числовой оси расположены три точки: A, B, C.
     Определить, какая из двух последних точек (B или C) расположена ближе к A,
     и вывести эту точку и ее расстояние от точки A. Если пользователь введёт координаты B и C так,
     что они будут равноотстоящими от А, совпадать с А или между собой - выдать соответствующее сообщение.*/
    
    internal struct Point2D
    {
        private int _x;
        private int _y;

        public int X => _x;
        public int Y => _y;
        
        public Point2D(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public string Text()
        {
            return $"{_x},{_y}";
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            // TODO: loop 

            Console.WriteLine("Введите 2D координаты первой точки через запятую, по типу 'x,y':");
            var strings = Console.ReadLine()?.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var pointA = new Point2D(int.Parse(strings?[0] ?? string.Empty), int.Parse(strings?[1] ?? string.Empty));

            Console.WriteLine("Введите 2D координаты второй точки через запятую:");
            strings = Console.ReadLine()?.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var pointB = new Point2D(int.Parse(strings?[0] ?? string.Empty), int.Parse(strings?[1] ?? string.Empty));

            Console.WriteLine("Введите 2D координаты третьей точки через запятую:");
            strings = Console.ReadLine()?.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var pointC = new Point2D(int.Parse(strings?[0] ?? string.Empty), int.Parse(strings?[1] ?? string.Empty));


            var result = !Closest(pointA, pointB, pointC, out var point)
                ? $"Точки B и C равноудалены от точки A\r\nКоордината точки: {point.Text()}"
                : $"Координата ближайшей точки: {point.Text()}";

            Console.WriteLine(result);
        }
        
        private static bool Closest(Point2D pointA, Point2D pointB, Point2D pointC, out Point2D point)
        {
            var distAB = Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
            var distAC = Math.Sqrt(Math.Pow(pointC.X - pointA.X, 2) + Math.Pow(pointC.Y - pointA.Y, 2));

            if (distAB < distAC)
            {
                point = pointB;
                return true;
            }

            if (distAB > distAC)
            {
                point = pointC;
                return true;
            }

            point = pointB;
            return false;
        }
    }
}