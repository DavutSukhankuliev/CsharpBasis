using System;

namespace Task_9._1___ExceptionHandlingCalculator
{
    /*Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа,
     а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). 
     После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.*/
    
    internal class Program
    {
        private static int Calculate(int a, int b, int operation)
        {
            switch (operation)
            {
                case 1:
                    try
                    {
                        checked
                        {
                            return a + b;
                        }
                    }
                    catch (OverflowException)
                    {
                        throw new OverflowException("Переполнение при сложении");
                    }
                case 2:
                    try
                    {
                        checked
                        {
                            return a - b;
                        }
                    }
                    catch (OverflowException)
                    {
                        throw new OverflowException("Переполнение при вычитании");
                    }
                case 3:
                    try
                    {
                        checked
                        {
                            return a * b;
                        }
                    }
                    catch (OverflowException)
                    {
                        throw new OverflowException("Переполнение при умножении");
                    }
                case 4:
                    if (b != 0)
                    {
                        return a / b;
                    }
                    throw new DivideByZeroException("Деление на ноль");
                default:
                    throw new ArgumentException("Недопустимый код операции");
            }
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Хелло, это калькулятор");

            var a = 0;
            var b = 0;
            var operation = 0;

            try
            {
                Console.Write("Введите целое число a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число b = ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите код операции:" +
                                  "\r\n\t1 - сложение" +
                                  "\r\n\t2 - вычитание" +
                                  "\r\n\t3 - умножение" +
                                  "\r\n\t4 - деление");
                Console.Write("Вы выбрали код операции: ");
                operation = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Результат = {Calculate(a, b, operation)}");
            }
            catch (FormatException formatException)
            {
                Console.WriteLine(formatException.Message);
                Console.WriteLine("Введен недопустимый формат данных" +
                                  "\r\nВ след раз введите целое число!");
            }
            catch (OverflowException overflowException)
            {
                Console.WriteLine(overflowException.Message);
                Console.WriteLine("Введено слишком большое число или слишком маленькое" +
                                  $"\r\nВ след раз введите целое число в пределах [{int.MinValue}, {int.MaxValue}]");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}