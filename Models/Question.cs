using System;

namespace TelBot.Models
{ 
    class Question
    {
        public Boolean TakeItem { get; set; }
        public Boolean DropItem { get; set; }
        public Boolean OpenDoor { get; set; }
        public String Direction { get; set; }

        // public TakeItem takeItem { get; set; }      //TODO: Build the Action
        // public DropItem dropItem { get; set; }      //TODO: Build the Action
        // public OpenDoor openDoor { get; set; }      //TODO: Build the Action
        // public Direction direction { get; set; }    
    }
}    