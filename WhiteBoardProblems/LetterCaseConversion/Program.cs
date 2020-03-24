using System;

namespace LetterCaseConversion
{
    class Program
    { //Given a string TrentReznorIsAGod convert all the caplital letters to lowercase and 
        //lowercase letters to capital
        static void Main(string[] args)
        {
            string ninstr = "TrentReznorIsAGod";
            char[]nin =ninstr.ToCharArray();
            

            for (int i=0; i < nin.Length; i++)
            {
                if(nin[i] >= 'a')
                {
                    nin[i]= (char)(nin[i]-('a'-'A'));
                }
                else if(nin[i] < 'a')
                {
                    nin[i] = (char)(nin[i] + ('a' - 'A'));
                }

            }
            Console.WriteLine(nin);
        }
    }
}
