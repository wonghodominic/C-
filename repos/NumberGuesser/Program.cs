using System;

//Namespace
namespace NumberGuesser
{//Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {

            GetAppInfo();
            GreetUser();           
            while (true)
            {

                //Set correct number
                //int correctNumber = 7;

                //Create a new Random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {

                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        //keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                       
                        PrintColorMessage(ConsoleColor.Red, "wrong number, please try again");

                    }
                }
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!!");

                //Ask to play again
                Console.WriteLine("Play Again [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }

                else
                {
                    return;
                }
            }
        }
        static void GetAppInfo() {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dominic Wong";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version{1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

        }
        static void GreetUser() {
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        static void PrintColorMessage(ConsoleColor color, string message) {
            Console.ForegroundColor = color;

            //tell user not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();

        }
    }
}