using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HighOrLower.library.Tests
{
    [TestClass]
    public class LeaderBoardTests
    {
        [TestMethod]
        public void CanCreateInstanceOfLeaderboard()
        {
            LeaderBoard leaderBoard = new LeaderBoard();
            Assert.IsNotNull(leaderBoard);
        }

        [TestMethod]
        public void CanAddHighscoreToLeaderboard()
        {
            var leaderboard = new LeaderBoard();

            leaderboard.AddScore("Oliver", 15);
            leaderboard.AddScore("Jonatan", 9);
        }

        [TestMethod]
        public void CanReadLeaderBoard()
        {
            var leaderboard = new LeaderBoard();

            leaderboard.AddScore("Oliver", 15);
            leaderboard.AddScore("Kristofer", 9);

            var list = leaderboard.GetAll();

            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(list[0].Username, "Oliver");
            Assert.AreEqual(list[0].Points, 15);
            Assert.AreEqual(list[1].Username, "Kristofer");
            Assert.AreEqual(list[1].Points, 9);
        }
    }
}
