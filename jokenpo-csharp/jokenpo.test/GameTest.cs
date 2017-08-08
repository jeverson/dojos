using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace jokenpo.test
{
    [TestClass]
    public class GameTest
    {
        Game game;

        [TestInitialize]
        public void Init()
        {
            game = new Game();
        }

        [TestMethod]
        public void Create()
        {
            Assert.IsNotNull(game);
        }

        [TestMethod]
        public void PaperWinsOverStone()
        {

            var p1 = new Mock<IPlayer>();
            p1.Setup<Play>(p => p.play()).Returns(Play.Paper);

            var p2 = new Mock<IPlayer>();
            p2.Setup<Play>(p => p.play()).Returns(Play.Stone);

            game.Player1 = p1.Object;
            game.Player2 = p2.Object;
            game.Judge = new Judge();

            var score = game.RunOneRound();
            ValidateScore(score, 1, 0, 0, 1);

            p1.Setup<Play>(p => p.play()).Returns(Play.Stone);
            p2.Setup<Play>(p => p.play()).Returns(Play.Paper);
            score = game.RunOneRound();

            ValidateScore(score, 1, 1, 0, 2);
        }

        private static void ValidateScore(Score score, int firstPlayerWins, int secondPlayerWins, int ties, int totals)
        {
            Assert.IsNotNull(score);
            Assert.AreEqual(firstPlayerWins, score.FirstPlayerWins);
            Assert.AreEqual(secondPlayerWins, score.SecondPlayerWins);
            Assert.AreEqual(ties, score.Ties);
            Assert.AreEqual(totals, score.TotalOfRounds);
        }

    }
}
