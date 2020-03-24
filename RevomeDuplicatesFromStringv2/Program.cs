using System;

namespace RevomeDuplicatesFromStringv2
{
    class Program
    {
        static void Main(string[] args)
        {
            string any = "Accommodate";
          

            Console.WriteLine(RemoveDuplicate(any));
        }
        static string RemoveDuplicate(string any)
        {
            
           

            for (int i =any.Length-1; i > -1; i--)
            {
                for(int j= i-1; j>-1; j--)
                {
                    if (any[i] == any[j])

                        any.

                }

            }

            return any;
        }
    }
}
