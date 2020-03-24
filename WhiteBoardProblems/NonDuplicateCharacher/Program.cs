using System;

namespace NonDuplicateCharacher
{

    //Given a string return the first non duplicate charagter
    //Duplicates do not have to be next to eachother
    //is not case sensitive
    class Program
    {
        static void Main(string[] args)
        {
            string Any = "abababcddef";
            Console.WriteLine(firstNonDuplicate(Any));
        }

        static char firstNonDuplicate(string Any)
        {
            bool isDublicate = false; //this sets a flag we are assuming that there are no duplicates

            for (int i = 0; i < Any.Length; i++)
            {
                isDublicate = false;

                for (int j = 0; j < Any.Length; j++)
                {
                    if (i != j && Any[i] == Any[j]) //this says if index i does not = index j so it looks at every letter in the string
                    {
                        isDublicate = true;
                        break;
                    }
                }
                if (!isDublicate)
                    return Any[i];
            }
            return '\0';
            
        }

    }
}


//step 1 look at the first char in the string and see if it has a duplicate
//step 2 repeat for each char in the string
//step 3 return the first char that does not have a duplicate