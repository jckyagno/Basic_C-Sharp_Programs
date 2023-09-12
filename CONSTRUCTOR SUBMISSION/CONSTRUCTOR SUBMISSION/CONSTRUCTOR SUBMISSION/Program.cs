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
            //make a constant variable
            const string constant = "Constant";
            //make a variable using "var"
            var variable = "Variable";
            //chained the two variables together
            var chained = constant + " " + variable;

            //print to console
            Console.WriteLine(chained);
            Console.ReadLine();

        }
    }
}
