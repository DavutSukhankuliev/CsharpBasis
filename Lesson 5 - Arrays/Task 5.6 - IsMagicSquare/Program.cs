using System;

namespace Task_5._6___IsMagicSquare
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Впишите целочисленное значение N для формирования двумерного массива NxN");
            } while (!int.TryParse(Console.ReadLine(), out n));

            var array = Array2DCustom(n);
            
            Console.WriteLine("Выходной массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) 
                    Console.Write($"{array[i, j]} ");
                Console.WriteLine();
            }

            Console.WriteLine($"Этот массив является магическим квадратом: {IsMagicSquare(array)}");
        }
        
        private static int[,] Array2DCustom(int size)
        {
            int[,] newArray = new int[size, size];

            Console.WriteLine($"Введите числа через пробел для заполнения строки массива." +
                              $"\r\nУчтите, первые {size} элементов будут записаны." +
                              $"\r\nПример: 1 2 25 -1 4.");
            
            for (int i = 0; i < size; i++)
            {
                var strings = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < size; j++)
                {
                    try
                    {
                        if (int.TryParse(strings[j], out newArray[i, j]))
                        {
                            //just parse out to newArray[i, j]
                        }
                        else
                        {
                            newArray[i, j] = 0;
                        }
                    }
                    catch
                    {
                        newArray[i, j] = 0;
                    }
                }
            }

            return newArray;
        }

        private static bool IsMagicSquare(int[,] twoDimArray)
        {
            if (twoDimArray.Rank == 1 && twoDimArray.Length != 1)
                return false;
            
            int size = twoDimArray.GetLength(0);
            if (size != twoDimArray.GetLength(1))
                return false;

            int[,] sums = new int[size + 1, twoDimArray.Rank];
            
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    sums[i, 0] += twoDimArray[i, j];
                    sums[j, 1] += twoDimArray[i, j];
                    
                    if (i == j)
                    {
                        sums[size, 0] += twoDimArray[i, j];
                    }

                    if (i + j == size - 1)
                    {
                        sums[size, 1] += twoDimArray[i, j];
                    }
                }

            int temp = sums[0, 0];
            
            foreach (var sum in sums)
            {
                if (sum != temp)
                    return false;

                temp = sum;
            }

            return true;
        }
    }
}