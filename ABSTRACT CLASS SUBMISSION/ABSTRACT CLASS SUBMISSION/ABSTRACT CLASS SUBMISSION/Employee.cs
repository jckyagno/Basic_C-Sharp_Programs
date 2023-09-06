using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION
{
    //Employee inherits from Person
    public class Employee : Person
    {
        //method SayName is based in Employee class
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
