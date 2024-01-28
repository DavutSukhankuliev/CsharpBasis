using System;
using System.Linq;
using System.Reactive.Linq;

namespace Task_4._1___Square_number
{
    /*Задачи на использование операторов цикла for.
     Осуществить ввод необходимых данных, выполнить реализацию алгоритма с использованием операторов цикла for,
     обеспечить вывод полученных результатов. Не разрешается использовать другие операторы цикла.*/
    
    /*Обязательная задача*. Ввести целое число N > 0.
     Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1).
     После добавления к сумме каждого слагаемого выводить текущее значение суммы
     (в результате будут выведены квадраты всех целых чисел от 1 до N).*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var calculateSquare = new CalculateSquare();
            
            int subTask;
            do
            {
                Console.WriteLine("Данная задача реализована 3 способами." +
                                  "\r\n1 - Простой способ, логика счета и вывода каждого шага расписана в методе" +
                                  "\r\n2 - EventHandler, логика счета прописана в методе, однако мы подписываемся на событие внутри цикла" +
                                  "\r\n3 - Reactive, реактивное программирование (автор сделал его с целью попробовать данный подход)");
                int.TryParse(Console.ReadLine(), out subTask);
            } while (subTask < 1 || subTask > 3);

            int num;
            do
            {
                Console.WriteLine("Введите целое число N>0");
                int.TryParse(Console.ReadLine(), out num);
            } while (num <= 0);

            string result;
            switch (subTask)
            {
                case 1:
                {
                    result = $"Квадрат числа {num} = {calculateSquare.CalculateSquareCasual(num)}";
                    break;
                }
                case 2:
                {
                    calculateSquare.StepCalculated += (sender, stepResult) =>
                        Console.WriteLine($"Промежуточный результат: {stepResult}");

                    result = $"Квадрат числа {num} = {calculateSquare.CalculateSquareEventHandler(num)}";
                    break;
                }
                default:
                {
                    var sequence = calculateSquare.CalculateSquareReactive(num);
                    sequence.Subscribe(
                        res => Console.WriteLine($"Промежуточный результат квадрата числа {num} = {res}"));
                    result = string.Empty;
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }

    internal class CalculateSquare
    {
        public event EventHandler<int> StepCalculated;

        public int? CalculateSquareCasual(int num)
        {
            var result = 0;
            
            for (var i = 1; i <= num; i++)
            {
                result += 2 * i - 1;
                Console.WriteLine($"Шаг {i}: {result}");
            }
            
            return result;
        }

        public int? CalculateSquareEventHandler(int num)
        {
            var result = 0;
            
            for (var i = 1; i <= num; i++)
            {
                result += 2 * i - 1;
                StepCalculated?.Invoke(this, result);
            }
            
            return result;
        }

        public IObservable<int> CalculateSquareReactive(int num)
        {
            return Observable.Range(1, num)
                .Select(n => Enumerable.Range(1, n).Select(i => 2 * i - 1).Sum());
        }
    }
}