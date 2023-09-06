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
            int input1 = Convert.ToInt32(Console.ReadLine());

            //asks user for second number (optional)
            Console.WriteLine("Please input another number (or leave blank):");
            //stores second number as string, necessary for the optional functionality
            string inputTwo = Console.ReadLine();

            if (inputTwo == "")
            {
                string response = input1 + " * 1 = " + calculation.Method(input1);
                Console.WriteLine(response);
            }
            else
            {
                int input2 = Convert.ToInt32(inputTwo);
                string response = input1 + " * " + input2 + " = " + calculation.Method(input1, input2);
                Console.WriteLine(response);
            }


            Console.ReadLine();
        }
    }
}
