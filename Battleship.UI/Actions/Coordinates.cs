using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.Actions
{
    public class Coordinates
    {
        public string[] Letters { get; set; } = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        public int GameCoordinates { get; set; } = 10;
        public string[,] Grid { get; set; } = new string[10, 10];


        public void DisplayCoordinates(string userInput)
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
        }
    }
}
