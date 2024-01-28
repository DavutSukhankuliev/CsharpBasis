using System;
using System.Collections.Generic;

namespace Task_4._2___More_positives_or_negatives
{
    /*Задачи на использование операторов цикла с постусловием.
     Осуществить ввод необходимых данных,
     выполнить реализацию алгоритма с использованием операторов цикла do - while,
     обеспечить вывод полученных результатов. Использование других операторов цикла недопустимо.*/
        
    /*Осуществить ввод последовательности целых чисел и сравнить, что больше,
     количество положительных или количество отрицательных.
     Последовательность потенциально не ограничена, окончанием последовательности служит число 0.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел через Enter (для завершения введите 0 и нажмите Enter):");
                    
            var numbers = new List<int>(); 
            int input;
            do
            {
                int.TryParse(Console.ReadLine(), out input);
                numbers.Add(input);
            } while (input != 0);

            numbers.RemoveAt(numbers.Count - 1);

            var result = IsPositivesMore(numbers.ToArray())
                ? "В введенной последовательности больше положительных чисел"
                : "В введенной последовательности больше отрицательных чисел";

            Console.WriteLine(result);
        }
        
        private static bool IsPositivesMore(int[] numbers)
        {
            var numberOfPositives = 0;
            
            var i = 0;
            do
            {
                numberOfPositives = numbers[i] > 0 ? numberOfPositives + 1 : numberOfPositives;
                i++;
            } while (i < numbers.Length);
            
            return numberOfPositives >= numbers.Length / 2d;
        }
    }
}