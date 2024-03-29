﻿using System;
using System.IO;

namespace Task_8._1___GetAllDirectories
{
    /*Обязательная задача*. Выберите любую папку на своем компьютере, имеющую вложенные директории.
     Выведите на консоль ее содержимое и содержимое всех подкаталогов.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"D:\Davut\University\Master ITMO\2 semester\CsharpBasis\Lesson 8 - FileSystem";
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            Console.ReadKey();
        }
    }
}