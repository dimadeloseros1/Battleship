using Battleship.UI.DTOs;
using Battleship.UI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.Actions
{
    public class GameManager
    {
        Coordinates cord = new Coordinates();
        PlayerData data = new PlayerData();
        public ShipResult AppTest(string userInput)
        {
            data.ColumnIndex = Array.IndexOf(cord.Letters, userInput[0].ToString());
            string inputWithoutFirstChar = userInput.Substring(1);
            if (!string.IsNullOrEmpty(inputWithoutFirstChar) && int.TryParse(inputWithoutFirstChar, out int rowIndex))
            {
                data.RowIndex = rowIndex - 1;
            }
            else
            {
                Console.WriteLine("Input a correct string");
            }

            if (!InvalidOutOfGrid(data.RowIndex))
            {
                return ShipResult.InvalidOffGrid;
            }

            if (InvalidOverlap(data.ColumnIndex, data.RowIndex))
            {
                return ShipResult.InvalidOverlap;
            }

            ConsoleIO.Grid[data.ColumnIndex, data.RowIndex] = userInput;
            return ShipResult.Placed;
        }

        public bool InvalidOutOfGrid(int rowIndex)
        {
            return rowIndex >= 0 && rowIndex < cord.GameCoordinates;
        }

        public bool InvalidOverlap(int columnIndex, int rowIndex)
        {
            //return !string.IsNullOrEmpty(ConsoleIO.Grid[columnIndex, rowIndex]);
            return ConsoleIO.Grid[columnIndex, rowIndex] == null;
        }


        
    }

    //public void Number()
    //{
    //    string input;
    //    int total = 0;
    //    do
    //    {
    //        Console.Write("Enter a number (Q to quit): ");
    //        input = Console.ReadLine().ToUpper();

    //        if (int.TryParse(input, out int num))
    //        {
    //            if (num < 0)
    //            {
    //                total -= Math.Abs(num);
    //            }
    //            else
    //            {
    //                total += num;
    //            }
    //        }
    //    } while (input != "Q");
    //    Console.WriteLine(total);
    //}
}
