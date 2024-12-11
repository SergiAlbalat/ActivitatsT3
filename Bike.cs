using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public class Bike
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int WheelSize { get; set; }
        public int GearNumber { get; set; }
        public Bike(string name, string color, int wheelSize, int gearNumber)
        {
            Name = name;
            Color = color;
            WheelSize = wheelSize;
            GearNumber = gearNumber;
        }
    }
}