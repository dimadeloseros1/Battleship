using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.Enums
{
    public enum ShipName
    {
        AircraftCarrier,
        Battleship,
        Cruiser,
        Submarine,
        Destroyer 
    }

    public enum ShipResult
    {
        Hit,
        Miss,
        Sunk,
        Placed,
        InvalidOffGrid,
        InvalidOverlap
    }
}
