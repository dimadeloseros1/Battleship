using Battleship.UI.DTOs;
using Battleship.UI.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.Actions
{
    public class Coordinates
    {
        public string[] Letters { get; set; } = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        public int GameCoordinates { get; set; } = 10;

        public int Size { get; set; }

        Ship ships = new Ship();
        PlayerData data = new PlayerData();
        ShipName ship = ShipName.Battleship;


        public string DisplayCoordinates(string userInput, string[,] gameGrid)
        {
            int columnIndex = Array.IndexOf(Letters, userInput[0].ToString());
            int rowIndex = int.Parse(userInput.Substring(1));

            for (int i = 1; i <= GameCoordinates; i++)
            {
                for (int k = 0; k < Letters.Length; k++)
                {
                    if (columnIndex > k && rowIndex > GameCoordinates)
                    {
                        Console.WriteLine("Make sure that the input is either A to J and between 1 and 10");
                        continue;
                    }
                    else if (columnIndex == k && rowIndex == i)
                    {
                        gameGrid[k, i - 1] = userInput;
                    }
                }
                Console.WriteLine();
            }
            return userInput;
        }

        public string CheckHorizontalOrVertical(string[,] gameGrid, string userInput, string input, int size)
        {
            string letter = ships.DisplayEachShipLetter(ship);

            var column = data.ColumnIndex;
            var row = data.RowIndex;

            column = Array.IndexOf(Letters, userInput[0].ToString());
            row = int.Parse(userInput.Substring(1)) - 1;

            do
            {
                if (input == "V")
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (row + i < GameCoordinates)
                        {
                            gameGrid[column, row + i] = letter;
                        }
                        else
                        {
                            Console.WriteLine("Index is outside of the array");
                        }
                    }
                    break;
                }
                else if (input == "H")
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (column + i < Letters.Length)
                        {
                            gameGrid[column + i, row] = letter;
                        }
                        else
                        {
                            Console.WriteLine("Index is outside of the array");
                        }
                    }
                    break;
                }
                Console.WriteLine("Please choose either V or H");
            } while (true);
            return userInput;
        }
    }
}