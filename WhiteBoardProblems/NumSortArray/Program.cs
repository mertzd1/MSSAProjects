using System;

namespace NumSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] UserInput = { 2, 8, 9, 6, 3 };

           NumSort(UserInput);//this calls the method however it does not print the array

           //this prints the array
            for (int i = 0; i < UserInput.Length; i++)
            {
                int index = UserInput[i];
                Console.Write(index); //this prints out the array in one line
                //Console.WriteLine(index);//this prints out the array vertically
            }
        }

            
        //this takes the integers  in the array and places them in the proper order
        //we need two for loops so everynumber gets compared to the first number/
        //we temperarily store the int being moved in temp then we swith i+1 with i, then we then we 
        // replace i with temp.
        static int[] NumSort(int [] UserInput)
        {
            int temp = 0;
            for(int i=0; i<UserInput.Length; i++)
            {
                for(int j = 0; j<UserInput.Length-1; j++)
                
                    if (UserInput[j] > UserInput[j+1])
                {
                    temp = UserInput[j + 1];
                    UserInput[j + 1] = UserInput[j];
                    UserInput[j] = temp;
                }
            }
            return UserInput;
        }
    }
}
