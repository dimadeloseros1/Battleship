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
        private GameManager manager = new GameManager();
        Ship ships = new Ship();
        public void TestingApp()
        {
            do
            {
                var shipsToPlace = new List<ShipName> { ShipName.AircraftCarrier, ShipName.Battleship, ShipName.Cruiser, ShipName.Submarine, ShipName.Destroyer };

                foreach (ShipName shipsName in shipsToPlace)
                {
                    ConsoleIO.DisplayGrid();

                    string[,] grid = ConsoleIO.Grid;
                    Coordinates coordinate = new Coordinates();
                    int size = ships.DisplayShipInputMessage(shipsName);
                    var input = ConsoleIO.GetRequiredCoordinate("Enter the starting coordinate (ex: A5): ");
                    //var inputs = coordinate.DisplayCoordinates(input, grid);
                    string verOrHor = ConsoleIO.GetRequiredCoordinate("Please choose either V or H: ");



                    // Idea to add a fourth paramether to CheckHorizontalOrVertical method
                    //var methodCoordinate = coordinate.DisplayCoordinates(input, grid);
                    var methodCoordinate = coordinate.CheckHorizontalOrVertical(grid, input, verOrHor, size);
                    var result = manager.AppTest(methodCoordinate);

                    if (result == ShipResult.InvalidOffGrid || result == ShipResult.InvalidOverlap)
                    {
                        ConsoleIO.ShipMessage(result);
                        continue;
                    }

                    if (result == ShipResult.Sunk)
                    {
                        ConsoleIO.ShipMessage(result);
                        ConsoleIO.DisplayGrid();
                        break;
                    }
                    if (shipsName == ShipName.Destroyer)
                    {
                        break;
                    }
                    ConsoleIO.ShipPlacementMessage(shipsName);
                    ConsoleIO.AnyKey();
                }
            } while (true);
        }

    }
}
