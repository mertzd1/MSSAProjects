using System;
using System.Collections.Generic;

namespace CardDeck
{
    class Program
    {

        public object Count { get => Card.Count; }

        static void playRound(Deck Player1, Deck Player2)
        {
            
            List<Card> tableCards = new List<Card>();
          

            Card a = new Card();
            Card b = new Card();
            a = Player1.RemoveTopCard();
            b = Player2.RemoveTopCard();
            tableCards.Add(a);
            tableCards.Add(b);
            
            Console.WriteLine($"Player 1's card is {a}");
            Console.WriteLine($"Player 2's card is {b}");
           





            while (a == b)
            {
                a = Player1.RemoveTopCard();
                b = Player2.RemoveTopCard();
                tableCards.Add(a);
                tableCards.Add(b);
                
                a = Player1.RemoveTopCard();
                b = Player2.RemoveTopCard();
                tableCards.Add(a);
                tableCards.Add(b);
                Console.WriteLine("You have a war!!!");
                Console.WriteLine($"Player 1's card is {a}");
                Console.WriteLine($"Player 2's card is {b}");
            }
            if (a > b)
            {
                Player1.Cards.AddRange(tableCards);
                tableCards.Clear();
                
            }
            else if (b>a)
            {
                Player2.Cards.AddRange(tableCards);
                tableCards.Clear();
                
            }
            Console.WriteLine($"Player 1 has {Player1.Count} cards");
            Console.WriteLine($"Player 2 has {Player2.Count} cards");
            
           

        }

        static void Main(string[] args)
        {
            
            Deck d = new Deck();
            Deck Player1 = new Deck();
            Deck Player2 = new Deck();


            
            foreach (CardSuit cs in Enum.GetValues(typeof(CardSuit)))
            {
                foreach(CardValue cv in Enum.GetValues(typeof(CardValue)))
                {
                    d.AddCard(new Card(cs, cv));
                }
            }
            
            int userInput = 0;
            while (userInput != -1)
            {
                
                Console.WriteLine("Press 1 to Shuffle and Deal Cards");
                Console.WriteLine("Press 2 then enter to deal next card round");


                userInput = int.Parse(Console.ReadLine());
               
                switch (userInput)
                {

                    case 1:
                        d.ShuffleDeck();
                        d.DealCards(Player1, Player2);                        
                        break;

                    case 2:
                        
                        playRound( Player1, Player2);
                       
                        break;

                    default:
                        break;
                }
            }
            

        }
       

    }
}
