using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HighOrLower.library.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CanCreateCard()
        {
            Card kingOfClubs = new Card(Ranks.King, Suits.Clubs);
            Card queenOfDiamonds = new Card(Ranks.Queen, Suits.Diamonds);
            Card jackOfHearts = new Card(Ranks.Jack, Suits.Hearts);

            Assert.AreEqual(Suits.Clubs, kingOfClubs.Suit);
            Assert.AreEqual(Ranks.Jack, jackOfHearts.Rank);
        }

        [TestMethod]
        public void TwoCardsWithSameRankShouldBeEqual()
        {
            Card threeOfSpades = new Card(Ranks.Three, Suits.Spades);
            Card threeOfHearts = new Card(Ranks.Three, Suits.Hearts);
            Card fiveOfClubs = new Card(Ranks.Five, Suits.Clubs);

            Assert.IsTrue(threeOfSpades.EqualRank(threeOfHearts));
            Assert.IsFalse(threeOfHearts.EqualRank(fiveOfClubs));
        }

        [TestMethod]
        public void CheckIfOneCardIsHigher()
        {
            Card kingOfDiamonds = new Card(Ranks.King, Suits.Diamonds);
            Card queenOfDiamonds = new Card(Ranks.Queen, Suits.Diamonds);

            Assert.IsTrue(kingOfDiamonds.IsHigher(queenOfDiamonds));
        }

        [TestMethod]
        public void CheckIfOneCardIsLower()
        {
            Card kingOfDiamonds = new Card(Ranks.King, Suits.Diamonds);
            Card queenOfDiamonds = new Card(Ranks.Queen, Suits.Diamonds);

            Assert.IsTrue(queenOfDiamonds.IsLower(kingOfDiamonds));
        }

        [TestMethod]
        public void AceIsBothTheHighestAndTheLowestCardInTheGame()
        {
            Card ace = new Card(Ranks.Ace, Suits.Diamonds);
            Card three = new Card(Ranks.Three, Suits.Clubs);
            Card king = new Card(Ranks.King, Suits.Spades);

            Assert.IsTrue(ace.IsHigher(king));
            Assert.IsTrue(ace.IsHigher(three));
            Assert.IsTrue(ace.IsLower(king));
            Assert.IsTrue(ace.IsLower(three));
        }

        [TestMethod]
        public void TwoAcesShouldBeEqual()
        {
            Card aceOfSpades = new Card(Ranks.Ace, Suits.Diamonds);
            Card aceOfDiamonds = new Card(Ranks.Ace, Suits.Diamonds);

            Assert.IsTrue(aceOfSpades.EqualRank(aceOfDiamonds));
        }

        [TestMethod]
        public void AceShouldNotBeHigherThanAce()
        {
            Card aceOfSpades = new Card(Ranks.Ace, Suits.Diamonds);
            Card aceOfDiamonds = new Card(Ranks.Ace, Suits.Diamonds);

            Assert.IsFalse(aceOfSpades.IsHigher(aceOfDiamonds));
            Assert.IsFalse(aceOfSpades.IsLower(aceOfDiamonds));
        }

        [TestMethod]
        public void CanBeConvertedToString()
        {
            Card fiveOfHearts = new Card(Ranks.Five, Suits.Hearts);
            Card aceOfHearts = new Card(Ranks.Ace, Suits.Hearts);

            Assert.AreEqual("Ace:♥", aceOfHearts.ToString());
            Assert.AreEqual("5:♥", fiveOfHearts.ToString());
        }

    }
}
