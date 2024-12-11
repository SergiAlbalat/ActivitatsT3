using System;
namespace ActivitatsT3
{
    public class Card : Games
    {
        public string Type { get; set; }

        public int Value { get; set; }
        
        public Card(int players, int difficultyLevel, string type, int value) : base(players, difficultyLevel)
        {
            Type = type;
            Value = value;
        }
    }
}