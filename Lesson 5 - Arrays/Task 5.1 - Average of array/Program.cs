using System;

namespace Task_5._1___Average_of_array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[7];
            Console.WriteLine($"Введите поочередно {array.Length} элементов");

            for (int i = 0; i < array.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out array[i]);
            }

            Console.WriteLine();
            Console.WriteLine($"Среднее значение элементов массива: {Average(array)}");
        }

        private static float Average(int[] arr)
        {
            var result = 0;
            
            foreach (var i in arr)
            {
                result += i;
            }

            return (float)result / arr.Length;
        }
    }
}