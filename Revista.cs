using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ActivitatsT3
{
    public class Revista : Textos, ILibrary
    {
        public Revista(string name, string editorial, string releaseDate, int volume, int pageNumber, string author, string category)
        {
            Name = name;
            Editorial = editorial;
            ReleaseDate = releaseDate;
            Volume = volume;
            PageNumber = pageNumber;
            Author = author;
            Category = category;
        }
        public  Revista() : this("revista", "default", "0/0/0000", 0, 0, "Nobody", "Revista") { }
        public override void NextPage() { }
        public override void Open() { }
        public void Prestec()
        {
            throw new NotImplementedException();
        }
        public void Read()
        {
            throw new NotImplementedException();
        }
    }
}