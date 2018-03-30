using System;
using System.Collections.Generic;
using TelBot;

namespace TelBot.Models
{
    public class Room
    {
        public String Title { get; set; }
        public String Context { get; set; }
        public Items Item { get; set; }
        public Dictionary<string, Room> Exits = new Dictionary<string, Room>();


        // public Room(string title, string context, string )
        // {
        //     Title = title;
        //     Context = context;
        // }
    }
}