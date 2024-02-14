using Battleship.UI.DTOs;
using Battleship.UI.Enums;
using Battleship.UI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.Actions
{
    /// <summary>
    /// 1: We will create an array that will contain the cordinates.
    /// 2: We will create 2 loops. First loop will run through the number cordinates. Second array will be an inner array inside the first cordinate array that will contain the letters.
    /// </summary>
    public class Ship
    {
        PlayerData data = new PlayerData();
        public string[] ShipArray { get; set; } = new string[17];

        public int Size { get; set; }



        /// <summary>
        /// This method displays the current ship that the user has to input in the game board
        /// </summary>
        /// <param name="shipName">Enum of the current ship</param>
        public int DisplayShipInputMessage(ShipName shipName)
        {
            int size;
            switch (shipName)
            {
                case ShipName.AircraftCarrier:
                    Console.WriteLine("Ship to place: Aircraft Carrier | Size: 5");
                    size = 5;
                    data.ShipSymbol = "A";
                    break;
                case ShipName.Battleship:
                    Console.WriteLine("Ship to place: Battleship | Size: 4");
                    size = 4;
                    data.ShipSymbol = "B";
                    break;
                case ShipName.Cruiser:
                    Console.WriteLine("Ship to place: Cruiser | Size: 3");
                    size = 3;
                    data.ShipSymbol = "C";
                    break;
                case ShipName.Submarine:
                    Console.WriteLine("Ship to place: Submarine | Size: 3");
                    size = 3;
                    data.ShipSymbol = "S";
                    break;
                case ShipName.Destroyer:
                    Console.WriteLine("Ship to place: Destroyer | Size: 2");
                    size = 2;
                    data.ShipSymbol = "D";
                    break;
                default:
                    size = 0;
                    break;
            }
            return size;
        }




        //public string ChooseVerticalOrHorizontal(string message, ShipName shipName, string[] shipGrid)
        //{
        //    do
        //    {
        //        string input = ConsoleIO.GetRequiredCoordinate(message);
        //        if (input == "H")
        //        {
        //            for (int i = 0; i < Size; i++)
        //            {

        //                shipGrid[i] = data.ShipSymbol;
        //            }
        //            break;
        //        }
        //        else if (input == "V")
        //        {

        //        }

        //    } while (true);
        //}

    }

}
