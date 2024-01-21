using System;
using System.Collections;

namespace Lesson_4___Loop_algorithms
{
    /*Задачи на использование операторов цикла с постусловием.
     Осуществить ввод необходимых данных,
     выполнить реализацию алгоритма с использованием операторов цикла do - while,
     обеспечить вывод полученных результатов. Использование других операторов цикла недопустимо.*/
        
    /*Осуществить ввод последовательности целых чисел и сравнить, что больше,
     количество положительных или количество отрицательных.
     Последовательность потенциально не ограничена, окончанием последовательности служит число 0.*/
    
    internal class Task2
    {
        public bool IsPositivesMore(int[] numbers)
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