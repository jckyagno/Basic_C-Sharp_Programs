using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //int currentTemperature = 70;
            //int roomTemperature = 70;

            //if (currentTemperature == roomTemperature) 
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmed than current temperature.");
            //}
            //else 
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            //Console.ReadLine();

            //string result = currentTemperature == roomTemperature ? "It is exactly room temperature." : "It is warmer than room temperature.";
            //Console.WriteLine(result);
            //Console.ReadLine();

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature) 
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else 
            //{
            //    Console.WriteLine("Uh... something went wrong.");
            //}

            //Console.WriteLine("\nWhat is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";
            //Console.WriteLine(result);
            //Console.ReadLine();

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below./n");
            //establish weight limit
            int weightLimit = 50;
            Console.WriteLine("Please input package height:");
            //store input as weightInput, then convert to int weight
            string weightInput = Console.ReadLine();
            int weight = Convert.ToInt32(weightInput);

            //if weight is greater than weightLimit
            if (weight > weightLimit)
            {
                //send notification, end program
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            //if weight is acceptable
            else
            {
                Console.WriteLine("\nPlease input package width:");
                //store input as widthInput, than convert to int width
                string widthInput = Console.ReadLine();
                int width = Convert.ToInt32(widthInput);

                Console.WriteLine("\nPlease input package height:");
                //same as width
                string heightInput = Console.ReadLine();
                int height = Convert.ToInt32(heightInput);

                Console.WriteLine("\nPlease input package length:");
                //same as width
                string lengthInput = Console.ReadLine();
                int length = Convert.ToInt32(lengthInput);

                //display summary of inputs in console for user
                Console.WriteLine("\nWidth: \t\t\t\t\t\t\t\t\t" + width + "\nHeight: \t\t\t\t\t\t\t\t" + height + "\nLength: \t\t\t\t\t\t\t\t" + length);
                //if sum of all inputs is greater than 50
                if (width + height + length > 50)
                {
                    //send notification and end program
                    Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    //product of w*h*l multiplied by weight, divided by 100
                    decimal quote = ((width * height * length) * weight) / 100;
                    //send notification to user of quoted cost
                    Console.WriteLine("\nYour estimated total for shipping this package is: \t\t\t$" + quote);
                    Console.WriteLine("\nThank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
