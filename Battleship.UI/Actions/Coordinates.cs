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



        public string DisplayCoordinates(string userInput, string[,] gameGrid)
        {
            int columnIndex = Array.IndexOf(Letters, userInput[0].ToString());
            int rowIndex = int.Parse(userInput.Substring(1));

            for (int i = 1; i <= GameCoordinates; i++)
            {
                for (int k = 0; k < Letters.Length; k++)
                {
                    if (columnIndex == k && rowIndex == i)
                    {
                        gameGrid[k, i - 1] = userInput;
                    }
                }
                Console.WriteLine();
            }
            return userInput;
        }

        public string CheckHorizontalOrVertical(ShipName ship, string userInput, string[,] gameGrid)
        {
            int size = ships.DisplayShipInputMessage(ship);
            string letter = ships.DisplayEachShipLetter(ship);
            string input;
            do
            {
                input = ConsoleIO.GetRequiredCoordinate("Please choose V or H: ");
                if (input == "V")
                {
                    for (int i = 0; i < size; i++)
                    {
                        gameGrid[i, 0] = letter;
                    }
                    break;
                }
                else if (input == "H")
                {
                    for (int i = 0; i < size; i++)
                    {
                        gameGrid[0, i] = letter;
                    }
                    break;
                }
                Console.WriteLine("Please choose either V or H");
            } while (true);
            return userInput;
        }
        

    }
}
