using Battleship.UI.Actions;
using Battleship.UI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.Workflow
{
    public class App
    {
        public void AppTest()
        {
            string[,] grid = ConsoleIO.Grid;
            Coordinates coordinate = new Coordinates();
            string input = ConsoleIO.GetRequiredCoordinate("Enter the starting coordinate (ex: A5): ");
            string inputs = coordinate.DisplayCoordinates(input, grid);

            coordinate.CheckHorizontalOrVertical(ShipName.Battleship, inputs, grid);
            ConsoleIO.DisplayGrid();
        }

    }
}
