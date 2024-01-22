using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.Interface
{
    public interface IPlayer
    {
        bool IsHuman { get; set; }
        int ShipPlacementChoice();
    }
}
