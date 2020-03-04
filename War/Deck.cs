using System;
using System.Collections.Generic;

namespace CardDeck
{
    class Deck
    {
        

        public List<Card> Cards { get; set; }
        public int NumCards { get => Cards.Count; }
        public object Count { get=> Cards.Count; }

        public Deck()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card newCard)
        {
            Cards.Add(newCard);
        }

        public Card RemoveTopCard()
        {
            Card cardToRemove = Cards[0];
            Cards.RemoveAt(0);
            return cardToRemove;
        }

        public void PrintDeck()
        {
            foreach(Card c in Cards)
            {
                System.Console.WriteLine(c);
            }
        }

        public void SortDeck()
        {
            Cards.Sort();
            
        }
        public void ShuffleDeck()
        {
            for (int i= 0; i < 10000; i++)
            {
                Card copy;
                Random rand = new Random();
                int cardremoved = rand.Next(this.Cards.Count);
                copy = this.Cards[cardremoved];
                this.Cards.Add(copy);
                this.Cards.RemoveAt(cardremoved);

            }           

        }
        public void DealCards(Deck Player1, Deck Player2)
        {

            


            
            for (int i = 0; i < Cards.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Card newCard = Cards[i];
                    Player1.AddCard(newCard);
                    

    }


                else
                {
                    Card newCard = Cards[i];
                    Player2.AddCard(newCard);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Player 1's deck");
            Console.WriteLine($"Player 1 has {Player1.Count} cards");
            Player1.PrintDeck();

            Console.WriteLine("\n");
            Console.WriteLine("Player 2's deck");
            Console.WriteLine($"Player 2 has {Player2.Count} cards");
            Player2.PrintDeck();
                          


                
            
        }
        


    }
}