﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD_SUBMISSION_ASSIGNMENT
{
    class Calculation
    {
        //method overload #1
        public static int Method(int inputOne)
        {
            int numOne = 1;
            int calculationOne = inputOne + numOne;
            return calculationOne;
        }

        //method overload #2
        public static decimal Method(decimal inputTwo)
        {
            decimal numTwo = 1.2345m;
            decimal calculationTwo = inputTwo + numTwo;
            return calculationTwo;
        }

        //method overload #3
        public static int Method(string inputThree)
        {
            int inputThreeConverted = Convert.ToInt32(inputThree);
            int numThree = 2;
            int calculationThree = inputThreeConverted + numThree;
            return calculationThree;
        }
    }
}
