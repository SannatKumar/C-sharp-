using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessthebird
{
    class Program
    {
        static void Main(string[] args)
        {
            //Function call to greet the user
            WelcomeUser();

            //Function to print the messages in different colours
            PrintColorMessage(ConsoleColor.Red, "Hei you");

            //Get the details of the app
            GetAppDetails();
                                 
        }

        //function to get the app detail
        static void GetAppDetails()
        {
            //Initialize the app info
            string appName = "Guess the bird";
            string appVersion = "1.0.0";
            string appAuthor = "Raj Kumar Tiwari";

            //print app details
            Console.WriteLine("App Name: {0}", appName);
            Console.WriteLine("App Version: {0}", appVersion);
            Console.WriteLine("App Author: {0}", appAuthor);
        }
        
        //function to greet the user
        static void WelcomeUser()
        {
            //Take the user name
            Console.WriteLine("What is your name?");

            //assign the input
            string PlayerName = Console.ReadLine();

            //Printing the Player name and game description
            Console.WriteLine("Hei {0}, Lets play a fun game/n where you have to choose a bird name and match the guess with the machine.", PlayerName);
        }

        //function to change the color and display messages
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change the color
            Console.ForegroundColor = color;

            //print the message
            Console.WriteLine(message);

            //Reset the color
            Console.ResetColor();
        }
    }
}
