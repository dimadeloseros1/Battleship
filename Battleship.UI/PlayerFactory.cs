using Battleship.UI.Implementations;
using Battleship.UI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.UI
{
    /// <summary>
    /// This is the Factory class which will be prompted to the user once the application starts in the program class
    /// The program will prompt the user to choose between Human or Computer player
    /// </summary>
    public static class PlayerFactory
    {
        public static IPlayer ChoosePlayerImplementation(string promt)
        {
            IPlayer game;
            string choice = Console.ReadLine().ToUpper();
            do
            {
                Console.Write(promt);
                if (choice == "H")
                {
                    game = new PlayerImpl();
                    break;
                }
                else if (choice == "C")
                {
                    game = new ComputerImpl();
                    break;
                }
                Console.WriteLine("Make sure that the input is either H or C");
            } while (true);
            return game;
        }
    }
}
