using System;

namespace Task_5._3___HalfsSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var array = new int[10];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 51);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
            Sort(array);
            foreach (var t in array)
            {
                Console.Write($"{t} ");
            }
        }

        private static void Sort(int[] array) 
        {
            if (array == null || array.Length <= 1) 
            {
                return;
            }

            MergeSortAlgorithm(array, 0, array.Length - 1);
        }

        private static void MergeSortAlgorithm(int[] array, int left, int right)
        {
            if (left >= right) return;
            
            int middle = (left + right) / 2;

            MergeSortAlgorithm(array, left, middle);
            MergeSortAlgorithm(array, middle + 1, right);

            if (right <= (array.Length - 1) / 2)
            {
                Merge(array, left, middle, right);
            }

            if (left >= (array.Length - 1) / 2)
            {
                Merge(array, left, middle, right, false);
            }
        }

        private static void Merge(int[] array, int left, int middle, int right, bool isAZ = true) 
        {
            int[] tempArray = new int[array.Length];
            Array.Copy(array, tempArray, array.Length);

            int i = left;
            int j = middle + 1;
            int k = left;
            
            if (isAZ)
            {
                while (i <= middle && j <= right) 
                {
                    if (tempArray[i] <= tempArray[j]) 
                    {
                        array[k] = tempArray[i];
                        i++;
                    } else 
                    {
                        array[k] = tempArray[j];
                        j++;
                    }
                    k++;
                }

                while (i <= middle) 
                {
                    array[k] = tempArray[i];
                    k++;
                    i++;
                }
            }
            else
            {
                while (i <= middle && j <= right) 
                {
                    if (tempArray[i] > tempArray[j]) 
                    {
                        array[k] = tempArray[i];
                        i++;
                    } else 
                    {
                        array[k] = tempArray[j];
                        j++;
                    }
                    k++;
                }

                while (i <= middle) 
                {
                    array[k] = tempArray[i];
                    k++;
                    i++;
                }
            }
        }
    }
}