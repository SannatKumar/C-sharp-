using System;
//Namespace
namespace NumberGuesser
{
     // Main class
    class Program
    {
         //Entry Point method
        static void Main(string[] args)
        {
            //Function Call to get the app details
            GetAppInfo();

            // //Function Call to greet the users
            GreetUser();

           
            while (true) { 

            //Create a random Objet
            Random random = new Random();

            //Init Correct Number

            int correctNumber = random.Next(1, 10);

            //Initialize guess variable
            int guess = 0;

            //Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while(guess!= correctNumber)
            {
                //Get users input
                string inputUser = Console.ReadLine();

                //Input Validation that it is a number
                if(!int.TryParse(inputUser, out guess)) 
                {
                    //Print Color message
                    PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                    //Keep going
                    continue;
                }
                
                //Cast to int and put it in guess
                guess = Int32.Parse(inputUser);

                //Check the guess if matches the correctNumber
                if (guess!= correctNumber)
                {
                    //Print Color message
                    PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                    //Keep going
                    continue;
                }

                //Change Text Colour
                Console.ForegroundColor = ConsoleColor.Green;

                //Reset text color
                Console.ResetColor();
            }

                //Print Color message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N}");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                //Checck Answer
                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }


            }


        }
        //Function to display the App Info
        static void GetAppInfo()
        {
            //Set App vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Raj Kumar Tiwari";

            //Change Text Colour
            Console.ForegroundColor = ConsoleColor.Green;

            //Print the value
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        //Function to greet user
        static void GreetUser()
        {

            //Ask users name
            Console.WriteLine("What is your name?");

            //Get User Input
            string inputName = Console.ReadLine();

            //Print the welcome statement 
            Console.WriteLine("Hello {0}, Let's play a game...", inputName);

        }

        //Print the color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            
            //Change text Color
            Console.ForegroundColor = color;

            //Give users the message
            Console.WriteLine(message);

            //Reset the color
            Console.ResetColor();
        }
    }
    }
