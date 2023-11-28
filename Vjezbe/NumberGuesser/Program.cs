using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    //Main Class
    internal class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();            

            while (true)
            {                
                Random random = new Random();

                int correctNumber = random.Next(1, 5);
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 5");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {

                        PrintColorMessage(ConsoleColor.Red, "Not an integer, try again");

                        continue;

                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "Correct number");

                if (YesOrNo2())
                {
                    continue;
                }
                else
                {
                    return;
                }

            }

        }


        static void GetAppInfo()
        {
            string appName = "Number guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Goran";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("Enter name: ");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {

            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();

        }

        static Boolean YesOrNo()
        {

            while (true)
            {

                Console.WriteLine("Play again? Y/N");
                string asnwer = Console.ReadLine().Trim().ToUpper();
                if (asnwer == "Y")
                {
                    return true;
                }
                else if (asnwer == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Input Y or N");
                    
                }

            }

            

        }

        static bool YesOrNo2()
        {
            String s;

            while (true)
            {

                Console.WriteLine("Play again? Y/N");
                s = Console.ReadLine().Trim().ToUpper();
                

                if (s.Equals("Y"))
                {
                    
                    return true;
                }
                else if (s.Equals("N"))
                {
                    
                    return false;
                }
                else
                {
                    Console.WriteLine("Answer must be \"y\" or \"n\"");
                    
                }
            }

        }


    }
}
