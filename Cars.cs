using System;
namespace ActivitatsT3
{
    public class Cars : WheeledVehicle
    {
        public string FuelType {  get; set; }
        Cars(string name, string color, int wheelSize, string fuelType) : base(name, color, wheelSize)
        {
            FuelType = fuelType;
        }
    }
}