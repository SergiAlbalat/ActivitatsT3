using System;
namespace ActivitatsT3
{
    public class Biblioteca
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Biblioteca(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }
}