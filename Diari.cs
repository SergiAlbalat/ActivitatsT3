using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ActivitatsT3
{
    public class Diari : Textos, ILibrary
    {
        public Diari(string name, string editorial, string releaseDate, int volume, int pageNumber, string author, string category)
        {
            Name = name;
            Editorial = editorial;
            ReleaseDate = releaseDate;
            Volume = volume;
            PageNumber = pageNumber;
            Author = author;
            Category = category;
        }
        public Diari() : this("diari", "default", "0/0/0000", 0, 0, "Nobody", "Diari") { }

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