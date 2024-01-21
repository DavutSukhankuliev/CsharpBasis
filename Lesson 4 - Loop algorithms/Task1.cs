using System;
using System.Linq;
using System.Reactive.Linq;

namespace Lesson_4___Loop_algorithms
{
    /*Обязательная задача*. Ввести целое число N > 0.
     Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1). 
     После добавления к сумме каждого слагаемого выводить текущее значение суммы 
     (в результате будут выведены квадраты всех целых чисел от 1 до N).*/
    
    internal class Task1
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