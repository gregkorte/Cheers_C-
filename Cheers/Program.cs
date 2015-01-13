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
            // Step 1: Get user's name and print it.
            System.Console.WriteLine("What is your name?\n");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Wilkommen, " + name + "\n");

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
                if (lowername[i] == ('a') ||
                    lowername[i] == ('e') ||
                    lowername[i] == ('f') ||
                    lowername[i] == ('h') ||
                    lowername[i] == ('i') ||
                    lowername[i] == ('l') ||
                    lowername[i] == ('m') ||
                    lowername[i] == ('n') ||
                    lowername[i] == ('o') ||
                    lowername[i] == ('r') ||
                    lowername[i] == ('s') ||
                    lowername[i] == ('x'))
                {
                    article = "an";
                } else {
                    article = "a";
                }
                string output = String.Format("Give me " + article + "..." + "\t" + " " + (lowername[i]));
                System.Console.WriteLine(output);
            }
            System.Console.WriteLine("\nWhat's that spell??!      " + uppername + "!\n");
            System.Console.WriteLine("What's that spell??!      " + uppername + "!\n");
            System.Console.WriteLine("What's that spell??!      " + uppername + "!\n");
            System.Console.WriteLine("What's that spell??!      " + uppername + "!\n");
            System.Console.WriteLine("When is your birthday? Please enter it in the following format xx/xx/xxxx\n");
            DateTime now = DateTime.Now;
            string bdayInput = System.Console.ReadLine();
            DateTime bdayDate = Convert.ToDateTime(bdayInput);
            int byearInt = bdayDate.Year;
            int bmonthInt = bdayDate.Month;
            int bdayInt = bdayDate.Day;
            string byearStr = byearInt.ToString();
            string bmonthStr = bmonthInt.ToString();
            string bdayStr = bdayInt.ToString();
            string currBdayStr = bmonthStr + "/" + bdayStr + "/" + now.Year;
            DateTime currBday = Convert.ToDateTime(currBdayStr);
            TimeSpan difference = (now - bdayDate);
            int differenceInDays = difference.Days;
            int yearsOld = differenceInDays / 365;
            
            TimeSpan timeToBd = (currBday - now);
            int timeToBdInt = timeToBd.Days;
            if (timeToBdInt == 0)
            {
                System.Console.WriteLine("\nHappy Biiiirthdaaaay dear, " + name + "... Happy Birthday to you!!");
            }
            else if (timeToBdInt < 0 || timeToBdInt > 345)
            {
                System.Console.WriteLine("\nHappy belated Birthday. Sorry we missed it!");
            }
            else
            {
                System.Console.WriteLine("\nYou will be " + (yearsOld + 1) + " in " + timeToBdInt + " days!");
            }
            
            System.Console.WriteLine("\nGood God! You have been alive for " + differenceInDays + " days!!!");
            System.Console.WriteLine("\nYou have aged " + yearsOld + " years! Keep on truckin'!");
            System.Console.WriteLine("\nPress any key to exit");
            System.Console.ReadKey();
        }
    }
}
