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

            //Ask users name
            Console.WriteLine("What is your name?");

            //Get User Input
            string inputName = Console.ReadLine();

            //Print the welcome statement 
            Console.WriteLine("Hello {0}, Let's play a game...", inputName);

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
                //change text color
                Console.ForegroundColor = ConsoleColor.Red;

                //Tell user it is not the right number
                Console.WriteLine("Please enter an actual number");


                //Bring Back the color
                Console.ResetColor();

                    //Keep going
                    continue;
                }
                
                //Cast to int and put it in guess
                guess = Int32.Parse(inputUser);

                //Check the guess if matches the correctNumber
                if (guess!= correctNumber)
                {
                    //change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Tell user it is not the right number
                    Console.WriteLine("Wrong Number, Please try again");

                    //Bring Back the color
                    Console.ResetColor();

                    //Keep going
                    continue;
                }

                //Change Text Colour
                Console.ForegroundColor = ConsoleColor.Green;

                

                //Reset text color
                Console.ResetColor();
            }

            //Change Text Colour
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Print the correct results
            Console.WriteLine("This is the Right Number.");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N}");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

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
    }
}
