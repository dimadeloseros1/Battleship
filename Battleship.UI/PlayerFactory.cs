//using Battleship.UI.Actions;
//using Battleship.UI.Implementations;
//using Battleship.UI.Interface;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Battleship.UI
//{
//    /// <summary>
//    /// This is the Factory class which will be prompted to the user once the application starts in the program class
//    /// The program will prompt the user to choose between Human or Computer player
//    /// </summary>
//    public static class PlayerFactory
//    {
//        public static IPlayer ChoosePlayerImplementation(string promt)
//        {
//            IPlayer player;

//            do
//            {
//                Console.Write(promt);
//                string input = Console.ReadLine().ToUpper();

//                if (!string.IsNullOrEmpty(input))
//                {
//                    if (input == "H")
//                    {
//                        player = new PlayerImpl();
//                        break;
//                    }
//                    else if (input == "C")
//                    {
//                        player = new ComputerImpl();
//                        break;
//                    }
//                    Console.WriteLine("Make sure that the input is either H or C");
//                }
//                Console.WriteLine("Make sure that the input has at least one character.");
//            } while (true);

//            return player;
//        }
//    }
//}
