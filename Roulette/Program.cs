using System;
using System.Collections.Generic;

namespace Roulette
{
    class Program
    {
        //comment for git push
        static void PrintWinningBets(int BinNumber, List<Bet> Bets)
        {
            foreach (Bet board in Bets)
            {
                if (board.WinningValues.Contains(BinNumber))
                {
                    Console.Write($"{board.BetType} won!!! [");
                    foreach (int val in board.WinningValues)
                    {
                        Console.Write(val + ",");
                    }
                    Console.WriteLine("]");
                }
            }
        }
        static void Main(string[] args)
        {
            RouletteBoard Board = new RouletteBoard();
            Random SpinWeel = new Random();
            ValidBets vb = new ValidBets();
            int winningNumber = SpinWeel.Next(1, 39);
            Board.WinningNumber = winningNumber;
            vb.PopulateBets(Board);
            PrintWinningBets(winningNumber, vb.Bets);
        }
       

    }
}
