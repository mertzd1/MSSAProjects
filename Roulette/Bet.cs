using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Bet
    {
        public string BetType { get; set; }

        
        public List<int> WinningValues { get; set; }
        public Bet()
        {
            WinningValues = new List<int>();
        }
            

    }
}
