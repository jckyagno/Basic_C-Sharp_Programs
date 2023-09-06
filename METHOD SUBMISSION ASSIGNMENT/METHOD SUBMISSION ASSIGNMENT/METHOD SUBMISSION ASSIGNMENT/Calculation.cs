using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_SUBMISSION_ASSIGNMENT
{
    class Calculation
    {
        //method intakes two inputs
        public string Method(int inputOne, string inputTwo)
        {
            //if there is nothing typed for input two...
            if (inputTwo == "")
            {
                //convert the "" to acutally zero
                int answer = Convert.ToInt32(inputOne);
                string response = "The number you entered is: " + answer;
                //return response string to be used in main program
                return response;
            }
            //if number was typed for second number...
            else
            {
                //convert string to int
                int inputTwoA = Convert.ToInt32(inputOne);
                //perform calculation
                int answer = inputOne + inputTwoA;
                string response = inputOne + " plus " + inputTwoA + " equals " + answer;
                //return response string to be used in main program
                return response;
            }
        }
        


    }
}
