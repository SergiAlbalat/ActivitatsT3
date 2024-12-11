using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public class Flight : Travel
    {
        public string Company { get; set; }

        public Flight(int duration, string origin, string destination, string company) :base(duration, origin, destination)
        {
            Company = company;
        }
    }
}