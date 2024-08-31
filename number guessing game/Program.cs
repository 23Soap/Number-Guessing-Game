using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace number_guessing_game
{
    internal class NumberGuessingGame
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while(playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min,max + 1);

                while(guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max);
                    guess = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Guess: " + guess);

                    if(guess > number)
                    {
                        Console.WriteLine(guess + " to HIGH!");

                    }
                    else if(guess < number)
                    {
                        Console.WriteLine(guess + " is to LOW!");
                    }
                    guesses++;
                }

                Console.WriteLine("The Number is" + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("WOULD YOU LIKE TO PLAY AGAIN? (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if(response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain= false;
                }
                Console.WriteLine("Thanks for playing");
            }

            Console.ReadKey();
        }
    }
}
