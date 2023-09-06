using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate class
            Calculation calculation = new Calculation();

            //user enters number
            Console.WriteLine("Enter a number:");
            int input1 = Convert.ToInt32(Console.ReadLine());

            //user enters a string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            //calls math equation method
            calculation.Calculate(input1);

            //calls StringCounter
            string a = calculation.StringCounter(input, out int count);
            Console.WriteLine(a);

            //calls ContainsVowel
            bool b = Calculation.ContainsVowel(input);
            Console.WriteLine("String input contains a vowel: " + b);



            Console.ReadLine();
        }
    }
}
