using Battleship.UI;
using Battleship.UI.Actions;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Battleship.Tests
{
        
    [TestFixture]
    public class GamTests
    {
        public GameGridTests GridManager()
        {
            return new GameGridTests();
        }
        [Test]
        public void AddingItemToTheGrid()
        {
            var manager = new GameGridTests();
            var result = manager.DisplayGrid("H3");

            Assert.That(result, Is.EqualTo(manager.Grid[7, 2]));
        }
    }
}