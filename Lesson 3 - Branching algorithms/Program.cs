using System;

namespace Lesson_3___Branching_algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Обязательная задача*. Ввести целочисленные координаты трех вершин прямоугольника,
             стороны которого параллельны координатным осям. Найти координаты его четвертой вершины.
             Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами, 
             параллельными координатным осям, вывести соответствующее сообщение.*/
            Console.WriteLine("Введите 2D координаты первой точки через запятую:");
            var strings = Console.ReadLine().Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
            var pointA = new Point2D(int.Parse(strings[0]), int.Parse(strings[1]));
            
            Console.WriteLine("Введите 2D координаты второй точки через запятую:");
            strings = Console.ReadLine().Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
            var pointB = new Point2D(int.Parse(strings[0]), int.Parse(strings[1]));
            
            Console.WriteLine("Введите 2D координаты третьей точки через запятую:");
            strings = Console.ReadLine().Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
            var pointC = new Point2D(int.Parse(strings[0]), int.Parse(strings[1]));

            //Task 1
            /*var pointD = Task1.FindFourthCoord(pointA, pointB, pointC);
            Console.WriteLine($"pointD: {pointD.X},{pointD.Y}");*/
            
            //Task 2
            Point2D point;
            Console.WriteLine(!Task2.Closest(pointA, pointB, pointC, out point)
                ? $"Точки B и C равноудалены от точки A\r\nКоордината точки: {point.Text()}"
                : $"Координата ближайшей точки: {point.Text()}");
        }
    }
}