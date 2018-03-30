using System;
using System.Collections.Generic;
using TelBot;
using TelBot.Models;

namespace TelBot.Models
{
    public class Game
    {
        public CurrentUser _currentUser { get; set; }
        public Room _currentRoom { get; set; }
        public void StartGame()
        {
            //Main Introduction
            Console.Clear();
            Console.WriteLine("Welcome to Tel-Bot");
            Console.WriteLine("We here at Tel-Bot have developed neural networks to take care of the simiplest life task to increase your enjoyment of life");
            Console.WriteLine("Why work harder when Tel-Bot can do it for you?");
            CreateCurrentUser();
        }
        private void CreateCurrentUser()
            {
                Console.WriteLine("What is your name?");
                _currentUser = new CurrentUser(Console.ReadLine());
                Console.WriteLine("Welcome to Tel-Bot " + _currentUser.Name);
                Console.ReadLine();
            }

            public void Move()
            {
                if (_currentRoom.Exits = _currentUser.Move)
            }
            else
            {
                Console.WriteLine("Invalid direction");
            };
        public void ShowRoomContext()
            {
                System.Console.WriteLine(_currentRoom.Title);
                System.Console.WriteLine(_currentRoom.Context);
                string exitText = string.Join(", ", _currentRoom.Exits.Keys);
                if (string.IsNullOrEmpty(exitText))
                {
                    exitText = "None";
                }
                System.Console.WriteLine("Exits: " + exitText);
            }
        public void Setup()
        {
            Room outside = new Room()
            {
                Title = "Outside",                                  //Main floor & outside of the building
                Context = "You are excited and worried. Everything is on you to succeed. You are standing in front of the Cosy Toad Twerks, Now known as Tel-Bot. A man in a suit with a camoflague baseball hat comes up to you and starts tellin you about the perfect wine he had with his meal. He tells you how he herd about this app, Through the Grapvine. You can not stop watching the dancing peice of broccoli stuck in his teeth as he talks. Finially he passes out and falls into the bushes out rolls a Mountain Dew can."
                
            };
            Room hallway = new Room()
            {
                Title = "Hallway",                                  //Main floor
                Context = "This is a short hallway with a non-working elevator to the west of you and along the east wall is a stairwell and a framed picture of a cat with an eyepatch on the wall. Underneight it has a plack says in memory of Chuck.",
                //Enter from the South
            };
            Room lobby = new Room()
            {
                Title = "Lobby",                                    //Main floor
                Context = "You are in a entrence way with a sitting area to the west. With a closed door that has pieces of pinnapple smashed on it. You can just barely make out the name Zach on the door. There is a low moaning sound coming from the room. To your east is a sliding glass window and a closed door. Looking through the glass you see an messy office with stale donuts in a box from Bryce Holes, a local pastry shop. You see that the computer is running.",
                //Enter from the South
            };
            Room securityStation = new Room()
            {
                Title = "Security Station",                         //Main floor
                Context = "You are in an office full of monitors displaying different parts of the building. One monitor seems to be tracking people with a Meet Me app. As you watch the people are working their way toward a coffee shop from different directions. Then one of the people just disapper... at that moment you here a crash as a man falls out of a closet in the corner. He is covered ham and pinnapple. His skin is pale and realize you need to get away from him as fast as possible.",
                //Enter from the East
            };
            Room stairWell = new Room()
            {
                Title = "Stair Well",                               //Main floor to Second Floor
                Context = "You are in a dark strair well with empty beer bottles and papers thrown about. On one of the papers you can read the words Brew Bros, apparently a beer app for 'hunks'. There are bodies laying all over the stairs. There all must have worked there because they all have the same black shirts on. As you work your way up the stair and make it to a second floor doorway you hear a loud noise coming from above. You see a man with a blue baseball hat on backwards, expression of panic on his face, holding a garbage can lid as a shield in one hand and a 3D printed Zelda sword in the other. Waving it franicly above his head he charges down the stairs toward you.",
                //Enter from the West
            };
            // Room managerOffice = new Room()
            // {
            //     Title = "Manager Office",                        //Second Floor 
            //     Context = "Replace with description content",
            //     Exits = ""                                       //Enter from your west
            // };
            Room frontOffice = new Room()
            {
                Title = "Front Office",                             //Main floor
                Context = "You are in the front office. The computer is running a beat-box app. You find your head starts to bob with the rythem. Then your hips start to swing back and forth. As you start really get into it you lose your balance fall into the box of donuts. As you get up one Boston Cream donut seems to be stuck in a very uncomfortable and personal area. You remove the donut and look at your fingure and wonder 'How stale is this donut?' Then the beat changes and you start to tap your foot again.",
                                                                    //Enter from the West
            };
            Room secondHall = new Room()
            {
                Title = "Second Floor Hallway",                     //Secong Floor Exit into hallway turn to face north.
                Context = "You are in a hallway on the second floor. You smell Pizza and find boxes and boxes of pizza. You start eating and eating and slowly fad into a food comma. That is unless you downloaded up your beat-box jam app from JRR-Tunes."
                //Enter from your West
            };
            //Exits to rooms
            outside.Exits.Add("north", lobby);

            lobby.Exits.Add("south", outside);
            lobby.Exits.Add("north", hallway);
            lobby.Exits.Add("east", securityStation);
            lobby.Exits.Add("west", frontOffice);
            lobby.Item.Add("Donut", _currentRoom; 

            securityStation.Exits.Add("west", lobby);
            securityStation.Item.Add("Meet_Me_app", _currentUser);

            frontOffice.Exits.Add("east", lobby);
            frontOffice.Item.Add("Beat_Box_app", _currentUser);

            // hallway.Exits.Add(Directions.East, elevator);
            hallway.Exits.Add("west", stairWell);
            hallway.Exits.Add("south", lobby);
            hallway.Item.Add("Picture_of_Chuck", _currentRoom);

            stairWell.Exits.Add("east", secondHall);
            stairWell.Exits.Add("west", hallway);
            stairWell.Item.Add("Beer_Bros_app", item._currentRoom);

            // secondHall.Exits.Add(Directions.West1, office1);
            // secondHall.Exits.Add(Directions.West2, office2);
            // secondHall.Exits.Add(Directions.East1, office5);
            // secondHall.Exits.Add(Directions.East2, office6);
            //8 offices, 1 closet, 1 files room to be added.

            
        
                _currentRoom = outside;
        }


        //Adding item to backpack
        public void Add(Item)
        {
            System.Console.WriteLine("You feel the increased weight in your backpack.");
            var BackPack = Items();
        }
        //Removing item from backpack
        public void Drop(Item)
        {
            System.Console.WriteLine("Your Backpack feels lighter");
            var BackPack = Items();
        }
    }
}

