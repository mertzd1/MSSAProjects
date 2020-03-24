using System;

namespace CountCharsInAString
{
    //Given a string count the amount of a given character in that string.
    //For example if string= Apple and Char= p answer would be 2.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            string word = Console.ReadLine();
            Console.WriteLine("Enter your char");
           
            char letter =Console.ReadKey().KeyChar;
            Console.WriteLine($"\n The amount of times {letter} in the string is");
            Console.WriteLine(CountChar(word,letter)) ;
        }
        static int CountChar(string word, char letter)
        {
            
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
