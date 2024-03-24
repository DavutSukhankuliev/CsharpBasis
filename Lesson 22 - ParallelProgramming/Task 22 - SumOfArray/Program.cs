using System;
using System.Threading.Tasks;

namespace Task_22___SumOfArray
{
    /*Сформировать массив случайных целых чисел (размер  задается пользователем).
     Вычислить сумму чисел массива и максимальное число в массиве.  
     Реализовать  решение  задачи  с  использованием  механизма  задач продолжения.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(GenerateRandomArray);
            Task<int[]> task1 = new Task<int[]>(func1, size);
            
            Func<Task<int[]>, int> func2 = new Func<Task<int[]>, int>(SumArray);
            Task<int> task2 = task1.ContinueWith<int>(func2);
            
            Func<Task<int[]>, int> func3 = new Func<Task<int[]>, int>(MaxArray);
            Task<int> task3 = task1.ContinueWith<int>(func3);

            task1.Start();

            Console.WriteLine(task2.Result);
            Console.WriteLine(task3.Result);
            
            Console.ReadKey();
        }
        
        public static int SumArray(Task<int[]> task)
        {
            int[] array = task.Result;
            int sum = 0;
            foreach (var t in array)
            {
                sum += t;
            }
            return sum;
        }
        
        public static int MaxArray(Task<int[]> task)
        {
            int[] array = task.Result;
            int maxValue = 0;
            foreach (var t in array)
            {
                if (t > maxValue)
                {
                    maxValue = t;
                }
            }
            return maxValue;
        }

        public static int[] GenerateRandomArray(object size)
        {
            int n = (int)size;
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 100);
            }
            return array;
        }

    }
}