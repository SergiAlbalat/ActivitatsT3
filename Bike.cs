using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public class Bike : WheeledVehicle
    {
        public int GearNumber { get; set; }
        public Bike(string name, string color, int wheelSize, int gearNumber) : base(name, color, wheelSize)
        {
            GearNumber = gearNumber;
        }
        public Bike(string name, int wheelSize, int gearNumber) : base(name, wheelSize)
        {
            GearNumber = gearNumber;
        }
    }
}