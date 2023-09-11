using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DATETIME_SUBMISSION
{
    class Program
    {
        public static void Main(string[] args)
        {
            //assigns current time to dateTime
            DateTime dateTime = DateTime.Now;
            //prints current time to console
            Console.WriteLine("It is now: " + dateTime);

            //asks user for input
            Console.WriteLine("Please enter a number: ");
            //stores input as a double to keep in format for datetime.AddHours in next step
            double input = Convert.ToInt32(Console.ReadLine());
            //adds input hours to dateTime to get new time
            DateTime dateTimePlusInput = dateTime.AddHours(input);
            //prints new time to console
            Console.WriteLine("\n" + input + " hours from now, it will be: " + dateTimePlusInput);


            Console.ReadLine();
        }
    }
}
