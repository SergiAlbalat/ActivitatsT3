using System;
namespace ActivitatsT3
{
    public class Card
    {
        public string Type { get; set; }

        public int Value { get; set; }
        
        public Card(string type, int value)
        {
            Type = type;
            Value = value;
        }
        public Card(string type) : this(type, 0) { }
        public Card(int value) : this("Unspecified", value) { }
        public Card() : this("Unspecified", 0) { }
    }
}