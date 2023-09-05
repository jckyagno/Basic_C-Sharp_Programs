using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();


        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    if (names[j] == "Jesse")
        //    {
        //        Console.WriteLine(names[j]);

        //    }
        //}
        //Console.ReadLine();



        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}
        //Console.ReadLine();




        //List<string> names = new List<string>() { "Jesse", "Erik", "Daniel", "Adam" };

        //foreach (string name in names)
        //{
        //    if (name == "Jesse")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //Console.ReadLine();


        //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        //List<int> passingScores = new List<int>();


        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        passingScores.Add(score);
        //        Console.WriteLine(score);
        //    }
        //}
        //Console.WriteLine("\nThe amount of students who passed is: " + passingScores.Count);
        //Console.ReadLine();










        //CONSOLE APP PART ONE ASSIGNMENT//
        Console.WriteLine("\nCONSOLE APP PART ONE ASSIGNMENT\n");

        //1. A one-dimensional array of strings.

        //created an array of strings named names, assigned aaron, bob, calvin as index 1, 2, 3 respectively

        string[] names = { "Aaron", "Bob", "Calvin" };



        //2. Ask the user to input some text.

        //console prompt to prompt user to type in a present-tense verb
        Console.WriteLine("Please type a single-word present-tense action. Ex: swims");

        //stores input as string action
        string action = Console.ReadLine();



        //3. A loop that iterates through each string in the array
        //and adds the user's text input to the end of each string.
        //This step will not output anything to the console,
        //but will update each array element by appending the user's text.

        //first loop to concatenate user input action to end of each index
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = names[i] + " " + action + ".";
        }



        //4. Then create a second loop that prints off each string in the
        //array one at a time.

        //second loop  to print off each index to console
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.ReadLine();









        //CONSOLE APP PART TWO ASSIGNMENT//
        Console.WriteLine("\nCONSOLE APP PART TWO ASSIGNMENT\n");


        //1. An infinite loop.

        //commented out so infinite loop doesn't run

        //initialize bool isRepeating so it can be used in the for loop
        //bool isRepeating = true;
        //i is set to never increment, therefore will always be less than length of names array
        //for (int i = 0; isRepeating = i < names.Length; i = 0)
        //{
        //    Console.WriteLine(names[i]);
        //}
        //Console.ReadLine();


        //3. Fix the infinite loop so that it will execute properly.
        bool isRepeating = true;

        //changed i to increment after every iteration
        for (int i = 0; isRepeating = i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.ReadLine();









        //CONSOLE APP PART THREE ASSIGNMENT//
        Console.WriteLine("\nCONSOLE APP PART THREE ASSIGNMENT\n");


        //1. A loop where the comparison that’s used to determine whether
        //to continue iterating the loop is a “<” operator.
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = names[i] + " And again.";
            Console.WriteLine(names[i]);
        }
        Console.ReadLine();

        //3. Add another loop where the comparison that’s used to determine
        //whether to continue iterating the loop is a “<=” operator.
        for (int i = 0; i <= 2; i++)
        {
            names[i] = names[i] + " And AGAIN.";
            Console.WriteLine(names[i]);
        }
        Console.ReadLine();









        //CONSOLE APP PART FOUR ASSIGNMENT//
        Console.WriteLine("\nCONSOLE APP PART FOUR ASSIGNMENT\n");


        //1. A list of strings where each item in the list is unique.
        List<string> cars = new List<string>() { "Ford", "Chevrolet", "Jeep", "GMC", "Buick", "Dodge", "RAM", "Cadillac", "Lincoln", "Chrysler", "Tesla", "Karma", "Lucid", "Faraday Future", "Brammo", "Rivian", "Lordstown", "Workhorse", "Canoo", "Drako Motors" };



        //2. Ask the user to input text to search for in the list.
        Console.WriteLine("Please type in an American car brand to search for in the database.");
        string userSearch = Console.ReadLine();
        Console.WriteLine("\nSearching for \"" + userSearch + "\" in database...\n.\n.\n.\n.\n.\n.\n.\n");



        //3. A loop that iterates through the list and then displays the
        //index of the list item that contains matching text on the screen.
        string message = "Your search term was not found in the database.";
        bool searchFound = false;


        do
        {
            foreach (string car in cars)
            {
                if (car == userSearch)
                {
                    message = "\nCar manufacturer \"" + car + "\" is in the database.\nIndex: " + cars.FindIndex(a => a.Contains(userSearch));
                    searchFound = true;

                    //5. Add code that stops the loop from executing once a match has been found.
                    break;
                }
            }
            if (searchFound == true)
            {
                Console.WriteLine(message);
            }

            //4. Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list. 
            else
            {
                Console.WriteLine("\nYour search term \"" + userSearch + "\" was not found in the database.\nPlease type in an American car brand to search for in the database.");
                userSearch = Console.ReadLine();
                Console.WriteLine("\nSearching for \"" + userSearch + "\" in database...\n.\n.\n.\n.\n.\n.\n.\n");
            }
        }
        while (!searchFound);

        Console.WriteLine("Thank you for using the American Car Manufacturer search program.");
        Console.ReadLine();












        //CONSOLE APP PART FIVE ASSIGNMENT//
        Console.WriteLine("\nCONSOLE APP PART FIVE ASSIGNMENT\n");


        //1. A list of strings that has at least two identical strings in the list.
        //Ask the user to select text to search for in the list.
        List<string> peopleNames = new List<string>() { "Jesse", "Erik", "Daniel", "Jesse" };
        Console.WriteLine("\nType the name of a person to see if they are on the list:");
        string userSearch3 = Console.ReadLine();


        //2. Create a loop that iterates through the list and then displays the indices
        //of the items matching the user-selected text. Ensure to remove any break
        //statements that may prevent your code from returning multiple matches.
        for (int i = 0; i < peopleNames.Count; i++)
        {
            if (peopleNames[i] == userSearch3)
            {
                Console.WriteLine(peopleNames[i] + " is at index value of: " + i);
            }

            //3. Add code to the loop to check if the user put in text that isn't on the list and,
            //if they did, tells the user their input is not on the list.
            //(You do not need to provide any additional chances for the user to enter text.)
            else if (!peopleNames.Contains(userSearch3))
            {
                Console.WriteLine("Could not find the name in database.");
                break;
            }
        }

        Console.ReadLine();










        //CONSOLE APP PART SIX ASSIGNMENT//
        Console.WriteLine("\nCONSOLE APP PART SIX ASSIGNMENT\n");

        //1. Create a list of strings that has at least two identical strings in the list.
        List<string> letters = new List<string>() { "A", "B", "C", "D", "E", "D" };
        List<string> duplicates = new List<string>();

        //2. Create a foreach loop that evaluates each item in the list,
        //and displays a message showing the string and whether or not it has already appeared in the list.
        foreach (string letter in letters)
        {
            if (!duplicates.Contains(letter))
            {
                duplicates.Add(letter);
                Console.WriteLine(letter + " - this item is unique");
            }
            else
            {
                Console.WriteLine(letter + " - this item is a duplicate");
            }
        }
        Console.ReadLine();
    }
}
