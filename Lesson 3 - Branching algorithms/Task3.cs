namespace Lesson_3___Branching_algorithms
{
    public class Task3
    {
        /*Обязательная задача*. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
         Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год»,
         например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год».
         Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.*/


        internal static string AgeToString(int age)
        {
            if (!(age >= 20 && age < 70))
            {
                return "Введите число в диапозоне 20-69";
            }
            
            string first;
            string middle;
            string last;
            
            if (age < 30)
            {
                first = "Двадцать";
            }
            else if (age < 40)
            {
                first = "Тридцать";
            }
            else if (age < 50)
            {
                first = "Сорок";
            }
            else if (age < 60)
            {
                first = "Пятьдесят";
            }
            else
            {
                first = "Шестьдесят";
            }

            switch (age % 10)
            {
                case 1:
                    middle = " один";
                    break;
                case 2:
                    middle = " два";
                    break;
                case 3:
                    middle = " три";
                    break;
                case 4:
                    middle = " четыре";
                    break;
                case 5:
                    middle = " пять";
                    break;
                case 6:
                    middle = " шесть";
                    break;
                case 7:
                    middle = " семь";
                    break;
                case 8:
                    middle = " восемь";
                    break;
                case 9:
                    middle = " девять";
                    break;
                default:
                    middle = string.Empty;
                    break;
            }
            
            if (age % 10 > 1 && age % 10 < 5)
            {
                last = " года";
            }
            else if (age % 10 == 1)
            {
                last = " год";
            }
            else
            {
                last = " лет";
            }

            return first + middle + last;
        }
    }
}