using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates employee, populates with a sample student
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //executes SayName() from Employee
            employee.SayName();

            void Quit()
            {
                Console.WriteLine("I quit.");
            }

            //uses polymorphism to create an object
            IQuittable quittable = new Employee();
            //calls Quit() from IQuittable
            quittable.Quit();

            Console.ReadLine();
        }
    }
}
