using System;

namespace Task_17._1___BankAccount
{
    /*Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
     Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. 
     Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
     Создать  несколько экземпляров класса, параметризированного различными типам. 
     Заполнить его поля и вывести на экран информацию об экземпляре класса.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var account1 = new BankAccount<int>();
            account1.SetAccount();
            account1.GetInfo();

            var account2 = new BankAccount<string>();
            account2.SetAccount();
            account2.GetInfo();

            Console.ReadKey();
        }
    }
}