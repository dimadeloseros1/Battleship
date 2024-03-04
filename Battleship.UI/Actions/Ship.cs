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
        /// Note ShipSymbol won't work so that method is just have to be another one with the type of string in order to pass it then later on to the grid 
        /// </summary>
        /// <param name="shipName">Enum of the current ship</param>
        public int DisplayShipInputMessage(ShipName shipName)
        {
            switch (shipName)
            {
                case ShipName.AircraftCarrier:
                    Console.WriteLine("Ship to place: Aircraft Carrier | Size: 5");
                    Size = 5;
                    break;
                case ShipName.Battleship:
                    Console.WriteLine("Ship to place: Battleship | Size: 4");
                    Size = 4;
                    break;
                case ShipName.Cruiser:
                    Console.WriteLine("Ship to place: Cruiser | Size: 3");
                    Size = 3;
                    break;
                case ShipName.Submarine:
                    Console.WriteLine("Ship to place: Submarine | Size: 3");
                    Size = 3;
                    break;
                case ShipName.Destroyer:
                    Console.WriteLine("Ship to place: Destroyer | Size: 2");
                    Size = 2;
                    break;
                default:
                    Size = 0;
                    break;
            }
            return Size;
        }

        public string DisplayEachShipLetter(ShipName ship)
        {
            switch (ship)
            {
                case ShipName.AircraftCarrier:
                    data.ShipSymbol = "A";
                    break;
                case ShipName.Battleship:
                    data.ShipSymbol = "B";
                    break;
                case ShipName.Submarine:
                    data.ShipSymbol = "S";
                    break;
                case ShipName.Cruiser:
                    data.ShipSymbol = "C";
                    break;
                case ShipName.Destroyer:
                    data.ShipSymbol = "D";
                    break;
                default:
                    data.ShipSymbol = " ";
                    break;
            }
            return data.ShipSymbol;
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
