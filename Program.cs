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
            var playing = true;
            while (playing)     //game.play loop
            game.ShowRoomContext();

//Showing the Lobby
            System.Console.WriteLine("Ready?");
            {
                System.Console.WriteLine("What would you like to do?");
                var userChoice = Console.ReadLine();
                //Player Options
            switch (userChoice)
            {
                case "help":
//General options including current room items
                    System.Console.WriteLine("Well if your curious then try North, South, East or West." + currentRoom.items);
                    break;
                case "look":
//Current user get current room context
                    game._currentUser ShowRoomContext();
                    break;
                case "takeItem":
//Current user takes item in current room                 
                    game._currentUser.takeItem(currentRoom.item);
                    break;
                case "dropItem":
                    game._currentUser.DropItem(currentRoom.item);
                        for (int i = 0; i < length; i++)            //look through the backpack 
                    {
                        if (itemInBackpack == i)                    //find item by keyword
                            delete(itemInBackPack)                  //remove item the matches keyword from backpack list
                        }
                    Console.WriteLine("You have dropped {itemInBackPack}");
                    break;
                case "backPack":
                   game._currentUser.BackPack()
                        foreach (var item in backPack)
                    {
                        Console.WriteLine<List>(backPack)
                        }
                    break;
                case "go":
                    System.Console.WriteLine("Which Way?");
                    var direction = Console.ReadLine();

                    if (_currentRoom.Exits.ContainsKey(direction))                         //Checking if there is exits
                    {
                        //iterate over the array of possible moves

                        //assign i to exits
                        //if exits and direction match...
                        _currentRoom = _currentRoom.Exits[direction];          //then set new room to current room
                    }
                    else
                    {
                        Console.WriteLine("You just bounced your head off the wall, good job.");
                    }
                    break;
                default:
                    Console.WriteLine("Thinking...");
                    break;

            }

           
        }







        
    }
}
