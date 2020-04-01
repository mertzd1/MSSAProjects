using System;

namespace SoleSurvivor
{
    class Program
    {
        //Given an array of integers where every int occurs three times except for one integer, which only occurs oncce
        //find and return the non-duplicated integer

            //example 6133366
            // example 6113166
            // 13,19,13,13
        static void Main(string[] args)
        {
            int[] numbers = { 6, 1, 3, 3, 3, 6, 6,1,1,2 };
            Console.WriteLine(SoleSurvivor(numbers));
        }

        static int SoleSurvivor(int[] numbers)
        {
            Array.Sort(numbers);
            int soleSurvivor=0;

            for (int i = 0; i < numbers.Length; i+=3)
            {
               
                for (int j = i + 1; j < numbers.Length ; j++)
                {
                    
                    if (numbers[i] == numbers[j])
                    {
                        soleSurvivor = numbers[i];
                        break;

                    }             

                }
                if (soleSurvivor != numbers[i])
                {
                    soleSurvivor = numbers[i];
                    break;
                }
            }
            return soleSurvivor;
        }
        
    }
}
