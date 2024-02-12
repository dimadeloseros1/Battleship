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
        public string[] ShipArray { get; set; } = new string[17];
       
        public int Size { get; set; }
        


        /// <summary>
        /// This method displays the current ship that the user has to input in the game board
        /// </summary>
        /// <param name="shipName">Enum of the current ship</param>
        public void DisplayShipInputMessage(ShipName shipName)
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
                    Console.WriteLine("Ship to place: Crsuier | Size: 3");
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
            }
        }

        


        public string ChooseVerticalOrHorizontal(string message, ShipName shipName)
        {
            do
            {
            string input = ConsoleIO.GetRequiredCoordinate(message);
                if (input == "H")
                {
                    for (int i = 0; i <= (int)shipName; i++)
                    {

                    }
                }
                
            } while (true);
        }
        
    }
    
}
