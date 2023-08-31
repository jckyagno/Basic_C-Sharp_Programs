using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Jesse");
        //intList.Remove("Jesse");

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();


        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();





        //initialize boxNum 
        int boxNum = 0;
        //bool if boxNum is 1=5 means true
        bool problem1 = boxNum >= 1 && boxNum <= 5;

        //intialize string stringArray with 5 strings
        string[] stringArray = new string[5];
        stringArray[0] = "apples";
        stringArray[1] = "bananas";
        stringArray[2] = "coconuts";
        stringArray[3] = "dates";
        stringArray[4] = "eggplants";

        Console.WriteLine("The farmer has extra food to give to you.\nThere's five numbered boxes with fruit inside.\nWhich box do you open? (Type 1-5)");

        //store input as input, convert to int - 1 to match with indices
        string input = Console.ReadLine();
        boxNum = Convert.ToInt32(input) - 1;

        //do while loop
        while (!problem1)
        {
            switch (boxNum)
            {
                //case 0-4 passing solutions
                case 0:
                    Console.WriteLine("\nYou got a free box of " + stringArray[boxNum] + "! :)");
                    //will allow loop to be continued
                    problem1 = true;
                    break;
                case 1:
                    Console.WriteLine("\nYou got a free box of " + stringArray[boxNum] + "! :)");
                    problem1 = true;
                    break;
                case 2:
                    Console.WriteLine("\nYou got a free box of " + stringArray[boxNum] + "! :)");
                    problem1 = true;
                    break;
                case 3:
                    Console.WriteLine("\nYou got a free box of " + stringArray[boxNum] + "! :)");
                    problem1 = true;
                    break;
                case 4:
                    Console.WriteLine("\nYou got a free box of " + stringArray[boxNum] + "! :)");
                    problem1 = true;
                    break;
                //if a wrong answer not matching 1-5 is given
                default:
                    Console.WriteLine("Look, just type 1-5.");
                    input = Console.ReadLine();
                    boxNum = Convert.ToInt32(input) - 1;
                    break;
            }
        }



        //initialize array intArray
        int[] intArray = new int[5];
        //initialize doorNum for future usage
        int doorNum = 0;
        //true if doorNum is 1-5
        bool problem2 = doorNum >= 1 && doorNum <= 5;

        intArray[0] = 5;
        intArray[1] = 420;
        intArray[2] = 100000;
        intArray[3] = 50000;
        intArray[4] = 6000;

        Console.WriteLine("\n\nYou won a game show!\nThere's five doors to choose from that give you different amounts of money.\nPick a door for your reward (Type 1-5)");
        //store input as input2, convert it int - 1 to match with indices
        string input2 = Console.ReadLine();
        doorNum = Convert.ToInt32(input2) - 1;


        //do while loop
        while (!problem2)
        {
            switch (doorNum)
            {
                //case 0-4 all passing solutions
                case 0:
                    Console.WriteLine("\nYou won $" + intArray[doorNum] + "!!! :D");
                    //will allow loop to be continued
                    problem2 = true;
                    break;
                case 1:
                    Console.WriteLine("\nYou won $" + intArray[doorNum] + "!!! :D");
                    problem2 = true;
                    break;
                case 2:
                    Console.WriteLine("\nYou won $" + intArray[doorNum] + "!!! :D");
                    problem2 = true;
                    break;
                case 3:
                    Console.WriteLine("\nYou won $" + intArray[doorNum] + "!!! :D");
                    problem2 = true;
                    break;
                case 4:
                    Console.WriteLine("\nYou won $" + intArray[doorNum] + "!!! :D");
                    problem2 = true;
                    break;
                //default solution if given input is not 1-5
                default:
                    Console.WriteLine("Look, just type 1-5.");
                    input2 = Console.ReadLine();
                    doorNum = Convert.ToInt32(input2) - 1;
                    break;
            }
        }


        //initialize carNum
        int carNum = 0;
        //initialize boolean problem3 for future usage, true if 1-5
        bool problem3 = carNum >= 1 && carNum <= 5;

        //created list of strings
        List<string> newList = new List<string>();
        newList.Add("Alfa Romeo");
        newList.Add("Buick");
        newList.Add("Cadillac");
        newList.Add("Dodge");
        newList.Add("Elemental");

        Console.WriteLine("\n\nA rich relative says that you can have the car parked in any one of their garages.\nWhich garage do you choose?");

        //store input as input3, convert to int - 1 to match with indices
        string input3 = Console.ReadLine();
        carNum = Convert.ToInt32(input3) - 1;

        //do while loop
        while (!problem3)
        {
            switch (carNum)
            {
                //case 0-4 passing solutions
                case 0:
                    Console.WriteLine("\nYou recieved a brand new " + newList[carNum] + " car!\nYour rich relative high-5s you. ( ^o^)/＼(^_^ )");
                    //will allow to continue from loop
                    problem3 = true;
                    break;                
                case 1:
                    Console.WriteLine("\nYou recieved a brand new " + newList[carNum] + " car!\nYour rich relative high-5s you. ( ^o^)/＼(^_^ )");
                    problem3 = true;
                    break;                
                case 2:
                    Console.WriteLine("\nYou recieved a brand new " + newList[carNum] + " car!\nYour rich relative high-5s you. ( ^o^)/＼(^_^ )");
                    problem3 = true;
                    break;                
                case 3:
                    Console.WriteLine("\nYou recieved a brand new " + newList[carNum] + " car!\nYour rich relative high-5s you. ( ^o^)/＼(^_^ )");
                    problem3 = true;
                    break;                
                case 4:
                    Console.WriteLine("\nYou recieved a brand new " + newList[carNum] + " car!\nYour rich relative high-5s you. ( ^o^)/＼(^_^ )");
                    problem3 = true;
                    break;
                //default answer for input not matching 1-5
                default:
                    Console.WriteLine("Look, just type 1-5.");
                    input3 = Console.ReadLine();
                    carNum = Convert.ToInt32(input3) - 1;
                    break;
            }
        }
        Console.ReadLine();
    }
}
