﻿using Battleship.UI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI.Actions
{
    public static class ConsoleIO
    {
        /// <summary>
        /// Shows the board game to the user before the game starts 
        /// </summary>
        /// 
        public static string[,] Grid { get; set; } = new string[10, 10];
        public static void ShowGrid()
        {
            Console.WriteLine("  A B C D E F G H I J");
            Console.WriteLine("1 - - - - - - - - - -");
            Console.WriteLine("2 - - - - - - - - - -");
            Console.WriteLine("3 - - - - - - - - - -");
            Console.WriteLine("4 - - - - - - - - - -");
            Console.WriteLine("5 - - - - - - - - - -");
            Console.WriteLine("6 - - - - - - - - - -");
            Console.WriteLine("7 - - - - - - - - - -");
            Console.WriteLine("8 - - - - - - - - - -");
            Console.WriteLine("9 - - - - - - - - - -");
            Console.WriteLine("10- - - - - - - - - -");
        }

        /// <summary>
        /// This method will prompt the user for the coordinate and a Horizontal or Vertical placement of the ship
        /// </summary>
        /// <returns>Returns the input of the user in the game board if it's more than 1 characther long.</returns>
        public static string GetRequiredCoordinate(string message)
        {
            do
            {
                Console.Write(message);
                string input = Console.ReadLine().Trim().ToUpper();

                // Check if the input is in the correct format (e.g., A7)
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }

                Console.WriteLine("Invalid input format. Please enter the coordinate in the format A7.");
            } while (true);
        }

        

        /// <summary>
        /// This method is probably useless, REMINDER
        /// </summary>
        public static ShipName LoopThroughShipNames()
        {
            foreach (var ships in Enum.GetValues(typeof(ShipName)))
            {
                return (ShipName)ships;
            }
            return ShipName.Submarine;
        }

        public static string CheckIfEmtpy(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                return "-";
            }
        }
        public static void DisplayGrid()
        {
            Coordinates cord = new Coordinates();

            for (int i = 1; i <= cord.GameCoordinates; i++)
            {
                for (int j = 0; j < cord.Letters.Length; j++)
                {
                    Console.Write($"{CheckIfEmtpy(Grid[j, i - 1]) + " "}");
                }
                Console.WriteLine();
            }
        }

        public static void ShipMessage(ShipResult result)
        {
            switch (result)
            {
                case ShipResult.InvalidOffGrid:
                    Console.WriteLine("Please place the ship inside the grid");
                    break;
                case ShipResult.InvalidOverlap:
                    Console.WriteLine("The ship currently overlaps");
                    break;
                case ShipResult.Placed:
                    Console.WriteLine("The ship has been placed");
                    break;
                case ShipResult.Hit:
                    Console.WriteLine("Something has been hit!");
                    break;
                case ShipResult.Miss:
                    Console.WriteLine("Miss!");
                    break;
                case ShipResult.Sunk:
                    Console.WriteLine("Boom! The ship has been sunk!");
                    break;
            }
        }

        public static void ShipPlacementMessage(ShipName result)
        {
            switch (result)
            {
                case ShipName.AircraftCarrier:
                    Console.WriteLine("You have plaed your Aircraft-Carried");
                    break;
                case ShipName.Battleship:
                    Console.WriteLine("You have plaed your Battleship");
                    break;
                case ShipName.Submarine:
                    Console.WriteLine("You have plaed your Submarine");
                    break;
                case ShipName.Cruiser:
                    Console.WriteLine("You have plaed your Cruiser");
                    break;
                case ShipName.Destroyer:
                    Console.WriteLine("You have plaed your Destroyer");
                    break;
            }
        }



        public static void AnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
