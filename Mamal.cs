using System;
namespace ActivitatsT3
{
    public class Mamal : Animal
    {
        public string FurType { get; set; }
        public Mamal(string furType) : base("Mamal", 0)
        {
            this.FurType = furType;
        }
    }
}
