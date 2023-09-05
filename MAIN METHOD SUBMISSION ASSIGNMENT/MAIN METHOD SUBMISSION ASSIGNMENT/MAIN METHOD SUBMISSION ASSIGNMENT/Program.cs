using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //method overload #1
            Console.WriteLine("Please input a number:");
            int inputOne = Convert.ToInt32(Console.ReadLine());

            int answerOne = Calculation.Method(inputOne);
            Console.WriteLine(inputOne + " + 1 = " + answerOne);



            //method overload #2
            Console.WriteLine("Please input a number:");
            decimal inputTwo = Convert.ToDecimal(Console.ReadLine());

            decimal answerTwo = Calculation.Method(inputTwo);
            Console.WriteLine(inputTwo + " + 1.2345 = " + answerTwo);
            Console.ReadLine();



            //method overload #3
            Console.WriteLine("Please input a number:");
            string inputThree = Console.ReadLine();

            int answerThree = Calculation.Method(inputThree);
            Console.WriteLine(inputThree + " + 2 = " + answerThree);
            Console.ReadLine();
        }
    }
}
