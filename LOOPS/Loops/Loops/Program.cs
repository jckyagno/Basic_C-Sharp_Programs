using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    Console.WriteLine("Guess a number?");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    bool isGuessed = number == 12;

        //    do
        //    {
        //        switch (number)
        //        {
        //            case 62:
        //                Console.WriteLine("You guessed 62. Guess Try again.\nGuess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 29:
        //                Console.WriteLine("You guessed 29. Guess Try again.\nGuess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 55:
        //                Console.WriteLine("You guessed 55. Guess Try again.\nGuess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 12:
        //                Console.WriteLine("You guessed 12. That is correct!");
        //                isGuessed = true;
        //                break;
        //            default:
        //                Console.WriteLine("You are wrong.\nGuess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //        }
        //    }
        //    while (!isGuessed);

        //    Console.ReadLine();
        //}
        {
            Console.WriteLine("Guess a number?");
            //stores input and converts to int
            int number = Convert.ToInt32(Console.ReadLine());
            //states number needed to be guessed
            bool isGuessed = number == 12;

            //while isGuessed is not true, run these cases
            while (!isGuessed);
                switch (number)
                    {
                        case 62:
                            Console.WriteLine("You guessed 62. Guess Try again.\nGuess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 29:
                            Console.WriteLine("You guessed 29. Guess Try again.\nGuess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 55:
                            Console.WriteLine("You guessed 55. Guess Try again.\nGuess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    //correct solution
                        case 12:
                            Console.WriteLine("You guessed 12. That is correct!");
                    //changes isGuessed to true, which continues on from the while loop
                            isGuessed = true;
                            break;
                    //default solution if none of above cases are met
                        default:
                            Console.WriteLine("You are wrong.\nGuess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }

            //readline to pause
            Console.ReadLine();


            Console.WriteLine("Best pizza topping?");
            //stores input as topping
            string topping = Console.ReadLine();
            //isGuessed2 false unless topping changed to pineapple
            bool isGuessed2 = topping == "pineapple";

            //do whiel loop
            do
            {
                switch (topping)
                {
                    //correct solution
                    case "pineapple":
                        Console.WriteLine("You guessed pineapple. That is correct!");
                        //changes isGuessed2 to true, continuing on from loop
                        isGuessed2 = true;
                        break;
                    //default solution if not guessed pineapple
                    default:
                        Console.WriteLine("You guessed " + topping + ". You are wrong.\nBest pizza topping?");
                        topping = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed2);
            
            Console.ReadLine();
        }
    }
}
