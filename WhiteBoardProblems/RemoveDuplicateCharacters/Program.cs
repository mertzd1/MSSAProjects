using System;

namespace RemoveDuplicateCharacters
{
    //Remove all duplicate char from a given string

    //The essential logic in removing duplicate characters is to check all the chars that have been encountered
    //and avoid adding further characters that have been encountered already
    class Program
    {
        static void Main()
        {
            string value1 = RemoveDuplicateChars("Csharpstar");
            string value2 = RemoveDuplicateChars("Google");
            string value3 = RemoveDuplicateChars("Yahoo");
            string value4 = RemoveDuplicateChars("CNN");
            string value5 = RemoveDuplicateChars("Line1\nLine2\nLine3");

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
            Console.WriteLine(value5);
        }

        static string RemoveDuplicateChars(string key)
        {
            // --- Removes duplicate chars using string concats. ---
            // Store encountered letters in this string.
            string table = "";

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                if (table.IndexOf(value) == -1) //index of is a zero-based index of the first occurrence of a specified unicode character. methods returs -1 if the char or string is not found in the instance
                {                               //there for if the string table does not have a char in it it will add it to the table and result, if the char is in it it returns o and does not enter the table or result
                    // Append to the table and the result.
                    table += value;
                    result += value;
                }
            }
            return result;
        }
    }
}
