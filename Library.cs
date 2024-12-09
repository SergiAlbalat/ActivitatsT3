using System;
namespace ActivitatsT3
{
    internal class Library
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Library(string name, string location)
        {
            this.Name = name;
            this.Location = location;
        }
    }
}
