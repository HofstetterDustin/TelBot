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
        public Directions _directions { get; set; }
        public bool Playing { get; set; } = true;
        public void StartGame()
        {
            //Main Introduction
            Console.Clear();
            Setup();
            Console.WriteLine("Welcome Player");
            Console.WriteLine(@"
            You fall out of a taxi as it pulls fishtails to a stop up against the curb. 
            The taxi driver is talking to you thru the window of the taxi 
            
            Taxi Driver:   'You good?    Yes, no, maybe so?' 
            Player:        'You say your fine.' 
            Taxi Driver:   'You need to be more careful.' 
            
            You hand him a twenty 
            Player:        'You have change for a twenty?' 
            Taxi Drive:    'Good, good, good' 

            Taxi driver drives off.");
           
            Console.WriteLine(@"
            You turn around and face the building. You notice two women walking out of the building quickly. 

            The girls run into you. The impact causes them to drop a bag to the ground.
            The bag spills out Butter Fingers candy bars all over the sidewalk. They were obvously smuggling them out. 

            They stop and start picking them up in a hurried manner, with a look of guilt across their faces. 
            They say ");
            CreateCurrentUser();
        }
        private void CreateCurrentUser()
        {
            Console.WriteLine(@"
            We're sorry, who are you?");
            _currentUser = new CurrentUser(Console.ReadLine());
            Console.WriteLine(@"
            I'm ok, my name is " + _currentUser.Name);
            Console.WriteLine(@"
            The women finish gathering the candy bars. As the women walk away they say
            Women: 'Be careful in there.' ");

            string input = "";
            Console.WriteLine(@"
            What do you want to do? Look or Quit?");
            input = Console.ReadLine();
            // if (input == "Look")
            // {
            //     _currentRoom.ShowContext();
            // }
            // else
            // {
            //     Console.WriteLine(@"
            //     You hear tires squealing as you look up. A white Dodge car jumps the curb. For a moment time slows and you plainly see a young women eyes wide open in fear as her phone float in mid air as she plows into you. 
                
            //     Emence pain as you lay on the ground with your own heel laid up beside your cheek. For a breif moment before you passout you see those two girls thowing Butter Finger cardy bars at you motionless body. 
                
            //     Pass-a-fist Death by Butter Finger, Broken Legs, No Defense.");
            // }
        }

        internal void UseItem(string itemToUse)
        {
            var item = _currentUser.Backpack.Find(i => i.Name == itemToUse);
            if (item == null)
            {
                System.Console.WriteLine("Bad Item");
                return;
            }

            if (item.Name == "beatbox" && _currentRoom.Title == "stairs")
            {
                
            }



        }

        internal void TakeItem(string itemName)
        {
            var foundItem = _currentRoom.Items.Find(i => i.Name == itemName);
            if (foundItem == null)
            {
                System.Console.WriteLine("there is no " + itemName);
                return;
            }
            _currentUser.Backpack.Add(foundItem);
            _currentRoom.Items.Remove(foundItem);
        }

            public void Exit_Room(string direction)
            { 
            _currentRoom = _currentRoom.Exits[direction];
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
                Context = "You are in a dark strair well with empty beer bottles and papers thrown about. On one of the papers you can read the words Brew Bros, apparently a beer app for 'hunks'. There are bodies laying all over the stairs. There all must have worked there because they all have the same black shirts on. As you work your way up the stair and make it to a second floor doorway you hear a loud noise coming from above. You see a man with a blue baseball hat on backwards, expression of panic on his face, holding a garbage can lid as a shield in one hand and a 3D printed Zelda master sword in the other. Waving it franicly above his head he charges down the stairs toward you.",
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
            _currentRoom = outside;

            //Exits to rooms
            // Console.WriteLine("What you like to do?");
            outside.Exits.Add("north", lobby);

            lobby.Exits.Add("south", outside);
            lobby.Exits.Add("north", hallway);
            lobby.Exits.Add("east", securityStation);
            lobby.Exits.Add("west", frontOffice);
            lobby.Items.Add(new Item() { Name = "Donut" });

            securityStation.Exits.Add("west", lobby);
            securityStation.Items.Add(new Item() { Name = "Meet_Me_app" });

            frontOffice.Exits.Add("east", lobby);
            frontOffice.Items.Add(new Item() { Name = "Beat_Box_App" });

            // hallway.Exits.Add(Directions.East, elevator);
            hallway.Exits.Add("west", stairWell);
            hallway.Exits.Add("south", lobby);
            hallway.Items.Add(new Item() { Name = "Picture_of_Chuck" });

            stairWell.Exits.Add("east", secondHall);
            stairWell.Exits.Add("west", hallway);
            stairWell.Items.Add(new Item() { Name = "Beer_Bros_app" });

            // secondHall.Exits.Add(Directions.West1, office1);
            // secondHall.Exits.Add(Directions.West2, office2);
            // secondHall.Exits.Add(Directions.East1, office5);
            // secondHall.Exits.Add(Directions.East2, office6);
            //8 offices, 1 closet, 1 files room to be added.




        }


        //Adding item to backpack
        // public void Add(Item)
        // {
        //     System.Console.WriteLine("You feel the increased weight in your backpack.");
        //     var BackPack = Items();
        // }
        //Removing item from backpack
        // public void Drop(Item)
        // {
        //     System.Console.WriteLine("Your Backpack feels lighter");
        //     var BackPack = Items();
        // }
    }
}

