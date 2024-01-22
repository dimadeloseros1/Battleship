using Battleship.UI;
using Battleship.UI.Actions;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Battleship.Tests
{
    [TestFixture]
    public class GamTests
    {
        public Ship ShipManager()
        {
            return new Ship();
        }


        [Test]
        public void ShipCordinate()
        {
            var manager = ShipManager();
            var result = manager.ShipPlacement("A", 3);

            ClassicAssert.IsNotNull(result);
        }
    }
}