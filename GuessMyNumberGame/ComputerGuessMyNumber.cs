using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumberGame
{
    class ComputerGuessMyNumber
    {
        public static int counter;

        public int Guess(int ComputerGuess, int HumanPick)
        {

            counter++;

            if (ComputerGuess == HumanPick)
            {
                Console.WriteLine("You guessed the correct number");
            }

            else if (ComputerGuess > HumanPick)
            {
                Console.WriteLine("You guessed to high, Guess again");
                Random Number = new Random();
                ComputerGuess = Number.Next(0, 100);
                Guess(ComputerGuess, HumanPick);
            }

            else if (ComputerGuess < HumanPick)
            {
                Console.WriteLine("You guessed to low, Guess again");
                Random Number = new Random();
                ComputerGuess = Number.Next(0, 100);
                Guess(ComputerGuess, HumanPick);
            }
            else
            {
                
            }

            return counter;

        }
    }
}
