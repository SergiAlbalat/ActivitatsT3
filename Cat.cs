using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string FavouriteFood { get; set; }
        public Cat(string name, int age, string breed, string favouriteFood)
        {
            Name = name;
            Age = age;
            Breed = breed;
            FavouriteFood = favouriteFood;
        }
        public void MakeMeowSound()
        {
            Console.WriteLine("Meow");
        }
        public void Play()
        {
            Console.WriteLine("*Playing*");
        }
        public void Wash()
        {
            Console.WriteLine("Washing");
        }
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
        public void Hunt()
        {
            Console.WriteLine("Hunting");
        }
    }
}