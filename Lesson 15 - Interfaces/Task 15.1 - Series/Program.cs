using System;

namespace Task_15._1___Series
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия:");
            Console.WriteLine("Начало:");
            int.TryParse(Console.ReadLine(), out var startValue);
            Console.WriteLine("Шаг:");
            int.TryParse(Console.ReadLine(), out var stepValue);

            var arith = new ArithProgression();
            arith.SetStart(startValue);
            arith.SetStep(stepValue);

            while (arith.CurrentValue < 1000)
            {
                Console.WriteLine($"{arith.CurrentValue}\t{arith.GetNext()}");
            }
            arith.Reset();
            Console.WriteLine(arith.CurrentValue);
            
            Console.WriteLine("Геометрическая прогрессия:");
            Console.WriteLine("Начало:");
            int.TryParse(Console.ReadLine(), out var startValueG);
            Console.WriteLine("Шаг:");
            int.TryParse(Console.ReadLine(), out var ratioValue);
            
            var geom = new GeomProgression();
            geom.SetStart(startValueG);
            geom.SetRatio(ratioValue);

            while (geom.CurrentValue < 1000)
            {
                Console.WriteLine($"{geom.CurrentValue}\t{geom.GetNext()}");
            }
            geom.Reset();
            Console.WriteLine(geom.CurrentValue);
            Console.ReadKey();
        }
    }
}