using System;
namespace ActivitatsT3
{
    public class Fish : Animal
    {
        public bool Sea {  get; set; }
        public Fish(bool sea) : base("Fish", 0)
        {
            Sea = sea;
        }
    }
}
