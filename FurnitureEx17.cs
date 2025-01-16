using System;
namespace ActivitatsT3
{
    public class FurnitureEx17 : HouseParts
    {
        public float Weight { get; set; }
        public bool Set {  get; set; }
        public string? Material { get; set; }
        public string? Colour { get; set; }
        public FurnitureEx17(float weight, double price, bool set,  string name, string? material, string? colour) : base(name,  price)
        {
            Weight = weight;
            Set = set;
            Material = material;
            Colour = colour;
        }
        public FurnitureEx17() : this(0.00f, 0.00, false, "furniture", null, null) { }
        public FurnitureEx17(string name, double price) : this(1.00f, price, false, name, null, null) { }
        public override string GetInfo() => $"Name: {Name}, Price: {Price}, Weight: {Weight}, Set: {Set}, Material: {Material}, Colour: {Colour}";
    }
}