using System;
namespace ActivitatsT3
{
    public class Program
    {
        public static void Main()
        {
            Player jugador1 = new Player("Messi", 30);
            Team equip1 = new Team("Barça");
            Console.WriteLine("{0}, {1}, {2}", jugador1.Name, jugador1.Age, equip1.Name);
        }
    }
}