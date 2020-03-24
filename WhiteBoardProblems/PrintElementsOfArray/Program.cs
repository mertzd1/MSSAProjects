using System;

namespace PrintElementsOfArray
{ 
    //Given any array print the elements of the array on the console
        class Program
        {
            static void Main(string[] args)
            {
                int[] temp = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


                for (int i = 0; i < temp.Length; i++)
                {
                    int index = temp[i];
                    Console.Write(index); //this prints out the array in one line
                                          //Console.WriteLine(index);//this prints out the array vertically
                }


            }
        }
}
