using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION
{
    public abstract class Person
    {
        //instantiates two properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //gives method SayName
        public abstract void SayName();

    }
}
