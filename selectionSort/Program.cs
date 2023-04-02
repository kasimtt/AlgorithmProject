using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace selectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 33, 43, 2, 45, 21, 45, 34, 12, 34, 51, 3, 154 };
            SelectionSortMethod(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }


        public static void SelectionSortMethod(int[] arr)
        {
            int n = arr.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;

            }
        }
    }
}


