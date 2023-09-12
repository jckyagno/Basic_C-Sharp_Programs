using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRYCATCH_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //assigned current time to dateTime
            DateTime dateTime = DateTime.Now;
            //prints current year to console
            Console.WriteLine("It is now the year " + dateTime.Year + ".");

            //validAnswer to dictact whether program keeps running based on coding
            bool validAnswer = false;
            //int default set to 0
            int age = 0;
            //while validAsnwer is false, perform the following
            while (!validAnswer)
            {
                try
                {
                    //asks user to input age
                    Console.WriteLine("What is your age in years?");
                    //program attempt to parse input
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    //if program does not detect validAnswer, throw generic exception
                    if (!validAnswer) throw new Exception();
                    //if input is less then or equal to zero, throw unique exception
                    if (age <= 0) throw new ZeroOrBelowException();
                }
                //unique exception for zero or below
                catch (ZeroOrBelowException)
                {
                    Console.WriteLine("Please enter a number greater than zero.");
                    Console.ReadLine();
                    return;
                }
                //generic exception for everything else
                catch (Exception)
                {
                    Console.WriteLine("Please enter an integer.");
                    Console.ReadLine();
                    return;
                }

            }

            //variable to store year current time minus age input
            var yearOfBirth = dateTime.AddYears(-age);

            //print current time minus age to console.
            Console.WriteLine("You were likely born in the year " + yearOfBirth.Year + ".");

            Console.ReadLine();

        }
    }
}
