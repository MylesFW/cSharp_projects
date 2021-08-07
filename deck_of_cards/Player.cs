using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Player
    {
        public string Name {get; set;}
        public List<Card> Hand {get; set;} = new List<Card>();

    public Player (string name)
    {
        Name = name;
    }
    public Card Draw(Deck deck)
    {
        Card drawnCard = deck.Deal();
        Hand.Add(drawnCard);
        return drawnCard;
    }
    public void PrintHand()
    {
        Console.WriteLine($"{Name}'s hand is now : ");
        foreach (Card card in Hand)
        {
            Console.WriteLine(card);
        }
    }
    }
}