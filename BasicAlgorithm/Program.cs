using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a C# Sharp program to compute the sum of the two given integer values.
            //    If the two values are the same, then return triple their sum
           
            
            //CpmputeSum obj = new CpmputeSum();
            //Console.WriteLine(obj.CalculateSum(5, 9));
            //Console.WriteLine(obj.CalculateSum(5, 5));


            //Write a C# Sharp program to remove the character in a given position of a given string.
            // The given position will be in the range 0.. string length -1 inclusive



            //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string
            Console.WriteLine("Enter Name");
            string text1 = Console.ReadLine();
            char first = text1.First();
            char last = text1.Last();
            
            Console.WriteLine(text1.Reverse());
            Console.ReadKey();

        }
    }
}
