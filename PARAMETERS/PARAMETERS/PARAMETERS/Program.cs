using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAMETERS
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates first employee object
            Employee<string> employee1 = new Employee<string>() {  };
            //assigns a list of strings to Things
            employee1.Things = new List<string>() { "Apples", "Bananas", "Croissants" };
            
            
            //instantiates second employee object
            Employee<int> employee2 = new Employee<int>() {  };
            //assigns a list of integers
            employee2.Things = new List<int>() { 1, 2, 4 };

            //for loop to print out results
            for (int i = 0; i < employee1.Things.Count; i++ )
            {
                Console.WriteLine(employee1.Things[i]);
            }
            for (int i = 0; i < employee2.Things.Count; i++ )
            {
                Console.WriteLine(employee2.Things[i]);
            }



            Console.ReadLine();


        }
    }
}
