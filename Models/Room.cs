using System;
using System.Collections.Generic;
using TelBot;

namespace TelBot.Models
{
    public class Room
    {
        public String Title { get; set; }
        public String Context { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public Dictionary<string, Room> Exits = new Dictionary<string, Room>();

        public void ShowContext()
        {
            System.Console.WriteLine(Title);
            System.Console.WriteLine(Context);
            System.Console.WriteLine("Exits:");
            System.Console.WriteLine(String.Join(", ", Exits.Keys));

        }
    }
};