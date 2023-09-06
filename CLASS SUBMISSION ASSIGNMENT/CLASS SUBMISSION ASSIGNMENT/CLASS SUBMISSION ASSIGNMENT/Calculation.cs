using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    class Calculation
    {
        public int number { get; set; }

        public void Calculate(int input)
        {
            //takes input and divides by 2
            number = input / 2;
            //since void, performs console writeline in method so there's no return
            Console.WriteLine("\n" + input + " divided by 2 is: " + number);
        }

        public string StringCounter(string input, out int count)
        {
            //gets string length
            count = input.Length;
            //writes string results to response 1 and returns to main program
            string response1 = "\nYour string is " + count + " characters long.";
            return response1;
        }

        //overloaded method for above
        public int StringCounter(string input)
        {
            int count = input.Length;
            return count;
        }

        public static bool ContainsVowel(string input)
        {
            //detects "a" in string
            if (input.Contains("a"))
            {
                bool response2 = input.Contains("a");
                return response2;
            }
            //detects "e" in string
            if (input.Contains("e"))
            {
                bool response2 = input.Contains("e");
                return response2;
            }
            //detects "i" in string
            if (input.Contains("i"))
            {
                bool response2 = input.Contains("i");
                return response2;
            }
            //detects "o" in string
            if (input.Contains("o"))
            {
                bool response2 = input.Contains("o");
                return response2;
            }
            //detects "u" in string
            if (input.Contains("u"))
            {
                bool response2 = input.Contains("u");
                return response2;
            }
            //else if no vowels, return false
            else
            {
                bool response2 = false;
                return response2;
            }
        }
    }
}
