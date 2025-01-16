using System;
namespace ActivitatsT3
{
    public class Car : IVehicle
    {
        public double Gasoline {  get; set; }
        public Car(double gasoline)
        {
            Gasoline = gasoline;
        }
        public void Drive()
        {
            if(Gasoline > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("No gasoline =(");
            }
        }
        public bool Refuel(int amount)
        {
            Gasoline += amount;
            return true;
        }
    }
}