using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine("Five plus ten = " + total.ToString());
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //int remainder2 = 11 % 2;
            //Console.WriteLine(remainder2);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            ////bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature == roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //asks user for input of a number
            Console.WriteLine("Input a number...");
            //stores input as input
            string input = Console.ReadLine();
            //converts input to int
            int num = Convert.ToInt32(input);
            //num times 50
            int product = num * 50;
            //num plus 25
            int sum = num + 25;
            //num divided by 12.5, use of float for decimals
            float quotient = num / 12.5f;
            //num greater than 50, result is false
            bool isGreater = num > 50;
            //num divided by 7, modulus is 1
            int remainder = num % 7;
            //block of code to display all information to console
            Console.WriteLine("\n" + num + " times 50 is... " + product);
            Console.WriteLine(num + " plus 25 is... " + sum);
            Console.WriteLine(num + " divided by 12.5 is... " + quotient);
            Console.WriteLine(num + " is greater than 50... " + isGreater);
            Console.WriteLine(num + " divided by seven, the remainder is... " + remainder);
            Console.ReadLine();

        }
    }
}
