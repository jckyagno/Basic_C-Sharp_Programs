using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION
{
    class Person
    {
        //instantiates two properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //method to display full name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
