using System;
namespace ActivitatsT3
{
    public class Lamp : Furniture
    {
        public int Lumens {  get; set; }

        public Lamp(string name, string color, string description, int lumens) :base(name, color, description)
        {
            Lumens = lumens;
        }
    }
}