using System;
namespace ActivitatsT3
{
    public class Program
    {
        public static void Main()
        {
            Car myCar = new Car(0);
            myCar.Refuel(50);
            myCar.Drive();
        }
    }
}