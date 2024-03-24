using System;
using System.Threading.Tasks;

namespace Task_23___AsyncFactorial
{
    /*Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalculateFactorialAsync(n).Result);
            
            Console.ReadKey();
        }

        public static async Task<int> CalculateFactorialAsync(int n)
        { 
            return await Task.Run(() => Factorial(n));
        }

        
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            
            return n * Factorial(n - 1);
        }
    }
}