using System;
namespace ActivitatsT3
{
    internal class Book
    {
        //Relacio d'agregació amb Library
        public string Name { get; set; }
        public string Author { get; set; }
        public Book(string name, string author)
        {
            this.Name = name;
            this.Author = author;
        }
    }
}
