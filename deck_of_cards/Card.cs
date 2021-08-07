namespace deck_of_cards
{
    public class Card
    {
        public string _StringVal {get; set;} // giving the card these slots that can be used for data
        public string Suit {get; set;}
        public int Val {get; set;}

    public Card(string stringVal, string suit, int val) //constructor - assigning values to each card
    {
        _StringVal = stringVal;
        Suit = suit;
        Val = val;
    }
    }
}