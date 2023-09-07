using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORS_SUBMISSION
{
    public class Employee
    {
        //created id, firstname, lastname
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        bool isEqual = false;

        //overload == operator
        public static string operator==(Employee employee1, Employee employee2)
        {
            //if employee ids are equal
            if (employee1.Id == employee2.Id)
            {
                string response = "Employee IDs are equal. (==)";
                return response;
            }
            else
            {
                string response = "Employee IDs are not equal. (==)";
                return response;
            }
        }
        //overloads != operator
        public static string operator!=(Employee employee1, Employee employee2)
        {
            //if employee ids are not equal
            if (employee1.Id != employee2.Id)
            {
                string response = "Employee IDs are not equal. (!=)";
                return response;
            }
            else
            {
                string response = "Employee IDs are equal. (!=)";
                return response;
            }

        }
    }
}
