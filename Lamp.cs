using System;
namespace ActivitatsT3
{
    public class Lamp
    {
        public string Color {  get; set; }

        public int Lumens {  get; set; }

        public Lamp(string color, int lumens)
        {
            Color = color;
            Lumens = lumens;
        }
    }
}