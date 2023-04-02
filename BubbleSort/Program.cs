using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 3, 54, 34, 56, 21, 66, 53, 89, 54, 21, 44, 31 };
            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            bubblesort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void bubblesort(int[] Arr) // bir diziyi parametre alan fonksiyon
        {
            int temp;
            bool isSorting = true;
            for (int i = 0;i < Arr.Length;i++)
            {
                for (int j = 1;j<Arr.Length;j++)
                {
                    if (Arr[j] < Arr[j-1])
                    {
                        temp= Arr[j-1];
                        Arr[j-1] = Arr[j];
                        Arr[j] = temp;
                        isSorting = false;
                    }
                }
                if(isSorting)
                {
                    break;
                }
            }
                
        }


    }
}
