using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1,3,4,5,6,7,8,9,100,55};
            int largest = 0;
            foreach (int number in numbers)
            {  
                
                if (largest < number) { 
                
                    largest = number;
                }
            }
            Console.WriteLine(largest);
            
            Console.ReadLine();
        }
    }
}
