using System;
namespace ActivitatsT3
{
    public class WheeledVehicle : Vehicles
    {
        public int WheelSize { get; set; }
        public WheeledVehicle(string name, string color, int wheelSize) : base(name, color)
        {
            WheelSize = wheelSize;
        }
        public WheeledVehicle(string name, int wheelSize) : base(name)
        {
            WheelSize = wheelSize;
        }
    }
}