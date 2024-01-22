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
        public string ShipPlacement(string letter, int cordinate)
        {
            int numArr = 10;
            string[] letterArr = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

            for (int i = 1; i <= numArr; i++)
            {
                for (int k = 0; k < letterArr.Length; k++)
                {
                    int.Parse(letter);
                }
            }
            return letter + cordinate;
        }
    }
}
