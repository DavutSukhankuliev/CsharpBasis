using System;
using System.IO;
using System.Text.Json;
using Task_16._1___ProductJSON;

namespace Task_16._2___ProductJSONDeserialize
{
    /*Необходимо разработать программу для получения информации о товаре из json-файла.
    Десериализовать файл «Products.json» из задачи 1. Определить название самого дорогого товара.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }

            var products = JsonSerializer.Deserialize<Product[]>(jsonString);

            var maxProduct = products[0];
            foreach (var product in products)
            {
                if (product.Price > maxProduct.Price)
                {
                    maxProduct = product;
                }
            }

            Console.WriteLine($"Самый дорогой товар: {maxProduct.Name}");
            Console.ReadKey();
        }
    }
}