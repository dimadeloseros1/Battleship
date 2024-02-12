using Battleship.UI.Enums;
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
                Console.WriteLine(message);
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
        public static ShipName DisplayShipPlacementMessage()
        {
            foreach (var ships in Enum.GetValues(typeof(ShipName)))
            {
                return (ShipName)ships;
            }
            return ShipName.Submarine;
        }

        public static void AnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
