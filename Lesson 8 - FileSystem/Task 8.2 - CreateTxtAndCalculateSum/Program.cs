using System;
using System.IO;

namespace Task_8._2___CreateTxtAndCalculateSum
{
    /*Обязательная задача*. Программно создайте текстовый файл и запишите в него 10 случайных чисел.
     Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"D:\Davut\University\Master ITMO\2 semester\CsharpBasis\Lesson 8 - FileSystem\Task 8.2 - CreateTxtAndCalculateSum\obj\Numbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 11));
                }
            }

            int sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}