using System;

namespace Task_17._1___BankAccount
{
    public class BankAccount<T>
    {
        private T _accountNumber;
        private string _fullName;
        private int _balance;

        public void SetAccount()
        {
            Console.WriteLine("Введите номер счета:");
            _accountNumber = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО владельца счета:");
            _fullName = Console.ReadLine();
            Console.WriteLine("Введите баланс счета:");
            _balance = Convert.ToInt32(Console.ReadLine());
        }

        public void GetInfo()
        {
            Console.WriteLine($"Номер счета:\t{_accountNumber}" +
                              $"\n\rФИО:\t{_fullName}" +
                              $"\n\rБаланс:\t{_balance}");
        }
    }
}