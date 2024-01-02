using System;

class Foo
{
    void Main()
    {
        /*Обязательная задача*. Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью.*/
        Console.WriteLine("Введите длину окружности L:");
        double length = Convert.ToDouble(Console.ReadLine());
        double radius = length / (2 * Math.PI);
        double square = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Радиус равен = {radius}");
        Console.WriteLine($"Площадь круга = {square}");
    }
}