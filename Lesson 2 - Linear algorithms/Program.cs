using System;

namespace Task_2___Linear_algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int taskNumber;
            do
            {
                Console.WriteLine("Введите номер задачи 1-3. Для выполнения нажмите Enter");
                int.TryParse(Console.ReadLine(), out taskNumber);
            } while (taskNumber < 1 || taskNumber > 3);

            string result;
            switch (taskNumber)
            {
                case 1:
                {
                    double length;
                    do
                    {
                        Console.WriteLine("Введите длину окружности L:");
                        double.TryParse(Console.ReadLine(), out length);
                        if (length < 0)
                        {
                            Console.WriteLine("Длина окружности должна быть положительной");
                        }
                    } while (length < 0);
                   
                    Task1.GetRadiusAndSquare(length, out var radius, out var square);
                    result = $"Радиус окружности с длинной {length} равен {radius} ед." +
                             $"\r\nПлощадь окружности с длинной {length} равна {square} кв.ед.";
                    break;
                }

                case 2:
                {
                    // TODO: loops and isRectangle condition
                    
                    Console.WriteLine("Введите x1 координату прямоугольника");
                    float.TryParse(Console.ReadLine(), out var x1);
                    Console.WriteLine("Введите y1 координату прямоугольника");
                    float.TryParse(Console.ReadLine(), out var y1);
                    Console.WriteLine("Введите x2 координату прямоугольника");
                    float.TryParse(Console.ReadLine(), out var x2);
                    Console.WriteLine("Введите y2 координату прямоугольника");
                    float.TryParse(Console.ReadLine(), out var y2);

                    Task2.GetPerimeterAndSquareRectangleCoord(x1, y1, x2, y2, out var perimeter, out var square);
                    result = $"Периметр прямоугольника с координатами ({x1};{y1}) и ({x2};{y2}) равен {perimeter} ед." +
                             $"\r\nПлощадь прямоугольника с координатами ({x1};{y1}) и ({x2};{y2}) равна {square} кв.ед.";
                    
                    break;
                }

                case 3:
                {
                    // TODO: loops
                    
                    Console.WriteLine("Введите x1 координату треуголника");
                    float.TryParse(Console.ReadLine(), out var x1);
                    Console.WriteLine("Введите y1 координату треуголника");
                    float.TryParse(Console.ReadLine(), out var y1);
                    Console.WriteLine("Введите x2 координату треуголника");
                    float.TryParse(Console.ReadLine(), out var x2);
                    Console.WriteLine("Введите y2 координату треуголника");
                    float.TryParse(Console.ReadLine(), out var y2);
                    Console.WriteLine("Введите x3 координату треуголника");
                    float.TryParse(Console.ReadLine(), out var x3);
                    Console.WriteLine("Введите y3 координату треуголника");
                    float.TryParse(Console.ReadLine(), out var y3);

                    Task3.GetPerimeterAndSquareTriangleCoord(x1, y1, x2, y2, x3, y3, out var perimeter, out var square);
                    result = $"Периметр треугольника с координатами ({x1};{y1}),({x2};{y2}) и ({x3};{y3}) равен {perimeter} ед." +
                             $"\r\nПлощадь треугольника с координатами ({x1};{y1}),({x2};{y2}) и ({x3};{y3}) равна {square} кв.ед.";
                    break;
                }

                default:
                    result = string.Empty;
                    break;
            }

            Console.WriteLine(result);
            
            
        }
    }
}
