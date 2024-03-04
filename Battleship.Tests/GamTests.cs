using Battleship.UI;
using Battleship.UI.Actions;
using Battleship.UI.DTOs;
using Battleship.UI.Enums;
using Battleship.UI.Workflow;
using NUnit.Framework;

namespace Battleship.Tests
{
        
    [TestFixture]
    public class GamTests
    {
        public GameGridTests TestManager()
        {
            return new GameGridTests();
        }
        PlayerData data = new PlayerData();

        /// <summary>
        /// Checks if the input is located in the exact location on the Grid
        /// </summary>
        [Test]
        public void AddingShipToTheGrid()
        {
            var manager = TestManager();
            var result = manager.DisplayGrid("H3");

            Assert.That(result, Is.EqualTo(manager.Grid[7, 2]));    
        }

        
        [Test]
        public void CheckCorrectShipLetter()
        {
            var ship = new Ship();
            var newShips = ship.DisplayEachShipLetter(ShipName.AircraftCarrier);

            Assert.That(newShips, Is.EqualTo("A"));
        }

        [Test]
        public void InvalidOffGrid()
        {
            var manager = new GameManager();
            var result = manager.AppTest("H11");

            Assert.That(result, Is.EqualTo(ShipResult.InvalidOffGrid));
        }
            
        [Test]
        public void InvalidOverlap()
        {
            var manager = new GameManager();
            manager.AppTest("B9");
            var result = manager.AppTest("B9");

            Assert.That(result, Is.EqualTo(ShipResult.InvalidOverlap));
        }

        //[Test]
        //public void CheckVertical()
        //{
        //    var appManager = new Coordinates();
        //    var manager = TestManager();
        //    var assigning = appManager.CheckHorizontalOrVertical(manager.Grid, "C4", "V");
            
        //    Assert.That(assigning, Is.EqualTo(manager.Grid[3, 4]));
        //}
    }
}