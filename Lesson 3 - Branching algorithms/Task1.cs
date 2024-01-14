using System;

namespace Lesson_3___Branching_algorithms
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

        public string Text()
        {
            return $"{_x},{_y}";
        }
    }

    internal class Task1
    {
        public static Point2D FindFourthCoord(Point2D pointA, Point2D pointB, Point2D pointC)
        {
            if (pointA.X == pointB.X && pointB.Y == pointC.Y)
            {
                var x = pointA.X + pointC.X - pointB.X;
                var y = pointA.Y + pointC.Y - pointB.Y;
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