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










        ////CONSOLE APP PART ONE ASSIGNMENT//

        ////1. A one-dimensional array of strings.

        ////created an array of strings named names, assigned aaron, bob, calvin as index 1, 2, 3 respectively

        //string[] names = { "Aaron", "Bob", "Calvin" };



        ////2. Ask the user to input some text.

        ////console prompt to prompt user to type in a present-tense verb
        //Console.WriteLine("Please type a single-word present-tense action. Ex: swims");

        ////stores input as string action
        //string action = Console.ReadLine();



        ////3. A loop that iterates through each string in the array
        ////and adds the user's text input to the end of each string.
        ////This step will not output anything to the console,
        ////but will update each array element by appending the user's text.

        ////first loop to concatenate user input action to end of each index
        //for (int i = 0; i < names.Length; i++)
        //{
        //    names[i] = names[i] + " " + action + ".";
        //} 



        ////4. Then create a second loop that prints off each string in the
        ////array one at a time.
        
        ////second loop  to print off each index to console
        //for (int i = 0; i < names.Length; i++)
        //{
        //    Console.WriteLine(names[i]);
        //} 
        //Console.ReadLine();









        ////CONSOLE APP PART TWO ASSIGNMENT//



        ////1. An infinite loop.

        ////commented out so infinite loop doesn't run

        //    //initialize bool isRepeating so it can be used in the for loop
        //    //bool isRepeating = true;
        //    //i is set to never increment, therefore will always be less than length of names array
        //    //for (int i = 0; isRepeating = i < names.Length; i = 0)
        //    //{
        //    //    Console.WriteLine(names[i]);
        //    //}
        //    //Console.ReadLine();


        ////3. Fix the infinite loop so that it will execute properly.
        //bool isRepeating = true;

        ////changed i to increment after every iteration
        //for (int i = 0; isRepeating = i < names.Length; i++)
        //{
        //    Console.WriteLine(names[i]);
        //}
        //Console.ReadLine();









        ////CONSOLE APP PART THREE ASSIGNMENT//



        ////1. A loop where the comparison that’s used to determine whether
        ////to continue iterating the loop is a “<” operator.
        //for (int i = 0; i < names.Length; i++)
        //{
        //    names[i] = names[i] + " And again.";
        //    Console.WriteLine(names[i]);
        //}
        //Console.ReadLine();

        ////3. Add another loop where the comparison that’s used to determine
        ////whether to continue iterating the loop is a “<=” operator.
        //for (int i = 0; i <= 2; i++)
        //{
        //    names[i] = names[i] + " And AGAIN.";
        //    Console.WriteLine(names[i]);
        //}
        //Console.ReadLine();









        ////CONSOLE APP PART FOUR ASSIGNMENT//



        ////1. A list of strings where each item in the list is unique.
        //List<string> cars = new List<string>() { "Ford", "Chevrolet", "Jeep", "GMC", "Buick", "Dodge", "RAM", "Cadillac", "Lincoln", "Chrysler", "Tesla", "Karma", "Lucid", "Faraday Future", "Brammo", "Rivian", "Lordstown", "Workhorse", "Canoo", "Drako Motors" };



        ////2. Ask the user to input text to search for in the list.
        //Console.WriteLine("Please type in an American car brand to search for in the database.");
        //string userSearch = Console.ReadLine();
        //Console.WriteLine("\nSearching for \"" + userSearch + "\" in database...\n.\n.\n.\n.\n.\n.\n.\n");



        ////3. A loop that iterates through the list and then displays the
        ////index of the list item that contains matching text on the screen.
        //string message = "Your search term was not found in the database.";
        //bool searchFound = false;


        //do
        //{
        //    foreach (string car in cars)
        //    {
        //        if (car == userSearch)
        //        {
        //            message = "\nCar manufacturer \"" + car + "\" is in the database.\nIndex: " + cars.FindIndex(a => a.Contains(userSearch));
        //            searchFound = true;

        ////5. Add code that stops the loop from executing once a match has been found.
        //            break;
        //        }
        //    }
        //    if (searchFound == true)
        //    {
        //        Console.WriteLine(message);
        //    }

        ////4. Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list. 
        //    else
        //    {
        //        Console.WriteLine("\nYour search term \"" + userSearch + "\" was not found in the database.\nPlease type in an American car brand to search for in the database.");
        //        userSearch = Console.ReadLine();
        //        Console.WriteLine("\nSearching for \"" + userSearch + "\" in database...\n.\n.\n.\n.\n.\n.\n.\n");
        //    }
        //}
        //while (!searchFound);

        //Console.WriteLine("Thank you for using the American Car Manufacturer search program.");












        //CONSOLE APP PART FIVE ASSIGNMENT//



        List<int> scores = new List<int>() { 86, 98, 12, 74, 98, 98, 99 };

        Console.WriteLine("\nPlease input a number to search for in the database:");
        string input = Console.ReadLine();
        int userSearch2 = Convert.ToInt32(input);

        foreach (int score in scores)
        {
            if (score == userSearch2)
            {
                Console.WriteLine("Index: {0}", scores.IndexOf(userSearch2));
            }
        }
        Console.ReadLine();



    }
}
