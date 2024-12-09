using System;
namespace ActivitatsT3
{
    public class Player
    {
        // Relació d'associoacio amb Team
        public string Name { get; set; }
        public int Age { get; set; }
        public Player(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
