using System;
using System.Text.RegularExpressions;

namespace Task_6._3___RemoveTextInBraces
{
    /*Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки.
     В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
     Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.*/
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine($"{s.RemoveTextInBraces()}");
        }

        private static string RemoveTextInBraces(this string input)
        {
            Regex regex = new Regex(@"{[^{}]*}");
            while (regex.IsMatch(input)) 
                input = regex.Replace(input, string.Empty);
        
            return input;
        }
    }
}