using System;

namespace DeterminePythagrean
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 8,3,2,9,25};
            
            Console.WriteLine(DeterminePythagrean(input));
        }

        static bool DeterminePythagrean(int[] input)
        {

            bool result = false;

            Array.Sort(input);

            for (int i = 0; i < input.Length; i++)
            {
                input[i]=(int)Math.Pow(input[i], 2);
            }
       

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    for (int k = i + 2; k < input.Length; k++)
                    {
                        if (i + j == k)
                        {
                            result = true;
                        }
                       
                    }

                }

            }
            return result;
        }
            
    }
}
