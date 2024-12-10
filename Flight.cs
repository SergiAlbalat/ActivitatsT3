using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public class Flight
    {
        public int Duration {  get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public string Company { get; set; }

        public Flight(int duration, string origin, string destination, string company)
        {
            Duration = duration;
            Origin = origin;
            Destination = destination;
            Company = company;
        }
    }
}