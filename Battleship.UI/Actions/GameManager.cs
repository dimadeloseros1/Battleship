﻿using Battleship.UI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.Actions
{
    public class GameManager
    {
        

        public void Run()
        {
            Coordinates coordinate = new Coordinates();
            string input = ConsoleIO.GetRequiredCoordinate("Enter the starting coordinate (ex: A5): ");
            string inputs = coordinate.DisplayCoordinates(input);

            coordinate.CheckHorizontalOrVertical(ShipName.AircraftCarrier, inputs);
            coordinate.DisplayGrid();
            
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
