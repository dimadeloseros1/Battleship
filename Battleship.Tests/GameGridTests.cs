using Battleship.UI.DTOs;
using Battleship.UI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Tests
{
    public class GameGridTests
    {
        PlayerData data = new PlayerData();
        public string[,] Grid { get; set; } = new string[10, 10];
        public string[] Letters { get; set; } = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        public int Coordinates { get; set; } = 10;
        public int Size { get; set; }

        public string DisplayGrid(string userInput)
        {
            
            int columnIndex = Array.IndexOf(Letters, userInput[0].ToString());
            int rowIndex = int.Parse(userInput.Substring(1));
            // Assign the userInput to the corresponding cell in the grid
            for (int i = 1; i <= Coordinates; i++)
            {
                for (int k = 0; k < Letters.Length; k++)
                {
                    // Check if the current position matches the userInput position
                    if (k == columnIndex && i == rowIndex)
                    {
                        Grid[k, i - 1] = userInput;
                    }
                }
            }
            return userInput;
        }

        public void DisplayShipInputMessage(ShipName shipName)
        {
            switch (shipName)
            {
                case ShipName.AircraftCarrier:
                    Console.WriteLine("Ship to place: Aircraft Carrier | Size: 5");
                    Size = 5;
                    data.ShipSymbol = "A";
                    break;
                case ShipName.Battleship:
                    Console.WriteLine("Ship to place: Battleship | Size: 4");
                    Size = 4;
                    data.ShipSymbol = "B";
                    break;
                case ShipName.Cruiser:
                    Console.WriteLine("Ship to place: Crsuier | Size: 3");
                    Size = 3;
                    data.ShipSymbol = "C";
                    break;
                case ShipName.Submarine:
                    Console.WriteLine("Ship to place: Submarine | Size: 3");
                    Size = 3;
                    data.ShipSymbol = "S";
                    break;
                case ShipName.Destroyer:
                    Console.WriteLine("Ship to place: Destroyer | Size: 2");
                    Size = 2;
                    data.ShipSymbol = "D";
                    break;
            }

        }

        public void CheckHorizontalOrVertical(string userInput, ShipName ship)  
        {
            string input;
            int columnIndex = Array.IndexOf(Letters, userInput[0].ToString());
            DisplayShipInputMessage(ship);
            do
            {
                input = Console.ReadLine().ToUpper();
                if (!string.IsNullOrEmpty(input))
                {
                    if (input == "H")
                    {
                        for (int i = 0; i < Size; i++)
                        {
                            Grid[0, i] = data.ShipSymbol;
                        }
                        break;
                    }
                    else if (input == "V")
                    {
                        for (int i = 0; i < Size; i++)
                        {
                            Grid[i, 0] = data.ShipSymbol;
                        }
                        break;
                    }
                }
                Console.WriteLine("Make sure that the input is at least one charachter long");
            } while (true);
        }
    }
}
