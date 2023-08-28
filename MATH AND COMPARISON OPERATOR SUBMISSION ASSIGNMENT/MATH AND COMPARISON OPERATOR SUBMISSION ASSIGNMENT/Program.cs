using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATH_AND_COMPARISON_OPERATOR_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n\nPerson 1:\nPlease input Hourly Rate:");
            string input1 = Console.ReadLine();
            int person1HR = Convert.ToInt32(input1);
            Console.WriteLine("\nPlease input hours worked per week:");
            string input2 = Console.ReadLine();
            int person1HW = Convert.ToInt32(input2);
            Console.WriteLine("\nPerson 1:\nHourly Rate: \t\t\t\t" + person1HR + "\nHours worked per week: \t\t\t" + person1HW);

            Console.WriteLine("\nPerson 2:\nPlease input Hourly Rate:");
            string input3 = Console.ReadLine();
            int person2HR = Convert.ToInt32(input3);
            Console.WriteLine("\nPlease input hours worked per week:");
            string input4 = Console.ReadLine();
            int person2HW = Convert.ToInt32(input4);
            Console.WriteLine("\nPerson 2:\nHourly Rate: \t\t\t\t" + person2HR + "\nHours worked per week: \t\t\t" + person2HW);

            int annualSalary1 = person1HR * person1HW * 52;
            Console.WriteLine("\nAnnual Salary of Person 1: \t\t" + annualSalary1);
            int annualSalary2 = person2HR * person2HW * 52;
            Console.WriteLine("Annual Salary of Person 2: \t\t" + annualSalary2);

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            bool comparison = annualSalary1 > annualSalary2;
            Console.WriteLine(comparison);
            Console.ReadLine();
        }
    }
}
