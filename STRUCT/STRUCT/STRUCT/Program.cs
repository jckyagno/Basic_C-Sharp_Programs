using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCT
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of data type Number
            Number number = new Number();
            //assigns 0.07 to number.Amount
            number.Amount = .07m;

            //print to console number.Amount
            Console.WriteLine(number.Amount);

            Console.ReadLine();
        }
    }
}
