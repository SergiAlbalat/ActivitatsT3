using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }
}