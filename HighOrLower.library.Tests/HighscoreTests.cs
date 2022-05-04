using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HighOrLower.library.Tests
{
    [TestClass]
    public class ScoreTests
    {
        [TestMethod]
        public void CanCreateInstanceOfScore()
        {
            Score score = new Score { Username = "Oliver", Points = 42 };

            Assert.AreEqual("Oliver", score.Username);
            Assert.AreEqual(42, score.Points);
        }
    }
}
