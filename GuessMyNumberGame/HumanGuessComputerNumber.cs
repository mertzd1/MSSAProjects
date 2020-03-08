using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GuessMyNumberGame
{
    class HumanGuessComputerNumber
    {

     public static int counter;
        
        //still need to put in the Try and catch if the human enters invalid number
        public int Guess(int HumanGuess,int ComputerPick)
        {

            counter++;

            if (HumanGuess == ComputerPick)
            {
                Console.WriteLine("You guessed the correct number");
            }

            else if (HumanGuess > ComputerPick)
            {
                Console.WriteLine("Your number was to high, Guess Again");
                HumanGuess = int.Parse(Console.ReadLine());
                HumanGuess = Guess(HumanGuess, ComputerPick);
            }

            else if (HumanGuess < ComputerPick)
            {
                Console.WriteLine("Your number was to low, Guess Again");
                HumanGuess = int.Parse(Console.ReadLine());
                HumanGuess = Guess(HumanGuess, ComputerPick);
            }
            else
            {

            }
         
            return  counter;
            
        }
    }
}

