using System;


namespace DAILY_REPORT_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main()
        {
            //greeting
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("\nWhat is your name?");
            //stores input as name
            string name = Console.ReadLine();
            //uses name to greet
            Console.WriteLine("\nHello, " + name + "!");
            Console.WriteLine("What course are you on?");
            //stores input as course
            string course = Console.ReadLine();
            Console.WriteLine("\nWhat page number?");
            //stores input as page
            string page = Console.ReadLine();
            //converts page into an int
            int pageNum = Convert.ToInt32(page);
            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            
            //stores input as input, then if "true" assigns value as bool true, else false
            string input = Console.ReadLine();
            if (input == "true")
            {
                bool value = true;
            }
            else
            {
                bool value = false;
            }

            Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.");
            //stores input as experience
            string experience = Console.ReadLine();
            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
            //stores input as feedback
            string feedback = Console.ReadLine();
            Console.WriteLine("\nHow many hours did you study today?");
            //stores input as hours, converts string to int
            string hours = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hours);

            //summary of inputs from questions
            Console.WriteLine("\n\nName: \t\t\t\t" + name);
            Console.WriteLine("Course: \t\t\t" + course);
            Console.WriteLine("Page#: \t\t\t\t" + page);
            Console.WriteLine("Do you need assistance?: \t" + input);
            Console.WriteLine("Any positive experiences?: \t" + experience);
            Console.WriteLine("Feedback: \t\t\t" + feedback);
            Console.WriteLine("Hours Studied: \t\t\t" + hours);
            Console.WriteLine("\n\nPress key to continue...");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}
