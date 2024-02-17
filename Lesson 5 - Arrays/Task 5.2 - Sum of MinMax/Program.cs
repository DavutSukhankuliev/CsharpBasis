using System;

namespace Task_5._2___Sum_of_MinMax
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var array = new int[15];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 51);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма мин и макс занчений массива: {GetMaxValue(array) + GetMinValue(array)}");
        }

        private static int GetMaxValue(int[] arr)
        {
            var maxValue = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                maxValue = arr[i] > maxValue ? arr[i] : maxValue;
            }
            
            return maxValue;
        }
        
        private static int GetMinValue(int[] arr)
        {
            var minValue = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                minValue = arr[i] < minValue ? arr[i] : minValue;
            }
            
            return minValue;
        }
    }
}