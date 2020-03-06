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
            WelcomeUSer();
            GetAppDetails();
                                 
        }
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
        static void WelcomeUSer()
        {
            //Take the user name
            Console.WriteLine("What is your name?");

            //assign the input
            string PlayerName = Console.ReadLine();

            //Printing the Player name and game description
            Console.WriteLine("Hei {0}, Lets play a fun game/n where you have to choose a bird name and match the guess with the machine.", PlayerName);
        }
    }
}
