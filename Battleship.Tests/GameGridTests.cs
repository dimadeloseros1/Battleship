using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Tests
{
    public class GameGridTests
    {
        public string[,] Grid { get; set; } = new string[10, 10];
        public string[] Letters { get; set; } = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        public int Coordinates { get; set; } = 10;

        public string DisplayGrid(string userInput)
        {
            int columnIndex = Array.IndexOf(Letters, userInput[0].ToString());
            int rowIndex = int.Parse(userInput.Substring(1)); // Subtract 1 because array indices start from 0

            // Assign the userInput to the corresponding cell in the grid
            for (int i = 0; i < Coordinates; i++)
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
    }
}
