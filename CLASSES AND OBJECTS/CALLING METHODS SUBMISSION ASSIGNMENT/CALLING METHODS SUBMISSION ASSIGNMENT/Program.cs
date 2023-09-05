using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculation calculation = new Calculation();
            //calculation = MethodOne(calculation);
            //int input = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(calculation);
            //Console.ReadLine();

            Console.WriteLine("Please enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());


            int answerOne = Calculation.MethodOne(input);
            int answerTwo = Calculation.MethodTwo(input);
            int answerThree = Calculation.MethodThree(input);
            Console.WriteLine(input + " times 5 is: " + answerOne);
            Console.WriteLine(input + " times 10 is: " + answerTwo);
            Console.WriteLine(input + " times 15 is: " + answerThree);
            Console.ReadLine();



        }
    }
}
