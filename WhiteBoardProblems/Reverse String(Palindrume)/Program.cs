using System;

namespace Reverse_String_Palindrome
{
    class Program
    { //given a string calculate whether the word is Palidrome
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse());


        }
        //this code reverses a string then checks to see if it is a palindrome
        public static bool Reverse()
        {
            string Val = "racecar";
            string Out = "";
            
            for (int i = Val.Length - 1; i > -1; i--)
            {
                Out += Val[i];
               
            }
            Console.WriteLine($"{Out}");
            
            return Out == Val;

            
            
        }
    }
}
