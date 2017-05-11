using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Builder;

namespace Test
{
    [TestClass]
    public class BuilderTest
    {
        private GameMaker _gameMaker;

        [TestInitialize]
        public void init()
        {
            _gameMaker = new GameMaker();
        }

        [TestMethod]
        public void Should_Construct_Dice_Game()
        {
            var builder = new DiceGameBuilder();

            var game = _gameMaker.Construct(builder);

            Assert.AreEqual(game["board"], "No board");
            Assert.AreEqual(game["box"], "Awesome black");
            Assert.AreEqual(game["component"], "Full of dice");
            Assert.AreEqual(game["rules"], "Unleash the kraken");
        }

        [TestMethod]
        public void Should_Construct_Board_Game()
        {
            var builder = new BoardGameBuilder();

            var game = _gameMaker.Construct(builder);

            Assert.AreEqual(game["board"], "Large board");
            Assert.AreEqual(game["box"], "Huge!!");
            Assert.AreEqual(game["component"], "So many cards and looks this mini");
            Assert.AreEqual(game["rules"], "RTFM");
        }

    }
}
