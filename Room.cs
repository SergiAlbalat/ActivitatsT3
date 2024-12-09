using System;
namespace ActivitatsT3
{
    public class Room
    {
        public int Surface { get; set; }
        public string Type { get; set; }
        public Room(int surface, string type)
        {
            this.Surface = surface;
            this.Type = type;
        }
    }
}
