using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Deck
    {
        public List<Card> allCards = new List<Card>();
        public Deck()
        {
            string[] possibleSuit = new string[] {"clubs", "spades", "hearts", "diamonds"};
            string[] possibleFaces = new string[] {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};

            for (int i = 0; i < possibleSuit.Length; i++)
            {
                for (int x = 0; x < possibleFaces.Length; x++)
                {
                    Card singleCard = new Card(possibleFaces[x], possibleSuit[i], x+1);
                    allCards.Add(singleCard);
                    Console.WriteLine(singleCard._StringVal + " of " +singleCard.Suit);
                }
            }
        }
        public Card Deal()
        {
            if (allCards.Count == 0)
            {
                return null;
            }
            Card cardToDeal = allCards[allCards.Count-1];
            allCards.RemoveAt(allCards.Count-1);
            return cardToDeal;
        }
        public void Reset()
        {
            allCards = new List<Card>();
        }
        
        public void Shuffle()
        {
            Random rng = new Random();

            for (int i = 0; i < allCards.Count; i++)
            {
                int rand = rng.Next(allCards.Count);
                Card temp = allCards[i];
                allCards[i] = allCards[rand];
                allCards[rand] = temp;
            }
        }
    }
}