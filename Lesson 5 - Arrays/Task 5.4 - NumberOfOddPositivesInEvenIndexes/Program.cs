using System;

namespace Task_5._4___NumberOfOddPositivesInEvenIndexes
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[20];
            
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 51);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Кол-во нечентных полодительных элеиментов, стоящих на четных местах: {array.Odds().Positives().EvenIndex().Sum()}");
        }

        private static int[] Odds(this int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);

            for (var i = 0; i < array.Length; i++)
                newArray[i] = Math.Abs(array[i] % 2) == 1 ? array[i] : 0;

            return newArray;
        }
        
        private static int[] Positives(this int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);

            for (var i = 0; i < array.Length; i++)
                newArray[i] = array[i] > 0 ? array[i] : 0;
            
            return newArray;
        }
        
        private static int[] EvenIndex(this int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);

            for (var i = 0; i < array.Length; i++)
                newArray[i] = i % 2 == 0 ? array[i] : 0;

            return newArray;
        }
        
        private static int Sum(this int[] array)
        {
            int sum = 0;

            foreach (var i in array)
            {
                if (i == 0)
                    continue;
                sum++;
            }

            return sum;
        }
    }
}