using System;
namespace ActivitatsT3
{
    public class Boat : Vehicles
    {
        public int SailSize {  get; set; }
        public Boat(string name, string color, int sailsize) : base(name, color)
        {
            SailSize = sailsize;
        }
        public Boat(string name, int sailsize) : base(name)
        {
            SailSize = sailsize;
        }
    }
}