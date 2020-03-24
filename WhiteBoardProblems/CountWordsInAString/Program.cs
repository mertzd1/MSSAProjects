using System;

namespace CountWordsInAString
{
    class Program
    {
        //Write a method that returns the number of words in an input string (there are two spaces after a period)
        //ie. "Airforce knockoffs with the Gucci print material.  Way before the iPhone, Twitter, Gram Socials. I'm talking about
        //Nextel chirps, Boost Mobile"
        //should return 21
        static void Main(string[] args)
        {
            string input = "Airforce knockoffs with the Gucci print material.  Way before the iPhone, " +
                "Twitter, Gram Socials. I'm talking about Nextel, chirps, Boost Mobile";

            Console.WriteLine(CountingWords(input));
        }

        static int CountingWords(string input)
        {
            int wordCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    if (input[i]== input[i+1])
                    {
                        continue;
                    }
                    
                    wordCount++;
                }
            }
            return wordCount + 1;
        }
    }
}
