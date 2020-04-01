using System;

namespace RemoveChar
{
    class Program
    {
        /*Remove all occurrences of a specified character from an array of character and return a new array that is the exact size of the string without the character to remove.

Note: a string cannot be used anywhere and helper methods may not be used (ie: ToCharArray())

ie: given 'i' and {'m', 'i', 's', 's', 'i', 's', 's', 'i', 'p', 'p', 'i'}
    return {'m', 's', 's', 's', 's', 'p', 'p'}

ie: given 'n' and {'a', 'n', 'o', 'n', 'y', 'm', 'o', 'u', 's'}
    return {'a', 'o', 'y', 'm', 'o', 'u', 's'}

    */

        static void Main(string[] args)
        {
            Char[] input = { 'm', 'o', 'm', 'm','y' };
            string input1 = "Mommy";
            char removing = 'o';

            Console.WriteLine(RemoveCharFromArray(removing,input));
            Console.WriteLine(RemoveCharFromString(removing,input1));
        }


        static char[] RemoveCharFromArray(char removing, char[] input)
        {
            int count = 0;

            foreach(char c in input)
            {
                if (c != removing)
                    count++;
            }
            char[] output = new char[count];
            count = 0;
            foreach(char c in input)
            {
                if(c!=removing)
                {
                    output[count] = c;
                    count++;

                }
            }
            return output;
        }
        //if I was allowed to use a string I could have done it like this.
        static string RemoveCharFromString(char remove, string input)
        {
            string output="";

            foreach (char c in input)
                
                if (c != remove)
                {
                    output += c;
                }
            return output;
        }
    }
}
