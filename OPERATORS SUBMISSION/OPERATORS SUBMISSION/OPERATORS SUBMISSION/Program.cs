using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORS_SUBMISSION
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //instantiates two employees
            Employee employee1 = new Employee() { Id = 111, FirstName = "Sample", LastName = "Salaryman" };
            Employee employee2 = new Employee() { Id = 222, FirstName = "Example", LastName = "Employee" };

            //write responses to console
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);
            Console.ReadLine();


        }
    }
}
