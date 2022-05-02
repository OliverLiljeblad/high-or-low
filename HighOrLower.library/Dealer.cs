using System;
using System.Collections.Generic;

namespace HighOrLower.library
{
    public static class Dealer
    {
        public static List<Card> GetAllCards()
        {
            var cards = new List<Card>();

            cards.Add(new Card(Ranks.Ace,    Suits.Clubs));
            cards.Add(new Card(Ranks.Two,    Suits.Clubs));
            cards.Add(new Card(Ranks.Three,  Suits.Clubs));
            cards.Add(new Card(Ranks.Four,   Suits.Clubs));
            cards.Add(new Card(Ranks.Five,   Suits.Clubs));
            cards.Add(new Card(Ranks.Six,    Suits.Clubs));
            cards.Add(new Card(Ranks.Seven,  Suits.Clubs));
            cards.Add(new Card(Ranks.Eight,  Suits.Clubs));
            cards.Add(new Card(Ranks.Nine,   Suits.Clubs));
            cards.Add(new Card(Ranks.Ten,    Suits.Clubs));
            cards.Add(new Card(Ranks.Jack,   Suits.Clubs));
            cards.Add(new Card(Ranks.Queen,  Suits.Clubs));
            cards.Add(new Card(Ranks.King,   Suits.Clubs));

            cards.Add(new Card(Ranks.Ace,    Suits.Spades));
            cards.Add(new Card(Ranks.Two,    Suits.Spades));
            cards.Add(new Card(Ranks.Three,  Suits.Spades));
            cards.Add(new Card(Ranks.Four,   Suits.Spades));
            cards.Add(new Card(Ranks.Five,   Suits.Spades));
            cards.Add(new Card(Ranks.Six,    Suits.Spades));
            cards.Add(new Card(Ranks.Seven,  Suits.Spades));
            cards.Add(new Card(Ranks.Eight,  Suits.Spades));
            cards.Add(new Card(Ranks.Nine,   Suits.Spades));
            cards.Add(new Card(Ranks.Ten,    Suits.Spades));
            cards.Add(new Card(Ranks.Jack,   Suits.Spades));
            cards.Add(new Card(Ranks.Queen,  Suits.Spades));
            cards.Add(new Card(Ranks.King,   Suits.Spades));            
            
            cards.Add(new Card(Ranks.Ace,    Suits.Hearts));
            cards.Add(new Card(Ranks.Two,    Suits.Hearts));
            cards.Add(new Card(Ranks.Three,  Suits.Hearts));
            cards.Add(new Card(Ranks.Four,   Suits.Hearts));
            cards.Add(new Card(Ranks.Five,   Suits.Hearts));
            cards.Add(new Card(Ranks.Six,    Suits.Hearts));
            cards.Add(new Card(Ranks.Seven,  Suits.Hearts));
            cards.Add(new Card(Ranks.Eight,  Suits.Hearts));
            cards.Add(new Card(Ranks.Nine,   Suits.Hearts));
            cards.Add(new Card(Ranks.Ten,    Suits.Hearts));
            cards.Add(new Card(Ranks.Jack,   Suits.Hearts));
            cards.Add(new Card(Ranks.Queen,  Suits.Hearts));
            cards.Add(new Card(Ranks.King,   Suits.Hearts));

            
            cards.Add(new Card(Ranks.Ace,    Suits.Diamonds));
            cards.Add(new Card(Ranks.Two,    Suits.Diamonds));
            cards.Add(new Card(Ranks.Three,  Suits.Diamonds));
            cards.Add(new Card(Ranks.Four,   Suits.Diamonds));
            cards.Add(new Card(Ranks.Five,   Suits.Diamonds));
            cards.Add(new Card(Ranks.Six,    Suits.Diamonds));
            cards.Add(new Card(Ranks.Seven,  Suits.Diamonds));
            cards.Add(new Card(Ranks.Eight,  Suits.Diamonds));
            cards.Add(new Card(Ranks.Nine,   Suits.Diamonds));
            cards.Add(new Card(Ranks.Ten,    Suits.Diamonds));
            cards.Add(new Card(Ranks.Jack,   Suits.Diamonds));
            cards.Add(new Card(Ranks.Queen,  Suits.Diamonds));
            cards.Add(new Card(Ranks.King,   Suits.Diamonds));

            return cards;
        }

        public static void Shuffle(List<Card> cards, int seed)
        {
            var rnd = new Random(seed);
            Shuffle(cards, rnd);
        }

        public static void Shuffle(List<Card> cards)
        {
            var rnd = new Random();
            Shuffle(cards, rnd);
        }

        private static void Shuffle(List<Card> cards, Random rnd)
        {
            var tempList = new List<Card>();

            var cardCount = cards.Count;

            for (int i = 0; i < cardCount; i++)
            {
                int randomIndex = rnd.Next(cards.Count);

                tempList.Add(cards[randomIndex]);

                cards.RemoveAt(randomIndex);
            }

            cards.AddRange(tempList);
        }

    }
}
