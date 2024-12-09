using System;
namespace ActivitatsT3
{
    public class Program
    {
        public static void Main()
        {
            Book llibre1 = new Book("Wind and Truth", "Brandon Sanderson");
            Library biblioteca = new Library("Barça", "Aqui");
            Console.WriteLine("{0}, {1}, {2}", llibre1.Name, llibre1.Author, biblioteca.Name);
        }
    }
}