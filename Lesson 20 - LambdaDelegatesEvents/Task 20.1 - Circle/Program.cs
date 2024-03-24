using System;

namespace Task_20._1___Circle
{
    /*В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
    - метод получает входным параметром переменную типа double;
    - метод возвращает значение типа double, которое является результатом вычисления.
    Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
    - длину окружности по формуле D = 2 * π* R;
    - площадь круга по формуле S = π* R²;
    - объем шара. Формула V = 4/3 * π * R³.*/
    
    internal class Program
    {
        delegate double MyDelegate(double radius);
        public static void Main(string[] args)
        {
            MyDelegate myDelegate = Circumference;
            myDelegate += Area;
            myDelegate += Volume;
            
            Console.WriteLine("Введите радиус");
            var radius = Convert.ToDouble(Console.ReadLine());
            
            foreach (MyDelegate del in myDelegate.GetInvocationList())
            {
                double result = del(radius);
                Console.WriteLine($"Результат: {result}");
            }
            
            Console.ReadKey();
        }

        public static double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        
        public static double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
        
        public static double Volume(double radius)
        {
            return 4d/3d * Math.PI * radius * radius * radius;
        }
    }
}