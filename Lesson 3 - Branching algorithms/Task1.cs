using System;

namespace Lesson_3___Branching_algorithms
{
    struct Point2D
    {
        internal int x;
        internal int y;
    }
    
    class Task1
    {
        void Main()
        {
            /*Обязательная задача*. Ввести целочисленные координаты трех вершин прямоугольника,
             стороны которого параллельны координатным осям. Найти координаты его четвертой вершины.
             Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами, 
             параллельными координатным осям, вывести соответствующее сообщение.*/
            var rectangle = new Point2D[4];
                
            for (int i = 1; i <= 6; i++)
            {
                string axis = "x";
                int number = 1;
                
                if (i % 2 == 0)
                {
                    axis = "y";
                    number /= 2;
                }

                Console.WriteLine($"Введите координату {axis}{number} прямоугольника");

                if (i % 2 != 0)
                {
                    rectangle[number].x = int.Parse(Console.ReadLine() ?? string.Empty);
                }
                else
                {
                    rectangle[number].y = int.Parse(Console.ReadLine() ?? string.Empty);
                }
            }
        }
    }
}