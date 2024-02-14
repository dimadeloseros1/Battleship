using Battleship.UI.DTOs;
using Battleship.UI.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Battleship.UI.Actions
{
    public class Coordinates
    {
        public string[] Letters { get; set; } = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        public int GameCoordinates { get; set; } = 10;
        public string[,] Grid { get; set; } = new string[10, 10];
        public int Size { get; set; }

        Ship ships = new Ship();
        PlayerData data = new PlayerData();


        public string DisplayCoordinates(string userInput)
        {
            int columnIndex = Array.IndexOf(Letters, userInput[0].ToString());
            int rowIndex = int.Parse(userInput.Substring(1));

            for (int i = 1; i <= GameCoordinates; i++)
            {
                for (int k = 0; k < Letters.Length; k++)
                {
                    string coordinate = $"{Letters[k]}{i}";
                    if (columnIndex == k && rowIndex == i)
                    {
                        Grid[k, i - 1] = userInput;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write($"{coordinate}");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            return userInput;
        }

        public void CheckHorizontalOrVertical(ShipName ship, string userInput)
        {
            int size = ships.DisplayShipInputMessage(ship);

            string input;
            do
            {
                input = ConsoleIO.GetRequiredCoordinate("Please choose V or H: ");
                if (input == "V")
                {
                    for (int i = 0; i < size; i++)
                    {
                        Grid[i, 0] = userInput;
                    }
                    break;
                }
                else if (input == "H")
                {
                    for (int i = 0; i < size; i++)
                    {
                        Grid[0, i] = userInput;
                    }
                    break;
                }
            } while (true);
        }

        public void DisplayGrid()
        {
            for (int i = 1; i < GameCoordinates; i++)
            {
                for (int j = 0; j < Letters.Length; j++)
                {
                    Console.Write(Grid[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
