using System;
namespace ActivitatsT3
{
    public class Games
    {
        public int Players { get; set; }
        public int DifficultyLevel { get; set; }
        public Games(int players, int difficultyLevel)
        {
            Players = players;
            DifficultyLevel = difficultyLevel;
        }
    }
}