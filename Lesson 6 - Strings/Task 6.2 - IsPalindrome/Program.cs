using System;

namespace Task_6._2___IsPalindrome
{
    /*Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
     Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта 
     пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).*/
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            Console.WriteLine($"Данное предложение является палиндромом: {sentence.IsPalindrome()}");
        }

        private static bool IsPalindrome(this string sentence)
        {
            string cacheString = new string(sentence.ToLower().Replace(" ", "").ToCharArray());
            string newString = "";
            
            foreach (char c in cacheString) 
                newString = c + newString;
            
            return cacheString.Equals(newString);
        }
    }
}