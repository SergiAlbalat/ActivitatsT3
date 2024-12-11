using System;
namespace ActivitatsT3
{
    public class Program
    {
        public static void Main()
        {
            Cat gatete = new Cat("Morgana", 1, "negro", "atun");
            Console.WriteLine("{0}, {1}, {2}, {3}", gatete.Name, gatete.Age, gatete.Breed, gatete.FavouriteFood);
            gatete.Eat();
        }
    }
}