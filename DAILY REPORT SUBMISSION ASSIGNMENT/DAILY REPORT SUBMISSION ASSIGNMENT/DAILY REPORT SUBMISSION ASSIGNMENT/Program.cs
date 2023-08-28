using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAILY_REPORT_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            int pageNum = Convert.ToInt32(page);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string input = Console.ReadLine();
            if (input == "true")
            {
                bool value = true;
            }
            else
            {
                bool value = false;
            }

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hours);

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Page#: " + page);
            Console.WriteLine("Do you need assistance?: " + input);
            Console.WriteLine("Any positive experiences?: " + experience);
            Console.WriteLine("Feedback: " + feedback);
            Console.WriteLine("Hours Studied: " + hours);
            Console.WriteLine("Press key to continue...");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}
