﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates object with starting info
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            //executes SayName method
            employee.SayName();

            Console.ReadLine();
        }
    }

}
