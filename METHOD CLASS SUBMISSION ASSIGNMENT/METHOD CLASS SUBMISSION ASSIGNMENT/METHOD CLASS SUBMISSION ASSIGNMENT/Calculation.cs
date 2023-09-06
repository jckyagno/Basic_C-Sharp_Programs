using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_CLASS_SUBMISSION_ASSIGNMENT
{
    class Calculation
    {
        //void method, no return
        public void Method(int a, int b)
        {
            //input a used in math operation
            int answer = a + 2;

            //sum of math operation displayed
            Console.WriteLine("\n" + a + " plus 2 is " + answer + ".");
            //input 2 displayed by itself.
            Console.WriteLine(b + " is by itself.");
        }
    }
}
