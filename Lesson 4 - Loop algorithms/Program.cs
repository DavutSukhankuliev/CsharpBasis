using System;

namespace Lesson_4___Loop_algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int taskNumber;
            do
            {
                Console.WriteLine("Введите номер задачи 1-3. Для выполнения нажмите Enter");
                int.TryParse(Console.ReadLine(), out taskNumber);
            } while (taskNumber < 1 || taskNumber > 3);

            string result = string.Empty;
            switch (taskNumber)
            {
                case 1:
                {
                    var calculateSquare = new Task1();
                    
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
                            sequence.Subscribe(res => Console.WriteLine($"Промежуточный результат квадрата числа {num} = {res}"));
                            result = string.Empty;
                            break;
                        }
                    }
                    break;
                }
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}