using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application that will accept ten numbers between 0 and 100, and report their sum.
            
            int sum = 0;// Initializing  the sum as 0;
            int userInput;//This variable holds the user entries
            for (int i = 0; i < 10; i++)
                {           
                Console.Write("Enter a number between 1 and 100 : "); //string
                userInput = int.Parse(Console.ReadLine());
                sum = sum + userInput;
            }
            
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
            

        }
    }
}

