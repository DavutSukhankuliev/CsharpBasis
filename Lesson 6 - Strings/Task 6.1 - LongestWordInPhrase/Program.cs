using System;

namespace Task_6._1___LongestWordInPhrase
{
    /*Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
     Знаки препинания не используются. Найти самое длинное слово в строке.*/
    
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            Console.WriteLine($"{sentence.GetLongestWord()}");
        }

        private static string GetLongestWord(this string words)
        {
            string maxLengthWord = "";
            string[] strings = words.Split();
            foreach (var s in strings)
                if (s.Length > maxLengthWord.Length)
                    maxLengthWord = s;
                
            return maxLengthWord;
        }
    }
}