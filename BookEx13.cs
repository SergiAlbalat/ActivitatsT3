using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivitatsT3
{
    public class BookEx13 : Textos, ILibrary
    {
        public BookEx13(string name, string editorial, string releaseDate, int volume, int pageNumber, string author, string category)
        {
            Name = name;
            Editorial = editorial;
            ReleaseDate = releaseDate;
            Volume = volume;
            PageNumber = pageNumber;
            Author = author;
            Category = category;
        }
        public BookEx13() : this("libro", "default", "0/0/0000", 0, 0, "Nobody", "Book") { }

        public Biblioteca Biblioteca
        {
            get => default;
            set
            {
            }
        }

        public override void NextPage() { }
        public override void Open() { }
        public void Read()
        {
            throw new NotImplementedException();
        }
    }
}