using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");

            // Step 1: Get user's name and print it.
            System.Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Wilkommen, " + name);

            // Step 2: Cheer the user on.
            // If name is "Bob", output should be:
            // Give me a... b
            // Give me an... o
            // Give me a... b
            // BOB is... GRAND!
            String uppername = name.ToUpper();
            String lowername = name.ToLower();
            for (int i = 0; i < lowername.Length; i++){
                string article = String.Empty;
                if (lowername[i].Equals("a") || 
                    lowername[i].Equals("e") || 
                    lowername[i].Equals("f") || 
                    lowername[i].Equals("h") || 
                    lowername[i].Equals("i") || 
                    lowername[i].Equals("l") || 
                    lowername[i].Equals("m") || 
                    lowername[i].Equals("n") || 
                    lowername[i].Equals("o") || 
                    lowername[i].Equals("r") || 
                    lowername[i].Equals("s") || 
                    lowername[i].Equals("x"))
                {
                    article = "an";
                } else {
                    article = "a";
                }
                string output = String.Format("Give me " + article + "..." + " " + (lowername[i]) + "\n");
                System.Console.Write(output);
            }
            System.Console.Write(uppername + "... is GREAT!\n");

            System.Console.Write("When is your birthday? Please enter it in the following format xx/xx/xxxx\n");
            string bday = System.Console.ReadLine();
            DateTime bdayDate = Convert.ToDateTime(bday);
            DateTime now = DateTime.Now;
            TimeSpan difference = (now - bdayDate);
            int differenceInYears = difference.YY;
            System.Console.Write(differenceInYears);
            System.Console.Write(now.Year);

            System.Console.WriteLine("\nPress any key to exit");
            System.Console.ReadKey();
        }
    }
}
