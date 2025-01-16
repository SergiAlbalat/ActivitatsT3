using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public abstract class HouseParts
    {
        protected string Name {  get; set; }
        protected double Price { get; set; }
        public HouseParts(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public abstract string GetInfo();
    }
}