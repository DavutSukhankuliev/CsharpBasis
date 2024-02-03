using System;

namespace Task_5._3___HalfsSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var array = new int[10];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 51);
                array[i] += 50;
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            var result = SortHalfsNorm(array, 100);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= 50;
                Console.Write($"{array[i]} ");
            }
        }

        private static int[] SortHalfsNorm(int[] array, int maxValue)
        {
            /*for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length / 2)
                {
                    
                }
                else
                {
                    
                }
            }*/
            
            int[] counts = new int[maxValue + 1];

            foreach (int num in array)
            {
                counts[num]++;
            }

            int index = 0;
            for (int i = 0; i < counts.Length; i++)
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    array[index++] = i;
                }
            }

            return array;
        }
    }
}