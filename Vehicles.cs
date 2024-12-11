using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public class Vehicles
    {
        public string Name {  get; set; }
        public string Color { get; set; }
        public Vehicles(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public Vehicles(string name) : this(name, "white") { }
    }
}