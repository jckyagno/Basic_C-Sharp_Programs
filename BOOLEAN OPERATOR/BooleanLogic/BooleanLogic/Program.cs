using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == false);
            //Console.WriteLine(true == true);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != false);
            //Console.WriteLine(true != true);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ false);
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(false ^ false);

            //Console.ReadLine();

            Console.WriteLine("What is your age?");
            //store input as answer1a
            string answer1a = Console.ReadLine();
            //converts answer1a to int answer2
            int answer1 = Convert.ToInt32(answer1a);
            //uses bool logic, true if answer1 is greater than 15
            bool eligible1 = (answer1 > 15);

            Console.WriteLine("\nHave you ever had a DUI? Type true or false.");
            //store input as answer2
            string answer2 = Console.ReadLine();
            //converts answer2 string to bool eligible2
            bool eligible2 = Convert.ToBoolean(answer2);

            Console.WriteLine("\nHow many speeding tickets do you have?");
            //store input as answer3a
            string answer3a = Console.ReadLine();
            //convert answer3a string to int answer3
            int answer3 = Convert.ToInt32(answer3a);
            //uses bool logic, true if answer3 is less than or equal to 3
            bool eligible3 = (answer3 <= 3);

            Console.WriteLine("\nQualified?");
            //checks eligibles to see if all are true, except for eligible2 since its a negative question, hence the xor
            bool isEligible = ((eligible1 && eligible3) ^ eligible2);
            Console.WriteLine(isEligible);
            Console.ReadLine();
        }
    }
}
