using System;
namespace ActivitatsT3
{
    public class Building
    {
        //Relacio de composició amb room
        public string Name { get; set; }
        public int Floors { get; set; }
        public Building(string name, int floors)
        {
            this.Name = name;
            this.Floors = floors;
        }
    }
}
