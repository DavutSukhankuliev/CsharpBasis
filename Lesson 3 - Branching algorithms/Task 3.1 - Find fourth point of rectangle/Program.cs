using System;

namespace Task_3._1___Find_fourth_point_of_rectangle
{
    /*Обязательная задача*. Ввести целочисленные координаты трех вершин прямоугольника,
     стороны которого параллельны координатным осям. Найти координаты его четвертой вершины.
     Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами,
     параллельными координатным осям, вывести соответствующее сообщение.*/
    
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
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            // TODO: loop

            Console.WriteLine("Введите 2D координаты первой точки через запятую, по типу 'x,y':");
            var strings = Console.ReadLine()?.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
            var pointA = new Point2D(int.Parse(strings?[0] ?? string.Empty), int.Parse(strings?[1] ?? string.Empty));
            
            Console.WriteLine("Введите 2D координаты второй точки через запятую:");
            strings = Console.ReadLine()?.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
            var pointB = new Point2D(int.Parse(strings?[0] ?? string.Empty), int.Parse(strings?[1] ?? string.Empty));
            
            Console.WriteLine("Введите 2D координаты третьей точки через запятую:");
            strings = Console.ReadLine()?.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
            var pointC = new Point2D(int.Parse(strings?[0] ?? string.Empty), int.Parse(strings?[1] ?? string.Empty));
            
            var pointD = FindFourthCoord(pointA, pointB, pointC);
            var result = $"Кооридинаты 4ой точки прямоугольника: {pointD.X},{pointD.Y}";

            Console.WriteLine(result);
        }
        
        private static Point2D FindFourthCoord(Point2D pointA, Point2D pointB, Point2D pointC)
        {
            var squareAB = (int)(Math.Pow(pointA.X - pointB.X, 2) + Math.Pow(pointA.Y - pointB.Y, 2));
            var squareAC = (int)(Math.Pow(pointA.X - pointC.X, 2) + Math.Pow(pointA.Y - pointC.Y, 2));
            var squareBC = (int)(Math.Pow(pointB.X - pointC.X, 2) + Math.Pow(pointB.Y - pointC.Y, 2));

            if (squareAB != 0 && squareAC != 0 && squareBC != 0 && (squareAB == squareAC + squareBC || squareAC == squareAB + squareBC || squareBC == squareAB + squareAC))
            {
                var x = pointA.X ^ pointB.X ^ pointC.X;
                var y = pointA.Y ^ pointB.Y ^ pointC.Y;
                return new Point2D(x, y);
            }
            else
            {
                Console.WriteLine("Введенные точки не могут образовать прямоугольник со сторонами, параллельными координатным осям.");
                return new Point2D();
            }
        }
    }
}