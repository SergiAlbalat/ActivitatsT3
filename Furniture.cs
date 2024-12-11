using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public class Furniture
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public Furniture(string name, string color, string description)
        {
            Name = name;
            Color = color;
            Description = description;
        }
    }
}