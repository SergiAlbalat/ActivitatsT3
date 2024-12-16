using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public class FurnitureEx17
    {
        public float Weight { get; set; }
        public double Price { get; set; }
        public bool Set {  get; set; }
        public string? Name { get; set; }
        public string? Material { get; set; }
        public string? Colour { get; set; }
        public FurnitureEx17(float weight, double price, bool set,  string? name, string? material, string? colour)
        {
            Weight = weight;
            Price = price;
            Set = set;
            Name = name;
            Material = material;
            Colour = colour;
        }
        public FurnitureEx17() : this(0.00f, 0.00, false, "furniture", null, null) { }
    }
}