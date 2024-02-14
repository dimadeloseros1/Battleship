using Battleship.UI;
using Battleship.UI.Actions;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Battleship.Tests
{
        
    [TestFixture]
    public class GamTests
    {
        public GameGridTests TestManager()
        {
            return new GameGridTests();
        }

        /// <summary>
        /// Checks if the input is located in the exact location on the Grid
        /// </summary>
        [Test]
        public void AddingItemToTheGrid()
        {
            var manager = TestManager();
            var result = manager.DisplayGrid("H3");

            Assert.That(result, Is.EqualTo(manager.Grid[7, 2]));    
        }

        
        [Test]
        public void PlaceVerticalOrHorizontal()
        {
            var manager = TestManager();
            var placeSymbol = manager.DisplayGrid("H3");
            //var result = manager.CheckHorizontalOrVertical("H6");

        }
    }
}