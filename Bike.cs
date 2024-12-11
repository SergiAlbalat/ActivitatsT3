using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public class Bike : Vehicles
    {
        public int WheelSize { get; set; }
        public int GearNumber { get; set; }
        public Bike(string name, string color, int wheelSize, int gearNumber) : base(name, color)
        {
            WheelSize = wheelSize;
            GearNumber = gearNumber;
        }
    }
}