using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Roulette
{
    public class ValidBets
    {
        public List<Bet> Bets { get; set; }
           
        public ValidBets()
        {
            Bets = new List<Bet>();
        }

        void PopulateNumberBets(RouletteBoard board)
        {
            string betType = "Number bet";
            foreach (Cell c in board.ZeroCells)
            {
                Bet bet = new Bet();
                bet.BetType = betType;
                bet.WinningValues.Add(c.Value);
                Bets.Add(bet);
            }
            foreach (Cell c in board.Board)
            {
                Bet bet = new Bet();
                bet.BetType = betType;
                bet.WinningValues.Add(c.Value);
                Bets.Add(bet);
            }
        }
        void PopulateOddBets(RouletteBoard board)
        {
            string betType = "Odd bet";
            foreach (Cell c in board.Board)
            {
                if(c.Value % 2 !=0)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType;
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);

                }
            }

        }
        void PopulateEvenBets(RouletteBoard board)
        {
            string betType = "Even bet";
            foreach (Cell c in board.Board)
            {
                if (c.Value % 2 == 0)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType;
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);

                }
            }

        }

        void PopulateEvenOddBets(RouletteBoard board)
        {
            PopulateEvenBets(board);
            PopulateOddBets(board);
        }

        void PopulateRedBets(RouletteBoard board)
        {
            string betType = "Red bet";
            foreach (Cell c in board.Board)
            {
                if (c.Color==CellColor.Red)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType;
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);

                }
            }

        }
        void PopulateBlackBets(RouletteBoard board)
        {
            string betType = "Black bet";
            foreach (Cell c in board.Board)
            {
                if (c.Color == CellColor.Black)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType;
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);

                }
            }

        }
        void PopulateColorBets(RouletteBoard board)
        {
            PopulateRedBets(board);
            PopulateBlackBets(board);
        }
        void PopulateHighBets(RouletteBoard board)
        {
            string betType = "High bet";
            foreach (Cell c in board.Board)
            {
                if (c.Value > 18 )
                {
                    Bet bet = new Bet();
                    bet.BetType = betType;
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);

                }
            }

        }
        void PopulateLowBets(RouletteBoard board)
        {
            string betType = "Low bet";
            foreach (Cell c in board.Board)
            {
                if (c.Value < 19)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType;
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);

                }
            }

        }

        void PopulateLowHighBets(RouletteBoard board)
        {
            PopulateHighBets(board);
            PopulateLowBets(board);
        }
        void PopulateFirstThird(RouletteBoard board)
        {
            string betType = "1st 12";
            foreach (Cell c in board.Board)
            {
                if (c.Value <13)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType;
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);

                }
            }

        }
        void PopulateSecondThird(RouletteBoard board)
        {
            string betType = "2nd 12";
            foreach (Cell c in board.Board)
            {
                if (c.Value > 13 && c.Value < 25)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType;
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);

                }
            }

        }

        void PopulateThirdThird(RouletteBoard board)
        {
            string betType = "3rd 12";
            foreach (Cell c in board.Board)
            {
                if (c.Value > 24)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType;
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);

                }
            }

        }
        void PopulateDozenBets(RouletteBoard board)
        {
            PopulateFirstThird(board);
            PopulateSecondThird(board);
            PopulateThirdThird(board);
        }
        void PopulateFirstColumn(RouletteBoard board)
        {
            string betType = "1st Column";
            foreach (Cell c in board.Board)
            {
                if (c.Value % 3==1)
                {                    
                        Bet bet = new Bet();
                        bet.BetType = betType;
                        bet.WinningValues.Add(c.Value);
                        Bets.Add(bet);     
                }
            }

        }
        void PopulateSecondColumn(RouletteBoard board)
        {
            string betType = "2nd Column";
            foreach (Cell c in board.Board)
            {
                if (c.Value % 3 == 2)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType;
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }
            }

        }
        void PopulateThirdColumn(RouletteBoard board)
        {
            string betType = "3rd Column";
            foreach (Cell c in board.Board)
            {
                if (c.Value % 3 == 0)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType;
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }
            }

        }
        void PopulateColumnBets(RouletteBoard board)
        {
            PopulateFirstColumn(board);
            PopulateSecondColumn(board);
            PopulateThirdColumn(board);
        }
       
        void PopulateStreetBets(RouletteBoard board)
        {
           
            
                for (int x = 0; x < board.Board.GetLength(0); x++)
                {
                    Bet bet = new Bet();
                    bet.BetType = $"Street {x+1}";
                    for (int y = 0; y < board.Board.GetLength(1); y++)
                    {
                        bet.WinningValues.Add(board.Board[x,y].Value);
                    }
                    Bets.Add(bet);                    
                }    
        }
        void PopulateDoubleRowBets(RouletteBoard board)
        {

            string betType = $"DoubleRow ";

            foreach (Cell c in board.Board)
            {

                if (c.Value < 7)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType + "1 & 2";
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);

                }
                 if (c.Value > 3 && c.Value < 10)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType + "2 & 3";
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }
                if (c.Value > 6 && c.Value < 13)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType + "3 & 4";
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }
                 if (c.Value > 9 && c.Value < 16)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType + "4 & 5";
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }
                 if (c.Value > 12 && c.Value < 19)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType + "5 & 6";
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }
                 if (c.Value > 15 && c.Value < 22)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType + "6 & 7";
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }
                 if (c.Value > 18 && c.Value < 25)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType + "7 & 8";
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }
                 if (c.Value > 21 && c.Value < 28)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType + "8 & 9";
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }
                 if (c.Value > 24 && c.Value < 31)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType + "9 & 10";
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }
                 if (c.Value > 27 && c.Value < 34)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType + "10 & 11";
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }
                 if (c.Value > 30 && c.Value < 37)
                {
                    Bet bet = new Bet();
                    bet.BetType = betType + "11 & 12";
                    bet.WinningValues.Add(c.Value);
                    Bets.Add(bet);
                }

            }
        }
        void PopulateSplitBets(RouletteBoard board)
        {
            
                List<Cell> neighbor = new List<Cell>();
            
            
                int x = (board.WinningNumber - 1) / 3;
                int y = (board.WinningNumber - 1) % 3;

            if(board.WinningNumber > 0)
            {
                for (int i = -1; i < 2; i += 2)
                {
                    Bet bet = new Bet();

                    if (x + i >= 0 && x + i < 12)
                    {
                        neighbor.Add(board.Board[x + i, y]);
                                              
                    }
                    if (y + i >= 0 && y + i < 3)
                    {
                        neighbor.Add(board.Board[x, y + i]);
                    }

                }
                foreach (Cell c in neighbor)
                {
                    Console.WriteLine($"Split bet {board.WinningNumber} {c.Value} won");
                }


            }
        }

        void PopulateCornerBets(RouletteBoard board)
        {

            List<Cell> neighbor = new List<Cell>();

//this code finds the indexes in the 2d [] based on the number that was chosen.
//from here we can navigate to the corner bets by using the for loop to adjust the index that 
//corresponds with the corner. the if else statements keep the loop from going out of bounds within 
//the array
            int x = (board.WinningNumber - 1) / 3;
            int y = (board.WinningNumber - 1) % 3;

            if (board.WinningNumber > 0)
            {
                for (int i = -1; i < 2; i += 2)
                {
                    Bet bet = new Bet();                   

                    if ((x - 1 >= 0 && x - i <= 12) && (y + i >= 0 && y + i < 3))
                    {
                        neighbor.Add(board.Board[x - 1, y + i]);
                    }
                    for (int j = -1; j < 1; j+=2)
                    {
                        if ((x + 1 >= 0 && x + 1 < 12) && (y + i >= 0 && y + i < 3))
                        {
                            neighbor.Add(board.Board[x + 1, y+i]);
                        }

                    }
                   
                    

                }
                foreach (Cell c in neighbor) 
                {
                    Console.WriteLine($"Corner bet {board.WinningNumber} {c.Value} won");
                }


            }
        }






        public void PopulateBets(RouletteBoard board)
        {
            PopulateNumberBets(board);
            PopulateEvenOddBets(board);
            PopulateColorBets(board);
            PopulateLowHighBets(board);
            PopulateDozenBets(board);
            PopulateColumnBets(board);
            PopulateStreetBets(board);
            PopulateDoubleRowBets(board);
            PopulateSplitBets(board); 
            PopulateCornerBets(board); 
        }


    }
    
}
