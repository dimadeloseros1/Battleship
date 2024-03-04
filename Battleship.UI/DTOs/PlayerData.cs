using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.DTOs
{
    public  class PlayerData
    {
        public string UserName { get; set; }
        public string ShipSymbol { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
    }
}
