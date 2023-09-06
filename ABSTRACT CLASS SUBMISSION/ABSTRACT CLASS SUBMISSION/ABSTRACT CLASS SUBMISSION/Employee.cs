using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION
{
    //Employee inherits from Person, IQuittable
    public class Employee : Person, IQuittable
    {
        //method SayName is based in Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        //implements Quit from IQuittable
        public void Quit()
        {
            Console.WriteLine("I quit.");
        }
    }
}
