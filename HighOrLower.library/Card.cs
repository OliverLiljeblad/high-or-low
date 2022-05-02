using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighOrLower.library
{
    public class Card
    {
        public Card(Ranks ranks, Suits suits)
        {
            Rank = ranks;
            Suit = suits;
        }

        public bool EqualRank(Card otherCard)
        {
            return Rank == otherCard.Rank;
        }
        
        public bool IsHigher(Card otherCard)
        {
            if (Rank == Ranks.Ace && otherCard.Rank != Ranks.Ace)
                return true;

            return Rank > otherCard.Rank; 
        }

        public bool IsLower(Card otherCard)
        {
            if (Rank == Ranks.Ace && otherCard.Rank != Ranks.Ace) 
                return true; 

            return Rank < otherCard.Rank; 
        }

        public Suits Suit { get; }

        public Ranks Rank { get; }

        public override string ToString()
        {
            char s = ' ';
            string r;

            switch (this.Suit)
            {
                case Suits.Clubs:
                    s = '\u2663'; //Set s to unicode value for clubs
                    break;
                case Suits.Diamonds:
                    s = '\u2666';
                    break;
                case Suits.Spades:
                    s = '\u2660';
                    break;
                case Suits.Hearts:
                    s = '\u2665';
                    break;
                default:
                    break;
            }

            switch (this.Rank)
            {
                case Ranks.Ace:
                    r = "Ace";
                    break;
                case Ranks.Jack:
                    r = "Jack";
                    break;
                case Ranks.Queen:
                    r = "Queen";
                    break;
                case Ranks.King:
                    r = "King";
                    break;
                default:
                    r = ((int)Rank).ToString();
                    break;
            }

            return r + ":" + s;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Card;
            if (other == null)
            {
                return false;
            }

            return this.Rank == other.Rank && this.Suit == other.Suit;
        }
    }
}
