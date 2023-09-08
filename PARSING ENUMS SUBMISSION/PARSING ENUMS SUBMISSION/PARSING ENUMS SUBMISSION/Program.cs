using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PARSING_ENUMS_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user input for current day of week
            Console.WriteLine("Please enter the current day of the week:");

            //store user input
            string input = Console.ReadLine();

            //confirmation on user input
            Console.WriteLine("You typed in: " + input);

            //try/catch block
            try
            {
                //enum parse method
                Day.DaysOfTheWeek today = (Day.DaysOfTheWeek) Enum.Parse(typeof(Day.DaysOfTheWeek), input);
                //display result
                Console.WriteLine(today);
            }
            //catch block if solution not found
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();

        }

    }
}
