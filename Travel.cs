using System;
namespace ActivitatsT3
{
    public class Travel
    {
        public int Duration { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }
        public Travel(int duration, string origin, string destination)
        {
            Duration = duration;
            Origin = origin;
            Destination = destination;
        }
    }
}