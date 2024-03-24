using System;

namespace Task_13._1___Building
{
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