using System;
namespace ActivitatsT3
{
    public class Program
    {
        public static void Main()
        {
            Building edifici = new Building("Wind and Truth", 1500);
            Room sala = new Room(80, "Aqui");
            Console.WriteLine("{0}, {1}, {2}, {3}", edifici.Name, edifici.Floors, sala.Surface, sala.Type);
        }
    }
}