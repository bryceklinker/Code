using System.Collections.Generic;
using System.Linq;
using Code.Data.Contexts;
using Code.Data.Entities;
using Code.Data.Games;
using Moq;
using NUnit.Framework;

namespace Code.Data.Test.Contexts
{
    [TestFixture]
    public class FootballManagerContextTests
    {
        private Mock<FootballManagerGame> _mockGame;
        private List<FootballManagerPlayer> _fmPlayers;
        private FootballManagerContext _context;

        private void AddPlayer()
        {
            _fmPlayers.Add(new Mock<FootballManagerPlayer>().Object);
        }

        private void AddPlayers(int playerCount)
        {
            for (var i = 0; i < playerCount; i++)
                AddPlayer();
        }

        [SetUp]
        public void Setup()
        {
            _fmPlayers = new List<FootballManagerPlayer>();
            _mockGame = new Mock<FootballManagerGame>();
            _mockGame
                .Setup(s => s.Players)
                .Returns(_fmPlayers);
            _context = new FootballManagerContext(_mockGame.Object);
        }

        [Test]
        public void PlayersGetsPlayersFromGame()
        {
            AddPlayers(5);

            Assert.AreEqual(5, _context.Players.Count());
        }

        [Test]
        public void PlayersLoadsGame()
        {
            _context.Players.ToList();
            _mockGame.Verify(s => s.Load(), Times.Once());
        }
    }
}