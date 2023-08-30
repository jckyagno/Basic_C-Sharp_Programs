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
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            while (!isGuessed)
            {
                switch (number)
                {
                    case 12:
                        Console.WriteLine("\nYou guessed 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("\nYou guessed: " + number + "\nYou are wrong.\nGuess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();
        }


        Console.WriteLine("Best pizza topping?");
        //stores input as topping
        string topping = Console.ReadLine();
        //isGuessed2 false unless topping changed to pineapple
        bool isGuessed2 = topping == "pineapple";

        //do while loop
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
while (!isGuessed2) ;

Console.ReadLine();
    }

}
