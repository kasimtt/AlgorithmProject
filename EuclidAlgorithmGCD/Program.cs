using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EuclidAlgorithmGCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = EuclidAlgorithm(15,50);
            Console.WriteLine(result);
            Console.ReadLine();
            
        }

        public static int EuclidAlgorithm(int sayi1, int sayi2)
        {
            if(sayi2 == 0)
            {
                return sayi1;
            }
           int sayi3   = sayi1 % sayi2;

            return EuclidAlgorithm(sayi2, sayi3);
        }
    }
}
