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
            int lowChoice = 0;
            int highChoice = 0;
            int guessNumber;
            int guessChoice = 0;
            bool guessing = true;

            while (lowChoice >= highChoice)
            {
                Console.WriteLine("Welcome to Random Number Guessing Game");
                Console.WriteLine("Please set the low value of the range.");
                lowChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please set the high value of the range.");
                highChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
            }

            {
                if (highChoice >= lowChoice)
                {
                    while (guessChoice > highChoice || guessChoice < lowChoice)                 // Make sures your range isn't incorrect
                    {
                        Console.WriteLine("Pick the Number within the range " + lowChoice + " - " + highChoice + " for the computer to guess.");
                        guessChoice = Convert.ToInt32(Console.ReadLine());

                        if (guessChoice > highChoice || guessChoice < lowChoice)
                        {
                            Console.WriteLine("That was outside the boundries try again.");
                        }

                    }

                }
                
            }

            while (guessing == true)                                                            // While in this loop run until you get the correct number when computer is using random values between range
            {
                guessNumber = random.Next(lowChoice, (highChoice + 1));
                if (guessNumber == guessChoice)
                {
                    Console.WriteLine("You got it!");
                    guessing = false;
                    counter++;

                }
                else if (guessNumber > guessChoice)
                {
                    guessing = true;
                    counter++;

                }
                else if (guessNumber < guessChoice)
                {
                    guessing = true;
                    counter++;

                }

            }
            Console.WriteLine(" ");
            Console.WriteLine("Your Number: "  + guessChoice);
            Console.WriteLine("It took " + counter + " tries before it got it right.");
            Console.ReadKey();
        }
    }
}
