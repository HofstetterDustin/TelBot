using System.Collections.Generic;
using TelBot;

namespace TelBot.Models
{
    public class CurrentUser
    {
        public string Name { get; set; }
        
        public List<Item> Backpack = new List<Item>();

        public CurrentUser(string name)
        {
            Name = name;
        }
    }
}