using System;

namespace MaxProfit
{
    class Program
    {   //PROBLEM ASKED BY FACEBOOK
        //Given an array of numbers representing the stock prices of a company in chronological order, write a function 
        //that calculates the maximum profit you could have made from buying and selling the stock
        //once. You must buy before you can sell it.

        //For example  give [9,11,8,5,7,10], you should return 5, since you could but the stock at 5 dollars and sell it a 10 dollars
        static void Main(string[] args)
        {
            int[] inputArray = { 9, 11, 8, 5, 7, 10 };
            Console.WriteLine(findProfit(inputArray));
            

        }
        public static int findProfit(int[] inputArray)
        {
            int bestProfit = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j =i+1; j< inputArray.Length; j++)
                {
                    if(inputArray[i] < inputArray[j])
                    {
                        int profit = inputArray[j] - inputArray[i];

                            if(profit > bestProfit)
                        {
                            bestProfit = profit;
                        }
                    }
                }
                
            }
            return bestProfit;
        }
    }
}
