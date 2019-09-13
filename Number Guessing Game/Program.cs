using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            int counter = 0;
            int lowChoice = 1;
            int highChoice = 10;
            int guessNumber;
            int guessChoice = 0;
            string input = "";
            bool validation = false;
            bool guessing = true;

            while (validation != true)
            {
                Console.WriteLine("Welcome to Random Number Guessing Game");
                Console.WriteLine("Pick the Number within the range " + lowChoice + " - " + highChoice + " for the computer to guess.");
                guessChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                if(guessChoice >= lowChoice && guessChoice <= highChoice)
                {
                    validation = true;
                }

            }

            while (guessing == true)                                                            // While in this loop run until you get the correct number when computer is using random values between range
            {
                guessNumber = random.Next(lowChoice, (highChoice + 1));
                if (guessNumber == guessChoice)
                {
                    CheatCheck();

                }
                else if (guessNumber >= guessChoice)
                {
                    AskIfRight();

                }
                else if (guessNumber <= guessChoice)
                {
                    AskIfRight();

                }

                if (lowChoice >= highChoice)
                {
                    guessing = false;
                    Console.WriteLine("Computer has noticed that you are cheating, so it automatically won.");
                    Console.WriteLine("Filthy Cheater...");
                }

            }
            Console.WriteLine(" ");
            Console.WriteLine("Your Number: " + guessChoice);
            Console.WriteLine("It took " + counter + " tries before it got it right.");
            Console.ReadKey();



            void AskIfRight()
            {
                Console.WriteLine("The number you chose: " + guessChoice);
                Console.WriteLine("Computer's Guess: " + guessNumber);
                Console.WriteLine("");
                Console.WriteLine("Is this your number?");
                Console.WriteLine("(Y)es thats right! \n(H)igher chief. \n(L)ower my guy.");
                Console.WriteLine(" ");
                input = Console.ReadLine();
                if (input == "Y" || input == "y")
                {
                    Console.WriteLine("You got it!");
                    guessing = false;
                    counter++;
                }
                else if (input == "H" || input == "h")
                {
                    highChoice = (guessNumber + 1);
                    guessing = true;
                    counter++;
                }
                else if (input == "L" || input == "l")
                {
                    lowChoice = (guessNumber - 1);
                    guessing = true;
                    counter++;
                }

            }

            void CheatCheck()
            {
                Console.WriteLine("The number you chose: " + guessChoice);
                Console.WriteLine("Computer's Guess: " + guessNumber);
                Console.WriteLine("");
                Console.WriteLine("Is this your number?");
                Console.WriteLine("(Y)es thats right! \n(H)igher chief. \n(L)ower my guy.");
                Console.WriteLine(" ");
                input = Console.ReadLine();
                if (input == "Y" || input == "y")
                {
                    Console.WriteLine("You got it!");
                    guessing = false;
                    counter++;
                }
                else if (input == "H" || input == "h")
                {
                    Console.WriteLine("Cheater really...");
                    Console.WriteLine("Computer has detected that you are cheating.");
                    guessing = false;
                    counter++;
                }
                else if (input == "L" || input == "l")
                {
                    Console.WriteLine("Cheater really...");
                    Console.WriteLine("Computer has detected that you are cheating.");
                    guessing = false;
                    counter++;
                }

            }


        }
    }
}


