using System;
using System.Collections.Generic;

namespace Task_18._1___Parenthesises
{
    /*Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
     Проверить, корректно ли в ней расставлены скобки. 
     Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет. 
     Указание: задача решается однократным проходом по символам заданной строки слева направо; 
     для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, 
     каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается); 
     в конце прохода стек должен быть пуст.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var str = Console.ReadLine();
            Console.WriteLine(Check(str));
            Console.ReadKey();
        }

        private static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dictionary = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' },
            };

            foreach (var c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(dictionary[c]);
                }

                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            
            return stack.Count == 0;
        }
    }
}