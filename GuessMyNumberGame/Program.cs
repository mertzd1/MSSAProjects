using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace GuessMyNumberGame
{
    class Program
    {
      
        
      
        static void Main(string[] args)
        {
            
            Step3();
            

        }
        public static void Step1() //I put the ty and catch method here so I could recall Step one if a User input the wrong information.
        {
            try
            {
                Console.WriteLine("Input a number from 1-10");
                int Value = int.Parse(Console.ReadLine());

                if (Value < 0 || Value > 10)
                {
                    Console.WriteLine("You entered a numer outside of the Array's Range");
                    Step1();
                    return;
                }
                BisectionAlgorithmImplement Try = new BisectionAlgorithmImplement();
                Console.WriteLine($"The number in the array is {ReadArray(Try.Check(Value))}");
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Step1();
            }
        }
        public static int counter2;
        public static void Step2()
        {
            try
            {
                counter2 = 1;
                counter2++;

                Console.WriteLine("Can you guess my Number?");
                Console.WriteLine("Guess any number between 1 and 1000 to start the game");
                int HumanGuess = int.Parse(Console.ReadLine());

                if (HumanGuess < 0 || HumanGuess > 1000)
                {
                    Console.WriteLine("You entered a numer outside of the  Range");
                    Step2();
                    return;
                }
                Random Number = new Random();
                int ComputerPick = Number.Next(1, 1000);

                HumanGuessComputerNumber Play = new HumanGuessComputerNumber();
                Console.WriteLine($"You guessed the correct number in  {(Play.Guess(HumanGuess, ComputerPick))} guesses");
                //I still need to calculate the average number of guesses for the amount of times played
                Step2();//this has the user immediatly start another round of HumanGuessComputerNumber

            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Step2();
            }


        }



        public static int counter3;
        public static void Step3()
        {
            try
            {
                counter3 = 0;
                counter3++;

                Console.WriteLine("Pick a number for me to guess between 1 and 100");
                int HumanPick = int.Parse(Console.ReadLine());

                if (HumanPick < 0 || HumanPick > 1000)
                {
                    Console.WriteLine("You entered a numer outside of the  Range");
                    Step2();
                    return;
                }
                Random Number = new Random();
                int ComputerGuess = Number.Next(1, 100);

                ComputerGuessMyNumber Play = new ComputerGuessMyNumber();
                Console.WriteLine($"It took me an average of {(Play.Guess(ComputerGuess, HumanPick/counter3))} guesses to guess your number");
                //I still need to calculate the average number of guesses for the amount of times played
                Step3();//this has the user immediatly start another round of HumanGuessComputerNumber

            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Step2();
            }






        }



        static string ReadArray(int[] Input)
        {
            string output = "";
            for (int i = 0; i < Input.Length; i++)
            {
                
                output+=(Input[i]).ToString(); //this prints out the array in one line
                
            }
            return output;
        }

    }
}



