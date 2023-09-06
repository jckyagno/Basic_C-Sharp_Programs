using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_CLASS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiate class
            Calculation calculation = new Calculation();

            //asks for user input 1, stored as a
            Console.WriteLine("Please input a number to perform a math operation:");
            int a = Convert.ToInt32(Console.ReadLine());

            //asks for user input 2, stored as b
            Console.WriteLine("\nPlease input a number to just show on the console:");
            int b = Convert.ToInt32(Console.ReadLine());

            //run method
            calculation.Method(a, b);
            Console.ReadLine();
        }
    }
}
