using Battleship.UI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.Implementations
{
    public class ComputerImpl : IPlayer
    {
        public bool IsHuman { get; set; } = false;
        public int ShipPlacementChoice()
        {
            return 0;
        }
    }
}
