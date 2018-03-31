using System;
using TelBot.Models;

namespace TelBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
            System.Console.WriteLine($"{game._currentRoom.Context}");

            //Showing the Lobby
            System.Console.WriteLine("Ready?");
            {
                //Player Options

                while (game.Playing)
                {
                System.Console.WriteLine("What would you like to do?");
                var userChoice = Console.ReadLine();

                    switch (userChoice)
                    {
                        case "help":
                            // General options including current room items
                            System.Console.WriteLine("Well if your curious then try North, South, East or West.");
                            break;
                        case "Look":
                            // Current user get current room context
                            game._currentRoom.ShowContext();
                            break;
                        case "take":
                            var itemName = Console.ReadLine();
                            game.TakeItem(itemName);
                            // Current user takes item in current room
                            // game.TakeItem(currentRoom.item);
                            break;
                        case "use":
                            string itemToUse = Console.ReadLine();
                            game.UseItem(itemToUse);
                            break;
                        case "backpack":
                            foreach (var item in game._currentUser.Backpack)
                            {
                                Console.WriteLine(item.Name);
                            }
                            break;
                        case "go":
                            System.Console.WriteLine("Which Way?");
                            var direction = Console.ReadLine();
                            if (game._currentRoom.Exits.ContainsKey(direction))                         //Checking if there is exits
                            {
                              game.Exit_Room(direction);
                                       //then set new room to current room
                            }
                            else
                            {
                                Console.WriteLine("You just bounced your head off the wall, good job.");
                            }
                            break;
                        default:
                            Console.WriteLine("Dieing...");
                            break;
                    }    //game.play loop

                }


            }

        }
    }
}