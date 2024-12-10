using System;
namespace ActivitatsT3
{
    public class Bird : Animal
    {
        public int WingLenght { get; set; }
        public Bird (int wingLenght) : base("Bird", 0)
        {
            this.WingLenght = wingLenght;
        }
    }
}
