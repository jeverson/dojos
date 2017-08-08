using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jokenpo.test
{
    [TestClass]
    public class JudgeTest
    {
        Judge judge;

        [TestInitialize]
        public void Init()
        {
            judge = new Judge();
        }

        [TestMethod]
        public void Create()
        {
            Assert.IsNotNull(judge);
        }

        [TestMethod]
        public void FirstWins()
        {
            var winner = judge.judge(Play.Paper, Play.Stone);
            Assert.AreEqual(WinnerPosition.First, winner);
        }

        [TestMethod]
        public void SecondWins()
        {
            var winner = judge.judge(Play.Stone, Play.Paper);
            Assert.AreEqual(WinnerPosition.Second, winner);

            winner = judge.judge(Play.Scissors, Play.Stone);
            Assert.AreEqual(WinnerPosition.Second, winner);
        }

        [TestMethod]
        public void Tie()
        {
            var winner = judge.judge(Play.Stone, Play.Stone);
            Assert.AreEqual(WinnerPosition.None, winner);
        }
    }
}
