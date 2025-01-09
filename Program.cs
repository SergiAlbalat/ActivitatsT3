using System;
namespace ActivitatsT3
{
    public class Program
    {
        public static void Main()
        {
            Bike bike1 = new Bike("SuperBike", "Blue", 60, 5);
            Console.WriteLine("{0}, {1}, {2}, {3}", bike1.Name, bike1.Color, bike1.WheelSize, bike1.GearNumber);
            Console.WriteLine("Hello World")
        }
    }
}