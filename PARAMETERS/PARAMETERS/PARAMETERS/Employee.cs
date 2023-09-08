using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAMETERS
{
    //makes class take a generic type parameter
    public class Employee<T>
    {
        //adds Things property, data type generic
        public List<T> Things { get; set; }
    }
}
