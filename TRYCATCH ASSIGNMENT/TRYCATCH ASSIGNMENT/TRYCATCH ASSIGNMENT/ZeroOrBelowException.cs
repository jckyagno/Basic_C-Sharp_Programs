using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRYCATCH_ASSIGNMENT
{
    //made public
    public class ZeroOrBelowException : Exception
    {
        //made a method for zero or below
        public ZeroOrBelowException()
            : base() { }
        //override to include custom message
        public ZeroOrBelowException(string message)
            : base(message) { }
    }
}
