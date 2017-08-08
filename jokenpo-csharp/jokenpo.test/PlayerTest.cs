using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jokenpo.test
{
    [TestClass]
    public class PlayerTest
    {

        Player player;

        [TestInitialize]
        public void Init() {
            player = new Player();
        }

        [TestMethod]
        public void Create()
        {
            Assert.IsNotNull(player);
        }

        [TestMethod]
        public void PlayAnyMovement()
        {
            var play = player.play();
            Assert.IsInstanceOfType(play, typeof(Play));
        }

        [TestMethod]
        public void SayWinningMessage()
        {
            Assert.IsNotNull(player.WinningMessage());
        }

        [TestMethod]
        public void SayLosingMessage()
        {
            Assert.IsNotNull(player.LosingMessage());
        }
    }
}
