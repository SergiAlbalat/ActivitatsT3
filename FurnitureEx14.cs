using System;
namespace ActivitatsT3
{
    public class FurnitureEx14
    {
        public float Weight {  get; set; }
        public double Price {  get; set; }
        public bool Set {  get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Colour {  get; set; }
        public FurnitureEx14(float weight, double price, bool set, string name, string material, string colour)
        {
            Weight = weight;
            Price = price;
            Set = set;
            Name = name;
            Material = material;
            Colour = colour;
        }
        public FurnitureEx14() : this(0.0f, 0, true, "Furniture", "Wood", "Brown") { }
    }

}