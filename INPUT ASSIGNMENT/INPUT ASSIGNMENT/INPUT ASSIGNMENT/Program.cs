using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace INPUT_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks an input number from user
            Console.WriteLine("Please entry a number:");
            //converts input to integer
            int input = Convert.ToInt32(Console.ReadLine());
            //using streamwriter to make sure the memory is freed after use, appending input to log.txt
            using (StreamWriter file = new StreamWriter(@"D:\Visual Studio Projects\Logs\log.txt", true))
            {
                //appending input
                file.WriteLine(input);
            }

            //assigning text in log.txt to text
            string text = File.ReadAllText(@"D:\Visual Studio Projects\Logs\log.txt");
            //writing text to console
            Console.WriteLine(text);


            Console.ReadLine();
        }
    }
}
