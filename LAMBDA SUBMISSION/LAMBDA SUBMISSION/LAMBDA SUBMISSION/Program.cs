using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiated employee list
            List<Employee> employeeList = new List<Employee>();
            //created 10 employees, three of which have Joe as a first name
            employeeList.Add(new Employee() { Id = 01, FirstName = "Aaron", LastName = "Aaronson" });
            employeeList.Add(new Employee() { Id = 02, FirstName = "Bob", LastName = "Bobson" });
            employeeList.Add(new Employee() { Id = 03, FirstName = "Charlie", LastName = "Charlieson" });
            employeeList.Add(new Employee() { Id = 04, FirstName = "Joe", LastName = "Joekerson" });
            employeeList.Add(new Employee() { Id = 05, FirstName = "Evan", LastName = "Evanson" });
            employeeList.Add(new Employee() { Id = 06, FirstName = "Franklin", LastName = "Franklinson" });
            employeeList.Add(new Employee() { Id = 07, FirstName = "Joe", LastName = "Joeraldson" });
            employeeList.Add(new Employee() { Id = 08, FirstName = "Harry", LastName = "Harrison" });
            employeeList.Add(new Employee() { Id = 09, FirstName = "Ian", LastName = "Ianson" });
            employeeList.Add(new Employee() { Id = 10, FirstName = "Joe", LastName = "Joeson" });

            //instantiated joe list
            List<Employee> joeList = new List<Employee>();
            List<Employee> greaterThanFiveList = new List<Employee>();



            //STEP 3//
            Console.WriteLine("3. Using a foreach loop, create a new list of all employees with the first name “Joe”.\nIn your comparison statement, remember to reference the property of the object you are checking.");

            //foreach loop, if index has firstname == joe, take index and move to joe list
            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(new Employee() { Id = employee.Id, FirstName = employee.FirstName, LastName = employee.LastName });
                }
            }

            //foreach loop to print out joe list
            foreach (Employee joe in joeList)
            {
                Console.WriteLine("\nID#\t\t:\t" + joe.Id + "\nFirst Name\t:\t" + joe.FirstName + "\nLast Name\t:\t" + joe.LastName);
            }



            //STEP 4//
            Console.WriteLine("\n\n\n4. Perform the same action again, but this time with a lambda expression.");

            //lambda to show all indices with first name joe
            joeList = employeeList.Where(x => x.FirstName == "Joe").ToList();

            //foreach loop to print out results of lambda
            foreach (Employee joe in joeList)
            {
                Console.WriteLine("\nID#\t\t:\t" + joe.Id + "\nFirst Name\t:\t" + joe.FirstName + "\nLast Name\t:\t" + joe.LastName);
            }



            //STEP 5//
            Console.WriteLine("\n\n\n5. Using a lambda expression, make a list of all employees with an Id number greater than 5.");

            //lambd to show all indices with Id greater than 5
            greaterThanFiveList = employeeList.Where(x => x.Id > 5).ToList();
            foreach (Employee greaterThenFive in greaterThanFiveList)
            {
                Console.WriteLine("\nID#\t\t:\t" + greaterThenFive.Id + "\nFirst Name\t:\t" + greaterThenFive.FirstName + "\nLast Name\t:\t" + greaterThenFive.LastName);
            }


            Console.ReadLine();
        }
    }
}
