using System;
using System.Threading;

namespace Task_21._1___Gardeners
{
    /*Имеется пустой участок земли (двумерный массив) и план сада, который необходимо реализовать.
     Эту задачу выполняют два садовника, которые не хотят встречаться друг с другом. 
     Первый садовник начинает работу с верхнего левого угла сада и перемещается слева направо, сделав ряд, он спускается вниз. 
     Второй садовник начинает работу с нижнего правого угла сада и перемещается снизу вверх, сделав ряд, он перемещается влево. 
     Если садовник видит, что участок сада уже выполнен другим садовником, он идет дальше. Садовники должны работать параллельно. 
     Создать многопоточное приложение, моделирующее работу садовников.*/
    
    internal class Program
    {
        private const int n = 5;
        private static int[,] garden = new int[n, n];
        private static int[] path = new int[n] { 1, 2, 7, 3, 4 };
        
        public static void Main(string[] args)
        {
            Thread gardener1 = new Thread(Gardener1Work);
            Thread gardener2 = new Thread(Gardener2Work);

            gardener1.Start();
            gardener2.Start();

            gardener1.Join();
            gardener2.Join();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{garden[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        
        public static void Gardener1Work()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (garden[i, j] == 0)
                    {
                        garden[i, j] = 1;
                        Thread.Sleep(path[i]);
                    }
                }
            }
        }

        public static void Gardener2Work()
        {
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (garden[i, j] == 0)
                    {
                        garden[i, j] = 2;
                        Thread.Sleep(path[i]);
                    }
                }
            }
        }
    }
}