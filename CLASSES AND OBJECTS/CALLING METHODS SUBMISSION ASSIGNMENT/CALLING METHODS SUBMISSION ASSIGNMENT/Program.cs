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

            Console.WriteLine("Please enter a number:");
            //asks the user for input to multiply with
            int input = Convert.ToInt32(Console.ReadLine());

            //uses input and grabs each return and stores in answers
            int answerOne = Calculation.MethodOne(input);
            int answerTwo = Calculation.MethodTwo(input);
            int answerThree = Calculation.MethodThree(input);

            //displays answers to user
            Console.WriteLine(input + " times 5 is: " + answerOne);
            Console.WriteLine(input + " times 10 is: " + answerTwo);
            Console.WriteLine(input + " times 15 is: " + answerThree);
            Console.ReadLine();



        }
    }
}
