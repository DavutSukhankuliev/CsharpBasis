using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Task_16._1___ProductJSON
{
    /*Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.

    Разработать класс для моделирования объекта «Товар». Предусмотреть члены класса «Код товара» (целое число), «Название товара» (строка), «Цена товара» (вещественное число).
    Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
    Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json».*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int numberOfProducts = 5;

            var products = new Product[numberOfProducts];

            for (var i = 0; i < products.Length; i++)
            {
                Console.Write("Название продукта: ");
                var name = Console.ReadLine();
                Console.Write("Цена продукта: ");
                var price = Convert.ToDouble(Console.ReadLine());

                products[i] = new Product() { Id = i, Name = name, Price = price };
            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(products, options);

            using (StreamWriter sw = new StreamWriter("../../../Products.json"))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}