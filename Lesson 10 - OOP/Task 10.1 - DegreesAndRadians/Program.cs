using System;

namespace Task_10._1___DegreesAndRadians
{
    /*Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
     Реализовать класс, в котором указанные значения представлены в виде свойств. 
     Для свойств предусмотреть проверку корректности данных. 
     Класс должен содержать конструктор для установки начальных значений, 
     а также метод ToRadians для перевода угла в радианы. Создать объект на основе разработанного класса. 
     Осуществить использование объекта в программе.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите угловые значения. Сначала граудсы, затем минуты, затем секунды через Enter");
            
            var degrees = Convert.ToInt32(Console.ReadLine());
            var minutes = Convert.ToInt32(Console.ReadLine());
            var seconds = Convert.ToInt32(Console.ReadLine());

            var angle = new AngularDegree(degrees, minutes, seconds);

            Console.WriteLine($"Вот сколько это в радинах: {angle.ToRadians()}");
            Console.ReadKey();
        }
    }
}