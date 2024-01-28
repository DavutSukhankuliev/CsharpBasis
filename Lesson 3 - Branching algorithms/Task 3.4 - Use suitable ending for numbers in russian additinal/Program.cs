using System;

namespace Task_3._4___Use_suitable_ending_for_numbers_in_russian_additinal
{
    /*Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например:
         256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».
         Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100 до 1000");
            var result = int.TryParse(Console.ReadLine(), out var number)
                ? IntToString(number)
                : "Введите число";
        }
        
        private static string IntToString(int number)
        {
            if (!(number >= 100 && number < 1000))
            {
                return "Введите число от 100 до 999";
            }

            int hundreds = number / 100;
            int tens = number % 100 / 10;
            int digits = number % 10;
            
            string[] digitsText = {string.Empty, "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};
            string[] tensText = {string.Empty, "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто"};
            string[] tensForTenText = {string.Empty, "одинадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"};
            string[] hundredsText = {string.Empty, "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот"};

            var result = hundredsText[hundreds];

            if (tens == 1)
            {
                result += $" {tensForTenText[digits]}";
            }
            else
            {
                result += $" {tensText[tens]} {digitsText[digits]}";
            }
            
            return $"{number} - {result}";
        }
    }
}