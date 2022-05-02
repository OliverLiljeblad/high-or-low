using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HighOrLower.library.Tests
{
    [TestClass]
    public class DealerTests
    {
        [TestMethod]
        public void CanGetAll52CardsInNormalDeck()
        {
            List<Card> cards = Dealer.GetAllCards();

            Assert.AreEqual(52, cards.Count);
            Assert.AreEqual(new Card(Ranks.Ace, Suits.Clubs), cards[0]);
            Assert.AreEqual(new Card(Ranks.King, Suits.Diamonds), cards[51]);
        }

        [TestMethod]
        public void CanShuffleListOfCardsWithSeed()
        {
            var cards = new List<Card>();

            cards.Add(new Card(Ranks.Ace, Suits.Clubs));
            cards.Add(new Card(Ranks.Two, Suits.Diamonds));
            cards.Add(new Card(Ranks.Three, Suits.Clubs));
            cards.Add(new Card(Ranks.Four, Suits.Spades));
            cards.Add(new Card(Ranks.Five, Suits.Hearts));

            Dealer.Shuffle(cards, 16943);

            Assert.AreEqual(new Card(Ranks.Ace, Suits.Clubs), cards[0]);
            Assert.AreEqual(new Card(Ranks.Two, Suits.Diamonds), cards[1]);
            Assert.AreEqual(new Card(Ranks.Five, Suits.Hearts), cards[2]);
            Assert.AreEqual(new Card(Ranks.Four, Suits.Spades), cards[3]);
            Assert.AreEqual(new Card(Ranks.Three, Suits.Clubs), cards[4]);
        }

        [TestMethod]
        public void CanShuffleListOfCards()
        {
            var cards = new List<Card>();

            cards.Add(new Card(Ranks.Ace, Suits.Clubs));
            cards.Add(new Card(Ranks.Two, Suits.Diamonds));
            cards.Add(new Card(Ranks.Three, Suits.Clubs));
            cards.Add(new Card(Ranks.Four, Suits.Spades));
            cards.Add(new Card(Ranks.Five, Suits.Hearts));

            Dealer.Shuffle(cards);

            Assert.AreEqual(5, cards.Count);
        }
    }
}
