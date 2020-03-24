using System;

namespace String1StartString2Bool
{
    class Program
    {
        //write a method that takes 2 strings as input and returns true
        //if the fist string starts with the second string
        //and returns false otherwise
        static void Main(string[] args)
        {
           string string1 = "popcorn";
            string string2 = "pop";
            Console.WriteLine(StartString(string1, string2));
            
        }

        static bool StartString(string string1, string string2)
        {
            int count = 0;

            for(int i= 0; i < string2.Length; i++)
            {
                if (string1[i] == string2[i])
                {
                    count++;
                }

            }

            if (count == string2.Length)
            {
                return true;
            }
            return false;         

        
        }               //does not account for empty strings
                        //we are case sensitive which may not have been the intent
            
        
    }
}
