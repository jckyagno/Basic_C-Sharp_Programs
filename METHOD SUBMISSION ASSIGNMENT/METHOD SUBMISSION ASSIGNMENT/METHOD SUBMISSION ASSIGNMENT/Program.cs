using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate class
            Calculation calculation = new Calculation();

            //asks user for first number (mandatory)
            Console.WriteLine("Please input a number:");
            //stores first number as an int to be used
            int inputOne = Convert.ToInt32(Console.ReadLine());

            //asks user for second number (optional)
            Console.WriteLine("Please input another number (or leave blank):");
            //stores second number as string, necessary for the optional functionality
            string inputTwo = Console.ReadLine();


            //create response string from returns
            string response = calculation.Method(inputOne, inputTwo);
            //display response
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
