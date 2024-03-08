using System;

namespace Task_7._2___GetCubeVolume
{
    /*Создать метод для вычисления объема и площади поверхности куба по длине его ребра*/
    
    internal class Program
    {
        private static void CalculateCubeVolumeAndArea(ref double side, out double volume, out double area)
        {
            area = 0;
            volume = 0;
            
            if (side < 0)
            {
                Console.WriteLine($"Была введена сторона с отрицательной длиной {side}" +
                                  $"\r\nМетод отработал через модуль");
                side = -side;
            }
            else if (side == 0)
            {
                Console.WriteLine($"Была введена сторона с отрицательной длиной {side}" +
                                  $"\r\nМетод отработал через модуль");
                return;
            }
            
            area = side * side * 6;
            volume = side * side * side;
        }
        
        public static void Main(string[] args)
        {
            var side = Convert.ToDouble(Console.ReadLine());

            CalculateCubeVolumeAndArea(ref side, out var volume, out var area);
            
            Console.WriteLine($"Длина ребра куба: \t{side}" +
                              $"\r\nПлощадь поверхности куба: \t{area}" +
                              $"\r\nОбъем куба: \t{volume}");
            Console.ReadKey();
        }
    }
}