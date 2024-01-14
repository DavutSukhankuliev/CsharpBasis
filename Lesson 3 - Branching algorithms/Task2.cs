using System;

namespace Lesson_3___Branching_algorithms
{
    /*На числовой оси расположены три точки: A, B, C.
     Определить, какая из двух последних точек (B или C) расположена ближе к A,
     и вывести эту точку и ее расстояние от точки A. Если пользователь введёт координаты B и C так, 
     что они будут равноотстоящими от А, совпадать с А или между собой - выдать соответствующее сообщение.*/

    internal class Task2
    {
        public static bool Closest(Point2D pointA, Point2D pointB, Point2D pointC, out Point2D point)
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