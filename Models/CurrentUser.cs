using System.Collections.Generic;
using TelBot;

namespace TelBot.Models
{
    public class CurrentUser
    {
        public string Name { get; set; }
        
        public List<Items> Backpack = new List<Items>();

        public CurrentUser(string name)
        {
            Name = name;

        }
    }
}