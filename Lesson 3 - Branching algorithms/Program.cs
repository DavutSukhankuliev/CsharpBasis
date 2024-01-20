using System;

namespace Lesson_3___Branching_algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int taskNumber;
            do
            {
                Console.WriteLine("Введите номер задачи 1-4. Для выполнения нажмите Enter");
                int.TryParse(Console.ReadLine(), out taskNumber);
            } while (taskNumber < 1 || taskNumber > 4);
            
            string result;
            switch (taskNumber)
            {
                case 1:
                case 2:
                {
                    
                    // TODO: loop and case 1 and 2 if statement fix
                    
                    Console.WriteLine("Введите 2D координаты первой точки через запятую, по типу 'x,y':");
                    var strings = Console.ReadLine()?.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
                    var pointA = new Point2D(int.Parse(strings?[0] ?? string.Empty), int.Parse(strings?[1] ?? string.Empty));
            
                    Console.WriteLine("Введите 2D координаты второй точки через запятую:");
                    strings = Console.ReadLine()?.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
                    var pointB = new Point2D(int.Parse(strings?[0] ?? string.Empty), int.Parse(strings?[1] ?? string.Empty));
            
                    Console.WriteLine("Введите 2D координаты третьей точки через запятую:");
                    strings = Console.ReadLine()?.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
                    var pointC = new Point2D(int.Parse(strings?[0] ?? string.Empty), int.Parse(strings?[1] ?? string.Empty));

                    if (taskNumber == 1)
                    {
                        var pointD = Task1.FindFourthCoord(pointA, pointB, pointC);
                        result = $"Кооридинаты 4ой точки прямоугольника: {pointD.X},{pointD.Y}";
                    }
                    else
                    {
                        result = !Task2.Closest(pointA, pointB, pointC, out var point)
                            ? $"Точки B и C равноудалены от точки A\r\nКоордината точки: {point.Text()}"
                            : $"Координата ближайшей точки: {point.Text()}";
                    }
                    
                    break;
                }

                case 3:
                {
                    Console.WriteLine("Введите число от 20 до 69");
                    result = int.TryParse(Console.ReadLine(), out var age)
                        ? Task3.AgeToString(age)
                        : "Введите число";

                    break;
                }

                case 4:
                {
                    Console.WriteLine("Введите число от 100 до 1000");
                    result = int.TryParse(Console.ReadLine(), out var number)
                        ? Task4.IntToString(number)
                        : "Введите число";

                    break;
                }

                default:
                {
                    result = string.Empty;
                    
                    break;
                }
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}