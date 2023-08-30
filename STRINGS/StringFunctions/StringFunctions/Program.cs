using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", " + name + ". \nHello on a new line.\n\t Hello on a tab.\\";
            //string fileName = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(name);
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Jesse.");


            //Console.WriteLine(sb);
            //Console.ReadLine();


            //defining sentences 1-3 for future concatenation
            string sentence1 = "This is ";
            string sentence2 = "a concatenated ";
            string sentence3 = "string! :)";
            //concatenate all sentences together
            string concatenatedString = sentence1 + sentence2 + sentence3;

            Console.WriteLine(concatenatedString);
            Console.ReadLine();


            //converts previous string to uppercase
            Console.WriteLine(concatenatedString.ToString().ToUpper());
            Console.ReadLine();


            //use StringBuilder to create another string
            StringBuilder sbString = new StringBuilder();

            sbString.Append("This is ");
            sbString.Append("a StringBuilder");
            sbString.Append("-built string! :D");

            Console.WriteLine(sbString);
            Console.ReadLine();



        }
    }
}
