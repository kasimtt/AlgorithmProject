using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 7, 10 };
            int number = 7;
            int sonuc = BinarySearchMethod(array, number);
            Console.Read();
        }
        public static int BinarySearchMethod(int[] array, int x)
        {
            int left = 0;
            int right = array.Length - 1;
            int i = 0;
            while (left <= right)
            {
                i++;
                int mid = left + (right - left) / 2;
                if (array[mid] == x)
                {
                    Console.WriteLine($"{mid}. dizide {x} değeri {i} denemede bulundu");
                    return 1;
                }
                if (array[mid] < x)
                {
                    left = mid + 1;
                    Console.WriteLine($"{array[i]} {x} den kucuk");
                }
                else
                {
                    Console.WriteLine($"{array[i]} {x} den buyuk");
                    right = mid - 1;
                }
            }
            Console.WriteLine($"{x} değeri bulunamadı");
            return 0;
        }
    }

   
}
