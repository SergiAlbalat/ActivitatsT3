using System;
namespace ActivitatsT3
{
    public class Textos
    {
        public virtual string Name { get; set; }
        public virtual string Editorial { get; set; }
        public virtual string ReleaseDate { get; set; }
        public virtual int Volume {  get; set; }
        public virtual int PageNumber { get; set; }
        public virtual string Author { get; set; }
        public virtual string Category { get; set; }
        public virtual void NextPage()
        {
            Console.WriteLine("Pagge skiped");
        }
        public virtual void Open()
        {
            Console.WriteLine("Opening");
        }
    }
}