using System;

namespace Task_11._1___LinearStruct
{
    /*Разработать структуру для решения линейного уравнения 0=kx+b.
     Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
     Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. 
     Осуществить использование экземпляра в программе.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите коэфициенты k и b для уравнения kx + b = 0");

            var k = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            var linearEquation = new LinearEquation(k, b);

            Console.WriteLine($"Введено уравнение: {k} * x + {b} = 0" +
                              $"\r\nКорень уравнения: x = {linearEquation.Root()}");
            Console.ReadKey();
        }
    }
}