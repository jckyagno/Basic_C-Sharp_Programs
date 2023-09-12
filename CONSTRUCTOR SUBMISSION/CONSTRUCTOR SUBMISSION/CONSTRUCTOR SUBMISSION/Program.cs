using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates two persons: one filled in with inputs, one filled in with defaults
            Person person1 = new Person(26, "Amy", "Blue");
            Person person2 = new Person();

            //make a constant variable
            const string constant = "Constant";
            //make a variable using "var"
            var variable = "Variable";
            //chained the two variables together

            //print to console
            Console.WriteLine(person1.name + " is a " + person1.age + " year old with " + person1.hairColor + " hair.");
            Console.WriteLine(person2.name + " is a " + person2.age + " year old with " + person2.hairColor + " hair.");
            Console.ReadLine();
        }

        //creates a publioc class Person
        public class Person
        {
            //instantiates age, hair color, name
            public int age;
            public string hairColor;
            public string name;
            
            //creates default
            public Person():this(20, "John Doe", "Black")
            {
            }
            //creates properties
            public Person(int theAge, string theName, string theHairColor)
            {
                age = theAge;
                name = theName;
                hairColor = theHairColor;
            }
        }


    }
}
