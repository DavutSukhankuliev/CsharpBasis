using System;

namespace Task_13._1___Building
{
    /*Задан класс Building, который описывает здание. Класс содержит следующие элементы:

    адрес здания;
    длина здания;
    ширина здания;
    высота здания.
    В классе Building нужно реализовать следующие методы:

    конструктор с 4 параметрами;
    свойства get/set для доступа к полям класса;
    метод Print(), который выводит информацию о здании.
    Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:

    конструктор с 5 параметрами – реализует вызов конструктора базового класса;
    свойство get/set доступа к внутреннему полю класса;
    метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
    Класс MultiBuilding сделать таким, что не может быть унаследован.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес: ");
            var address = Console.ReadLine();
            Console.WriteLine("Введите длину здания: ");
            double.TryParse(Console.ReadLine(), out var length);
            Console.WriteLine("Введите ширину здания: ");
            double.TryParse(Console.ReadLine(), out var width);
            Console.WriteLine("Введите высоту здания: ");
            double.TryParse(Console.ReadLine(), out var height);

            var building = new Building(address, length, width, height);
            Console.WriteLine(building.Print());

            Console.WriteLine("Введите кол-во этажей здания: ");
            int.TryParse(Console.ReadLine(), out var floors);

            var multiBuilding =
                new MultiBuilding(building.Address, building.Length, building.Width, building.Height, floors);
            Console.WriteLine(multiBuilding.Print());
        }
    }
}